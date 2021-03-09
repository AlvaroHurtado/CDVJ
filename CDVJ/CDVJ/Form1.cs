using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDVJ
{
    public partial class Game : Form
    {
        bool right; bool left;
        bool jump;
        int g = 26;
        int force = 8;
        int jumpspeed = 8;
        int playerspeed = 8;
        int backspeed = 8;
        public Game()
        {
            InitializeComponent();
        }

        private void tmrControles_Tick(object sender, EventArgs e)
        {
            if (left == true && pctPlayer.Left > 60)
            {
                pctPlayer.Left -= playerspeed;
                MoveGameElements("forward");
            }
            if (right == true && pctPlayer.Left + (pctPlayer.Width + 60)  < this.ClientSize.Width)
            {
                pctPlayer.Left += playerspeed;
                MoveGameElements("back");
            }
            if (jump == true)
            {
                pctPlayer.Top -= force;
                force -= 2;
            }
            if (pctPlayer.Top + pctPlayer.Height >= pnlscreen.Height)
            {
                pctPlayer.Top = pnlscreen.Height - pctPlayer.Height;
                jump = false;
            }
            foreach (Control x in this.Controls)
            {
                if(x is PictureBox && x.Tag == "platform")
                {
                    if(pctPlayer.Bounds.IntersectsWith(x.Bounds) && !jump)
                    {
                        force = g;
                        pctPlayer.Top = x.Top - pctPlayer.Height;
                    }
                }
            }
          



        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    left = true;
                    break;
                case Keys.D:
                    right = true;
                    break;
                    
            }
            if (jump != true)
            {
                if (e.KeyCode == Keys.Space)
                {
                    jump = true;
                    force = g;
                }
                
         
             

            }
               

        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            left = false;
            right = false;
        }
        private void MoveGameElements (string direction)
        {
           
           
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void pctbackground_Click(object sender, EventArgs e)
        {

        }

        private void Game_KeyPress(object sender, KeyPressEventArgs e)
        {

      


        }

        private void pctPlatform1_Click(object sender, EventArgs e)
        {

        }
    }
}
