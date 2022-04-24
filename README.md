```
CREATE SCHEMA IF NOT EXISTS dbo;

CREATE TABLE dbo.ArticleCommonTable (
	id serial PRIMARY KEY,
	ArticleTitle text,
	Type text
);

CREATE TABLE dbo.ArticleFirstTypeTable (   
    ArticleFirstTypeProperty text
) INHERITS (ArticleCommonTable);

CREATE TABLE dbo.ArticleSecondTypeTable (   
    ArticleSecondTypeProperty text
) INHERITS (ArticleCommonTable);
```
