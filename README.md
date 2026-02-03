# backend

## ConnectionString for the SQL Server database

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

## Steps to start the test database

Type the following commands:
```
# Go to the backend directory
cd backend

# Launch the containers
docker compose up -d
# OR
docker-compose up -d
```

Then go to localhost:8081 where Adminer is running

<img width="401" height="293" alt="image" src="https://github.com/user-attachments/assets/304a0508-7f26-407b-b32e-915353d1eee4" />

The password for sa user is
```
YourStrong@Passw0rd
```

Finally, you can see all the tables, some of which have been filled and feel free to test SQL queries

<img width="1269" height="785" alt="image" src="https://github.com/user-attachments/assets/64fb5cbb-7d5c-4d26-bd68-63d0a3d20e7d" />
