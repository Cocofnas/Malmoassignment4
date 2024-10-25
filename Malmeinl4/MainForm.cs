using System;
using System.Linq;
using System.Windows.Forms;

namespace Malmeinl4
{
    public partial class MainForm : Form
    {
        private const int MaxNumOfRecipes = 200;
        private const int MaxNumOfIngredients = 50;

        private RecipeManager recipeManager;
        private Recipe currRecipe;

        public MainForm()
        {
            InitializeComponent();

            recipeManager = new RecipeManager(MaxNumOfRecipes);
            currRecipe = new Recipe(MaxNumOfIngredients);

            comboBoxCategory.DataSource = Enum.GetValues(typeof(FoodCategory));
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            string recipeName = txtRecipeName.Text;
            string recipeDescription = string.Join(", ", listBoxDescription.Items.Cast<object>().Select(item => item.ToString())); // Adjusted
            FoodCategory selectedCategory;

            if (comboBoxCategory.SelectedItem != null)
            {
                selectedCategory = (FoodCategory)comboBoxCategory.SelectedItem;
            }
            else
            {
                MessageBox.Show("Please select a valid category.");
                return;
            }

            try
            {
                if (string.IsNullOrWhiteSpace(recipeName))
                {
                    MessageBox.Show("Please provide a valid recipe name.");
                    return;
                }

                currRecipe.Name = recipeName;
                currRecipe.Description = recipeDescription;
                currRecipe.Category = selectedCategory;

                recipeManager.AddRecipe(currRecipe);
                UpdateRecipeList();
                currRecipe = new Recipe(MaxNumOfIngredients);
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void listBoxRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRecipes.SelectedIndex >= 0)
            {
                Recipe selectedRecipe = recipeManager.GetRecipe(listBoxRecipes.SelectedIndex);

                listBoxDescription.Items.Clear();  // Clear the ListBox before adding new content
                foreach (var ingredient in selectedRecipe.GetIngredients())
                {
                    listBoxDescription.Items.Add(ingredient);  // Display each ingredient
                }

                listBoxDescription.Items.Add("");  // Spacer between ingredients and instructions
                listBoxDescription.Items.Add("Instructions:");
                string[] instructionLines = selectedRecipe.Description.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var line in instructionLines)
                {
                    listBoxDescription.Items.Add(line);  // Display each line of instructions
                }
            }
        }

        private void UpdateRecipeList()
        {
            listBoxRecipes.Items.Clear();
            for (int i = 0; i < recipeManager.Count; i++)
            {
                var recipeName = recipeManager.GetRecipe(i)?.Name;
                if (!string.IsNullOrEmpty(recipeName))
                {
                    listBoxRecipes.Items.Add(recipeName);
                }
            }
        }

        private void ClearInputFields()
        {
            txtRecipeName.Clear();
            comboBoxCategory.SelectedIndex = -1;
            listBoxDescription.Items.Clear();
        }

        private void btnAddIngredients_Click(object sender, EventArgs e)
        {
            FormRecipeDetails formRecipeDetails = new FormRecipeDetails(currRecipe);

            if (formRecipeDetails.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Ingredients updated successfully!");
            }
        }

        private void btnEditRecipe_Click(object sender, EventArgs e)
        {
            if (listBoxRecipes.SelectedIndex >= 0)
            {
                int selectedIndex = listBoxRecipes.SelectedIndex;
                Recipe selectedRecipe = recipeManager.GetRecipe(selectedIndex);

                FormRecipeDetails formRecipeDetails = new FormRecipeDetails(selectedRecipe);

                if (formRecipeDetails.ShowDialog() == DialogResult.OK)
                {
                    UpdateRecipeList();
                }
            }
            else
            {
                MessageBox.Show("Please select a recipe to edit.");
            }
        }

        private void btnDeleteRecipe_Click(object sender, EventArgs e)
        {
            if (listBoxRecipes.SelectedIndex >= 0)
            {
                recipeManager.RemoveRecipe(listBoxRecipes.SelectedIndex);
                UpdateRecipeList();
                ClearInputFields();
                MessageBox.Show("Recipe deleted successfully!");
            }
            else
            {
                MessageBox.Show("Please select a recipe to delete.");
            }
        }

        private void btnClearInput_Click(object sender, EventArgs e)
        {
            listBoxRecipes.ClearSelected();
            ClearInputFields();
            MessageBox.Show("Input fields cleared.");
        }
    }
}












