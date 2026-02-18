namespace kursach
{
    partial class DeleteHerb
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
            listBoxHerbs = new ListBox();
            btnDelete = new Button();
            btnBack = new Button();
            btnSearch = new Button();
            txtSearchHerb = new TextBox();
            panelHerbDetails = new Panel();
            SuspendLayout();
            // 
            // listBoxHerbs
            // 
            listBoxHerbs.FormattingEnabled = true;
            listBoxHerbs.ItemHeight = 25;
            listBoxHerbs.Location = new Point(19, 73);
            listBoxHerbs.Margin = new Padding(5);
            listBoxHerbs.Name = "listBoxHerbs";
            listBoxHerbs.Size = new Size(341, 579);
            listBoxHerbs.TabIndex = 0;
            listBoxHerbs.SelectedIndexChanged += listBoxHerbs_SelectedIndexChanged;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(401, 692);
            btnDelete.Margin = new Padding(5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(118, 38);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(19, 692);
            btnBack.Margin = new Padding(5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(118, 38);
            btnBack.TabIndex = 3;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(277, 24);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(83, 41);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Найти";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearchHerb
            // 
            txtSearchHerb.Location = new Point(19, 29);
            txtSearchHerb.Name = "txtSearchHerb";
            txtSearchHerb.Size = new Size(252, 32);
            txtSearchHerb.TabIndex = 5;
            // 
            // panelHerbDetails
            // 
            panelHerbDetails.Location = new Point(401, 73);
            panelHerbDetails.Name = "panelHerbDetails";
            panelHerbDetails.Size = new Size(624, 579);
            panelHerbDetails.TabIndex = 6;
            // 
            // DeleteHerb
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 752);
            Controls.Add(panelHerbDetails);
            Controls.Add(txtSearchHerb);
            Controls.Add(btnSearch);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(listBoxHerbs);
            Font = new Font("Segoe UI", 14F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5);
            Name = "DeleteHerb";
            Text = "Удаление растения";
            ResumeLayout(false);
            PerformLayout();
        }

        private void ListBoxHerbs_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ListBox listBoxHerbs;
        private Button btnDelete;
        private Button btnBack;
        private Button btnSearch;
        private TextBox txtSearchHerb;
        private Panel panelHerbDetails;
    }
}