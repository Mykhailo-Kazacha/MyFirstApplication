namespace MyFirstApplication
{
    partial class FMonster
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
            this.gBMonster = new System.Windows.Forms.GroupBox();
            this.cBOgreSword = new System.Windows.Forms.CheckBox();
            this.rBImp = new System.Windows.Forms.RadioButton();
            this.rBWitch = new System.Windows.Forms.RadioButton();
            this.rBOgre = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bStartFight = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.gBMonster.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBMonster
            // 
            this.gBMonster.Controls.Add(this.cBOgreSword);
            this.gBMonster.Controls.Add(this.rBImp);
            this.gBMonster.Controls.Add(this.rBWitch);
            this.gBMonster.Controls.Add(this.rBOgre);
            this.gBMonster.Location = new System.Drawing.Point(12, 76);
            this.gBMonster.Name = "gBMonster";
            this.gBMonster.Size = new System.Drawing.Size(242, 158);
            this.gBMonster.TabIndex = 0;
            this.gBMonster.TabStop = false;
            this.gBMonster.Text = "Monster types";
            // 
            // cBOgreSword
            // 
            this.cBOgreSword.AutoSize = true;
            this.cBOgreSword.Location = new System.Drawing.Point(23, 60);
            this.cBOgreSword.Name = "cBOgreSword";
            this.cBOgreSword.Size = new System.Drawing.Size(113, 17);
            this.cBOgreSword.TabIndex = 3;
            this.cBOgreSword.Text = "Ogre with a Sword";
            this.cBOgreSword.UseVisualStyleBackColor = true;
            // 
            // rBImp
            // 
            this.rBImp.AutoSize = true;
            this.rBImp.Enabled = false;
            this.rBImp.Location = new System.Drawing.Point(6, 117);
            this.rBImp.Name = "rBImp";
            this.rBImp.Size = new System.Drawing.Size(42, 17);
            this.rBImp.TabIndex = 2;
            this.rBImp.Text = "Imp";
            this.rBImp.UseVisualStyleBackColor = true;
            // 
            // rBWitch
            // 
            this.rBWitch.AutoSize = true;
            this.rBWitch.Enabled = false;
            this.rBWitch.Location = new System.Drawing.Point(6, 83);
            this.rBWitch.Name = "rBWitch";
            this.rBWitch.Size = new System.Drawing.Size(53, 17);
            this.rBWitch.TabIndex = 1;
            this.rBWitch.Text = "Witch";
            this.rBWitch.UseVisualStyleBackColor = true;
            // 
            // rBOgre
            // 
            this.rBOgre.AutoSize = true;
            this.rBOgre.Checked = true;
            this.rBOgre.Location = new System.Drawing.Point(6, 30);
            this.rBOgre.Name = "rBOgre";
            this.rBOgre.Size = new System.Drawing.Size(48, 17);
            this.rBOgre.TabIndex = 0;
            this.rBOgre.TabStop = true;
            this.rBOgre.Text = "Ogre";
            this.rBOgre.UseVisualStyleBackColor = true;
            this.rBOgre.CheckedChanged += new System.EventHandler(this.rBOgre_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose monster\'s type";
            // 
            // bStartFight
            // 
            this.bStartFight.Location = new System.Drawing.Point(35, 313);
            this.bStartFight.Name = "bStartFight";
            this.bStartFight.Size = new System.Drawing.Size(75, 23);
            this.bStartFight.TabIndex = 2;
            this.bStartFight.Text = "Start fight";
            this.bStartFight.UseVisualStyleBackColor = true;
            this.bStartFight.Click += new System.EventHandler(this.bStartFight_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(191, 255);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(281, 134);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(297, 87);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(175, 134);
            this.listBox2.TabIndex = 4;
            // 
            // FMonster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bStartFight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gBMonster);
            this.Name = "FMonster";
            this.Text = "MOsterForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FMonster_FormClosed);
            this.gBMonster.ResumeLayout(false);
            this.gBMonster.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBMonster;
        private System.Windows.Forms.CheckBox cBOgreSword;
        private System.Windows.Forms.RadioButton rBImp;
        private System.Windows.Forms.RadioButton rBWitch;
        private System.Windows.Forms.RadioButton rBOgre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bStartFight;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}