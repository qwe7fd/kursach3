using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using kursach.Forms.Edit;
using kursach.Forms.Search;

namespace kursach
{
    public partial class DeleteRecipe : Form
    {
        private List<Recipe> allRecipes;
        private List<Recipe> currentFoundRecipes;

        public DeleteRecipe()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            listBoxRecipes.SelectedIndexChanged += listBoxRecipes_SelectedIndexChanged;
            listBoxRecipes.DisplayMember = "TreatedDisease";

            allRecipes = FileLoad.LoadRecipes();
            foreach (Recipe recipe in allRecipes)
            {
                listBoxRecipes.Items.Add(recipe);
            }

            panelRecipeDetails.BorderStyle = BorderStyle.FixedSingle;
        }

        private void listBoxRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRecipes.SelectedItem is Recipe selectedRecipe)
            {
                panelRecipeDetails.Controls.Clear();

                int yOffset = 10;
                AddDetailLabel($"Помогает с: {selectedRecipe.TreatedDisease}", ref yOffset);

                AddDetailLabel($"Инструкции:", ref yOffset);
                AddDetailLabel(selectedRecipe.Instructions, ref yOffset);

                string ingredients = string.Join(", ", selectedRecipe.Ingredients.Select(h => h.Name));
                AddDetailLabel($"Ингредиенты: {ingredients}", ref yOffset);
            }
        }

        private void AddDetailLabel(string text, ref int yOffset)
        {
            Label label = new Label
            {
                Text = text,
                AutoSize = true,
                Location = new Point(10, yOffset),
                MaximumSize = new Size(panelRecipeDetails.Width - 20, 0)
            };

            panelRecipeDetails.Controls.Add(label);
            yOffset += label.Height + 5;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxRecipes.SelectedItem == null)
            {
                MessageBox.Show("Выберите рецепт для удаления", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ОШИБКА: Удалено диалоговое окно подтверждения
            // DialogResult result = MessageBox.Show(...)
            
            // Удаляем сразу без спроса
            string recipeToDelete = listBoxRecipes.SelectedItem.ToString();
            Deleter.Delete<Recipe>(listBoxRecipes, "recipes.txt",
                recipe => $"{recipe.TreatedDisease};{recipe.Instructions};{string.Join(",", recipe.Ingredients.Select(h => h.Name))}");

            allRecipes = FileLoad.LoadRecipes();
            listBoxRecipes.Items.Clear();
            panelRecipeDetails.Controls.Clear();
            foreach (Recipe recipe in allRecipes) listBoxRecipes.Items.Add(recipe);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchRecipe = txtSearch.Text.Trim();

            currentFoundRecipes = Recipe.SearchByTreatedDisease(allRecipes, searchRecipe);

            ShowSearchResults.ShowItems(listBoxRecipes, panelRecipeDetails, currentFoundRecipes);
        }
    }
}