namespace BlackJack
{
    partial class Menu
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
            this.btnLocal = new System.Windows.Forms.Button();
            this.btnReglage = new System.Windows.Forms.Button();
            this.btnOnline = new System.Windows.Forms.Button();
            this.txbPlayer0 = new System.Windows.Forms.TextBox();
            this.txbPlayer1 = new System.Windows.Forms.TextBox();
            this.txbPlayer2 = new System.Windows.Forms.TextBox();
            this.txbPlayer3 = new System.Windows.Forms.TextBox();
            this.txbPlayer4 = new System.Windows.Forms.TextBox();
            this.btnStartLocal = new System.Windows.Forms.Button();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer3 = new System.Windows.Forms.Label();
            this.lblPlayer4 = new System.Windows.Forms.Label();
            this.lblPlayer5 = new System.Windows.Forms.Label();
            this.UDnbHotseatPlayer = new System.Windows.Forms.NumericUpDown();
            this.lblAddPlayer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UDnbHotseatPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLocal
            // 
            this.btnLocal.Location = new System.Drawing.Point(12, 205);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(245, 98);
            this.btnLocal.TabIndex = 0;
            this.btnLocal.Text = "Joueur en local";
            this.btnLocal.UseVisualStyleBackColor = true;
            this.btnLocal.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnReglage
            // 
            this.btnReglage.Location = new System.Drawing.Point(12, 309);
            this.btnReglage.Name = "btnReglage";
            this.btnReglage.Size = new System.Drawing.Size(245, 98);
            this.btnReglage.TabIndex = 1;
            this.btnReglage.Text = "reglage";
            this.btnReglage.UseVisualStyleBackColor = true;
            // 
            // btnOnline
            // 
            this.btnOnline.Location = new System.Drawing.Point(12, 101);
            this.btnOnline.Name = "btnOnline";
            this.btnOnline.Size = new System.Drawing.Size(245, 98);
            this.btnOnline.TabIndex = 2;
            this.btnOnline.Text = "Jouer en ligne";
            this.btnOnline.UseVisualStyleBackColor = true;
            // 
            // txbPlayer0
            // 
            this.txbPlayer0.Location = new System.Drawing.Point(311, 122);
            this.txbPlayer0.Name = "txbPlayer0";
            this.txbPlayer0.Size = new System.Drawing.Size(221, 20);
            this.txbPlayer0.TabIndex = 3;
            this.txbPlayer0.Visible = false;
            // 
            // txbPlayer1
            // 
            this.txbPlayer1.Location = new System.Drawing.Point(311, 148);
            this.txbPlayer1.Name = "txbPlayer1";
            this.txbPlayer1.Size = new System.Drawing.Size(221, 20);
            this.txbPlayer1.TabIndex = 4;
            this.txbPlayer1.Visible = false;
            // 
            // txbPlayer2
            // 
            this.txbPlayer2.Location = new System.Drawing.Point(311, 174);
            this.txbPlayer2.Name = "txbPlayer2";
            this.txbPlayer2.Size = new System.Drawing.Size(221, 20);
            this.txbPlayer2.TabIndex = 5;
            this.txbPlayer2.Visible = false;
            // 
            // txbPlayer3
            // 
            this.txbPlayer3.Location = new System.Drawing.Point(311, 200);
            this.txbPlayer3.Name = "txbPlayer3";
            this.txbPlayer3.Size = new System.Drawing.Size(221, 20);
            this.txbPlayer3.TabIndex = 6;
            this.txbPlayer3.Visible = false;
            // 
            // txbPlayer4
            // 
            this.txbPlayer4.Location = new System.Drawing.Point(311, 227);
            this.txbPlayer4.Name = "txbPlayer4";
            this.txbPlayer4.Size = new System.Drawing.Size(221, 20);
            this.txbPlayer4.TabIndex = 7;
            this.txbPlayer4.Visible = false;
            // 
            // btnStartLocal
            // 
            this.btnStartLocal.Location = new System.Drawing.Point(311, 288);
            this.btnStartLocal.Name = "btnStartLocal";
            this.btnStartLocal.Size = new System.Drawing.Size(221, 61);
            this.btnStartLocal.TabIndex = 10;
            this.btnStartLocal.Text = "Lancer la partie local";
            this.btnStartLocal.UseVisualStyleBackColor = true;
            this.btnStartLocal.Visible = false;
            this.btnStartLocal.Click += new System.EventHandler(this.btnStartLocal_Click);
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.ForeColor = System.Drawing.Color.White;
            this.lblPlayer1.Location = new System.Drawing.Point(233, 123);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(72, 19);
            this.lblPlayer1.TabIndex = 11;
            this.lblPlayer1.Text = "Joueur 1:";
            this.lblPlayer1.Visible = false;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.ForeColor = System.Drawing.Color.White;
            this.lblPlayer2.Location = new System.Drawing.Point(233, 149);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(72, 19);
            this.lblPlayer2.TabIndex = 12;
            this.lblPlayer2.Text = "Joueur 2:";
            this.lblPlayer2.Visible = false;
            // 
            // lblPlayer3
            // 
            this.lblPlayer3.AutoSize = true;
            this.lblPlayer3.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer3.ForeColor = System.Drawing.Color.White;
            this.lblPlayer3.Location = new System.Drawing.Point(233, 175);
            this.lblPlayer3.Name = "lblPlayer3";
            this.lblPlayer3.Size = new System.Drawing.Size(72, 19);
            this.lblPlayer3.TabIndex = 13;
            this.lblPlayer3.Text = "Joueur 3:";
            this.lblPlayer3.Visible = false;
            // 
            // lblPlayer4
            // 
            this.lblPlayer4.AutoSize = true;
            this.lblPlayer4.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer4.ForeColor = System.Drawing.Color.White;
            this.lblPlayer4.Location = new System.Drawing.Point(233, 202);
            this.lblPlayer4.Name = "lblPlayer4";
            this.lblPlayer4.Size = new System.Drawing.Size(72, 19);
            this.lblPlayer4.TabIndex = 14;
            this.lblPlayer4.Text = "Joueur 4:";
            this.lblPlayer4.Visible = false;
            // 
            // lblPlayer5
            // 
            this.lblPlayer5.AutoSize = true;
            this.lblPlayer5.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer5.ForeColor = System.Drawing.Color.White;
            this.lblPlayer5.Location = new System.Drawing.Point(233, 228);
            this.lblPlayer5.Name = "lblPlayer5";
            this.lblPlayer5.Size = new System.Drawing.Size(72, 19);
            this.lblPlayer5.TabIndex = 15;
            this.lblPlayer5.Text = "Joueur 5:";
            this.lblPlayer5.Visible = false;
            // 
            // UDnbHotseatPlayer
            // 
            this.UDnbHotseatPlayer.Location = new System.Drawing.Point(404, 88);
            this.UDnbHotseatPlayer.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.UDnbHotseatPlayer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UDnbHotseatPlayer.Name = "UDnbHotseatPlayer";
            this.UDnbHotseatPlayer.Size = new System.Drawing.Size(120, 20);
            this.UDnbHotseatPlayer.TabIndex = 16;
            this.UDnbHotseatPlayer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UDnbHotseatPlayer.Visible = false;
            this.UDnbHotseatPlayer.ValueChanged += new System.EventHandler(this.UDnbHotseatPlayer_ValueChanged);
            // 
            // lblAddPlayer
            // 
            this.lblAddPlayer.AutoSize = true;
            this.lblAddPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblAddPlayer.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPlayer.ForeColor = System.Drawing.Color.White;
            this.lblAddPlayer.Location = new System.Drawing.Point(263, 89);
            this.lblAddPlayer.Name = "lblAddPlayer";
            this.lblAddPlayer.Size = new System.Drawing.Size(135, 19);
            this.lblAddPlayer.TabIndex = 20;
            this.lblAddPlayer.Text = "Ajouter des joueurs";
            this.lblAddPlayer.Visible = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJack.Properties.Resources.menuBackGround;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAddPlayer);
            this.Controls.Add(this.UDnbHotseatPlayer);
            this.Controls.Add(this.lblPlayer5);
            this.Controls.Add(this.lblPlayer4);
            this.Controls.Add(this.lblPlayer3);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.btnStartLocal);
            this.Controls.Add(this.txbPlayer4);
            this.Controls.Add(this.txbPlayer3);
            this.Controls.Add(this.txbPlayer2);
            this.Controls.Add(this.txbPlayer1);
            this.Controls.Add(this.txbPlayer0);
            this.Controls.Add(this.btnOnline);
            this.Controls.Add(this.btnReglage);
            this.Controls.Add(this.btnLocal);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.UDnbHotseatPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.Button btnReglage;
        private System.Windows.Forms.Button btnOnline;
        private System.Windows.Forms.TextBox txbPlayer0;
        private System.Windows.Forms.TextBox txbPlayer1;
        private System.Windows.Forms.TextBox txbPlayer2;
        private System.Windows.Forms.TextBox txbPlayer3;
        private System.Windows.Forms.TextBox txbPlayer4;
        private System.Windows.Forms.Button btnStartLocal;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblPlayer3;
        private System.Windows.Forms.Label lblPlayer4;
        private System.Windows.Forms.Label lblPlayer5;
        private System.Windows.Forms.NumericUpDown UDnbHotseatPlayer;
        private System.Windows.Forms.Label lblAddPlayer;
    }
}