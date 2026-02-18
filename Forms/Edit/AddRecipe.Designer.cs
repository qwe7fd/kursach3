namespace kursach
{
    partial class AddRecipe
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
            txtDisease = new TextBox();
            txtInstructions = new TextBox();
            checkedListBoxHerbs = new CheckedListBox();
            btnSaveRecipe = new Button();
            btnBack = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtDisease
            // 
            txtDisease.Location = new Point(314, 20);
            txtDisease.Margin = new Padding(5, 5, 5, 5);
            txtDisease.Name = "txtDisease";
            txtDisease.PlaceholderText = "Название недуга";
            txtDisease.Size = new Size(428, 32);
            txtDisease.TabIndex = 0;
            // 
            // txtInstructions
            // 
            txtInstructions.Location = new Point(314, 80);
            txtInstructions.Margin = new Padding(5, 5, 5, 5);
            txtInstructions.Multiline = true;
            txtInstructions.Name = "txtInstructions";
            txtInstructions.PlaceholderText = "Инструкция";
            txtInstructions.Size = new Size(428, 164);
            txtInstructions.TabIndex = 1;
            // 
            // checkedListBoxHerbs
            // 
            checkedListBoxHerbs.FormattingEnabled = true;
            checkedListBoxHerbs.Location = new Point(314, 257);
            checkedListBoxHerbs.Margin = new Padding(5, 5, 5, 5);
            checkedListBoxHerbs.Name = "checkedListBoxHerbs";
            checkedListBoxHerbs.Size = new Size(186, 274);
            checkedListBoxHerbs.TabIndex = 2;
            checkedListBoxHerbs.ItemCheck += checkedListBoxHerbs_ItemCheck;
            // 
            // btnSaveRecipe
            // 
            btnSaveRecipe.Location = new Point(580, 288);
            btnSaveRecipe.Margin = new Padding(5, 5, 5, 5);
            btnSaveRecipe.Name = "btnSaveRecipe";
            btnSaveRecipe.Size = new Size(118, 38);
            btnSaveRecipe.TabIndex = 3;
            btnSaveRecipe.Text = "Добавить";
            btnSaveRecipe.UseVisualStyleBackColor = true;
            btnSaveRecipe.Click += btnSaveRecipe_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(580, 465);
            btnBack.Margin = new Padding(5, 5, 5, 5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(118, 38);
            btnBack.TabIndex = 4;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 25);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(230, 25);
            label1.TabIndex = 5;
            label1.Text = "Введите название недуга";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 80);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(299, 25);
            label2.TabIndex = 6;
            label2.Text = "Введите инструкции для рецепта";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 257);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(215, 25);
            label3.TabIndex = 7;
            label3.Text = "Выберите ингредиенты";
            // 
            // AddRecipe
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 548);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnSaveRecipe);
            Controls.Add(checkedListBoxHerbs);
            Controls.Add(txtInstructions);
            Controls.Add(txtDisease);
            Font = new Font("Segoe UI", 14F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5, 5, 5, 5);
            Name = "AddRecipe";
            Text = "Добавление рецепта";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisease;
        private TextBox txtInstructions;
        private CheckedListBox checkedListBoxHerbs;
        private Button btnSaveRecipe;
        private Button btnBack;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}