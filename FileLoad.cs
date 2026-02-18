using kursach;
using System.Text;

public class FileLoad
{
    public static List<Herb> LoadHerbs()
    {
        List<Herb> herbs = new List<Herb>();

        try
        {
            string[] lines = File.ReadAllLines("herbs.txt", Encoding.UTF8);
            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                if (parts.Length >= 5)
                {
                    herbs.Add(new Herb(
                        parts[0],
                        parts[1],
                        parts[2],
                        parts[3],
                        parts[4].Split(',').ToList()
                    ));
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при загрузке списка растений: {ex.Message}",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return herbs;
    }

    public static List<Recipe> LoadRecipes()
    {
        List<Recipe> recipes = new List<Recipe>();
        try
        {
            string filePath = "recipes.txt";
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Файл с рецептами не найден!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return recipes;
            }
            string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(';');
                if (parts.Length >= 3)
                {
                    Recipe recipe = new Recipe(
                        parts[0],
                        parts[1],
                        parts[2].Split(',')
                        .Select(herbName => new Herb { Name = herbName.Trim() })
                        .ToList()
                    );
                    recipes.Add(recipe);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при чтении файла: {ex.Message}",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return recipes;
    }
}