using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace kursach
{
    public partial class AddRecipe : Form
    {
        private List<Herb> availableHerbs;
        private List<string> selectedHerbs = new List<string>();

        public AddRecipe()
        {
            InitializeComponent();
            LoadAvailableHerbs();
        }

        private void LoadAvailableHerbs()
        {
            availableHerbs = FileLoad.LoadHerbs();

            checkedListBoxHerbs.Items.Clear();
            foreach (Herb herb in availableHerbs)
            {
                checkedListBoxHerbs.Items.Add(herb.Name);
            }
        }

        private void btnSaveRecipe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDisease.Text))
            {
                MessageBox.Show("Введите название недуга", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedHerbs.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы один ингредиент", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtInstructions.Text))
            {
                MessageBox.Show("Введите инструкции", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string recipeEntry = $"{txtDisease.Text};{txtInstructions.Text};{string.Join(",", selectedHerbs)}";

                File.AppendAllLines("recipes.txt", new[] { recipeEntry }, Encoding.UTF8);

                MessageBox.Show("Рецепт успешно добавлен!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении рецепта: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtDisease.Clear();
            txtInstructions.Clear();

            for (int i = 0; i < checkedListBoxHerbs.Items.Count; i++)
            {
                checkedListBoxHerbs.SetItemChecked(i, false);
            }

            selectedHerbs.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkedListBoxHerbs_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string herbName = checkedListBoxHerbs.Items[e.Index].ToString();

            if (e.NewValue == CheckState.Checked)
            {
                if (!selectedHerbs.Contains(herbName))
                    selectedHerbs.Add(herbName);
            }
            else
            {
                selectedHerbs.Remove(herbName);
            }
        }
    }
}