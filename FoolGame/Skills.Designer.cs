namespace FoolGame
{
    partial class Skills
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDef = new System.Windows.Forms.Label();
            this.bAddDef = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDmg = new System.Windows.Forms.Label();
            this.bAddDmg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelHeal = new System.Windows.Forms.Label();
            this.bAddHeal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.bBleed = new System.Windows.Forms.Button();
            this.labelBleedHeal = new System.Windows.Forms.Label();
            this.labelBleedDmg = new System.Windows.Forms.Label();
            this.labelBleedHowMuch = new System.Windows.Forms.Label();
            this.labelBleed = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.bVamp = new System.Windows.Forms.Button();
            this.labelVampDmg = new System.Windows.Forms.Label();
            this.labelVampHeal = new System.Windows.Forms.Label();
            this.labelVampHowMuch = new System.Windows.Forms.Label();
            this.labelVamp = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bCntrDmg = new System.Windows.Forms.Button();
            this.labelCntrDmgDmg = new System.Windows.Forms.Label();
            this.labelCntrDmgDef = new System.Windows.Forms.Label();
            this.labelCntrDmgHowMuch = new System.Windows.Forms.Label();
            this.labelContrDmg = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelDef);
            this.panel1.Controls.Add(this.bAddDef);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 118);
            this.panel1.TabIndex = 0;
            // 
            // labelDef
            // 
            this.labelDef.AutoSize = true;
            this.labelDef.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelDef.Location = new System.Drawing.Point(421, 30);
            this.labelDef.Name = "labelDef";
            this.labelDef.Size = new System.Drawing.Size(92, 13);
            this.labelDef.TabIndex = 2;
            this.labelDef.Text = "Сейчас защиты: ";
            // 
            // bAddDef
            // 
            this.bAddDef.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bAddDef.Location = new System.Drawing.Point(0, 96);
            this.bAddDef.Name = "bAddDef";
            this.bAddDef.Size = new System.Drawing.Size(513, 20);
            this.bAddDef.TabIndex = 1;
            this.bAddDef.Text = "Добавить защиту";
            this.bAddDef.UseVisualStyleBackColor = true;
            this.bAddDef.Click += new System.EventHandler(this.bAddDef_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить 2 очка защиты?";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelDmg);
            this.panel2.Controls.Add(this.bAddDmg);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(515, 157);
            this.panel2.TabIndex = 1;
            // 
            // labelDmg
            // 
            this.labelDmg.AutoSize = true;
            this.labelDmg.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelDmg.Location = new System.Drawing.Point(432, 30);
            this.labelDmg.Name = "labelDmg";
            this.labelDmg.Size = new System.Drawing.Size(81, 13);
            this.labelDmg.TabIndex = 3;
            this.labelDmg.Text = "Сейчас урона: ";
            // 
            // bAddDmg
            // 
            this.bAddDmg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bAddDmg.Location = new System.Drawing.Point(0, 135);
            this.bAddDmg.Name = "bAddDmg";
            this.bAddDmg.Size = new System.Drawing.Size(513, 20);
            this.bAddDmg.TabIndex = 2;
            this.bAddDmg.Text = "Добавить урон";
            this.bAddDmg.UseVisualStyleBackColor = true;
            this.bAddDmg.Click += new System.EventHandler(this.bAddDmg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Добавить 2 очка урона?";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.labelHeal);
            this.panel3.Controls.Add(this.bAddHeal);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 275);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(515, 115);
            this.panel3.TabIndex = 1;
            // 
            // labelHeal
            // 
            this.labelHeal.AutoSize = true;
            this.labelHeal.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelHeal.Location = new System.Drawing.Point(420, 30);
            this.labelHeal.Name = "labelHeal";
            this.labelHeal.Size = new System.Drawing.Size(93, 13);
            this.labelHeal.TabIndex = 4;
            this.labelHeal.Text = "Сейчас лечения: ";
            // 
            // bAddHeal
            // 
            this.bAddHeal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bAddHeal.Location = new System.Drawing.Point(0, 93);
            this.bAddHeal.Name = "bAddHeal";
            this.bAddHeal.Size = new System.Drawing.Size(513, 20);
            this.bAddHeal.TabIndex = 3;
            this.bAddHeal.Text = "Добавить восстановление здоровья";
            this.bAddHeal.UseVisualStyleBackColor = true;
            this.bAddHeal.Click += new System.EventHandler(this.bAddHeal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(461, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Добавить 2 очка к восстановлению здоровья?";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(515, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(171, 390);
            this.panel4.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.bBleed);
            this.panel6.Controls.Add(this.labelBleedHeal);
            this.panel6.Controls.Add(this.labelBleedDmg);
            this.panel6.Controls.Add(this.labelBleedHowMuch);
            this.panel6.Controls.Add(this.labelBleed);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 118);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(171, 157);
            this.panel6.TabIndex = 1;
            // 
            // bBleed
            // 
            this.bBleed.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bBleed.Enabled = false;
            this.bBleed.Location = new System.Drawing.Point(0, 133);
            this.bBleed.Name = "bBleed";
            this.bBleed.Size = new System.Drawing.Size(167, 20);
            this.bBleed.TabIndex = 5;
            this.bBleed.Text = "Выбрать";
            this.bBleed.UseVisualStyleBackColor = true;
            this.bBleed.Click += new System.EventHandler(this.bBleed_Click);
            // 
            // labelBleedHeal
            // 
            this.labelBleedHeal.AutoSize = true;
            this.labelBleedHeal.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelBleedHeal.Location = new System.Drawing.Point(0, 52);
            this.labelBleedHeal.Name = "labelBleedHeal";
            this.labelBleedHeal.Size = new System.Drawing.Size(53, 13);
            this.labelBleedHeal.TabIndex = 4;
            this.labelBleedHeal.Text = "Лечение:";
            // 
            // labelBleedDmg
            // 
            this.labelBleedDmg.AutoSize = true;
            this.labelBleedDmg.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelBleedDmg.Location = new System.Drawing.Point(0, 39);
            this.labelBleedDmg.Name = "labelBleedDmg";
            this.labelBleedDmg.Size = new System.Drawing.Size(36, 13);
            this.labelBleedDmg.TabIndex = 3;
            this.labelBleedDmg.Text = "Урон:";
            // 
            // labelBleedHowMuch
            // 
            this.labelBleedHowMuch.AutoSize = true;
            this.labelBleedHowMuch.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelBleedHowMuch.Location = new System.Drawing.Point(0, 13);
            this.labelBleedHowMuch.Name = "labelBleedHowMuch";
            this.labelBleedHowMuch.Size = new System.Drawing.Size(149, 26);
            this.labelBleedHowMuch.TabIndex = 2;
            this.labelBleedHowMuch.Text = "До открытия кровотечения \r\nосталось усилить:";
            // 
            // labelBleed
            // 
            this.labelBleed.AutoSize = true;
            this.labelBleed.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelBleed.Location = new System.Drawing.Point(0, 0);
            this.labelBleed.Name = "labelBleed";
            this.labelBleed.Size = new System.Drawing.Size(78, 13);
            this.labelBleed.TabIndex = 1;
            this.labelBleed.Text = "Кровотечение";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.bVamp);
            this.panel7.Controls.Add(this.labelVampDmg);
            this.panel7.Controls.Add(this.labelVampHeal);
            this.panel7.Controls.Add(this.labelVampHowMuch);
            this.panel7.Controls.Add(this.labelVamp);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 275);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(171, 115);
            this.panel7.TabIndex = 1;
            // 
            // bVamp
            // 
            this.bVamp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bVamp.Enabled = false;
            this.bVamp.Location = new System.Drawing.Point(0, 91);
            this.bVamp.Name = "bVamp";
            this.bVamp.Size = new System.Drawing.Size(167, 20);
            this.bVamp.TabIndex = 5;
            this.bVamp.Text = "Выбрать";
            this.bVamp.UseVisualStyleBackColor = true;
            this.bVamp.Click += new System.EventHandler(this.bVamp_Click);
            // 
            // labelVampDmg
            // 
            this.labelVampDmg.AutoSize = true;
            this.labelVampDmg.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelVampDmg.Location = new System.Drawing.Point(0, 52);
            this.labelVampDmg.Name = "labelVampDmg";
            this.labelVampDmg.Size = new System.Drawing.Size(36, 13);
            this.labelVampDmg.TabIndex = 4;
            this.labelVampDmg.Text = "Урон:";
            // 
            // labelVampHeal
            // 
            this.labelVampHeal.AutoSize = true;
            this.labelVampHeal.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelVampHeal.Location = new System.Drawing.Point(0, 39);
            this.labelVampHeal.Name = "labelVampHeal";
            this.labelVampHeal.Size = new System.Drawing.Size(53, 13);
            this.labelVampHeal.TabIndex = 3;
            this.labelVampHeal.Text = "Лечение:";
            // 
            // labelVampHowMuch
            // 
            this.labelVampHowMuch.AutoSize = true;
            this.labelVampHowMuch.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelVampHowMuch.Location = new System.Drawing.Point(0, 13);
            this.labelVampHowMuch.Name = "labelVampHowMuch";
            this.labelVampHowMuch.Size = new System.Drawing.Size(143, 26);
            this.labelVampHowMuch.TabIndex = 2;
            this.labelVampHowMuch.Text = "До открытия вампиризма \r\nосталось усилить:";
            // 
            // labelVamp
            // 
            this.labelVamp.AutoSize = true;
            this.labelVamp.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelVamp.Location = new System.Drawing.Point(0, 0);
            this.labelVamp.Name = "labelVamp";
            this.labelVamp.Size = new System.Drawing.Size(66, 13);
            this.labelVamp.TabIndex = 1;
            this.labelVamp.Text = "Вампиризм";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.bCntrDmg);
            this.panel5.Controls.Add(this.labelCntrDmgDmg);
            this.panel5.Controls.Add(this.labelCntrDmgDef);
            this.panel5.Controls.Add(this.labelCntrDmgHowMuch);
            this.panel5.Controls.Add(this.labelContrDmg);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(171, 118);
            this.panel5.TabIndex = 0;
            // 
            // bCntrDmg
            // 
            this.bCntrDmg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bCntrDmg.Enabled = false;
            this.bCntrDmg.Location = new System.Drawing.Point(0, 94);
            this.bCntrDmg.Name = "bCntrDmg";
            this.bCntrDmg.Size = new System.Drawing.Size(167, 20);
            this.bCntrDmg.TabIndex = 4;
            this.bCntrDmg.Text = "Выбрать";
            this.bCntrDmg.UseVisualStyleBackColor = true;
            this.bCntrDmg.Click += new System.EventHandler(this.bCntrDmg_Click);
            // 
            // labelCntrDmgDmg
            // 
            this.labelCntrDmgDmg.AutoSize = true;
            this.labelCntrDmgDmg.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCntrDmgDmg.Location = new System.Drawing.Point(0, 52);
            this.labelCntrDmgDmg.Name = "labelCntrDmgDmg";
            this.labelCntrDmgDmg.Size = new System.Drawing.Size(36, 13);
            this.labelCntrDmgDmg.TabIndex = 3;
            this.labelCntrDmgDmg.Text = "Урон:";
            // 
            // labelCntrDmgDef
            // 
            this.labelCntrDmgDef.AutoSize = true;
            this.labelCntrDmgDef.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCntrDmgDef.Location = new System.Drawing.Point(0, 39);
            this.labelCntrDmgDef.Name = "labelCntrDmgDef";
            this.labelCntrDmgDef.Size = new System.Drawing.Size(49, 13);
            this.labelCntrDmgDef.TabIndex = 2;
            this.labelCntrDmgDef.Text = "Защита:";
            // 
            // labelCntrDmgHowMuch
            // 
            this.labelCntrDmgHowMuch.AutoSize = true;
            this.labelCntrDmgHowMuch.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCntrDmgHowMuch.Location = new System.Drawing.Point(0, 13);
            this.labelCntrDmgHowMuch.Name = "labelCntrDmgHowMuch";
            this.labelCntrDmgHowMuch.Size = new System.Drawing.Size(140, 26);
            this.labelCntrDmgHowMuch.TabIndex = 1;
            this.labelCntrDmgHowMuch.Text = "До открытия контр-атаки \r\nосталось усилить:\r\n";
            // 
            // labelContrDmg
            // 
            this.labelContrDmg.AutoSize = true;
            this.labelContrDmg.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelContrDmg.Location = new System.Drawing.Point(0, 0);
            this.labelContrDmg.Name = "labelContrDmg";
            this.labelContrDmg.Size = new System.Drawing.Size(69, 13);
            this.labelContrDmg.TabIndex = 0;
            this.labelContrDmg.Text = "Контр-атака";
            // 
            // Skills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Skills";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skills";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Skills_FormClosing);
            this.Load += new System.EventHandler(this.Skills_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bAddDef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bAddDmg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bAddHeal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelDef;
        private System.Windows.Forms.Label labelDmg;
        private System.Windows.Forms.Label labelHeal;
        private System.Windows.Forms.Label labelBleed;
        private System.Windows.Forms.Label labelVamp;
        private System.Windows.Forms.Label labelContrDmg;
        private System.Windows.Forms.Label labelBleedHowMuch;
        private System.Windows.Forms.Label labelVampHowMuch;
        private System.Windows.Forms.Label labelCntrDmgHowMuch;
        private System.Windows.Forms.Button bBleed;
        private System.Windows.Forms.Label labelBleedHeal;
        private System.Windows.Forms.Label labelBleedDmg;
        private System.Windows.Forms.Button bVamp;
        private System.Windows.Forms.Label labelVampDmg;
        private System.Windows.Forms.Label labelVampHeal;
        private System.Windows.Forms.Button bCntrDmg;
        private System.Windows.Forms.Label labelCntrDmgDmg;
        private System.Windows.Forms.Label labelCntrDmgDef;
    }
}