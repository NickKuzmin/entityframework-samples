```
CREATE TABLE ArticleCommonTable (
	id serial PRIMARY KEY,
	ArticleTitle text,
	Type text
);

CREATE TABLE ArticleFirstTypeTable (   
    ArticleFirstTypeProperty text
) INHERITS (ArticleCommonTable);

CREATE TABLE ArticleSecondTypeTable (   
    ArticleSecondTypeProperty text
) INHERITS (ArticleCommonTable);
```
