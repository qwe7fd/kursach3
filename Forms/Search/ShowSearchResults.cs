using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach.Forms.Search
{
    internal class ShowSearchResults
    {
        public static void ShowItems<T>(ListBox listBox, Panel panel, List<T> currentFound)
        {
            listBox.Items.Clear();
            panel.Controls.Clear();

            if (currentFound.Count == 0)
            {
                MessageBox.Show("Элементы не найдены", "Результат поиска",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (T item in currentFound)
                {
                    listBox.Items.Add(item);
                }
            }
        }
    }
}
