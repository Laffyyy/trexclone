using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static T_Rex_Endless_Runner_MOO_ICT.frmMainmenu;
using MySql.Data.MySqlClient;


namespace T_Rex_Endless_Runner_MOO_ICT
{
    public partial class Form1 : Form
    {

        

        bool jumping = false;
        int jumpSpeed;
        int force = 12;
        int score = 0;
        int obstacleSpeed = 10;
        Random rand = new Random();
        int position;
        bool isGameOver = false;



        public Form1()
        {
            InitializeComponent();

            GameReset();
            
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            trex.Top += jumpSpeed;

            txtScore.Text = "Score: " + score;

            if (jumping == true && force < 0)
            {
                jumping = false;
            }

            if (jumping == true)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }


            if (trex.Top > 366 && jumping == false)
            {
                force = 12;
                trex.Top = 367;
                jumpSpeed = 0;
            }


            foreach(Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;

                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(200, 500) + (x.Width * 15);
                        score++;
                    }

                    if (trex.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        trex.Image = Properties.Resources.dead;
                        txtScore.Text += " Press R to restart the game!";
                        isGameOver = true;

                        if (isGameOver)
                        {
                            ///query time
                            MySqlConnection conn;
                            conn = new MySqlConnection();
                            conn.ConnectionString = "server=localhost;userid=root;password='root'; database=dinorun";

                            try
                            {
                                conn.Open();


                                // Check if the username already exists
                                string selectQuery = "SELECT dScore FROM tbluserscore WHERE dUsername = @Username";
                                MySqlCommand selectCommand = new MySqlCommand(selectQuery, conn);
                                selectCommand.Parameters.AddWithValue("@Username", GlobalVariables.UserName);
                                object existingScore = selectCommand.ExecuteScalar();

                                if (existingScore != null)
                                {
                                    // Update the score if the username exists and new score is higher
                                    int currentScore = Convert.ToInt32(existingScore);
                                    int newScore = currentScore;
                                    if (newScore > currentScore)
                                    {
                                        string updateQuery = "UPDATE tbluserscore SET dScore = @Score WHERE dUsername = @Username";
                                        MySqlCommand updateCommand = new MySqlCommand(updateQuery, conn);
                                        updateCommand.Parameters.AddWithValue("@Username", GlobalVariables.UserName);
                                        updateCommand.Parameters.AddWithValue("@Score", newScore);
                                        updateCommand.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    // Insert a new row if the username doesn't exist
                                    string insertQuery = "INSERT INTO tbluserscore (dUsername, dScore) VALUES (@Username, @Score)";
                                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn);
                                    insertCommand.Parameters.AddWithValue("@Username", GlobalVariables.UserName);
                                    insertCommand.Parameters.AddWithValue("@Score", score);
                                    insertCommand.ExecuteNonQuery();
                                }
                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                conn.Close();
                            }


                        }
                    }
                }
            }

            if (score > 5)
            {
                obstacleSpeed = 15;
            }



        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (jumping == true)
            {
                jumping = false;
            }

            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                GameReset();
            }
        }

        private void GameReset()
        {
            force = 12;
            jumpSpeed = 0;
            jumping = false;
            score = 0;
            obstacleSpeed = 10;
            txtScore.Text = "Score: " + score;
            trex.Image = Properties.Resources.running;
            isGameOver = false;
            trex.Top = 367;

            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    position = this.ClientSize.Width + rand.Next(500, 800) + (x.Width * 10);

                    x.Left = position;
                }
            }


            


            gameTimer.Start();




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
