namespace kursach
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnSearchHerbByName = new Button();
            btnSearchHerbByDisease = new Button();
            btnSearchRecipeByDisease = new Button();
            btnSearchRecipeByHerb = new Button();
            btnRecipeAdd = new Button();
            btnHerbAdd = new Button();
            label2 = new Label();
            btnHerbDelete = new Button();
            btnRecipeDelete = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F);
            label1.Location = new Point(277, 31);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 31);
            label1.TabIndex = 0;
            label1.Text = "Поиск";
            // 
            // btnSearchHerbByName
            // 
            btnSearchHerbByName.Location = new Point(17, 78);
            btnSearchHerbByName.Margin = new Padding(5, 6, 5, 6);
            btnSearchHerbByName.Name = "btnSearchHerbByName";
            btnSearchHerbByName.Size = new Size(281, 81);
            btnSearchHerbByName.TabIndex = 1;
            btnSearchHerbByName.Text = "Поиск растения по названию";
            btnSearchHerbByName.UseVisualStyleBackColor = true;
            btnSearchHerbByName.Click += btnSearchHerbByName_Click;
            // 
            // btnSearchHerbByDisease
            // 
            btnSearchHerbByDisease.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchHerbByDisease.Location = new Point(339, 78);
            btnSearchHerbByDisease.Margin = new Padding(5, 6, 5, 6);
            btnSearchHerbByDisease.Name = "btnSearchHerbByDisease";
            btnSearchHerbByDisease.Size = new Size(269, 81);
            btnSearchHerbByDisease.TabIndex = 2;
            btnSearchHerbByDisease.Text = "Поиск растений по недугу";
            btnSearchHerbByDisease.UseVisualStyleBackColor = true;
            btnSearchHerbByDisease.Click += btnSearchHerbByDisease_Click;
            // 
            // btnSearchRecipeByDisease
            // 
            btnSearchRecipeByDisease.Location = new Point(19, 170);
            btnSearchRecipeByDisease.Margin = new Padding(5, 6, 5, 6);
            btnSearchRecipeByDisease.Name = "btnSearchRecipeByDisease";
            btnSearchRecipeByDisease.Size = new Size(280, 81);
            btnSearchRecipeByDisease.TabIndex = 3;
            btnSearchRecipeByDisease.Text = "Поиск рецептов по недугу";
            btnSearchRecipeByDisease.UseVisualStyleBackColor = true;
            btnSearchRecipeByDisease.Click += btnSearchRecipeByDisease_Click;
            // 
            // btnSearchRecipeByHerb
            // 
            btnSearchRecipeByHerb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchRecipeByHerb.Location = new Point(339, 170);
            btnSearchRecipeByHerb.Margin = new Padding(5, 6, 5, 6);
            btnSearchRecipeByHerb.Name = "btnSearchRecipeByHerb";
            btnSearchRecipeByHerb.Size = new Size(269, 81);
            btnSearchRecipeByHerb.TabIndex = 4;
            btnSearchRecipeByHerb.Text = "Поиск рецептов по ингредиенту";
            btnSearchRecipeByHerb.UseVisualStyleBackColor = true;
            btnSearchRecipeByHerb.Click += btnSearchRecipeByHerb_Click;
            // 
            // btnRecipeAdd
            // 
            btnRecipeAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRecipeAdd.Location = new Point(339, 400);
            btnRecipeAdd.Margin = new Padding(5, 6, 5, 6);
            btnRecipeAdd.Name = "btnRecipeAdd";
            btnRecipeAdd.Size = new Size(273, 67);
            btnRecipeAdd.TabIndex = 6;
            btnRecipeAdd.Text = "Добавить рецепт";
            btnRecipeAdd.UseVisualStyleBackColor = true;
            btnRecipeAdd.Click += btnRecipeAdd_Click;
            // 
            // btnHerbAdd
            // 
            btnHerbAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnHerbAdd.Location = new Point(17, 400);
            btnHerbAdd.Margin = new Padding(5, 6, 5, 6);
            btnHerbAdd.Name = "btnHerbAdd";
            btnHerbAdd.Size = new Size(286, 67);
            btnHerbAdd.TabIndex = 7;
            btnHerbAdd.Text = "Добавить растение";
            btnHerbAdd.UseVisualStyleBackColor = true;
            btnHerbAdd.Click += btnHerbAdd_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 17F);
            label2.Location = new Point(249, 353);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 31);
            label2.TabIndex = 8;
            label2.Text = "Изменение";
            // 
            // btnHerbDelete
            // 
            btnHerbDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnHerbDelete.Location = new Point(17, 479);
            btnHerbDelete.Margin = new Padding(5, 6, 5, 6);
            btnHerbDelete.Name = "btnHerbDelete";
            btnHerbDelete.Size = new Size(286, 65);
            btnHerbDelete.TabIndex = 9;
            btnHerbDelete.Text = "Удалить растение";
            btnHerbDelete.UseVisualStyleBackColor = true;
            btnHerbDelete.Click += btnHerbDelete_Click;
            // 
            // btnRecipeDelete
            // 
            btnRecipeDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRecipeDelete.Location = new Point(339, 478);
            btnRecipeDelete.Margin = new Padding(5, 6, 5, 6);
            btnRecipeDelete.Name = "btnRecipeDelete";
            btnRecipeDelete.Size = new Size(273, 67);
            btnRecipeDelete.TabIndex = 10;
            btnRecipeDelete.Text = "Удалить рецепт";
            btnRecipeDelete.UseVisualStyleBackColor = true;
            btnRecipeDelete.Click += btnRecipeDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom;
            btnExit.AutoSize = true;
            btnExit.Location = new Point(230, 619);
            btnExit.Margin = new Padding(5, 6, 5, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(178, 53);
            btnExit.TabIndex = 5;
            btnExit.Text = "Выйти";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 687);
            Controls.Add(btnRecipeDelete);
            Controls.Add(btnHerbDelete);
            Controls.Add(label2);
            Controls.Add(btnHerbAdd);
            Controls.Add(btnRecipeAdd);
            Controls.Add(btnExit);
            Controls.Add(btnSearchRecipeByHerb);
            Controls.Add(btnSearchRecipeByDisease);
            Controls.Add(btnSearchHerbByDisease);
            Controls.Add(btnSearchHerbByName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            Text = "Каталог лекарственных растений";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSearchHerbByName;
        private Button btnSearchHerbByDisease;
        private Button btnSearchRecipeByDisease;
        private Button btnSearchRecipeByHerb;
        private Button btnRecipeAdd;
        private Button btnHerbAdd;
        private Label label2;
        private Button btnHerbDelete;
        private Button btnRecipeDelete;
        private Button btnExit;
    }
}
