using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.IO;
using kursach.Forms.Search;

namespace kursach
{
    public partial class SearchRecipeByHerb : Form
    {
        private List<Herb> allHerbs;
        private List<Recipe> allRecipes;
        private List<Recipe> currentFoundRecipes;

        public SearchRecipeByHerb()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            allHerbs = FileLoad.LoadHerbs();
            allRecipes = FileLoad.LoadRecipes();

            listBoxRecipes.DisplayMember = "TreatedDisease.Name";
            listBoxRecipes.SelectedIndexChanged += ListBoxRecipes_SelectedIndexChanged;

            foreach (Recipe recipe in allRecipes)
            {
                listBoxRecipes.Items.Add(recipe);
            }

            panelRecipeDetails.BorderStyle = BorderStyle.FixedSingle;
        }        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchHerb = txtSearch.Text.Trim();


            currentFoundRecipes = Recipe.SearchByHerb(allRecipes, searchHerb);

            ShowSearchResults.ShowItems(listBoxRecipes, panelRecipeDetails, currentFoundRecipes);
        }

        private void ListBoxRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRecipes.SelectedItem is Recipe selectedRecipe)
            {
                panelRecipeDetails.Controls.Clear();

                int yOffset = 10;
                AddDetailLabel($"Помогает с: {selectedRecipe.TreatedDisease}", ref yOffset);

                AddDetailLabel($"Инструкции:", ref yOffset);
                AddDetailLabel(selectedRecipe.Instructions, ref yOffset);

                string ingredients = string.Join(", ",
                    selectedRecipe.Ingredients.Select(h => h.Name));
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

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}