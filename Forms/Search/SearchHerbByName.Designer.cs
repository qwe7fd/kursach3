namespace kursach
{
    partial class SearchHerbByName
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
            txtSearchHerb = new TextBox();
            label1 = new Label();
            btnSearch = new Button();
            back = new Button();
            listBoxHerbs = new ListBox();
            panelHerbDetails = new Panel();
            SuspendLayout();
            // 
            // txtSearchHerb
            // 
            txtSearchHerb.Location = new Point(19, 58);
            txtSearchHerb.Margin = new Padding(5, 6, 5, 6);
            txtSearchHerb.Name = "txtSearchHerb";
            txtSearchHerb.Size = new Size(394, 34);
            txtSearchHerb.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(371, 28);
            label1.TabIndex = 1;
            label1.Text = "Введите название растения для поиска";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(424, 45);
            btnSearch.Margin = new Padding(5, 6, 5, 6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(118, 65);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Найти";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // back
            // 
            back.Location = new Point(19, 845);
            back.Margin = new Padding(5, 6, 5, 6);
            back.Name = "back";
            back.Size = new Size(149, 75);
            back.TabIndex = 4;
            back.Text = "Назад";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // listBoxHerbs
            // 
            listBoxHerbs.FormattingEnabled = true;
            listBoxHerbs.ItemHeight = 28;
            listBoxHerbs.Location = new Point(19, 129);
            listBoxHerbs.Margin = new Padding(5, 6, 5, 6);
            listBoxHerbs.Name = "listBoxHerbs";
            listBoxHerbs.Size = new Size(532, 704);
            listBoxHerbs.TabIndex = 5;
            // 
            // panelHerbDetails
            // 
            panelHerbDetails.Location = new Point(583, 129);
            panelHerbDetails.Margin = new Padding(5, 6, 5, 6);
            panelHerbDetails.Name = "panelHerbDetails";
            panelHerbDetails.Size = new Size(883, 704);
            panelHerbDetails.TabIndex = 6;
            // 
            // SearchHerbByName
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
            Name = "SearchHerbByName";
            Text = "Поиск по названию растения";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearchHerb;
        private Label label1;
        private Button btnSearch;
        private Button back;
        private ListBox listBoxHerbs;
        private Panel panelHerbDetails;
    }
}