1.- docker build 
-f "C:\Users\samuel.sanchez\source\repos\dockertraining_samuel_sanchez_lopez\Dockerfile" 
--force-rm -t sessiontest1base 
"C:\Users\samuel.sanchez\source\repos"

2.- docker run --name site1 -p 8085:80 07e903ffd0f4
3.- docker run --name site2 -p 8086:80 -e "AppSettings:storename"="Hello from Docker" 07e903ffd0f4
4.- docker tag 07e903ffd0f4 dockertraining2020/sessiontest1base:samuel_sanchez_lopez
5.- docker push dockertraining2020/sessiontest1base