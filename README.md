**Code First Migrations:**
`EntityFramework.Samples\EntityFramework.Samples\Migrations\202204241734090_ArticleContextDBVersion1.cs`

```
CREATE SCHEMA IF NOT EXISTS dbo;

CREATE TABLE dbo.ArticleCommonTable (
	id serial PRIMARY KEY,
	ArticleTitle text,
	Type text
);

CREATE TABLE dbo.ArticleFirstTypeTable (   
    ArticleFirstTypeProperty text
) INHERITS (dbo.ArticleCommonTable);

CREATE TABLE dbo.ArticleSecondTypeTable (   
    ArticleSecondTypeProperty text
) INHERITS (dbo.ArticleCommonTable);
```

**Package Manager Console -> EntityFramework.Samples project:**
```
Enable-Migrations -Force
Add-Migration ArticleContextDBVersion1
Update-Database -verbose
```
