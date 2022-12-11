# Planny

## Database migrations

Adding a new migration from the root solution folder:

```console
dotnet ef migrations add SampleMigration --project src/Planny.Infrastructure --output-dir Persistence\Migrations --startup-project src/Planny.WebApi
```
