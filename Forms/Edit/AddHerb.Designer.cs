namespace kursach
{
    partial class AddHerb
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
            txtName = new TextBox();
            txtAppearance = new TextBox();
            txtHabitat = new TextBox();
            txtDescription = new TextBox();
            btnSaveHerb = new Button();
            btnBack = new Button();
            txtTreatedDiseases = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(317, 20);
            txtName.Margin = new Padding(5, 5, 5, 5);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Название растения";
            txtName.Size = new Size(351, 36);
            txtName.TabIndex = 0;
            // 
            // txtAppearance
            // 
            txtAppearance.Location = new Point(317, 83);
            txtAppearance.Margin = new Padding(5, 5, 5, 5);
            txtAppearance.Multiline = true;
            txtAppearance.Name = "txtAppearance";
            txtAppearance.PlaceholderText = "Внешний вид";
            txtAppearance.Size = new Size(351, 194);
            txtAppearance.TabIndex = 1;
            // 
            // txtHabitat
            // 
            txtHabitat.Location = new Point(680, 88);
            txtHabitat.Margin = new Padding(5, 5, 5, 5);
            txtHabitat.Multiline = true;
            txtHabitat.Name = "txtHabitat";
            txtHabitat.PlaceholderText = "Место произрастния";
            txtHabitat.Size = new Size(277, 189);
            txtHabitat.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(317, 290);
            txtDescription.Margin = new Padding(5, 5, 5, 5);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Полное описание";
            txtDescription.Size = new Size(351, 212);
            txtDescription.TabIndex = 4;
            // 
            // btnSaveHerb
            // 
            btnSaveHerb.Location = new Point(757, 323);
            btnSaveHerb.Margin = new Padding(5, 5, 5, 5);
            btnSaveHerb.Name = "btnSaveHerb";
            btnSaveHerb.Size = new Size(118, 38);
            btnSaveHerb.TabIndex = 5;
            btnSaveHerb.Text = "Добавить";
            btnSaveHerb.UseVisualStyleBackColor = true;
            btnSaveHerb.Click += btnSaveHerb_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(757, 428);
            btnBack.Margin = new Padding(5, 5, 5, 5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(118, 38);
            btnBack.TabIndex = 6;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtTreatedDiseases
            // 
            txtTreatedDiseases.Location = new Point(317, 515);
            txtTreatedDiseases.Margin = new Padding(5, 5, 5, 5);
            txtTreatedDiseases.Multiline = true;
            txtTreatedDiseases.Name = "txtTreatedDiseases";
            txtTreatedDiseases.PlaceholderText = "Список лечимых недугов";
            txtTreatedDiseases.Size = new Size(640, 36);
            txtTreatedDiseases.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 25);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(253, 25);
            label1.TabIndex = 8;
            label1.Text = "Введите название растения";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 88);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(297, 25);
            label2.TabIndex = 9;
            label2.Text = "Опишите внешний вид растения";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(970, 93);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(229, 50);
            label4.TabIndex = 11;
            label4.Text = "Введите место \r\nпроизрастания растения";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 295);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(258, 25);
            label5.TabIndex = 12;
            label5.Text = "Опишите растение в общем";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 520);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(302, 25);
            label6.TabIndex = 13;
            label6.Text = "Введите список лечимых недугов";
            // 
            // AddHerb
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 602);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTreatedDiseases);
            Controls.Add(btnBack);
            Controls.Add(btnSaveHerb);
            Controls.Add(txtDescription);
            Controls.Add(txtHabitat);
            Controls.Add(txtAppearance);
            Controls.Add(txtName);
            Font = new Font("Segoe UI", 14F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5, 5, 5, 5);
            Name = "AddHerb";
            Text = "Добавление растения";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtAppearance;
        private TextBox txtHabitat;
        private TextBox txtDescription;
        private Button btnSaveHerb;
        private Button btnBack;
        private TextBox txtTreatedDiseases;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}