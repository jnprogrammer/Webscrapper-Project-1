CREATE TABLE [dbo].RecipeIngredient
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [RecipeId] INT NOT NULL, 
    [IngredientId] INT NOT NULL, 
    CONSTRAINT RecipeFK FOREIGN KEY ([RecipeId]) REFERENCES Recipe(Id),
    CONSTRAINT IngredientFK FOREIGN KEY ([IngredientId]) REFERENCES Ingredient(Id)

)
