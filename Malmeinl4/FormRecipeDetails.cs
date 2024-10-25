using System;
using System.Windows.Forms;

namespace Malmeinl4
{
    public partial class FormRecipeDetails : Form
    {
        private Recipe currRecipe;

        public FormRecipeDetails(Recipe recipe)
        {
            InitializeComponent();
            currRecipe = recipe;  // Work with the copy of the recipe passed from MainForm
            LoadIngredients();    // Load existing ingredients into the ListBox
        }

        // Load existing ingredients into the ListBox when the form loads
        private void LoadIngredients()
        {
            listBoxIngredients.Items.Clear();  // Clear current list
            foreach (string ingredient in currRecipe.GetIngredients())
            {
                listBoxIngredients.Items.Add(ingredient);  // Populate list with current ingredients
            }
            UpdateIngredientCount();  // Update ingredient count when loading
        }

        // Add or Edit Ingredient
        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            string ingredient = txtBoxIngredient.Text.Trim();  // Get input from the TextBox

            if (!string.IsNullOrWhiteSpace(ingredient))
            {
                if (listBoxIngredients.SelectedIndex >= 0)
                {
                    // If an ingredient is selected, edit it
                    currRecipe.UpdateIngredient(listBoxIngredients.SelectedIndex, ingredient);  // Update ingredient in recipe
                    listBoxIngredients.Items[listBoxIngredients.SelectedIndex] = ingredient;    // Update ListBox
                }
                else
                {
                    // If no ingredient is selected, add a new one
                    try
                    {
                        currRecipe.AddIngredient(ingredient);  // Add the ingredient to the current recipe
                        listBoxIngredients.Items.Add(ingredient);  // Add to ListBox
                        txtBoxIngredient.Clear();  // Clear the input field for next input
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);  // Show error if max ingredients reached
                    }
                }

                UpdateIngredientCount();  // Update the count after adding or editing
            }
            else
            {
                MessageBox.Show("Please enter a valid ingredient.");
            }
        }

        // Remove selected ingredient
        private void btnDeleteIngredient_Click(object sender, EventArgs e)
        {
            if (listBoxIngredients.SelectedIndex >= 0)
            {
                // Remove selected ingredient from ListBox and Recipe object
                currRecipe.RemoveIngredient(listBoxIngredients.SelectedIndex);
                listBoxIngredients.Items.RemoveAt(listBoxIngredients.SelectedIndex);
                UpdateIngredientCount();  // Update the count after removing
            }
            else
            {
                MessageBox.Show("Please select an ingredient to remove.");
            }
        }

        // Event handler for Cancel button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form or cancel the current operation
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Select ingredient for editing
        private void listBoxIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxIngredients.SelectedItem != null)
            {
                txtBoxIngredient.Text = listBoxIngredients.SelectedItem.ToString();  // Load selected ingredient into TextBox
            }
            else
            {
                txtBoxIngredient.Clear();  // Optionally clear the TextBox if nothing is selected
            }
        }

        // Event handler for OK button
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        // Event handler for Edit button
        private void btnEditRecipe_Click(object sender, EventArgs e)
        {
            // Ensure something is selected in the ListBox
            if (listBoxIngredients.SelectedItem != null)
            {
                // Safely load the selected ingredient into the TextBox for editing
                txtBoxIngredient.Text = listBoxIngredients.SelectedItem?.ToString();
            }
            else
            {
                // Show a message if no ingredient is selected
                MessageBox.Show("Please select an ingredient to edit.");
            }
        }



        // Update the TextBox with the current ingredient count
        private void UpdateIngredientCount()
        {
            txtIngredientCount.Text = listBoxIngredients.Items.Count.ToString();
        }
    }
}





