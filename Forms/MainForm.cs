namespace kursach
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            // ОШИБКА: Границы окна не зафиксированы (FormBorderStyle по умолчанию Sizable)
        }

        private void btnSearchHerbByName_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchHerbByName form1 = new SearchHerbByName();
            form1.ShowDialog();
            this.Show();
        }

        private void btnSearchHerbByDisease_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchHerbByDisease diseaseHerbSearch = new SearchHerbByDisease();
            diseaseHerbSearch.ShowDialog();
            this.Show();
        }

        private void btnSearchRecipeByDisease_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchRecipeByDisease form3 = new SearchRecipeByDisease();
            form3.ShowDialog();
            this.Show();
        }

        private void btnSearchRecipeByHerb_Click(object sender, EventArgs e)
        {
            this.Hide();
            // ОШИБКА: Открывается не то окно (ошибка Copy-Paste)
            SearchRecipeByDisease form4 = new SearchRecipeByDisease();
            form4.ShowDialog();
            this.Show();
        }

        private void btnRecipeAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddRecipe herbRecipeAdd = new AddRecipe();
            herbRecipeAdd.ShowDialog();
            this.Show();
        }

        private void btnHerbAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddHerb herbAdd = new AddHerb();
            herbAdd.ShowDialog();
            this.Show();
        }

        private void btnHerbDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteHerb deleteHerb = new DeleteHerb();
            deleteHerb.ShowDialog();
            this.Show();
        }

        private void btnRecipeDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteRecipe deleteRecipe= new DeleteRecipe();
            deleteRecipe.ShowDialog();
            this.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            // ОШИБКА: Вместо выхода приложение сворачивается
            this.WindowState = FormWindowState.Minimized;
        }
    }
}