namespace raceproject
{
    partial class MainForm
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
            this.putinImg = new System.Windows.Forms.PictureBox();
            this.trumpImg = new System.Windows.Forms.PictureBox();
            this.moderateImg = new System.Windows.Forms.PictureBox();
            this.radicalImg = new System.Windows.Forms.PictureBox();
            this.trumpBtn = new System.Windows.Forms.RadioButton();
            this.putinBtn = new System.Windows.Forms.RadioButton();
            this.moderateBtn = new System.Windows.Forms.RadioButton();
            this.betLbl = new System.Windows.Forms.Label();
            this.extremistBtn = new System.Windows.Forms.RadioButton();
            this.bobMoneyLbl = new System.Windows.Forms.Label();
            this.fredMoneyLbl = new System.Windows.Forms.Label();
            this.ballbagsMoneyLbl = new System.Windows.Forms.Label();
            this.bobCreditLbl = new System.Windows.Forms.Label();
            this.fredCreditLbl = new System.Windows.Forms.Label();
            this.ballbagsCreditLbl = new System.Windows.Forms.Label();
            this.betupdown = new System.Windows.Forms.NumericUpDown();
            this.groupBoxRacer = new System.Windows.Forms.GroupBox();
            this.bettorBox = new System.Windows.Forms.GroupBox();
            this.selectBallbagsBtn = new System.Windows.Forms.RadioButton();
            this.selectFredBtn = new System.Windows.Forms.RadioButton();
            this.selectBobBtn = new System.Windows.Forms.RadioButton();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.bobStatusLbl = new System.Windows.Forms.Label();
            this.fredStatusLbl = new System.Windows.Forms.Label();
            this.ballbagsStatusLbl = new System.Windows.Forms.Label();
            this.RacerWonLbl = new System.Windows.Forms.Label();
            this.globalReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.putinImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trumpImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moderateImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radicalImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betupdown)).BeginInit();
            this.groupBoxRacer.SuspendLayout();
            this.bettorBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // putinImg
            // 
            this.putinImg.Image = global::raceproject.Properties.Resources.putin;
            this.putinImg.Location = new System.Drawing.Point(296, 139);
            this.putinImg.Margin = new System.Windows.Forms.Padding(4);
            this.putinImg.Name = "putinImg";
            this.putinImg.Size = new System.Drawing.Size(277, 123);
            this.putinImg.TabIndex = 3;
            this.putinImg.TabStop = false;
            // 
            // trumpImg
            // 
            this.trumpImg.Image = global::raceproject.Properties.Resources.trump;
            this.trumpImg.Location = new System.Drawing.Point(296, 15);
            this.trumpImg.Margin = new System.Windows.Forms.Padding(4);
            this.trumpImg.Name = "trumpImg";
            this.trumpImg.Size = new System.Drawing.Size(277, 110);
            this.trumpImg.TabIndex = 0;
            this.trumpImg.TabStop = false;
            // 
            // moderateImg
            // 
            this.moderateImg.Image = global::raceproject.Properties.Resources.moderate;
            this.moderateImg.Location = new System.Drawing.Point(296, 270);
            this.moderateImg.Margin = new System.Windows.Forms.Padding(4);
            this.moderateImg.Name = "moderateImg";
            this.moderateImg.Size = new System.Drawing.Size(277, 218);
            this.moderateImg.TabIndex = 4;
            this.moderateImg.TabStop = false;
            // 
            // radicalImg
            // 
            this.radicalImg.Image = global::raceproject.Properties.Resources.radical;
            this.radicalImg.Location = new System.Drawing.Point(296, 503);
            this.radicalImg.Margin = new System.Windows.Forms.Padding(4);
            this.radicalImg.Name = "radicalImg";
            this.radicalImg.Size = new System.Drawing.Size(277, 261);
            this.radicalImg.TabIndex = 5;
            this.radicalImg.TabStop = false;
            // 
            // trumpBtn
            // 
            this.trumpBtn.AutoSize = true;
            this.trumpBtn.Location = new System.Drawing.Point(15, 42);
            this.trumpBtn.Margin = new System.Windows.Forms.Padding(4);
            this.trumpBtn.Name = "trumpBtn";
            this.trumpBtn.Size = new System.Drawing.Size(70, 21);
            this.trumpBtn.TabIndex = 6;
            this.trumpBtn.TabStop = true;
            this.trumpBtn.Text = "Trump";
            this.trumpBtn.UseVisualStyleBackColor = true;
            this.trumpBtn.CheckedChanged += new System.EventHandler(this.trumpBtn_CheckedChanged);
            // 
            // putinBtn
            // 
            this.putinBtn.AutoSize = true;
            this.putinBtn.Location = new System.Drawing.Point(15, 70);
            this.putinBtn.Margin = new System.Windows.Forms.Padding(4);
            this.putinBtn.Name = "putinBtn";
            this.putinBtn.Size = new System.Drawing.Size(61, 21);
            this.putinBtn.TabIndex = 7;
            this.putinBtn.TabStop = true;
            this.putinBtn.Text = "Putin";
            this.putinBtn.UseVisualStyleBackColor = true;
            this.putinBtn.CheckedChanged += new System.EventHandler(this.putinBtn_CheckedChanged);
            // 
            // moderateBtn
            // 
            this.moderateBtn.AutoSize = true;
            this.moderateBtn.Location = new System.Drawing.Point(15, 98);
            this.moderateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.moderateBtn.Name = "moderateBtn";
            this.moderateBtn.Size = new System.Drawing.Size(116, 21);
            this.moderateBtn.TabIndex = 8;
            this.moderateBtn.TabStop = true;
            this.moderateBtn.Text = "Moderate guy";
            this.moderateBtn.UseVisualStyleBackColor = true;
            this.moderateBtn.CheckedChanged += new System.EventHandler(this.moderateBtn_CheckedChanged);
            // 
            // betLbl
            // 
            this.betLbl.AutoSize = true;
            this.betLbl.Location = new System.Drawing.Point(8, 94);
            this.betLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.betLbl.Name = "betLbl";
            this.betLbl.Size = new System.Drawing.Size(75, 17);
            this.betLbl.TabIndex = 10;
            this.betLbl.Text = "Bet money";
            // 
            // extremistBtn
            // 
            this.extremistBtn.AutoSize = true;
            this.extremistBtn.Location = new System.Drawing.Point(15, 127);
            this.extremistBtn.Margin = new System.Windows.Forms.Padding(4);
            this.extremistBtn.Name = "extremistBtn";
            this.extremistBtn.Size = new System.Drawing.Size(86, 21);
            this.extremistBtn.TabIndex = 14;
            this.extremistBtn.TabStop = true;
            this.extremistBtn.Text = "Extremist";
            this.extremistBtn.UseVisualStyleBackColor = true;
            this.extremistBtn.CheckedChanged += new System.EventHandler(this.extremistBtn_CheckedChanged);
            // 
            // bobMoneyLbl
            // 
            this.bobMoneyLbl.AutoSize = true;
            this.bobMoneyLbl.Location = new System.Drawing.Point(11, 437);
            this.bobMoneyLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bobMoneyLbl.Name = "bobMoneyLbl";
            this.bobMoneyLbl.Size = new System.Drawing.Size(89, 17);
            this.bobMoneyLbl.TabIndex = 15;
            this.bobMoneyLbl.Text = "Bob\'s money";
            // 
            // fredMoneyLbl
            // 
            this.fredMoneyLbl.AutoSize = true;
            this.fredMoneyLbl.Location = new System.Drawing.Point(12, 471);
            this.fredMoneyLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fredMoneyLbl.Name = "fredMoneyLbl";
            this.fredMoneyLbl.Size = new System.Drawing.Size(93, 17);
            this.fredMoneyLbl.TabIndex = 16;
            this.fredMoneyLbl.Text = "Fred\'s money";
            // 
            // ballbagsMoneyLbl
            // 
            this.ballbagsMoneyLbl.AutoSize = true;
            this.ballbagsMoneyLbl.Location = new System.Drawing.Point(12, 503);
            this.ballbagsMoneyLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ballbagsMoneyLbl.Name = "ballbagsMoneyLbl";
            this.ballbagsMoneyLbl.Size = new System.Drawing.Size(111, 17);
            this.ballbagsMoneyLbl.TabIndex = 17;
            this.ballbagsMoneyLbl.Text = "Ballbags\' money";
            // 
            // bobCreditLbl
            // 
            this.bobCreditLbl.AutoSize = true;
            this.bobCreditLbl.Location = new System.Drawing.Point(215, 437);
            this.bobCreditLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bobCreditLbl.Name = "bobCreditLbl";
            this.bobCreditLbl.Size = new System.Drawing.Size(24, 17);
            this.bobCreditLbl.TabIndex = 18;
            this.bobCreditLbl.Text = "50";
            // 
            // fredCreditLbl
            // 
            this.fredCreditLbl.AutoSize = true;
            this.fredCreditLbl.Location = new System.Drawing.Point(215, 471);
            this.fredCreditLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fredCreditLbl.Name = "fredCreditLbl";
            this.fredCreditLbl.Size = new System.Drawing.Size(24, 17);
            this.fredCreditLbl.TabIndex = 19;
            this.fredCreditLbl.Text = "50";
            // 
            // ballbagsCreditLbl
            // 
            this.ballbagsCreditLbl.AutoSize = true;
            this.ballbagsCreditLbl.Location = new System.Drawing.Point(215, 503);
            this.ballbagsCreditLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ballbagsCreditLbl.Name = "ballbagsCreditLbl";
            this.ballbagsCreditLbl.Size = new System.Drawing.Size(24, 17);
            this.ballbagsCreditLbl.TabIndex = 20;
            this.ballbagsCreditLbl.Text = "50";
            // 
            // betupdown
            // 
            this.betupdown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betupdown.Location = new System.Drawing.Point(8, 124);
            this.betupdown.Margin = new System.Windows.Forms.Padding(4);
            this.betupdown.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.betupdown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.betupdown.Name = "betupdown";
            this.betupdown.Size = new System.Drawing.Size(160, 22);
            this.betupdown.TabIndex = 21;
            this.betupdown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBoxRacer
            // 
            this.groupBoxRacer.Controls.Add(this.moderateBtn);
            this.groupBoxRacer.Controls.Add(this.trumpBtn);
            this.groupBoxRacer.Controls.Add(this.putinBtn);
            this.groupBoxRacer.Controls.Add(this.extremistBtn);
            this.groupBoxRacer.Location = new System.Drawing.Point(20, 213);
            this.groupBoxRacer.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxRacer.Name = "groupBoxRacer";
            this.groupBoxRacer.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxRacer.Size = new System.Drawing.Size(232, 170);
            this.groupBoxRacer.TabIndex = 22;
            this.groupBoxRacer.TabStop = false;
            this.groupBoxRacer.Text = "Racer";
            // 
            // bettorBox
            // 
            this.bettorBox.Controls.Add(this.selectBallbagsBtn);
            this.bettorBox.Controls.Add(this.selectFredBtn);
            this.bettorBox.Controls.Add(this.selectBobBtn);
            this.bettorBox.Controls.Add(this.betLbl);
            this.bettorBox.Controls.Add(this.betupdown);
            this.bettorBox.Location = new System.Drawing.Point(20, 15);
            this.bettorBox.Margin = new System.Windows.Forms.Padding(4);
            this.bettorBox.Name = "bettorBox";
            this.bettorBox.Padding = new System.Windows.Forms.Padding(4);
            this.bettorBox.Size = new System.Drawing.Size(268, 191);
            this.bettorBox.TabIndex = 23;
            this.bettorBox.TabStop = false;
            this.bettorBox.Text = "Ones who bet";
            // 
            // selectBallbagsBtn
            // 
            this.selectBallbagsBtn.AutoSize = true;
            this.selectBallbagsBtn.Location = new System.Drawing.Point(152, 46);
            this.selectBallbagsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.selectBallbagsBtn.Name = "selectBallbagsBtn";
            this.selectBallbagsBtn.Size = new System.Drawing.Size(83, 21);
            this.selectBallbagsBtn.TabIndex = 2;
            this.selectBallbagsBtn.TabStop = true;
            this.selectBallbagsBtn.Text = "Ballbags";
            this.selectBallbagsBtn.UseVisualStyleBackColor = true;
            this.selectBallbagsBtn.CheckedChanged += new System.EventHandler(this.selectBallbagsBtn_CheckedChanged);
            // 
            // selectFredBtn
            // 
            this.selectFredBtn.AutoSize = true;
            this.selectFredBtn.Location = new System.Drawing.Point(83, 46);
            this.selectFredBtn.Margin = new System.Windows.Forms.Padding(4);
            this.selectFredBtn.Name = "selectFredBtn";
            this.selectFredBtn.Size = new System.Drawing.Size(58, 21);
            this.selectFredBtn.TabIndex = 1;
            this.selectFredBtn.TabStop = true;
            this.selectFredBtn.Text = "Fred";
            this.selectFredBtn.UseVisualStyleBackColor = true;
            this.selectFredBtn.CheckedChanged += new System.EventHandler(this.selectFredBtn_CheckedChanged);
            // 
            // selectBobBtn
            // 
            this.selectBobBtn.AutoSize = true;
            this.selectBobBtn.Location = new System.Drawing.Point(9, 46);
            this.selectBobBtn.Margin = new System.Windows.Forms.Padding(4);
            this.selectBobBtn.Name = "selectBobBtn";
            this.selectBobBtn.Size = new System.Drawing.Size(54, 21);
            this.selectBobBtn.TabIndex = 0;
            this.selectBobBtn.TabStop = true;
            this.selectBobBtn.Text = "Bob";
            this.selectBobBtn.UseVisualStyleBackColor = true;
            this.selectBobBtn.CheckedChanged += new System.EventHandler(this.selectBobBtn_CheckedChanged);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(16, 390);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(4);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(176, 28);
            this.confirmBtn.TabIndex = 24;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // bobStatusLbl
            // 
            this.bobStatusLbl.AutoSize = true;
            this.bobStatusLbl.Location = new System.Drawing.Point(52, 570);
            this.bobStatusLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bobStatusLbl.Name = "bobStatusLbl";
            this.bobStatusLbl.Size = new System.Drawing.Size(125, 17);
            this.bobStatusLbl.TabIndex = 27;
            this.bobStatusLbl.Text = "Bob is in the game";
            // 
            // fredStatusLbl
            // 
            this.fredStatusLbl.AutoSize = true;
            this.fredStatusLbl.Location = new System.Drawing.Point(53, 603);
            this.fredStatusLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fredStatusLbl.Name = "fredStatusLbl";
            this.fredStatusLbl.Size = new System.Drawing.Size(129, 17);
            this.fredStatusLbl.TabIndex = 28;
            this.fredStatusLbl.Text = "Fred is in the game";
            // 
            // ballbagsStatusLbl
            // 
            this.ballbagsStatusLbl.AutoSize = true;
            this.ballbagsStatusLbl.Location = new System.Drawing.Point(52, 638);
            this.ballbagsStatusLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ballbagsStatusLbl.Name = "ballbagsStatusLbl";
            this.ballbagsStatusLbl.Size = new System.Drawing.Size(154, 17);
            this.ballbagsStatusLbl.TabIndex = 29;
            this.ballbagsStatusLbl.Text = "Ballbags is in the game";
            // 
            // RacerWonLbl
            // 
            this.RacerWonLbl.AutoSize = true;
            this.RacerWonLbl.Location = new System.Drawing.Point(56, 687);
            this.RacerWonLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RacerWonLbl.Name = "RacerWonLbl";
            this.RacerWonLbl.Size = new System.Drawing.Size(145, 17);
            this.RacerWonLbl.TabIndex = 30;
            this.RacerWonLbl.Text = "No Racer has won yet";
            // 
            // globalReset
            // 
            this.globalReset.Enabled = false;
            this.globalReset.Location = new System.Drawing.Point(60, 724);
            this.globalReset.Margin = new System.Windows.Forms.Padding(4);
            this.globalReset.Name = "globalReset";
            this.globalReset.Size = new System.Drawing.Size(100, 28);
            this.globalReset.TabIndex = 31;
            this.globalReset.Text = "Reset game";
            this.globalReset.UseVisualStyleBackColor = true;
            this.globalReset.Click += new System.EventHandler(this.globalReset_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 778);
            this.Controls.Add(this.globalReset);
            this.Controls.Add(this.RacerWonLbl);
            this.Controls.Add(this.ballbagsStatusLbl);
            this.Controls.Add(this.fredStatusLbl);
            this.Controls.Add(this.bobStatusLbl);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.bettorBox);
            this.Controls.Add(this.groupBoxRacer);
            this.Controls.Add(this.ballbagsCreditLbl);
            this.Controls.Add(this.fredCreditLbl);
            this.Controls.Add(this.bobCreditLbl);
            this.Controls.Add(this.ballbagsMoneyLbl);
            this.Controls.Add(this.fredMoneyLbl);
            this.Controls.Add(this.bobMoneyLbl);
            this.Controls.Add(this.radicalImg);
            this.Controls.Add(this.moderateImg);
            this.Controls.Add(this.putinImg);
            this.Controls.Add(this.trumpImg);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.putinImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trumpImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moderateImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radicalImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betupdown)).EndInit();
            this.groupBoxRacer.ResumeLayout(false);
            this.groupBoxRacer.PerformLayout();
            this.bettorBox.ResumeLayout(false);
            this.bettorBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox trumpImg;
        private System.Windows.Forms.PictureBox putinImg;
        private System.Windows.Forms.PictureBox moderateImg;
        private System.Windows.Forms.PictureBox radicalImg;
        private System.Windows.Forms.RadioButton trumpBtn;
        private System.Windows.Forms.RadioButton putinBtn;
        private System.Windows.Forms.RadioButton moderateBtn;
        private System.Windows.Forms.Label betLbl;
        private System.Windows.Forms.RadioButton extremistBtn;
        private System.Windows.Forms.Label bobMoneyLbl;
        private System.Windows.Forms.Label fredMoneyLbl;
        private System.Windows.Forms.Label ballbagsMoneyLbl;
        private System.Windows.Forms.Label bobCreditLbl;
        private System.Windows.Forms.Label fredCreditLbl;
        private System.Windows.Forms.Label ballbagsCreditLbl;
        private System.Windows.Forms.NumericUpDown betupdown;
        private System.Windows.Forms.GroupBox groupBoxRacer;
        private System.Windows.Forms.GroupBox bettorBox;
        private System.Windows.Forms.RadioButton selectBallbagsBtn;
        private System.Windows.Forms.RadioButton selectFredBtn;
        private System.Windows.Forms.RadioButton selectBobBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label bobStatusLbl;
        private System.Windows.Forms.Label fredStatusLbl;
        private System.Windows.Forms.Label ballbagsStatusLbl;
        private System.Windows.Forms.Label RacerWonLbl;
        private System.Windows.Forms.Button globalReset;
    }
}
