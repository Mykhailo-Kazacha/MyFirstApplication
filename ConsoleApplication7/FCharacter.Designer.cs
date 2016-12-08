namespace MyFirstApplication
{
    partial class FCharacter
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
            this.raceBox = new System.Windows.Forms.GroupBox();
            this.rBOrc = new System.Windows.Forms.RadioButton();
            this.rBElf = new System.Windows.Forms.RadioButton();
            this.rBHuman = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.weaponBox = new System.Windows.Forms.GroupBox();
            this.rBBowAndDagger = new System.Windows.Forms.RadioButton();
            this.rBSword = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBDefault = new System.Windows.Forms.CheckBox();
            this.bAddMemberToParty = new System.Windows.Forms.Button();
            this.bSaveParty = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.raceBox.SuspendLayout();
            this.weaponBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // raceBox
            // 
            this.raceBox.Controls.Add(this.rBOrc);
            this.raceBox.Controls.Add(this.rBElf);
            this.raceBox.Controls.Add(this.rBHuman);
            this.raceBox.Location = new System.Drawing.Point(21, 161);
            this.raceBox.Name = "raceBox";
            this.raceBox.Size = new System.Drawing.Size(185, 154);
            this.raceBox.TabIndex = 0;
            this.raceBox.TabStop = false;
            this.raceBox.Text = "Races";
            // 
            // rBOrc
            // 
            this.rBOrc.AutoSize = true;
            this.rBOrc.Location = new System.Drawing.Point(25, 110);
            this.rBOrc.Name = "rBOrc";
            this.rBOrc.Size = new System.Drawing.Size(42, 17);
            this.rBOrc.TabIndex = 2;
            this.rBOrc.Text = "Orc";
            this.rBOrc.UseVisualStyleBackColor = true;
            // 
            // rBElf
            // 
            this.rBElf.AutoSize = true;
            this.rBElf.Location = new System.Drawing.Point(25, 72);
            this.rBElf.Name = "rBElf";
            this.rBElf.Size = new System.Drawing.Size(37, 17);
            this.rBElf.TabIndex = 1;
            this.rBElf.Text = "Elf";
            this.rBElf.UseVisualStyleBackColor = true;
            // 
            // rBHuman
            // 
            this.rBHuman.AutoSize = true;
            this.rBHuman.Checked = true;
            this.rBHuman.Location = new System.Drawing.Point(24, 36);
            this.rBHuman.Name = "rBHuman";
            this.rBHuman.Size = new System.Drawing.Size(59, 17);
            this.rBHuman.TabIndex = 0;
            this.rBHuman.TabStop = true;
            this.rBHuman.Text = "Human";
            this.rBHuman.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose race and weapon";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Go to monster creation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // weaponBox
            // 
            this.weaponBox.Controls.Add(this.rBBowAndDagger);
            this.weaponBox.Controls.Add(this.rBSword);
            this.weaponBox.Location = new System.Drawing.Point(275, 161);
            this.weaponBox.Name = "weaponBox";
            this.weaponBox.Size = new System.Drawing.Size(185, 154);
            this.weaponBox.TabIndex = 3;
            this.weaponBox.TabStop = false;
            this.weaponBox.Text = "Weapon";
            // 
            // rBBowAndDagger
            // 
            this.rBBowAndDagger.AutoSize = true;
            this.rBBowAndDagger.Location = new System.Drawing.Point(28, 72);
            this.rBBowAndDagger.Name = "rBBowAndDagger";
            this.rBBowAndDagger.Size = new System.Drawing.Size(103, 17);
            this.rBBowAndDagger.TabIndex = 1;
            this.rBBowAndDagger.TabStop = true;
            this.rBBowAndDagger.Text = "Bow and dagger";
            this.rBBowAndDagger.UseVisualStyleBackColor = true;
            // 
            // rBSword
            // 
            this.rBSword.AutoSize = true;
            this.rBSword.Checked = true;
            this.rBSword.Location = new System.Drawing.Point(28, 35);
            this.rBSword.Name = "rBSword";
            this.rBSword.Size = new System.Drawing.Size(55, 17);
            this.rBSword.TabIndex = 0;
            this.rBSword.TabStop = true;
            this.rBSword.Text = "Sword";
            this.rBSword.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter your character\'s name";
            // 
            // cBDefault
            // 
            this.cBDefault.AutoSize = true;
            this.cBDefault.Location = new System.Drawing.Point(275, 87);
            this.cBDefault.Name = "cBDefault";
            this.cBDefault.Size = new System.Drawing.Size(149, 17);
            this.cBDefault.TabIndex = 6;
            this.cBDefault.Text = "Create a default character";
            this.cBDefault.UseVisualStyleBackColor = true;
            this.cBDefault.CheckedChanged += new System.EventHandler(this.cBDefault_CheckedChanged);
            // 
            // bAddMemberToParty
            // 
            this.bAddMemberToParty.Location = new System.Drawing.Point(275, 338);
            this.bAddMemberToParty.Name = "bAddMemberToParty";
            this.bAddMemberToParty.Size = new System.Drawing.Size(185, 53);
            this.bAddMemberToParty.TabIndex = 7;
            this.bAddMemberToParty.Text = "Add a member to the party";
            this.bAddMemberToParty.UseVisualStyleBackColor = true;
            this.bAddMemberToParty.Click += new System.EventHandler(this.bAddMemberToParty_Click);
            // 
            // bSaveParty
            // 
            this.bSaveParty.Location = new System.Drawing.Point(275, 397);
            this.bSaveParty.Name = "bSaveParty";
            this.bSaveParty.Size = new System.Drawing.Size(185, 52);
            this.bSaveParty.TabIndex = 9;
            this.bSaveParty.Text = "Save your party";
            this.bSaveParty.UseVisualStyleBackColor = true;
            this.bSaveParty.Click += new System.EventHandler(this.bSaveParty_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 10;
            // 
            // FCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bSaveParty);
            this.Controls.Add(this.bAddMemberToParty);
            this.Controls.Add(this.cBDefault);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.weaponBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.raceBox);
            this.Name = "FCharacter";
            this.Text = "Character creation";
            this.raceBox.ResumeLayout(false);
            this.raceBox.PerformLayout();
            this.weaponBox.ResumeLayout(false);
            this.weaponBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox raceBox;
        private System.Windows.Forms.RadioButton rBOrc;
        private System.Windows.Forms.RadioButton rBElf;
        private System.Windows.Forms.RadioButton rBHuman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox weaponBox;
        private System.Windows.Forms.RadioButton rBBowAndDagger;
        private System.Windows.Forms.RadioButton rBSword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cBDefault;
        private System.Windows.Forms.Button bAddMemberToParty;
        private System.Windows.Forms.Button bSaveParty;
        private System.Windows.Forms.Label label3;
    }
}