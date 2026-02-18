using kursach.Forms.Edit;
using kursach.Forms.Search;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kursach
{
    public partial class DeleteHerb : Form
    {
        private List<Herb> allHerbs;

        public DeleteHerb()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            listBoxHerbs.DisplayMember = "Name";

            allHerbs = FileLoad.LoadHerbs();
            foreach (Herb herb in allHerbs)
            {
                listBoxHerbs.Items.Add(herb);
            }

            panelHerbDetails.BorderStyle = BorderStyle.FixedSingle;
        }

        private void listBoxHerbs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxHerbs.SelectedItem is Herb selectedHerb)
            {
                panelHerbDetails.Controls.Clear();

                int yOffset = 10;
                AddDetailLabel($"Название: {selectedHerb.Name}", ref yOffset);
                AddDetailLabel($"Внешний вид: {selectedHerb.Appearance}", ref yOffset);
                AddDetailLabel($"Место произрастания: {selectedHerb.Habitat}", ref yOffset);
                AddDetailLabel($"Описание: {selectedHerb.Description}", ref yOffset);

                string diseases = string.Join(", ", selectedHerb.TreatedDiseases);
                AddDetailLabel($"Помогает с: {diseases}", ref yOffset);
            }
        }

        private void AddDetailLabel(string text, ref int yOffset)
        {
            Label label = new Label
            {
                Text = text,
                AutoSize = true,
                Location = new Point(10, yOffset),
                MaximumSize = new Size(panelHerbDetails.Width - 20, 0)
            };

            panelHerbDetails.Controls.Add(label);
            yOffset += label.Height + 5;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (listBoxHerbs.SelectedItem == null)
            {
                MessageBox.Show("Выберите растение для удаления", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Вы уверены, что хотите удалить растение '{listBoxHerbs.SelectedItem}'?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string herbToDelete = listBoxHerbs.SelectedItem.ToString();
                Deleter.Delete<Herb>(listBoxHerbs, "herbs.txt",
                    herb => $"{herb.Name};{herb.Appearance};{herb.Habitat};{herb.Description};{string.Join(",", herb.TreatedDiseases)}");

                allHerbs = FileLoad.LoadHerbs();
                listBoxHerbs.Items.Clear();
                panelHerbDetails.Controls.Clear();
                foreach (Herb herb in allHerbs) listBoxHerbs.Items.Add(herb);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchDisease = txtSearchHerb.Text.Trim();

            List<Herb> currentFoundHerbs = Herb.SearchByTreatedDiseases(allHerbs, searchDisease);

            ShowSearchResults.ShowItems(listBoxHerbs, panelHerbDetails, currentFoundHerbs);
        }
    }
}