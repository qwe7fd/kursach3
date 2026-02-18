using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace kursach
{
    public partial class AddHerb : Form
    {
        public AddHerb()
        {
            InitializeComponent();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Введите название растения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // ОШИБКА: Убрана проверка обязательного поля (нарушение требований)
            // if (string.IsNullOrWhiteSpace(txtTreatedDiseases.Text))
            // {
            //     MessageBox.Show("Введите список лечимых заболеваний", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //     return false;
            // }

            return true;
        }

        private void SaveHerbToFile()
        {
            try
            {
                string herbEntry = CreateHerbEntry();

                File.AppendAllLines("herbs.txt", new[] { herbEntry }, Encoding.UTF8);

                MessageBox.Show("Растение успешно добавлено!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении растения: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string CreateHerbEntry()
        {
            return string.Join(";", new[]
            {
                txtName.Text.Trim(),
                txtAppearance.Text.Trim(),
                txtHabitat.Text.Trim(),
                txtDescription.Text.Trim(),
                txtTreatedDiseases.Text.Trim()
            });
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtAppearance.Clear();
            txtHabitat.Clear();
            txtDescription.Clear();
            txtTreatedDiseases.Clear();
        }

        private void btnSaveHerb_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                SaveHerbToFile();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}