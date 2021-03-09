namespace CDVJ
{
    partial class Game
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.tmrControles = new System.Windows.Forms.Timer(this.components);
            this.pctPlayer = new System.Windows.Forms.PictureBox();
            this.pctPlatform1 = new System.Windows.Forms.PictureBox();
            this.pnlscreen = new System.Windows.Forms.Panel();
            this.pctPlatform2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlatform1)).BeginInit();
            this.pnlscreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlatform2)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrControles
            // 
            this.tmrControles.Enabled = true;
            this.tmrControles.Interval = 1;
            this.tmrControles.Tick += new System.EventHandler(this.tmrControles_Tick);
            // 
            // pctPlayer
            // 
            this.pctPlayer.Image = ((System.Drawing.Image)(resources.GetObject("pctPlayer.Image")));
            this.pctPlayer.Location = new System.Drawing.Point(12, 249);
            this.pctPlayer.Name = "pctPlayer";
            this.pctPlayer.Size = new System.Drawing.Size(107, 101);
            this.pctPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctPlayer.TabIndex = 0;
            this.pctPlayer.TabStop = false;
            // 
            // pctPlatform1
            // 
            this.pctPlatform1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pctPlatform1.Location = new System.Drawing.Point(0, 356);
            this.pctPlatform1.Name = "pctPlatform1";
            this.pctPlatform1.Size = new System.Drawing.Size(356, 50);
            this.pctPlatform1.TabIndex = 1;
            this.pctPlatform1.TabStop = false;
            this.pctPlatform1.Tag = "platform";
            this.pctPlatform1.Click += new System.EventHandler(this.pctPlatform1_Click);
            // 
            // pnlscreen
            // 
            this.pnlscreen.Controls.Add(this.pctPlatform2);
            this.pnlscreen.Controls.Add(this.pctPlatform1);
            this.pnlscreen.Controls.Add(this.pctPlayer);
            this.pnlscreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlscreen.Location = new System.Drawing.Point(0, 0);
            this.pnlscreen.Name = "pnlscreen";
            this.pnlscreen.Size = new System.Drawing.Size(912, 386);
            this.pnlscreen.TabIndex = 1;
            // 
            // pctPlatform2
            // 
            this.pctPlatform2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pctPlatform2.Location = new System.Drawing.Point(784, 176);
            this.pctPlatform2.Name = "pctPlatform2";
            this.pctPlatform2.Size = new System.Drawing.Size(356, 50);
            this.pctPlatform2.TabIndex = 2;
            this.pctPlatform2.TabStop = false;
            this.pctPlatform2.Tag = "platform";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 386);
            this.Controls.Add(this.pnlscreen);
            this.Name = "Game";
            this.Text = "CyberDetective";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Game_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlatform1)).EndInit();
            this.pnlscreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctPlatform2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrControles;
        private System.Windows.Forms.PictureBox pctPlayer;
        private System.Windows.Forms.PictureBox pctPlatform1;
        private System.Windows.Forms.Panel pnlscreen;
        private System.Windows.Forms.PictureBox pctPlatform2;
    }
}

