namespace Assignment3
{
    partial class Form3
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
            btnSelectImage = new Button();
            btnAdd = new Button();
            txtAddStat4 = new TextBox();
            txtAddStat3 = new TextBox();
            txtAddStat2 = new TextBox();
            txtAddStat1 = new TextBox();
            txtAddName = new TextBox();
            lblStat4 = new Label();
            lblStat3 = new Label();
            lblStat2 = new Label();
            lblStat1 = new Label();
            lblName = new Label();
            pictureBoxAdd = new PictureBox();
            btnCancel = new Button();
            pictureBoxTeam = new PictureBox();
            lblTeam = new Label();
            btnSelectAddTeamImage = new Button();
            cmbAddTeam = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTeam).BeginInit();
            SuspendLayout();
            // 
            // btnSelectImage
            // 
            btnSelectImage.Location = new Point(75, 192);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(116, 23);
            btnSelectImage.TabIndex = 47;
            btnSelectImage.Text = "Select Image";
            btnSelectImage.UseVisualStyleBackColor = true;
            btnSelectImage.Click += btnSelectImage_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(577, 333);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 46;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtAddStat4
            // 
            txtAddStat4.Location = new Point(353, 211);
            txtAddStat4.Name = "txtAddStat4";
            txtAddStat4.Size = new Size(100, 23);
            txtAddStat4.TabIndex = 45;
            // 
            // txtAddStat3
            // 
            txtAddStat3.Location = new Point(353, 158);
            txtAddStat3.Name = "txtAddStat3";
            txtAddStat3.Size = new Size(100, 23);
            txtAddStat3.TabIndex = 44;
            // 
            // txtAddStat2
            // 
            txtAddStat2.Location = new Point(353, 105);
            txtAddStat2.Name = "txtAddStat2";
            txtAddStat2.Size = new Size(100, 23);
            txtAddStat2.TabIndex = 43;
            // 
            // txtAddStat1
            // 
            txtAddStat1.Location = new Point(353, 54);
            txtAddStat1.Name = "txtAddStat1";
            txtAddStat1.Size = new Size(100, 23);
            txtAddStat1.TabIndex = 42;
            // 
            // txtAddName
            // 
            txtAddName.Location = new Point(107, 248);
            txtAddName.Name = "txtAddName";
            txtAddName.Size = new Size(100, 23);
            txtAddName.TabIndex = 41;
            // 
            // lblStat4
            // 
            lblStat4.AutoSize = true;
            lblStat4.Location = new Point(237, 219);
            lblStat4.Name = "lblStat4";
            lblStat4.Size = new Size(95, 15);
            lblStat4.TabIndex = 39;
            lblStat4.Text = "Blocks per Game";
            // 
            // lblStat3
            // 
            lblStat3.AutoSize = true;
            lblStat3.Location = new Point(237, 166);
            lblStat3.Name = "lblStat3";
            lblStat3.Size = new Size(96, 15);
            lblStat3.TabIndex = 38;
            lblStat3.Text = "Assists per Game";
            // 
            // lblStat2
            // 
            lblStat2.AutoSize = true;
            lblStat2.Location = new Point(237, 113);
            lblStat2.Name = "lblStat2";
            lblStat2.Size = new Size(114, 15);
            lblStat2.TabIndex = 37;
            lblStat2.Text = "Rebounds per Game";
            // 
            // lblStat1
            // 
            lblStat1.AutoSize = true;
            lblStat1.Location = new Point(237, 62);
            lblStat1.Name = "lblStat1";
            lblStat1.Size = new Size(94, 15);
            lblStat1.TabIndex = 36;
            lblStat1.Text = "Points per Game";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(50, 256);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 34;
            lblName.Text = "Name";
            // 
            // pictureBoxAdd
            // 
            pictureBoxAdd.Location = new Point(50, 51);
            pictureBoxAdd.Name = "pictureBoxAdd";
            pictureBoxAdd.Size = new Size(157, 123);
            pictureBoxAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAdd.TabIndex = 33;
            pictureBoxAdd.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(50, 333);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 48;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // pictureBoxTeam
            // 
            pictureBoxTeam.Location = new Point(489, 63);
            pictureBoxTeam.Name = "pictureBoxTeam";
            pictureBoxTeam.Size = new Size(163, 152);
            pictureBoxTeam.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTeam.TabIndex = 51;
            pictureBoxTeam.TabStop = false;
            // 
            // lblTeam
            // 
            lblTeam.AutoSize = true;
            lblTeam.Location = new Point(473, 261);
            lblTeam.Name = "lblTeam";
            lblTeam.Size = new Size(35, 15);
            lblTeam.TabIndex = 53;
            lblTeam.Text = "Team";
            // 
            // btnSelectAddTeamImage
            // 
            btnSelectAddTeamImage.Location = new Point(514, 224);
            btnSelectAddTeamImage.Name = "btnSelectAddTeamImage";
            btnSelectAddTeamImage.Size = new Size(116, 23);
            btnSelectAddTeamImage.TabIndex = 57;
            btnSelectAddTeamImage.Text = "Select Image";
            btnSelectAddTeamImage.UseVisualStyleBackColor = true;
            btnSelectAddTeamImage.Click += btnSelectAddTeamImage_Click;
            // 
            // cmbAddTeam
            // 
            cmbAddTeam.FormattingEnabled = true;
            cmbAddTeam.Location = new Point(514, 258);
            cmbAddTeam.Name = "cmbAddTeam";
            cmbAddTeam.Size = new Size(121, 23);
            cmbAddTeam.TabIndex = 58;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 381);
            Controls.Add(cmbAddTeam);
            Controls.Add(btnSelectAddTeamImage);
            Controls.Add(lblTeam);
            Controls.Add(pictureBoxTeam);
            Controls.Add(btnCancel);
            Controls.Add(btnSelectImage);
            Controls.Add(btnAdd);
            Controls.Add(txtAddStat4);
            Controls.Add(txtAddStat3);
            Controls.Add(txtAddStat2);
            Controls.Add(txtAddStat1);
            Controls.Add(txtAddName);
            Controls.Add(lblStat4);
            Controls.Add(lblStat3);
            Controls.Add(lblStat2);
            Controls.Add(lblStat1);
            Controls.Add(lblName);
            Controls.Add(pictureBoxAdd);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTeam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectImage;
        private Button btnAdd;
        private TextBox txtAddStat4;
        private TextBox txtAddStat3;
        private TextBox txtAddStat2;
        private TextBox txtAddStat1;
        private TextBox txtAddName;
        private Label lblStat4;
        private Label lblStat3;
        private Label lblStat2;
        private Label lblStat1;
        private Label lblName;
        private PictureBox pictureBoxAdd;
        private Button btnCancel;
        private PictureBox pictureBoxTeam;
        private Label lblTeam;
        private Button btnSelectAddTeamImage;
        private ComboBox cmbAddTeam;
    }
}