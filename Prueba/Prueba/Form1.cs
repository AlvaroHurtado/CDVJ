using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class frmJuego : Form
    {
        bool goleft = false;
        bool goright = false;
        bool jumping = false;
        bool hasKey;

        int jumpSpeed = 10;
        int force = 8;
        int playerSpeed = 10;
        int backgroundSpeed = 8; 

        public frmJuego()
        {
            InitializeComponent();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.D)
            {
                goright = true;
            }
            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
            }
        }
        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                goright = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pctPlayer.Top += jumpSpeed;

            if (jumping && force <0)
            {
                jumping = false;
            }

            if (jumping)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }
        
       
            if (goleft == true && pctPlayer.Left > 60)
            {
                pctPlayer.Left -= playerSpeed;
                pctPlayer.Image = Properties.Resources.Personaje_Iz;
            }
            if (goright == true && pctPlayer.Left + (pctPlayer.Width + 60) < this.ClientSize.Width)
            {
                pctPlayer.Left += playerSpeed;
                pctPlayer.Image = Properties.Resources.Jugador;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "platform")
                {
                    if(pctPlayer.Bounds.IntersectsWith(x.Bounds)&& !jumping)
                    {
                        force = 8;
                        pctPlayer.Top = x.Top - pctPlayer.Height;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "enemy")
                {
                    if(pctPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        tmrGeneral.Stop();
                        MessageBox.Show("Has Muerto!" + Environment.NewLine + "Pulsa ACEPTAR para jugar de nuevo");
                        RestartGame();
                    }
                }
            }

            if (pctPlayer.Bounds.IntersectsWith(pctKey.Bounds))
            {
                pctKey.Visible = false;
                hasKey = true;
            }

            if (pctPlayer.Bounds.IntersectsWith(pctDoor.Bounds) && hasKey == true)
            {
                pctDoor.Image = Properties.Resources.Efecto_teletransporte;
                tmrGeneral.Stop();
                MessageBox.Show("Buen trabajo, has ganado el juego!" + Environment.NewLine + "Pulsa ACEPTAR para jugar de nuevo");
                RestartGame();
            }

            if (pctPlayer.Top + pctPlayer.Height > this.ClientSize.Height)
            {
                tmrGeneral.Stop();
                MessageBox.Show("Has Muerto!" + Environment.NewLine + "Pulsa ACEPTAR para jugar de nuevo");
                RestartGame();
            }

            if (goleft == true && pctBackground.Left < 0)
            {
                pctBackground.Left += backgroundSpeed;
                MoveGameElements("forward");
            }

            if(goright == true && pctBackground.Left > -644)
            {
                pctBackground.Left -= backgroundSpeed;
                MoveGameElements("back");
            }
        }

        private void frmJuego_Load(object sender, EventArgs e)
        {

        }

        private void CloseGame(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RestartGame()
        {
            frmJuego newWindow = new frmJuego();
            newWindow.Show();
            this.Hide();
        }

        private void MoveGameElements(string direction)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string) x.Tag == "platform" || x is PictureBox && (string)x.Tag == "enemy" || x is PictureBox && (string)x.Tag == "key" || x is PictureBox && (string)x.Tag == "door")
                {
                    if (direction == "back")
                    {
                        x.Left -= backgroundSpeed;
                    }
                    if (direction == "forward")
                    {
                        x.Left += backgroundSpeed;
                    }
                }
            }
        }

        private void pctBackground_Click(object sender, EventArgs e)
        {

        }
    }
}
