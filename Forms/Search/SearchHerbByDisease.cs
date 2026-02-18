using System.Data;
using System.Text;
using kursach.Forms.Search;

namespace kursach
{
    public partial class SearchHerbByDisease : Form
    {
        private List<Herb> allHerbs;

        public SearchHerbByDisease()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            allHerbs = FileLoad.LoadHerbs();

            listBoxHerbs.DisplayMember = "Name";
            listBoxHerbs.SelectedIndexChanged += ListBoxHerbs_SelectedIndexChanged;

            foreach (Herb herb in allHerbs)
            {
                listBoxHerbs.Items.Add(herb);
            }

            panelHerbDetails.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchDisease = txtSearchHerb.Text.Trim();

            List<Herb> currentFoundHerbs = Herb.SearchByTreatedDiseases(allHerbs, searchDisease);

            ShowSearchResults.ShowItems(listBoxHerbs, panelHerbDetails, currentFoundHerbs);
        }

        private void ListBoxHerbs_SelectedIndexChanged(object sender, EventArgs e)
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

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}