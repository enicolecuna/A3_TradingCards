using System;
using System.Collections.Generic;
using System.Drawing; 
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text.Json;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        private List<PlayerCard> playerCards; //stores player data
        private string selectedImagePath = "Images/default.png"; // default image
        private readonly string dataFilePath = "players.json"; // file where players data is stored
        private List<PlayerCard> filteredPlayerCards; // list for filtered players
        private Panel pictureBorderPanel; // border for player picture based on team


        public Form1()
        {
            

            InitializeComponent();
            InitializeBorderPanel(); // set up the picture border
            InitializeDefaults();    // reset to default when the app starts
            LoadPlayerData();        // load saved players or the default players
            BindPlayerList();        // show players to listbox
            PopulateFilterDropdown(); // add team names to the filter 

        }

        private void InitializeDefaults()
        {
            // Reset inputs
            txtName.Clear();
            txtTeam.Clear();
            txtStat1.Clear();
            txtStat2.Clear();
            txtStat3.Clear();
            txtStat4.Clear();

            // Make it read-only for display
            txtName.ReadOnly = true;
            txtTeam.ReadOnly = true;
            txtStat1.ReadOnly = true;
            txtStat2.ReadOnly = true;
            txtStat3.ReadOnly = true;
            txtStat4.ReadOnly = true;

            

            // Set player pic to default image and clear border
            pictureOfPlayers.ImageLocation = "Images/default.png";
            pictureBoxTeamDisplay.ImageLocation = "Images/default.png"; 
            pictureOfPlayers.SizeMode = PictureBoxSizeMode.StretchImage; 
            pictureOfPlayers.BorderStyle = BorderStyle.None;
            selectedImagePath = "Images/default.png";
        }
        //basketball team and their logo
        private List<Team> teams = new List<Team>
        {
            new Team { Name = "Lakers", ImagePath = "Images/Lakers.png" },
            new Team { Name = "Warriors", ImagePath = "Images/Warriors.png" },
            new Team { Name = "Bulls", ImagePath = "Images/Bulls.png" }
        };
        // map team names to border colors
        private Dictionary<string, Color> teamColors = new Dictionary<string, Color>
        {
            { "Lakers", Color.Purple },
            { "Warriors", Color.Gold },
            { "Bulls", Color.Red }
        };

        // add the team names to the filter
        private void PopulateFilterDropdown()
        {
            // start with "All" as the first option
            var teamOptions = new List<string> { "All" };
            teamOptions.AddRange(teams.Select(t => t.Name));//add the team names

            cmbFilterTeam.DataSource = teamOptions; // show the options to the dropdown
            cmbFilterTeam.SelectedIndexChanged += CmbFilterTeam_SelectedIndexChanged; // manages team selection
        }

        // sets a panel around a picture to be a border
        private void InitializeBorderPanel()
        {
            // Add a panel to simulate a border around the PictureBox
            pictureBorderPanel = new Panel
            {
                Size = new Size(pictureOfPlayers.Width + 10, pictureOfPlayers.Height + 10), // Add border size
                BackColor = Color.Transparent,
                Location = new Point(pictureOfPlayers.Left - 5, pictureOfPlayers.Top - 5), // Adjust for border
            };
            Controls.Add(pictureBorderPanel); //add panel to the form
            pictureBorderPanel.BringToFront(); //make the panel front
            pictureOfPlayers.Parent = pictureBorderPanel; // put the pic inside of the panel
            pictureOfPlayers.Location = new Point(5, 5); // center it inside the panel
        }

        //default list of basketball players
        private List<PlayerCard> GetDefaultPlayers()
        {
            return new List<PlayerCard>
            {
                 new PlayerCard { Name = "Zach LaVine", Team = "Bulls", Stat1 = 92, Stat2 = 87, Stat3 = 88, Stat4 = 85, PhotoPath = "Images/zachlavine.png", TeamPhotoPath = "Images/Bulls.png" },
                new PlayerCard { Name = "DeMar DeRozan", Team = "Bulls", Stat1 = 90, Stat2 = 85, Stat3 = 87, Stat4 = 88, PhotoPath = "Images/demarderozan.png", TeamPhotoPath = "Images/Bulls.png" },
                new PlayerCard { Name = "LeBron James", Team = "Lakers", Stat1 = 97, Stat2 = 85, Stat3 = 90, Stat4 = 92, PhotoPath = "Images/lebronjames.png", TeamPhotoPath = "Images/Lakers.png" },
                new PlayerCard { Name = "Anthony Davis", Team = "Lakers", Stat1 = 93, Stat2 = 88, Stat3 = 85, Stat4 = 90, PhotoPath = "Images/anthonydavis.png", TeamPhotoPath = "Images/Lakers.png" },
                new PlayerCard { Name = "Stephen Curry", Team = "Warriors", Stat1 = 98, Stat2 = 94, Stat3 = 96, Stat4 = 89, PhotoPath = "Images/stephencurry.png", TeamPhotoPath = "Images/Warriors.png" },
                new PlayerCard { Name = "Lonzo Ball", Team = "Bulls", Stat1 = 88, Stat2 = 84, Stat3 = 85, Stat4 = 86, PhotoPath = "Images/lonzoball.png", TeamPhotoPath = "Images/Bulls.png" },
                new PlayerCard { Name = "Austin Reaves", Team = "Lakers", Stat1 = 83, Stat2 = 80, Stat3 = 78, Stat4 = 81, PhotoPath = "Images/austinreaves.png", TeamPhotoPath = "Images/Lakers.png" },
                new PlayerCard { Name = "Jordan Poole", Team = "Warriors", Stat1 = 84, Stat2 = 85, Stat3 = 86, Stat4 = 83, PhotoPath = "Images/jordanpoole.png", TeamPhotoPath = "Images/Warriors.png" },
                new PlayerCard { Name = "Klay Thompson", Team = "Warriors", Stat1 = 89, Stat2 = 92, Stat3 = 90, Stat4 = 88, PhotoPath = "Images/klaythompson.png", TeamPhotoPath = "Images/Warriors.png" },
                new PlayerCard { Name = "Draymond Green", Team = "Warriors", Stat1 = 85, Stat2 = 89, Stat3 = 80, Stat4 = 83, PhotoPath = "Images/draymondgreen.png", TeamPhotoPath = "Images/Warriors.png" }
               
            };
        }

        //loads players data from a file or uses the default list
        private void LoadPlayerData()
        {
            if (File.Exists(dataFilePath))
            {
                string json = File.ReadAllText(dataFilePath); // Read the JSON file
                playerCards = JsonSerializer.Deserialize<List<PlayerCard>>(json);

                // use default players if the json is empty
                if (playerCards == null || !playerCards.Any())
                {
                    playerCards = GetDefaultPlayers();
                    SavePlayerData(); // Save default players to the json file
                }
            }
            else
            {
                // load default players if the json file does not exist
                playerCards = GetDefaultPlayers();
                SavePlayerData(); // Save default players to the json file
            }
        }

        //updates the listbox with players

        private void BindPlayerList(IEnumerable<PlayerCard> filteredList = null)
        {
            filteredPlayerCards = filteredList?.ToList() ?? playerCards; // use filtered players or the full list of players
            listOfPlayers.DataSource = null; // clear current list
            listOfPlayers.DataSource = filteredPlayerCards.Select(p => p.Name).ToList(); // show player names

            listOfPlayers.SelectedIndexChanged -= listOfPlayers_SelectedIndexChanged;
            listOfPlayers.SelectedIndexChanged += listOfPlayers_SelectedIndexChanged;
        }

        //updates the player details when you click a name in the list
        private void listOfPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listOfPlayers.SelectedIndex >= 0 && filteredPlayerCards != null)//check if something is selected
            {
                PlayerCard selectedPlayer = filteredPlayerCards[listOfPlayers.SelectedIndex]; // Get the selected player from the filtered list
                DisplayPlayerDetails(selectedPlayer); // Display player data
            }
        }

        // When you click the button to select an image, this runs

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select a Player Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK) // if the user picked a file
                {
                    selectedImagePath = openFileDialog.FileName;//save the file path
                    pictureOfPlayers.ImageLocation = selectedImagePath;//show image in picturebox
                }
            }
        }

      
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (Form3 addForm = new Form3(playerCards, teams)) // open a form to add a new player
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    
                    playerCards.Add(addForm.NewPlayer);//add the new player to the list
                    BindPlayerList();//refresh the list
                    SavePlayerData();//save the new data to the file
                    MessageBox.Show("Player added successfully!");

                    // show the player's data
                    DisplayPlayerDetails(addForm.NewPlayer);
                }
            }
        }

        // This shows all the player's information when you click their name
        private void DisplayPlayerDetails(PlayerCard player)
        {
            if (player == null)
            {
                // Reset to default images when no player is selected
                pictureOfPlayers.ImageLocation = "Images/default.png";
                pictureBoxTeamDisplay.ImageLocation = "Images/default.png";
                return;
            }

            //fill in the txtboxes with info
            txtName.Text = player.Name;
            txtTeam.Text = player.Team;
            txtStat1.Text = player.Stat1.ToString();
            txtStat2.Text = player.Stat2.ToString();
            txtStat3.Text = player.Stat3.ToString();
            txtStat4.Text = player.Stat4.ToString();
            pictureOfPlayers.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureOfPlayers.ImageLocation = player.PhotoPath;

            // update the player image
            pictureOfPlayers.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureOfPlayers.ImageLocation = player.PhotoPath;

            // update the team image
            pictureBoxTeamDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
            if (!string.IsNullOrEmpty(player.TeamPhotoPath) && File.Exists(player.TeamPhotoPath))
            {
                pictureBoxTeamDisplay.ImageLocation = player.TeamPhotoPath;
            }
            else
            {
                pictureBoxTeamDisplay.ImageLocation = "Images/default.png"; // Use default if path is invalid
            }

            // update the border color based on the team
            if (teamColors.TryGetValue(player.Team, out Color borderColor))
            {
                pictureBorderPanel.BackColor = borderColor; // Set the border color
            }
            else
            {
                pictureBorderPanel.BackColor = SystemColors.Control; // Default border color
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listOfPlayers.SelectedIndex < 0 || filteredPlayerCards == null)//check if a player is selected
            {
                MessageBox.Show("Please select a player to edit.");
                return;
            }

            
            var selectedPlayer = filteredPlayerCards[listOfPlayers.SelectedIndex];// get the selected player from filtered list


            using (Form2 editForm = new Form2(selectedPlayer, playerCards, teams))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // update the player's details in the main list

                    var updatedPlayer = playerCards.FirstOrDefault(p => p.Name == selectedPlayer.Name && p.Team == selectedPlayer.Team);
                    if (updatedPlayer != null)
                    {
                        updatedPlayer.Name = selectedPlayer.Name;
                        updatedPlayer.Team = selectedPlayer.Team;
                        updatedPlayer.Stat1 = selectedPlayer.Stat1;
                        updatedPlayer.Stat2 = selectedPlayer.Stat2;
                        updatedPlayer.Stat3 = selectedPlayer.Stat3;
                        updatedPlayer.Stat4 = selectedPlayer.Stat4;
                        updatedPlayer.PhotoPath = selectedPlayer.PhotoPath;
                        updatedPlayer.TeamPhotoPath = selectedPlayer.TeamPhotoPath;
                    }

                    // refresh the filtered list
                    string selectedTeam = cmbFilterTeam.SelectedItem.ToString();
                    if (selectedTeam == "All")
                    {
                        BindPlayerList(playerCards); // show all players
                    }
                    else
                    {
                        var filteredPlayers = playerCards.Where(p => p.Team == selectedTeam).ToList(); // Filter by team
                        BindPlayerList(filteredPlayers);
                    }

                    // Save the updated data
                    SavePlayerData();
                    DisplayPlayerDetails(selectedPlayer); // Refresh the player details UI

                    MessageBox.Show("Player edited successfully!");
                }
            }
        }




        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listOfPlayers.SelectedIndex < 0 || filteredPlayerCards == null) // check if a player is selected
            {
                MessageBox.Show("Please select a player to delete.");
                return;
            }

            // eet the selected player from the filtered list
            var selectedPlayer = filteredPlayerCards[listOfPlayers.SelectedIndex];

         
            var confirmResult = MessageBox.Show($"Are you sure you want to delete {selectedPlayer.Name}?",
                                                "Confirm Delete",
                                                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                // remove the player from the main list
                playerCards.Remove(selectedPlayer);

                // refresh the filtered list
                BindPlayerList(filteredPlayerCards.Where(p => p != selectedPlayer).ToList());

                // save the updated data
                SavePlayerData();

                // reset fields
                InitializeDefaults();

                MessageBox.Show("Player deleted successfully!");
            }
        }

        // filters the players based on the selected team

        private void CmbFilterTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTeam = cmbFilterTeam.SelectedItem.ToString();

            if (selectedTeam == "All")
            {
                BindPlayerList(playerCards); // show all players
            }
            else
            {
                var filteredPlayers = playerCards.Where(p => p.Team == selectedTeam).ToList(); // Filter by team
                BindPlayerList(filteredPlayers); // show players from selected team
            }
        }


        private void SavePlayerData()
        {
            string json = JsonSerializer.Serialize(playerCards); // convert the list to json
            File.WriteAllText(dataFilePath, json); // write the json to a file
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureOfPlayers_Click(object sender, EventArgs e)
        {

        }

    }
}
