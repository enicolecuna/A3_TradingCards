namespace Assignment3
{
    partial class Form1
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
            listOfPlayers = new ListBox();
            pictureOfPlayers = new PictureBox();
            lblName = new Label();
            lblTeam = new Label();
            lblStat1 = new Label();
            lblStat2 = new Label();
            lblStat3 = new Label();
            lblStat4 = new Label();
            txtTeam = new TextBox();
            txtName = new TextBox();
            txtStat1 = new TextBox();
            txtStat2 = new TextBox();
            txtStat3 = new TextBox();
            txtStat4 = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            label1 = new Label();
            JustLabel = new Label();
            label2 = new Label();
            pictureBoxTeamDisplay = new PictureBox();
            cmbFilterTeam = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureOfPlayers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTeamDisplay).BeginInit();
            SuspendLayout();
            // 
            // listOfPlayers
            // 
            listOfPlayers.BackColor = SystemColors.ButtonFace;
            listOfPlayers.ForeColor = SystemColors.ControlText;
            listOfPlayers.FormattingEnabled = true;
            listOfPlayers.ItemHeight = 15;
            listOfPlayers.Location = new Point(23, 126);
            listOfPlayers.Name = "listOfPlayers";
            listOfPlayers.Size = new Size(185, 154);
            listOfPlayers.TabIndex = 0;
            // 
            // pictureOfPlayers
            // 
            pictureOfPlayers.Location = new Point(416, 56);
            pictureOfPlayers.Name = "pictureOfPlayers";
            pictureOfPlayers.Size = new Size(157, 206);
            pictureOfPlayers.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureOfPlayers.TabIndex = 1;
            pictureOfPlayers.TabStop = false;
            pictureOfPlayers.Click += pictureOfPlayers_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(416, 293);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            lblName.Click += btnSelectImage_Click;
            // 
            // lblTeam
            // 
            lblTeam.AutoSize = true;
            lblTeam.Location = new Point(670, 238);
            lblTeam.Name = "lblTeam";
            lblTeam.Size = new Size(35, 15);
            lblTeam.TabIndex = 3;
            lblTeam.Text = "Team";
            lblTeam.Click += btnSelectImage_Click;
            // 
            // lblStat1
            // 
            lblStat1.AutoSize = true;
            lblStat1.Location = new Point(277, 340);
            lblStat1.Name = "lblStat1";
            lblStat1.Size = new Size(94, 15);
            lblStat1.TabIndex = 4;
            lblStat1.Text = "Points per Game";
            lblStat1.Click += btnSelectImage_Click;
            // 
            // lblStat2
            // 
            lblStat2.AutoSize = true;
            lblStat2.Location = new Point(259, 393);
            lblStat2.Name = "lblStat2";
            lblStat2.Size = new Size(114, 15);
            lblStat2.TabIndex = 5;
            lblStat2.Text = "Rebounds per Game";
            lblStat2.Click += btnSelectImage_Click;
            // 
            // lblStat3
            // 
            lblStat3.AutoSize = true;
            lblStat3.Location = new Point(507, 340);
            lblStat3.Name = "lblStat3";
            lblStat3.Size = new Size(96, 15);
            lblStat3.TabIndex = 6;
            lblStat3.Text = "Assists per Game";
            lblStat3.Click += btnSelectImage_Click;
            // 
            // lblStat4
            // 
            lblStat4.AutoSize = true;
            lblStat4.Location = new Point(507, 393);
            lblStat4.Name = "lblStat4";
            lblStat4.Size = new Size(95, 15);
            lblStat4.TabIndex = 7;
            lblStat4.Text = "Blocks per Game";
            lblStat4.Click += btnSelectImage_Click;
            // 
            // txtTeam
            // 
            txtTeam.Location = new Point(727, 230);
            txtTeam.Name = "txtTeam";
            txtTeam.Size = new Size(100, 23);
            txtTeam.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(473, 285);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 9;
            // 
            // txtStat1
            // 
            txtStat1.Location = new Point(380, 334);
            txtStat1.Name = "txtStat1";
            txtStat1.Size = new Size(100, 23);
            txtStat1.TabIndex = 10;
            // 
            // txtStat2
            // 
            txtStat2.Location = new Point(380, 385);
            txtStat2.Name = "txtStat2";
            txtStat2.Size = new Size(100, 23);
            txtStat2.TabIndex = 11;
            // 
            // txtStat3
            // 
            txtStat3.Location = new Point(609, 334);
            txtStat3.Name = "txtStat3";
            txtStat3.Size = new Size(100, 23);
            txtStat3.TabIndex = 12;
            // 
            // txtStat4
            // 
            txtStat4.Location = new Point(609, 385);
            txtStat4.Name = "txtStat4";
            txtStat4.Size = new Size(100, 23);
            txtStat4.TabIndex = 13;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(610, 423);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(23, 312);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(133, 313);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlText;
            label1.Location = new Point(250, 6);
            label1.Name = "label1";
            label1.Size = new Size(3, 450);
            label1.TabIndex = 18;
            // 
            // JustLabel
            // 
            JustLabel.AutoSize = true;
            JustLabel.Location = new Point(62, 45);
            JustLabel.Name = "JustLabel";
            JustLabel.Size = new Size(79, 15);
            JustLabel.TabIndex = 19;
            JustLabel.Text = "List of Players";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(452, 24);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 20;
            label2.Text = "Profile Details";
            label2.Click += label2_Click;
            // 
            // pictureBoxTeamDisplay
            // 
            pictureBoxTeamDisplay.Location = new Point(691, 56);
            pictureBoxTeamDisplay.Name = "pictureBoxTeamDisplay";
            pictureBoxTeamDisplay.Size = new Size(163, 152);
            pictureBoxTeamDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTeamDisplay.TabIndex = 21;
            pictureBoxTeamDisplay.TabStop = false;
            // 
            // cmbFilterTeam
            // 
            cmbFilterTeam.FormattingEnabled = true;
            cmbFilterTeam.Location = new Point(87, 84);
            cmbFilterTeam.Name = "cmbFilterTeam";
            cmbFilterTeam.Size = new Size(121, 23);
            cmbFilterTeam.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 92);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 23;
            label3.Text = "Sort by Team";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 460);
            Controls.Add(label3);
            Controls.Add(cmbFilterTeam);
            Controls.Add(pictureBoxTeamDisplay);
            Controls.Add(label2);
            Controls.Add(JustLabel);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtStat4);
            Controls.Add(txtStat3);
            Controls.Add(txtStat2);
            Controls.Add(txtStat1);
            Controls.Add(txtName);
            Controls.Add(txtTeam);
            Controls.Add(lblStat4);
            Controls.Add(lblStat3);
            Controls.Add(lblStat2);
            Controls.Add(lblStat1);
            Controls.Add(lblTeam);
            Controls.Add(lblName);
            Controls.Add(pictureOfPlayers);
            Controls.Add(listOfPlayers);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureOfPlayers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTeamDisplay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listOfPlayers;
        private PictureBox pictureOfPlayers;
        private Label lblName;
        private Label lblTeam;
        private Label lblStat1;
        private Label lblStat2;
        private Label lblStat3;
        private Label lblStat4;
        private TextBox txtTeam;
        private TextBox txtName;
        private TextBox txtStat1;
        private TextBox txtStat2;
        private TextBox txtStat3;
        private TextBox txtStat4;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Label label1;
        private Label JustLabel;
        private Label label2;
        private PictureBox pictureBoxTeamDisplay;
        private ComboBox cmbFilterTeam;
        private Label label3;
    }
}
