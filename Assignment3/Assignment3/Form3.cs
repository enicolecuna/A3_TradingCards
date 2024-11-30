using System;
using System.Collections.Generic;

using System.Linq;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Assignment3
{
    public partial class Form3 : Form
    {
        public PlayerCard NewPlayer { get; private set; } //holds new added player
        private string selectedImagePath = "Images/default.png"; // default player image
        private string selectedTeamImagePath = "Images/default_team.png"; // default team image

        private readonly List<PlayerCard> allPlayers;//list of all players already added
        private readonly List<Team> teams; // list of teams

        private bool customTeamImageSelected = false; // tracks if a custom image is selected

        public Form3(List<PlayerCard> existingPlayers, List<Team> existingTeams)
        {
            InitializeComponent();
            allPlayers = existingPlayers; // get the list of existing players
            teams = existingTeams;// get the list of teams

            // Initialize UI with default values
            pictureBoxAdd.ImageLocation = selectedImagePath; // default player image
            pictureBoxTeam.ImageLocation = selectedTeamImagePath; // default team image
            BindTeamsToComboBox(); // fill the dropdown with team names
        }

        // This method populates the ComboBox with team names
        private void BindTeamsToComboBox()
        {
            cmbAddTeam.DataSource = null; // Clear anything already in combobox
            cmbAddTeam.DataSource = teams.Select(t => t.Name).ToList(); // add all the team names 
            cmbAddTeam.SelectedIndexChanged += cmbAddTeam_SelectedIndexChanged; // update team image when a team is selected
        }

        // When you select a team from the ComboBox 
        private void cmbAddTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update the image if a custom one hasn't been chosen
            if (!customTeamImageSelected)
            {
                var selectedTeam = teams.FirstOrDefault(t => t.Name == cmbAddTeam.SelectedItem.ToString());//get the selelcted team
                if (selectedTeam != null)
                {
                    selectedTeamImagePath = selectedTeam.ImagePath; // update the selected team image path
                    pictureBoxTeam.ImageLocation = selectedTeamImagePath; // show the selected team image
                }
            }
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            // Select Player Image
            using (OpenFileDialog openFileDialog = new OpenFileDialog())// create a file picker
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)// check if the user picked a file
                {
                    selectedImagePath = openFileDialog.FileName;
                    pictureBoxAdd.ImageLocation = selectedImagePath;
                }
            }
        }

        private void btnSelectAddTeamImage_Click(object sender, EventArgs e)
        {
            // Select Custom Team Image
            using (OpenFileDialog openFileDialog = new OpenFileDialog())// create a file picker
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)// check if the user picked a file
                {
                    selectedTeamImagePath = openFileDialog.FileName;
                    pictureBoxTeam.ImageLocation = selectedTeamImagePath;

                    // Mark that a custom team image is selected
                    customTeamImageSelected = true;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // validate inputs
            if (string.IsNullOrWhiteSpace(txtAddName.Text) || cmbAddTeam.SelectedItem == null ||
                !int.TryParse(txtAddStat1.Text, out int stat1) ||
                !int.TryParse(txtAddStat2.Text, out int stat2) ||
                !int.TryParse(txtAddStat3.Text, out int stat3) ||
                !int.TryParse(txtAddStat4.Text, out int stat4))
            {
                MessageBox.Show("All fields must be filled, and stats must be valid numbers.");
                return;
            }

            // check for duplicates
            if (allPlayers.Any(p => p.Name.Equals(txtAddName.Text, StringComparison.OrdinalIgnoreCase) &&
                                    p.Team.Equals(cmbAddTeam.SelectedItem.ToString(), StringComparison.OrdinalIgnoreCase) &&
                                    p.PhotoPath.Equals(selectedImagePath, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("A player with the same Name, Team, and Image already exists. Please change the details.");
                return;
            }

            // if the default team image is still selected, use the team's default image
            if (selectedTeamImagePath == "Images/default_team.png" && cmbAddTeam.SelectedItem != null && !customTeamImageSelected)
            {
                var selectedTeam = teams.FirstOrDefault(t => t.Name == cmbAddTeam.SelectedItem.ToString());
                if (selectedTeam != null)
                {
                    selectedTeamImagePath = selectedTeam.ImagePath;
                }
            }

            // create a new player
            NewPlayer = new PlayerCard
            {
                Name = txtAddName.Text,
                Team = cmbAddTeam.SelectedItem.ToString(),
                PhotoPath = selectedImagePath,
                Stat1 = stat1,
                Stat2 = stat2,
                Stat3 = stat3,
                Stat4 = stat4,
                TeamPhotoPath = selectedTeamImagePath // set the team image
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
