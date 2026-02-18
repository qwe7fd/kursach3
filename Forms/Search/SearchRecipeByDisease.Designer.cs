namespace kursach
{
    partial class SearchRecipeByDisease
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelRecipeDetails = new Panel();
            listBoxRecipes = new ListBox();
            back = new Button();
            btnSearch = new Button();
            label1 = new Label();
            txtSearch = new TextBox();
            SuspendLayout();
            // 
            // panelRecipeDetails
            // 
            panelRecipeDetails.Location = new Point(585, 119);
            panelRecipeDetails.Margin = new Padding(5, 6, 5, 6);
            panelRecipeDetails.Name = "panelRecipeDetails";
            panelRecipeDetails.Size = new Size(900, 704);
            panelRecipeDetails.TabIndex = 12;
            // 
            // listBoxRecipes
            // 
            listBoxRecipes.FormattingEnabled = true;
            listBoxRecipes.ItemHeight = 28;
            listBoxRecipes.Location = new Point(19, 119);
            listBoxRecipes.Margin = new Padding(5, 6, 5, 6);
            listBoxRecipes.Name = "listBoxRecipes";
            listBoxRecipes.Size = new Size(532, 704);
            listBoxRecipes.TabIndex = 11;
            // 
            // back
            // 
            back.Location = new Point(19, 835);
            back.Margin = new Padding(5, 6, 5, 6);
            back.Name = "back";
            back.Size = new Size(149, 75);
            back.TabIndex = 10;
            back.Text = "Назад";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(424, 43);
            btnSearch.Margin = new Padding(5, 6, 5, 6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(118, 65);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Найти";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 22);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(349, 28);
            label1.TabIndex = 8;
            label1.Text = "Введите название недуга для поиска";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(19, 56);
            txtSearch.Margin = new Padding(5, 6, 5, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(394, 34);
            txtSearch.TabIndex = 7;
            // 
            // SearchRecipeByDisease
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 931);
            Controls.Add(panelRecipeDetails);
            Controls.Add(listBoxRecipes);
            Controls.Add(back);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Font = new Font("Segoe UI", 15F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5, 6, 5, 6);
            Name = "SearchRecipeByDisease";
            Text = "Поиск рецепта по лечимому недугу";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelRecipeDetails;
        private ListBox listBoxRecipes;
        private Button back;
        private Button btnSearch;
        private Label label1;
        private TextBox txtSearch;
    }
}