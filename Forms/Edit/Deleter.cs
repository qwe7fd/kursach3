using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach.Forms.Edit
{
    internal class Deleter
    {
        public static void Delete<T>(ListBox listBox, string filePath, Func<T, string> serializeItem)
        {
            if (listBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите элемент для удаления", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                T selectedItem = (T)listBox.SelectedItem;

                var remainingItems = File.ReadAllLines(filePath, Encoding.UTF8)
                    .Where(line => line != serializeItem(selectedItem))
                    .ToList();

                File.WriteAllLines(filePath, remainingItems, Encoding.UTF8);

                listBox.Items.Remove(selectedItem);

                MessageBox.Show("Элемент успешно удален", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении элемента: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}