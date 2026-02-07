# backend

## Start the API

Launch the database

Note: make sure that your ports 8080 and 1433 are available (and for window users, dont forget to start docker desktop)
```
cd backend
docker compose up -d
# OR
docker-compose up -d
```

Update the database
```
cd backkend/api
dotnet ef database update --project HP2.Infrastructure --startup-project HP2.API
```

Launch the API
```
cd backend/api/HP2.API
dotnet run
```

Check Sagger
```
localhost:5075/swagger/index.html
```


## Secret ConnectionString for the SQL Server database

Go to the HP2.API directory:
```
cd api/HP2.API 
```
Then, type these dotnet commands:
```
dotnet user-secrets init
```
### Edit the credentials
You need to provide the actual connection string. To find it:

- Go to the Discord server TER-Projet.
- Look in the equipe-back channel.
- Check the Pinned Messages for the value of ConnectionStrings:DefaultConnection.
```
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Server=SERVER_NAME;Database=DATABASE_NAME;User ID=USER_ID;Password=PASSWORD"
```
