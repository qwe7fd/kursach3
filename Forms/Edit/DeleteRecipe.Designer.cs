namespace kursach
{
    partial class DeleteRecipe
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnBack = new Button();
            btnDelete = new Button();
            listBoxRecipes = new ListBox();
            SuspendLayout();
            // 
            // panelRecipeDetails
            // 
            panelRecipeDetails.Location = new Point(408, 72);
            panelRecipeDetails.Name = "panelRecipeDetails";
            panelRecipeDetails.Size = new Size(624, 579);
            panelRecipeDetails.TabIndex = 12;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(26, 28);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(252, 32);
            txtSearch.TabIndex = 11;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(284, 23);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(83, 41);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Найти";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(26, 691);
            btnBack.Margin = new Padding(5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(118, 38);
            btnBack.TabIndex = 9;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(408, 691);
            btnDelete.Margin = new Padding(5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(118, 38);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // listBoxRecipes
            // 
            listBoxRecipes.FormattingEnabled = true;
            listBoxRecipes.ItemHeight = 25;
            listBoxRecipes.Location = new Point(26, 72);
            listBoxRecipes.Margin = new Padding(5);
            listBoxRecipes.Name = "listBoxRecipes";
            listBoxRecipes.Size = new Size(341, 579);
            listBoxRecipes.TabIndex = 7;
            // 
            // DeleteRecipe
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 752);
            Controls.Add(panelRecipeDetails);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(listBoxRecipes);
            Font = new Font("Segoe UI", 14F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5);
            Name = "DeleteRecipe";
            Text = "Удаление рецепта";
            ResumeLayout(false);
            PerformLayout();
        }

        private void ListBoxRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panelRecipeDetails;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnBack;
        private Button btnDelete;
        private ListBox listBoxRecipes;
    }
}