namespace FoolGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelDataUpdate = new System.Windows.Forms.Label();
            this.labelHealSP = new System.Windows.Forms.Label();
            this.labelDmgSP = new System.Windows.Forms.Label();
            this.labelDefSP = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bScissors = new System.Windows.Forms.Button();
            this.bHeal = new System.Windows.Forms.Button();
            this.bRock = new System.Windows.Forms.Button();
            this.bDone = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelIsConnected = new System.Windows.Forms.Label();
            this.bCheckEnemyConnection = new System.Windows.Forms.Button();
            this.checkBoxReady = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelHpSP = new System.Windows.Forms.Label();
            this.progressBarSecondPlayer = new System.Windows.Forms.ProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bUseBleed = new System.Windows.Forms.Button();
            this.bUseVamp = new System.Windows.Forms.Button();
            this.bUseContr = new System.Windows.Forms.Button();
            this.labelHealFP = new System.Windows.Forms.Label();
            this.labelDmgFP = new System.Windows.Forms.Label();
            this.labelDefFP = new System.Windows.Forms.Label();
            this.labelHpFP = new System.Windows.Forms.Label();
            this.progressBarFirstPlayer = new System.Windows.Forms.ProgressBar();
            this.pictureBoxFP = new System.Windows.Forms.PictureBox();
            this.pictureBoxSP = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.bHelp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSP)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.bDone);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 303);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 87);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.labelDataUpdate);
            this.panel6.Controls.Add(this.labelHealSP);
            this.panel6.Controls.Add(this.labelDmgSP);
            this.panel6.Controls.Add(this.labelDefSP);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(357, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(227, 85);
            this.panel6.TabIndex = 2;
            // 
            // labelDataUpdate
            // 
            this.labelDataUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDataUpdate.AutoSize = true;
            this.labelDataUpdate.Location = new System.Drawing.Point(-168, 9);
            this.labelDataUpdate.Name = "labelDataUpdate";
            this.labelDataUpdate.Size = new System.Drawing.Size(67, 39);
            this.labelDataUpdate.TabIndex = 3;
            this.labelDataUpdate.Text = "СВЕЖЕСТЬ\r\nДАННЫХ\r\n:\r\n";
            // 
            // labelHealSP
            // 
            this.labelHealSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelHealSP.AutoSize = true;
            this.labelHealSP.Location = new System.Drawing.Point(3, 61);
            this.labelHealSP.Name = "labelHealSP";
            this.labelHealSP.Size = new System.Drawing.Size(171, 13);
            this.labelHealSP.TabIndex = 2;
            this.labelHealSP.Text = "Его восстановленной здоровье:";
            // 
            // labelDmgSP
            // 
            this.labelDmgSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDmgSP.AutoSize = true;
            this.labelDmgSP.Location = new System.Drawing.Point(3, 35);
            this.labelDmgSP.Name = "labelDmgSP";
            this.labelDmgSP.Size = new System.Drawing.Size(125, 13);
            this.labelDmgSP.TabIndex = 1;
            this.labelDmgSP.Text = "Вам нанесенный урон: ";
            // 
            // labelDefSP
            // 
            this.labelDefSP.AutoSize = true;
            this.labelDefSP.Location = new System.Drawing.Point(3, 9);
            this.labelDefSP.Name = "labelDefSP";
            this.labelDefSP.Size = new System.Drawing.Size(119, 13);
            this.labelDefSP.TabIndex = 0;
            this.labelDefSP.Text = "Ваш срезанный урон: ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bScissors);
            this.panel4.Controls.Add(this.bHeal);
            this.panel4.Controls.Add(this.bRock);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(357, 85);
            this.panel4.TabIndex = 1;
            // 
            // bScissors
            // 
            this.bScissors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bScissors.Enabled = false;
            this.bScissors.Location = new System.Drawing.Point(117, 0);
            this.bScissors.Name = "bScissors";
            this.bScissors.Size = new System.Drawing.Size(122, 85);
            this.bScissors.TabIndex = 1;
            this.bScissors.Text = "Ножницы";
            this.bScissors.UseVisualStyleBackColor = true;
            this.bScissors.Click += new System.EventHandler(this.bScissors_Click);
            // 
            // bHeal
            // 
            this.bHeal.Dock = System.Windows.Forms.DockStyle.Right;
            this.bHeal.Enabled = false;
            this.bHeal.Location = new System.Drawing.Point(239, 0);
            this.bHeal.Name = "bHeal";
            this.bHeal.Size = new System.Drawing.Size(118, 85);
            this.bHeal.TabIndex = 2;
            this.bHeal.Text = "Бумага";
            this.bHeal.UseVisualStyleBackColor = true;
            this.bHeal.Click += new System.EventHandler(this.bHeal_Click);
            // 
            // bRock
            // 
            this.bRock.Dock = System.Windows.Forms.DockStyle.Left;
            this.bRock.Enabled = false;
            this.bRock.Location = new System.Drawing.Point(0, 0);
            this.bRock.Name = "bRock";
            this.bRock.Size = new System.Drawing.Size(117, 85);
            this.bRock.TabIndex = 0;
            this.bRock.Text = "Камень";
            this.bRock.UseVisualStyleBackColor = true;
            this.bRock.Click += new System.EventHandler(this.bRock_Click);
            // 
            // bDone
            // 
            this.bDone.Dock = System.Windows.Forms.DockStyle.Right;
            this.bDone.Location = new System.Drawing.Point(584, 0);
            this.bDone.Name = "bDone";
            this.bDone.Size = new System.Drawing.Size(100, 85);
            this.bDone.TabIndex = 0;
            this.bDone.Text = "Сделать ход";
            this.bDone.UseVisualStyleBackColor = true;
            this.bDone.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelIsConnected);
            this.panel2.Controls.Add(this.bCheckEnemyConnection);
            this.panel2.Controls.Add(this.checkBoxReady);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.labelHpSP);
            this.panel2.Controls.Add(this.progressBarSecondPlayer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(506, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 277);
            this.panel2.TabIndex = 1;
            // 
            // labelIsConnected
            // 
            this.labelIsConnected.AutoSize = true;
            this.labelIsConnected.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelIsConnected.Location = new System.Drawing.Point(55, 235);
            this.labelIsConnected.Name = "labelIsConnected";
            this.labelIsConnected.Size = new System.Drawing.Size(50, 13);
            this.labelIsConnected.TabIndex = 5;
            this.labelIsConnected.Text = "Связь: ?";
            // 
            // bCheckEnemyConnection
            // 
            this.bCheckEnemyConnection.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bCheckEnemyConnection.Location = new System.Drawing.Point(55, 252);
            this.bCheckEnemyConnection.Name = "bCheckEnemyConnection";
            this.bCheckEnemyConnection.Size = new System.Drawing.Size(123, 23);
            this.bCheckEnemyConnection.TabIndex = 4;
            this.bCheckEnemyConnection.Text = "Проверка связи";
            this.bCheckEnemyConnection.UseVisualStyleBackColor = true;
            this.bCheckEnemyConnection.Click += new System.EventHandler(this.bCheckEnemyConnection_Click);
            // 
            // checkBoxReady
            // 
            this.checkBoxReady.AutoSize = true;
            this.checkBoxReady.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBoxReady.Location = new System.Drawing.Point(0, 235);
            this.checkBoxReady.Name = "checkBoxReady";
            this.checkBoxReady.Size = new System.Drawing.Size(55, 40);
            this.checkBoxReady.TabIndex = 6;
            this.checkBoxReady.Text = "Готов";
            this.checkBoxReady.UseVisualStyleBackColor = true;
            this.checkBoxReady.Click += new System.EventHandler(this.checkBoxReady_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 33);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(178, 202);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // labelHpSP
            // 
            this.labelHpSP.AutoSize = true;
            this.labelHpSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHpSP.Location = new System.Drawing.Point(0, 20);
            this.labelHpSP.Name = "labelHpSP";
            this.labelHpSP.Size = new System.Drawing.Size(30, 13);
            this.labelHpSP.TabIndex = 2;
            this.labelHpSP.Text = "0/50";
            // 
            // progressBarSecondPlayer
            // 
            this.progressBarSecondPlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBarSecondPlayer.Location = new System.Drawing.Point(0, 0);
            this.progressBarSecondPlayer.Name = "progressBarSecondPlayer";
            this.progressBarSecondPlayer.Size = new System.Drawing.Size(178, 20);
            this.progressBarSecondPlayer.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.labelHealFP);
            this.panel3.Controls.Add(this.labelDmgFP);
            this.panel3.Controls.Add(this.labelDefFP);
            this.panel3.Controls.Add(this.labelHpFP);
            this.panel3.Controls.Add(this.progressBarFirstPlayer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 277);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.bUseBleed);
            this.panel5.Controls.Add(this.bUseVamp);
            this.panel5.Controls.Add(this.bUseContr);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 252);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(178, 23);
            this.panel5.TabIndex = 5;
            // 
            // bUseBleed
            // 
            this.bUseBleed.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bUseBleed.Enabled = false;
            this.bUseBleed.Location = new System.Drawing.Point(0, -46);
            this.bUseBleed.Name = "bUseBleed";
            this.bUseBleed.Size = new System.Drawing.Size(178, 23);
            this.bUseBleed.TabIndex = 7;
            this.bUseBleed.Text = "Кровотечение";
            this.bUseBleed.UseVisualStyleBackColor = true;
            this.bUseBleed.Visible = false;
            this.bUseBleed.Click += new System.EventHandler(this.bUseUlt_Bleed);
            // 
            // bUseVamp
            // 
            this.bUseVamp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bUseVamp.Enabled = false;
            this.bUseVamp.Location = new System.Drawing.Point(0, -23);
            this.bUseVamp.Name = "bUseVamp";
            this.bUseVamp.Size = new System.Drawing.Size(178, 23);
            this.bUseVamp.TabIndex = 6;
            this.bUseVamp.Text = "Вампиризм";
            this.bUseVamp.UseVisualStyleBackColor = true;
            this.bUseVamp.Visible = false;
            this.bUseVamp.Click += new System.EventHandler(this.bUseUlt_Vamp);
            // 
            // bUseContr
            // 
            this.bUseContr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bUseContr.Enabled = false;
            this.bUseContr.Location = new System.Drawing.Point(0, 0);
            this.bUseContr.Name = "bUseContr";
            this.bUseContr.Size = new System.Drawing.Size(178, 23);
            this.bUseContr.TabIndex = 0;
            this.bUseContr.Text = "Контр-атака";
            this.bUseContr.UseVisualStyleBackColor = true;
            this.bUseContr.Visible = false;
            this.bUseContr.Click += new System.EventHandler(this.bUseUlt_Contr);
            // 
            // labelHealFP
            // 
            this.labelHealFP.AutoSize = true;
            this.labelHealFP.Location = new System.Drawing.Point(3, 130);
            this.labelHealFP.Name = "labelHealFP";
            this.labelHealFP.Size = new System.Drawing.Size(174, 13);
            this.labelHealFP.TabIndex = 4;
            this.labelHealFP.Text = "Ваше восстановление здоровья:";
            // 
            // labelDmgFP
            // 
            this.labelDmgFP.AutoSize = true;
            this.labelDmgFP.Location = new System.Drawing.Point(3, 87);
            this.labelDmgFP.Name = "labelDmgFP";
            this.labelDmgFP.Size = new System.Drawing.Size(57, 13);
            this.labelDmgFP.TabIndex = 3;
            this.labelDmgFP.Text = "Ваш урон:";
            // 
            // labelDefFP
            // 
            this.labelDefFP.AutoSize = true;
            this.labelDefFP.Location = new System.Drawing.Point(3, 43);
            this.labelDefFP.Name = "labelDefFP";
            this.labelDefFP.Size = new System.Drawing.Size(78, 13);
            this.labelDefFP.TabIndex = 2;
            this.labelDefFP.Text = "Ваша защита:";
            // 
            // labelHpFP
            // 
            this.labelHpFP.AutoSize = true;
            this.labelHpFP.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHpFP.Location = new System.Drawing.Point(0, 20);
            this.labelHpFP.Name = "labelHpFP";
            this.labelHpFP.Size = new System.Drawing.Size(30, 13);
            this.labelHpFP.TabIndex = 1;
            this.labelHpFP.Text = "0/50";
            // 
            // progressBarFirstPlayer
            // 
            this.progressBarFirstPlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBarFirstPlayer.Location = new System.Drawing.Point(0, 0);
            this.progressBarFirstPlayer.Name = "progressBarFirstPlayer";
            this.progressBarFirstPlayer.Size = new System.Drawing.Size(178, 20);
            this.progressBarFirstPlayer.TabIndex = 0;
            // 
            // pictureBoxFP
            // 
            this.pictureBoxFP.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxFP.Location = new System.Drawing.Point(180, 26);
            this.pictureBoxFP.Name = "pictureBoxFP";
            this.pictureBoxFP.Size = new System.Drawing.Size(163, 277);
            this.pictureBoxFP.TabIndex = 6;
            this.pictureBoxFP.TabStop = false;
            // 
            // pictureBoxSP
            // 
            this.pictureBoxSP.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxSP.Location = new System.Drawing.Point(348, 26);
            this.pictureBoxSP.Name = "pictureBoxSP";
            this.pictureBoxSP.Size = new System.Drawing.Size(158, 277);
            this.pictureBoxSP.TabIndex = 7;
            this.pictureBoxSP.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.bHelp);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(686, 26);
            this.panel7.TabIndex = 6;
            // 
            // bHelp
            // 
            this.bHelp.Dock = System.Windows.Forms.DockStyle.Right;
            this.bHelp.Location = new System.Drawing.Point(611, 0);
            this.bHelp.Name = "bHelp";
            this.bHelp.Size = new System.Drawing.Size(75, 26);
            this.bHelp.TabIndex = 1;
            this.bHelp.Text = "?";
            this.bHelp.UseVisualStyleBackColor = true;
            this.bHelp.Click += new System.EventHandler(this.bHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.pictureBoxSP);
            this.Controls.Add(this.pictureBoxFP);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSP)).EndInit();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelHpSP;
        private System.Windows.Forms.ProgressBar progressBarSecondPlayer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelHpFP;
        private System.Windows.Forms.ProgressBar progressBarFirstPlayer;
        private System.Windows.Forms.Button bDone;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bScissors;
        private System.Windows.Forms.Button bHeal;
        private System.Windows.Forms.Button bRock;
        private System.Windows.Forms.PictureBox pictureBoxFP;
        private System.Windows.Forms.PictureBox pictureBoxSP;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label labelHealSP;
        private System.Windows.Forms.Label labelDmgSP;
        private System.Windows.Forms.Label labelDefSP;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelHealFP;
        private System.Windows.Forms.Label labelDmgFP;
        private System.Windows.Forms.Label labelDefFP;
        private System.Windows.Forms.Label labelDataUpdate;
        private System.Windows.Forms.Button bCheckEnemyConnection;
        private System.Windows.Forms.Label labelIsConnected;
        private System.Windows.Forms.CheckBox checkBoxReady;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button bUseContr;
        private System.Windows.Forms.Button bUseBleed;
        private System.Windows.Forms.Button bUseVamp;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button bHelp;
    }
}
