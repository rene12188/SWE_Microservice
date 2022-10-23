I. Codebase
Tracked in Git: https://github.com/rene12188/SWE_Microservice.git. Gibt jedoch kein komplexed Deployment

III. Config
Es gibt 2 Configs einmal eine für das DEV enviroment und eine für das Production Enviroment (siehe AppSettings)

IV. Backing services
Es ist möglich den Connectionstring der Datenbank über die Config auszutauschen 

VI. Processes
Es ist komplett Stateless und speichert nichts auf lokalen Maschinen

VII. Port binding
Es ist möglich den Port auf dem der Server gezeigt wird über das Compose zu modifizieren mithilfe einer Deployment Software

VIII. Concurrency
Es ist möglich mehrere Apps auf eine Datenbank zugreifen zu lassen

IX. Disposability
Durch Docker können Services automatisch aufgebaut und abgebaut werden

X. Dev/prod parity
Der einzige Unterschied zwischen Dev und Prod ist das Config File und das SwaggerUI