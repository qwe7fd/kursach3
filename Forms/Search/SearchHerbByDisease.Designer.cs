namespace kursach
{
    partial class SearchHerbByDisease
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
            panelHerbDetails = new Panel();
            listBoxHerbs = new ListBox();
            back = new Button();
            btnSearch = new Button();
            label1 = new Label();
            txtSearchHerb = new TextBox();
            SuspendLayout();
            // 
            // panelHerbDetails
            // 
            panelHerbDetails.Location = new Point(583, 129);
            panelHerbDetails.Margin = new Padding(5, 6, 5, 6);
            panelHerbDetails.Name = "panelHerbDetails";
            panelHerbDetails.Size = new Size(883, 706);
            panelHerbDetails.TabIndex = 12;
            // 
            // listBoxHerbs
            // 
            listBoxHerbs.FormattingEnabled = true;
            listBoxHerbs.ItemHeight = 28;
            listBoxHerbs.Location = new Point(19, 131);
            listBoxHerbs.Margin = new Padding(5, 6, 5, 6);
            listBoxHerbs.Name = "listBoxHerbs";
            listBoxHerbs.Size = new Size(532, 704);
            listBoxHerbs.TabIndex = 11;
            // 
            // back
            // 
            back.Location = new Point(19, 847);
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
            btnSearch.Location = new Point(435, 54);
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
            label1.Location = new Point(30, 21);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(437, 28);
            label1.TabIndex = 8;
            label1.Text = "Введите название недуга для поиска растения";
            // 
            // txtSearchHerb
            // 
            txtSearchHerb.Location = new Point(30, 67);
            txtSearchHerb.Margin = new Padding(5, 6, 5, 6);
            txtSearchHerb.Name = "txtSearchHerb";
            txtSearchHerb.Size = new Size(394, 34);
            txtSearchHerb.TabIndex = 7;
            // 
            // SearchHerbByDisease
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 931);
            Controls.Add(panelHerbDetails);
            Controls.Add(listBoxHerbs);
            Controls.Add(back);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(txtSearchHerb);
            Font = new Font("Segoe UI", 15F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5, 6, 5, 6);
            Name = "SearchHerbByDisease";
            Text = "Поиск по названию растения";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHerbDetails;
        private ListBox listBoxHerbs;
        private Button back;
        private Button btnSearch;
        private Label label1;
        private TextBox txtSearchHerb;
    }
}