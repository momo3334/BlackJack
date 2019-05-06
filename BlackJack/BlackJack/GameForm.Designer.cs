namespace BlackJack
{
    partial class GameForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.localHand0 = new System.Windows.Forms.PictureBox();
            this.dealerHand0 = new System.Windows.Forms.PictureBox();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.lblDealerHandValue = new System.Windows.Forms.TextBox();
            this.localHand3 = new System.Windows.Forms.PictureBox();
            this.localHand4 = new System.Windows.Forms.PictureBox();
            this.localHand2 = new System.Windows.Forms.PictureBox();
            this.localHand1 = new System.Windows.Forms.PictureBox();
            this.lblPlayer0 = new System.Windows.Forms.Label();
            this.lblPlayer3 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer4 = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.btnBet1 = new System.Windows.Forms.Button();
            this.btnBet10 = new System.Windows.Forms.Button();
            this.btnBet50 = new System.Windows.Forms.Button();
            this.btnBet100 = new System.Windows.Forms.Button();
            this.btnBet250 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHandValue1 = new System.Windows.Forms.Label();
            this.lblHandValue2 = new System.Windows.Forms.Label();
            this.lblHandValue0 = new System.Windows.Forms.Label();
            this.lblHandValue3 = new System.Windows.Forms.Label();
            this.lblHandValue4 = new System.Windows.Forms.Label();
            this.lblBet0 = new System.Windows.Forms.Label();
            this.lblBet2 = new System.Windows.Forms.Label();
            this.lblBet1 = new System.Windows.Forms.Label();
            this.lblBet3 = new System.Windows.Forms.Label();
            this.lblBet4 = new System.Windows.Forms.Label();
            this.lblBetTurn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfirmBet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.localHand0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerHand0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localHand3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localHand4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localHand2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localHand1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // localHand0
            // 
            this.localHand0.BackColor = System.Drawing.Color.Transparent;
            this.localHand0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.localHand0.Location = new System.Drawing.Point(514, 441);
            this.localHand0.Name = "localHand0";
            this.localHand0.Size = new System.Drawing.Size(90, 126);
            this.localHand0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.localHand0.TabIndex = 1;
            this.localHand0.TabStop = false;
            this.localHand0.Visible = false;
            // 
            // dealerHand0
            // 
            this.dealerHand0.BackColor = System.Drawing.Color.Transparent;
            this.dealerHand0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealerHand0.Location = new System.Drawing.Point(514, 96);
            this.dealerHand0.Name = "dealerHand0";
            this.dealerHand0.Size = new System.Drawing.Size(90, 126);
            this.dealerHand0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerHand0.TabIndex = 2;
            this.dealerHand0.TabStop = false;
            // 
            // btnHit
            // 
            this.btnHit.BackColor = System.Drawing.Color.Transparent;
            this.btnHit.BackgroundImage = global::BlackJack.Properties.Resources.btnHit;
            this.btnHit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHit.FlatAppearance.BorderSize = 0;
            this.btnHit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHit.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(937, 600);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(75, 72);
            this.btnHit.TabIndex = 3;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = false;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            this.btnHit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHit_MouseDown);
            this.btnHit.MouseEnter += new System.EventHandler(this.btnBetMouseEnter);
            this.btnHit.MouseLeave += new System.EventHandler(this.btnBetMouseLeave);
            this.btnHit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnHit_MouseUp);
            // 
            // btnStand
            // 
            this.btnStand.BackColor = System.Drawing.Color.Transparent;
            this.btnStand.BackgroundImage = global::BlackJack.Properties.Resources.btnStand;
            this.btnStand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStand.FlatAppearance.BorderSize = 0;
            this.btnStand.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStand.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStand.Location = new System.Drawing.Point(1037, 600);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(75, 72);
            this.btnStand.TabIndex = 4;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = false;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            this.btnStand.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnStand_MouseDown);
            this.btnStand.MouseEnter += new System.EventHandler(this.btnBetMouseEnter);
            this.btnStand.MouseLeave += new System.EventHandler(this.btnBetMouseLeave);
            this.btnStand.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStand_MouseUp);
            // 
            // lblDealerHandValue
            // 
            this.lblDealerHandValue.Location = new System.Drawing.Point(465, 96);
            this.lblDealerHandValue.Name = "lblDealerHandValue";
            this.lblDealerHandValue.Size = new System.Drawing.Size(38, 20);
            this.lblDealerHandValue.TabIndex = 5;
            // 
            // localHand3
            // 
            this.localHand3.BackColor = System.Drawing.Color.Transparent;
            this.localHand3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.localHand3.Location = new System.Drawing.Point(252, 419);
            this.localHand3.Name = "localHand3";
            this.localHand3.Size = new System.Drawing.Size(90, 126);
            this.localHand3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.localHand3.TabIndex = 7;
            this.localHand3.TabStop = false;
            this.localHand3.Visible = false;
            // 
            // localHand4
            // 
            this.localHand4.BackColor = System.Drawing.Color.Transparent;
            this.localHand4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.localHand4.Location = new System.Drawing.Point(41, 344);
            this.localHand4.Name = "localHand4";
            this.localHand4.Size = new System.Drawing.Size(90, 126);
            this.localHand4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.localHand4.TabIndex = 8;
            this.localHand4.TabStop = false;
            this.localHand4.Visible = false;
            // 
            // localHand2
            // 
            this.localHand2.BackColor = System.Drawing.Color.Transparent;
            this.localHand2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.localHand2.Location = new System.Drawing.Point(769, 419);
            this.localHand2.Name = "localHand2";
            this.localHand2.Size = new System.Drawing.Size(90, 126);
            this.localHand2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.localHand2.TabIndex = 9;
            this.localHand2.TabStop = false;
            this.localHand2.Visible = false;
            // 
            // localHand1
            // 
            this.localHand1.BackColor = System.Drawing.Color.Transparent;
            this.localHand1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.localHand1.Location = new System.Drawing.Point(973, 344);
            this.localHand1.Name = "localHand1";
            this.localHand1.Size = new System.Drawing.Size(90, 126);
            this.localHand1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.localHand1.TabIndex = 10;
            this.localHand1.TabStop = false;
            this.localHand1.Visible = false;
            // 
            // lblPlayer0
            // 
            this.lblPlayer0.AutoSize = true;
            this.lblPlayer0.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer0.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPlayer0.Location = new System.Drawing.Point(526, 570);
            this.lblPlayer0.Name = "lblPlayer0";
            this.lblPlayer0.Size = new System.Drawing.Size(0, 13);
            this.lblPlayer0.TabIndex = 11;
            // 
            // lblPlayer3
            // 
            this.lblPlayer3.AutoSize = true;
            this.lblPlayer3.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer3.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPlayer3.Location = new System.Drawing.Point(274, 548);
            this.lblPlayer3.Name = "lblPlayer3";
            this.lblPlayer3.Size = new System.Drawing.Size(0, 13);
            this.lblPlayer3.TabIndex = 12;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPlayer2.Location = new System.Drawing.Point(783, 548);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(0, 13);
            this.lblPlayer2.TabIndex = 13;
            // 
            // lblPlayer4
            // 
            this.lblPlayer4.AutoSize = true;
            this.lblPlayer4.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer4.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPlayer4.Location = new System.Drawing.Point(47, 473);
            this.lblPlayer4.Name = "lblPlayer4";
            this.lblPlayer4.Size = new System.Drawing.Size(0, 13);
            this.lblPlayer4.TabIndex = 14;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPlayer1.Location = new System.Drawing.Point(991, 473);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(0, 13);
            this.lblPlayer1.TabIndex = 15;
            // 
            // btnBet1
            // 
            this.btnBet1.BackColor = System.Drawing.Color.Transparent;
            this.btnBet1.BackgroundImage = global::BlackJack.Properties.Resources.whiteBet1;
            this.btnBet1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBet1.FlatAppearance.BorderSize = 0;
            this.btnBet1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBet1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBet1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBet1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet1.Location = new System.Drawing.Point(9, 599);
            this.btnBet1.Margin = new System.Windows.Forms.Padding(0);
            this.btnBet1.Name = "btnBet1";
            this.btnBet1.Size = new System.Drawing.Size(75, 72);
            this.btnBet1.TabIndex = 40;
            this.btnBet1.Text = "1";
            this.btnBet1.UseVisualStyleBackColor = false;
            this.btnBet1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBet1_MouseDown);
            this.btnBet1.MouseEnter += new System.EventHandler(this.btnBetMouseEnter);
            this.btnBet1.MouseLeave += new System.EventHandler(this.btnBetMouseLeave);
            this.btnBet1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnBet1_MouseUp);
            // 
            // btnBet10
            // 
            this.btnBet10.BackColor = System.Drawing.Color.Transparent;
            this.btnBet10.BackgroundImage = global::BlackJack.Properties.Resources.redBet10;
            this.btnBet10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBet10.FlatAppearance.BorderSize = 0;
            this.btnBet10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBet10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBet10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBet10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet10.Location = new System.Drawing.Point(88, 601);
            this.btnBet10.Margin = new System.Windows.Forms.Padding(0);
            this.btnBet10.Name = "btnBet10";
            this.btnBet10.Size = new System.Drawing.Size(75, 72);
            this.btnBet10.TabIndex = 39;
            this.btnBet10.Text = "10";
            this.btnBet10.UseVisualStyleBackColor = false;
            this.btnBet10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBet10_MouseDown);
            this.btnBet10.MouseEnter += new System.EventHandler(this.btnBetMouseEnter);
            this.btnBet10.MouseLeave += new System.EventHandler(this.btnBetMouseLeave);
            this.btnBet10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnBet10_MouseUp);
            // 
            // btnBet50
            // 
            this.btnBet50.BackColor = System.Drawing.Color.Transparent;
            this.btnBet50.BackgroundImage = global::BlackJack.Properties.Resources.greenBet50;
            this.btnBet50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBet50.FlatAppearance.BorderSize = 0;
            this.btnBet50.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBet50.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBet50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBet50.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet50.Location = new System.Drawing.Point(168, 602);
            this.btnBet50.Margin = new System.Windows.Forms.Padding(0);
            this.btnBet50.Name = "btnBet50";
            this.btnBet50.Size = new System.Drawing.Size(75, 72);
            this.btnBet50.TabIndex = 38;
            this.btnBet50.Text = "50";
            this.btnBet50.UseVisualStyleBackColor = false;
            this.btnBet50.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBet50_MouseDown);
            this.btnBet50.MouseEnter += new System.EventHandler(this.btnBetMouseEnter);
            this.btnBet50.MouseLeave += new System.EventHandler(this.btnBetMouseLeave);
            this.btnBet50.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnBet50_MouseUp);
            // 
            // btnBet100
            // 
            this.btnBet100.BackColor = System.Drawing.Color.Transparent;
            this.btnBet100.BackgroundImage = global::BlackJack.Properties.Resources.blackBet100;
            this.btnBet100.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBet100.FlatAppearance.BorderSize = 0;
            this.btnBet100.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBet100.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBet100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBet100.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet100.Location = new System.Drawing.Point(252, 601);
            this.btnBet100.Margin = new System.Windows.Forms.Padding(0);
            this.btnBet100.Name = "btnBet100";
            this.btnBet100.Size = new System.Drawing.Size(75, 72);
            this.btnBet100.TabIndex = 37;
            this.btnBet100.Text = "100";
            this.btnBet100.UseVisualStyleBackColor = false;
            this.btnBet100.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBet100_MouseDown);
            this.btnBet100.MouseEnter += new System.EventHandler(this.btnBetMouseEnter);
            this.btnBet100.MouseLeave += new System.EventHandler(this.btnBetMouseLeave);
            this.btnBet100.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnBet100_MouseUp);
            // 
            // btnBet250
            // 
            this.btnBet250.BackColor = System.Drawing.Color.Transparent;
            this.btnBet250.BackgroundImage = global::BlackJack.Properties.Resources.yellowBet250;
            this.btnBet250.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBet250.FlatAppearance.BorderSize = 0;
            this.btnBet250.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBet250.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBet250.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBet250.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet250.Location = new System.Drawing.Point(332, 600);
            this.btnBet250.Margin = new System.Windows.Forms.Padding(0);
            this.btnBet250.Name = "btnBet250";
            this.btnBet250.Size = new System.Drawing.Size(75, 72);
            this.btnBet250.TabIndex = 36;
            this.btnBet250.Text = "250";
            this.btnBet250.UseVisualStyleBackColor = false;
            this.btnBet250.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBet250_MouseDown);
            this.btnBet250.MouseEnter += new System.EventHandler(this.btnBetMouseEnter);
            this.btnBet250.MouseLeave += new System.EventHandler(this.btnBetMouseLeave);
            this.btnBet250.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnBet250_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::BlackJack.Properties.Resources.cardbackblue;
            this.pictureBox1.Location = new System.Drawing.Point(41, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // lblHandValue1
            // 
            this.lblHandValue1.AutoSize = true;
            this.lblHandValue1.BackColor = System.Drawing.Color.Transparent;
            this.lblHandValue1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandValue1.Location = new System.Drawing.Point(1000, 491);
            this.lblHandValue1.Name = "lblHandValue1";
            this.lblHandValue1.Size = new System.Drawing.Size(0, 19);
            this.lblHandValue1.TabIndex = 53;
            // 
            // lblHandValue2
            // 
            this.lblHandValue2.AutoSize = true;
            this.lblHandValue2.BackColor = System.Drawing.Color.Transparent;
            this.lblHandValue2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandValue2.Location = new System.Drawing.Point(791, 560);
            this.lblHandValue2.Name = "lblHandValue2";
            this.lblHandValue2.Size = new System.Drawing.Size(0, 19);
            this.lblHandValue2.TabIndex = 63;
            // 
            // lblHandValue0
            // 
            this.lblHandValue0.AutoSize = true;
            this.lblHandValue0.BackColor = System.Drawing.Color.Transparent;
            this.lblHandValue0.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandValue0.Location = new System.Drawing.Point(535, 585);
            this.lblHandValue0.Name = "lblHandValue0";
            this.lblHandValue0.Size = new System.Drawing.Size(0, 19);
            this.lblHandValue0.TabIndex = 64;
            // 
            // lblHandValue3
            // 
            this.lblHandValue3.AutoSize = true;
            this.lblHandValue3.BackColor = System.Drawing.Color.Transparent;
            this.lblHandValue3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandValue3.Location = new System.Drawing.Point(280, 560);
            this.lblHandValue3.Name = "lblHandValue3";
            this.lblHandValue3.Size = new System.Drawing.Size(0, 19);
            this.lblHandValue3.TabIndex = 65;
            // 
            // lblHandValue4
            // 
            this.lblHandValue4.AutoSize = true;
            this.lblHandValue4.BackColor = System.Drawing.Color.Transparent;
            this.lblHandValue4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandValue4.Location = new System.Drawing.Point(51, 492);
            this.lblHandValue4.Name = "lblHandValue4";
            this.lblHandValue4.Size = new System.Drawing.Size(0, 19);
            this.lblHandValue4.TabIndex = 66;
            // 
            // lblBet0
            // 
            this.lblBet0.AutoSize = true;
            this.lblBet0.BackColor = System.Drawing.Color.Transparent;
            this.lblBet0.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet0.Location = new System.Drawing.Point(587, 419);
            this.lblBet0.Name = "lblBet0";
            this.lblBet0.Size = new System.Drawing.Size(17, 19);
            this.lblBet0.TabIndex = 67;
            this.lblBet0.Text = "0";
            // 
            // lblBet2
            // 
            this.lblBet2.AutoSize = true;
            this.lblBet2.BackColor = System.Drawing.Color.Transparent;
            this.lblBet2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet2.Location = new System.Drawing.Point(842, 397);
            this.lblBet2.Name = "lblBet2";
            this.lblBet2.Size = new System.Drawing.Size(17, 19);
            this.lblBet2.TabIndex = 68;
            this.lblBet2.Text = "0";
            // 
            // lblBet1
            // 
            this.lblBet1.AutoSize = true;
            this.lblBet1.BackColor = System.Drawing.Color.Transparent;
            this.lblBet1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet1.Location = new System.Drawing.Point(1046, 322);
            this.lblBet1.Name = "lblBet1";
            this.lblBet1.Size = new System.Drawing.Size(17, 19);
            this.lblBet1.TabIndex = 69;
            this.lblBet1.Text = "0";
            // 
            // lblBet3
            // 
            this.lblBet3.AutoSize = true;
            this.lblBet3.BackColor = System.Drawing.Color.Transparent;
            this.lblBet3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet3.Location = new System.Drawing.Point(328, 397);
            this.lblBet3.Name = "lblBet3";
            this.lblBet3.Size = new System.Drawing.Size(17, 19);
            this.lblBet3.TabIndex = 70;
            this.lblBet3.Text = "0";
            // 
            // lblBet4
            // 
            this.lblBet4.AutoSize = true;
            this.lblBet4.BackColor = System.Drawing.Color.Transparent;
            this.lblBet4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet4.Location = new System.Drawing.Point(114, 322);
            this.lblBet4.Name = "lblBet4";
            this.lblBet4.Size = new System.Drawing.Size(17, 19);
            this.lblBet4.TabIndex = 71;
            this.lblBet4.Text = "0";
            // 
            // lblBetTurn
            // 
            this.lblBetTurn.AutoSize = true;
            this.lblBetTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblBetTurn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetTurn.ForeColor = System.Drawing.Color.Gold;
            this.lblBetTurn.Location = new System.Drawing.Point(416, 363);
            this.lblBetTurn.Name = "lblBetTurn";
            this.lblBetTurn.Size = new System.Drawing.Size(257, 26);
            this.lblBetTurn.TabIndex = 72;
            this.lblBetTurn.Text = "Au tour de joueur1 de miser";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 73;
            this.label1.Text = "Mise: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 74;
            this.label2.Text = "Mise: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(535, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 75;
            this.label3.Text = "Mise: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(782, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 76;
            this.label4.Text = "Mise: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(990, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 77;
            this.label5.Text = "Mise: ";
            // 
            // btnConfirmBet
            // 
            this.btnConfirmBet.Enabled = false;
            this.btnConfirmBet.Location = new System.Drawing.Point(417, 603);
            this.btnConfirmBet.Name = "btnConfirmBet";
            this.btnConfirmBet.Size = new System.Drawing.Size(75, 67);
            this.btnConfirmBet.TabIndex = 78;
            this.btnConfirmBet.Text = "Miser";
            this.btnConfirmBet.UseVisualStyleBackColor = true;
            this.btnConfirmBet.Visible = false;
            this.btnConfirmBet.Click += new System.EventHandler(this.btnConfirmBet_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1124, 684);
            this.Controls.Add(this.btnConfirmBet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBetTurn);
            this.Controls.Add(this.lblBet4);
            this.Controls.Add(this.lblBet3);
            this.Controls.Add(this.lblBet1);
            this.Controls.Add(this.lblBet2);
            this.Controls.Add(this.lblBet0);
            this.Controls.Add(this.lblHandValue4);
            this.Controls.Add(this.lblHandValue3);
            this.Controls.Add(this.lblHandValue0);
            this.Controls.Add(this.lblHandValue2);
            this.Controls.Add(this.lblHandValue1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBet1);
            this.Controls.Add(this.btnBet10);
            this.Controls.Add(this.btnBet50);
            this.Controls.Add(this.btnBet100);
            this.Controls.Add(this.btnBet250);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.lblPlayer4);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer3);
            this.Controls.Add(this.lblPlayer0);
            this.Controls.Add(this.localHand1);
            this.Controls.Add(this.localHand2);
            this.Controls.Add(this.localHand4);
            this.Controls.Add(this.localHand3);
            this.Controls.Add(this.lblDealerHandValue);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.dealerHand0);
            this.Controls.Add(this.localHand0);
            this.DoubleBuffered = true;
            this.Name = "GameForm";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.localHand0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerHand0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localHand3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localHand4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localHand2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localHand1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox localHand0;
        private System.Windows.Forms.PictureBox dealerHand0;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.TextBox lblDealerHandValue;
        private System.Windows.Forms.PictureBox localHand3;
        private System.Windows.Forms.PictureBox localHand4;
        private System.Windows.Forms.PictureBox localHand2;
        private System.Windows.Forms.PictureBox localHand1;
        private System.Windows.Forms.Label lblPlayer0;
        private System.Windows.Forms.Label lblPlayer3;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblPlayer4;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Button btnBet1;
        private System.Windows.Forms.Button btnBet10;
        private System.Windows.Forms.Button btnBet50;
        private System.Windows.Forms.Button btnBet100;
        private System.Windows.Forms.Button btnBet250;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHandValue1;
        private System.Windows.Forms.Label lblHandValue2;
        private System.Windows.Forms.Label lblHandValue0;
        private System.Windows.Forms.Label lblHandValue3;
        private System.Windows.Forms.Label lblHandValue4;
        private System.Windows.Forms.Label lblBet0;
        private System.Windows.Forms.Label lblBet2;
        private System.Windows.Forms.Label lblBet1;
        private System.Windows.Forms.Label lblBet3;
        private System.Windows.Forms.Label lblBet4;
        private System.Windows.Forms.Label lblBetTurn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConfirmBet;
    }
}

