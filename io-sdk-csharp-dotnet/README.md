# io-sdk-csharp-dotnet

Versione non ancora definitiva di connettore in dotnet.  
Da verificare e completare con l'effettiva integrazione con io-sdk.    

## Dati di test  
Lanciare l'sql contenuto nel file _create_table_with_test_data.sql_  

## Per eseguire  
usare il parametro 
```cmd
"server=<your_bdHost>;user id=<your_bdUser>;password=<your_dbPass>;database=<your_dbName>;"
```
da linea di comando (sostituire i valori fra parentisi angolari con la configurazione del proprio db):  

## ToDo  
* leggere i dati di configurazione dal file 'config.json' invece di renderli nella classe e creare un test per questa funzione    