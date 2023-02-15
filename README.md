
[Question 1 - part1](https://i.imgur.com/sBSwxFP.png )

[Question 1 - part2](https://i.imgur.com/nLV7BMQ.png)


[Question 2 - Ive got top level statement ](https://i.imgur.com/K9GNikn.png)

[Question 3 ](https://i.imgur.com/M3g08Vd.png)

[Question 4 ](https://i.imgur.com/ZRMEHz7.png)






I tried using SoapUI and gave it the link to the asmx endpoint. That worked flawelessly.

Then i created a console client (SoapClient).
To this I added a service reference (WCF) where i pointed to the asmx endpoint. 
This created the ServiceReference1 under ConnectedServices. Check program.cs for use. 


For both projects (soap service and soap client) i needed to add System.ServiceModel.Http by running:

```
dotnet add package System.ServiceModel.Http
```

for the soapservice i had to run :
```
dotnet add package SoapCore
```
