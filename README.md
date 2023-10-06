# Skeleton-3-Capas
Skeleton 3 capas para los proyectos NetCore


## Migraciones
dotnet ef migrations add InitialCreate --project ./Infrastructure/ --startup-project ./API/ --output-dir ./Data/Migrations/

dotnet ef database update --project ./Infrastructure/ --startup-project ./API/  
