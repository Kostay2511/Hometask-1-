import os
import csv
import numpy
import operator
from SPARQLWrapper import SPARQLWrapper, JSON
from requests import get

#Перевод из cvs в двумерный массив
def cvs_to_array(dir, flag):
    with open(os.getcwd()+dir,"r") as f:
        Data_csv = csv.reader(f, delimiter=',')
        Data=[]
        for counter,row in enumerate(Data_csv):
            Data.append([])
            for value in row:
                Data[counter].append(value)
        if (flag!=0):
            Data=numpy.delete(Data, (0), axis=0)
        return Data

#Проверка на значение int
def Check_int(Num):
    try:
        int(Num)
        return True
    except ValueError:
        return False

#Список неоцененных фильмов
def list_of_not_rate(User,Data):
    List=[]
    for i in Data:
        if (i[0] == "User " + str(User)):
            Num=0
            for j in i:
                if (j == " -1"):
                    List.append(Num)
                Num=Num+1
            return List
            break

#Вычисление коэффициентов sim
def sim(User,Data):
    List=[]
    SimArray = []
    for i in Data[int(User)-1]:
        List.append(i)
    for ListArray in Data:
        Sum1 = 0;
        Sum2 = 0;
        Sum3 = 0;
        i=1
        j=0;
        while i < len(List):
            if (List[i]!=" -1" and ListArray[i]!=" -1"):
                Sum1=Sum1+float(List[i])*float(ListArray[i])
                Sum2 = Sum2 + float(List[i])**2
                Sum3 = Sum3 + float(ListArray[i]) ** 2
            i=i+1
        SimArray.append((Sum1/(Sum2**(1/2)*Sum3**(1/2))))
    return dict((counter+1, row) for counter,row in enumerate(SimArray))

#Сортировка массива от большего к меньшему, на 0 месте будет сам пользователь с значением 1
def sort(SimArray):
    return sorted(SimArray.items(), key=operator.itemgetter(1), reverse=True)

#Среднее значение оценки у пользователей для всех оценненых фильмов
def AvgRate(Data):
    AvgArray=[]
    for i in Data:
        Sum=0;Counter=0;
        j = 1
        while j < len(i):
            if (i[j]!=" -1"):
                Sum=Sum+int(i[j])
                Counter=Counter+1
            j=j+1
        AvgArray.append(Sum/Counter)
    return AvgArray

#Высчитываение рейтинга
def Rate(AvgArray,SimArray,ListRate,Data,User,kNN):
    Result=[]
    for Movie in ListRate:
        Sum=0
        ModSum=0
        NumPeople=1
        while NumPeople<=kNN:
            Sum=Sum+SimArray[NumPeople][1]*(float(Data[SimArray[NumPeople][0]-1][Movie])-AvgArray[SimArray[NumPeople][0]-1])
            ModSum=ModSum+SimArray[NumPeople][1]
            NumPeople=NumPeople+1
        Result.append(round(AvgArray[int(User)-1]+Sum/ModSum,3))
    return Result

#Вычисление коэффициентов sim для фильмов, которые нужно порекомендовать
def simPlaceDay(User,Data):
    List=[]
    SimArray = []
    for i in Data[int(User)-1]:
        List.append(i)
    for ListArray in Data:
        Sum1 = 0;
        Sum2 = 0;
        i=1
        while i < len(List):
            if (List[i]==ListArray[i] and ListArray[i]!=" -1"):
                Sum1= Sum1 + 1
            if (ListArray[i]==" Sat" or ListArray[i]==" Sun" or ListArray[i]==" h"):
                Sum1 = Sum1+1
            Sum2=Sum2+1
            i=i+1
        SimArray.append(Sum1/Sum2)
    return dict((counter+1, row) for counter,row in enumerate(SimArray))

#Объединение коэффициентов всех фильмов по оценке, по дню недели, по месту
def Concat(SimArray,SimArrayPlace,SimArrayDay):
    i=1
    SimArrayAll=[]
    while i<len(SimArray):
        SimArrayAll.append(float(SimArray[i])*float(SimArrayPlace[i])*float(SimArrayDay[i]))
        i=i+1
    return SimArrayAll

def getFilmUri(movie_title):
    json = get('https://www.wikidata.org/w/api.php', {
        'action': 'wbgetentities',
        'titles': movie_title,
        'sites': 'enwiki',
        'props': '',
        'format': 'json'
    }).json()
    result = list(json['entities'])[0]
    return result

def get_actors(filmUri):
    sparql = SPARQLWrapper("https://query.wikidata.org/sparql")
    sparql.setQuery("""#10
    SELECT ?actorPulp ?actorPulpLabel 
    WHERE {       
     wd:%s wdt:P161 ?actorPulp
     minus
    {  
    wd:Q104123 wdt:P161 ?actorPulp.
    ?film wdt:P31 wd:Q11424.
    ?film wdt:P161 ?actorPulp.
    ?film wdt:P577 ?date.
    filter(?date<"1994-05-12T00:00:00Z"^^xsd:dateTime)
    }     
    SERVICE wikibase:label { bd:serviceParam wikibase:language "[AUTO_LANGUAGE],en". }
    }""" % filmUri)
    sparql.setReturnFormat(JSON)
    return sparql.query().convert()