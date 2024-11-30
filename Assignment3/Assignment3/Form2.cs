using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Form2 : Form
    {
        private readonly List<PlayerCard> allPlayers;//all existing players
        private readonly List<Team> teams;//all teams

        public PlayerCard EditedPlayer { get; private set; }//player being edited
        private string selectedImagePath;//path for player's image
        private string selectedTeamImagePath;//path for team's image

        private bool isManualTeamImage = false; // checks if the team image was manually set

        public Form2(PlayerCard player, List<PlayerCard> existingPlayers, List<Team> existingTeams)
        {
            InitializeComponent();
            allPlayers = existingPlayers;//get all players
            teams = existingTeams;//get all teams

            EditedPlayer = player;//the player being currently edited

            // Pre fill the fields with the data of the player
            txtEditName.Text = player.Name;
            txtEditStat1.Text = player.Stat1.ToString();
            txtEditStat2.Text = player.Stat2.ToString();
            txtEditStat3.Text = player.Stat3.ToString();
            txtEditStat4.Text = player.Stat4.ToString();

            selectedImagePath = player.PhotoPath;//saving
            selectedTeamImagePath = player.TeamPhotoPath;//saving

            pictureBoxEdit.ImageLocation = selectedImagePath;//showing
            pictureBoxEditTeam.ImageLocation = selectedTeamImagePath;//showing

            BindTeamsToComboBox(player.Team);//fill the combobox with teams
        }

        private void BindTeamsToComboBox(string selectedTeam)
        {
            cmbEditTeam.DataSource = null;//clear combobox
            cmbEditTeam.DataSource = teams.Select(t => t.Name).ToList();//add team names
            cmbEditTeam.SelectedItem = selectedTeam;//set selected team
            cmbEditTeam.SelectedIndexChanged += cmbEditTeam_SelectedIndexChanged; //handle team changes
        }

        private void cmbEditTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            // stops overwriting the team image if manually set
            if (!isManualTeamImage)
            {
                var selectedTeam = teams.FirstOrDefault(t => t.Name == cmbEditTeam.SelectedItem.ToString());
                if (selectedTeam != null)
                {
                    pictureBoxEditTeam.ImageLocation = selectedTeam.ImagePath;//update the team image
                }
            }
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;
                    pictureBoxEdit.ImageLocation = selectedImagePath;
                }
            }
        }

        private void btnSelectEditTeamImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedTeamImagePath = openFileDialog.FileName;
                    pictureBoxEditTeam.ImageLocation = selectedTeamImagePath;

                    // mark the team image as manually set
                    isManualTeamImage = true;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // ensure all fields are filled
            if (string.IsNullOrWhiteSpace(txtEditName.Text) || cmbEditTeam.SelectedItem == null)
            {
                MessageBox.Show("All fields must be filled.");
                return;
            }

            // ensure uniqueness
            if (allPlayers.Any(p => p != EditedPlayer &&
                                    p.Name.Equals(txtEditName.Text, StringComparison.OrdinalIgnoreCase) &&
                                    p.Team.Equals(cmbEditTeam.SelectedItem.ToString(), StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("A player with the same name and team already exists.");
                return;
            }

            // update the player's data
            EditedPlayer.Name = txtEditName.Text;
            EditedPlayer.Stat1 = int.Parse(txtEditStat1.Text);
            EditedPlayer.Stat2 = int.Parse(txtEditStat2.Text);
            EditedPlayer.Stat3 = int.Parse(txtEditStat3.Text);
            EditedPlayer.Stat4 = int.Parse(txtEditStat4.Text);
            EditedPlayer.PhotoPath = selectedImagePath;
            EditedPlayer.Team = cmbEditTeam.SelectedItem.ToString();

            // ensure the team image is updated based on the selected team
            if (!isManualTeamImage) // if a custom image was not manually selected
            {
                var selectedTeam = teams.FirstOrDefault(t => t.Name == EditedPlayer.Team);
                if (selectedTeam != null)
                {
                    EditedPlayer.TeamPhotoPath = selectedTeam.ImagePath; // update team image path
                }
            }
            else
            {
                EditedPlayer.TeamPhotoPath = selectedTeamImagePath; // use manually selected team image
            }

            DialogResult = DialogResult.OK;
            Close();
        }

    }
}
