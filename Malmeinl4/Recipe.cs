using Malmeinl4;

public class Recipe
{
    private string name = string.Empty;
    private string description = string.Empty;
    private FoodCategory category;
    private string[] ingredients;
    private int ingredientCount;

    public Recipe(int maxNumOfIngredients)
    {
        ingredients = new string[maxNumOfIngredients];
        ingredientCount = 0;
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty.");
            name = value;
        }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    public FoodCategory Category
    {
        get { return category; }
        set { category = value; }
    }

    public void AddIngredient(string ingredient)
    {
        if (ingredientCount >= ingredients.Length)
            throw new InvalidOperationException("No more space for additional ingredients.");

        ingredients[ingredientCount++] = ingredient;
    }

    public void RemoveIngredient(int index)
    {
        if (index < 0 || index >= ingredientCount)
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of bounds.");

        for (int i = index; i < ingredientCount - 1; i++)
        {
            ingredients[i] = ingredients[i + 1];
        }

        ingredients[--ingredientCount] = string.Empty;
    }

    public void UpdateIngredient(int index, string newIngredient)
    {
        if (index >= 0 && index < ingredientCount)
        {
            ingredients[index] = newIngredient;
        }
        else
        {
            throw new ArgumentOutOfRangeException("Invalid index provided for updating an ingredient.");
        }
    }

    public string[] GetIngredients()
    {
        return ingredients.Take(ingredientCount).ToArray();
    }

    public string GetIngredient(int index)
    {
        if (index < 0 || index >= ingredientCount)
            throw new ArgumentOutOfRangeException(nameof(index), "Invalid index.");

        return ingredients[index];
    }
}

