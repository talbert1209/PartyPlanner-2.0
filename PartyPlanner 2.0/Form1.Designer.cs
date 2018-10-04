namespace PartyPlanner_2._0
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dinnerPartyTab = new System.Windows.Forms.TabPage();
            this.costLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.healthyBox = new System.Windows.Forms.CheckBox();
            this.fancyBox = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.birthdayPartyTab = new System.Windows.Forms.TabPage();
            this.birthdayCost = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cakeWriting = new System.Windows.Forms.TextBox();
            this.tooLongLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fancyBirthday = new System.Windows.Forms.CheckBox();
            this.numberBirthday = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.dinnerPartyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.birthdayPartyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.dinnerPartyTab);
            this.tabControl1.Controls.Add(this.birthdayPartyTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(267, 249);
            this.tabControl1.TabIndex = 0;
            // 
            // dinnerPartyTab
            // 
            this.dinnerPartyTab.Controls.Add(this.costLabel);
            this.dinnerPartyTab.Controls.Add(this.label2);
            this.dinnerPartyTab.Controls.Add(this.healthyBox);
            this.dinnerPartyTab.Controls.Add(this.fancyBox);
            this.dinnerPartyTab.Controls.Add(this.numericUpDown1);
            this.dinnerPartyTab.Controls.Add(this.label1);
            this.dinnerPartyTab.Location = new System.Drawing.Point(4, 25);
            this.dinnerPartyTab.Name = "dinnerPartyTab";
            this.dinnerPartyTab.Padding = new System.Windows.Forms.Padding(3);
            this.dinnerPartyTab.Size = new System.Drawing.Size(259, 220);
            this.dinnerPartyTab.TabIndex = 0;
            this.dinnerPartyTab.Text = "Dinner Party";
            this.dinnerPartyTab.UseVisualStyleBackColor = true;
            // 
            // costLabel
            // 
            this.costLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costLabel.Location = new System.Drawing.Point(75, 142);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(100, 23);
            this.costLabel.TabIndex = 11;
            this.costLabel.Click += new System.EventHandler(this.costLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cost";
            // 
            // healthyBox
            // 
            this.healthyBox.AutoSize = true;
            this.healthyBox.Location = new System.Drawing.Point(23, 100);
            this.healthyBox.Name = "healthyBox";
            this.healthyBox.Size = new System.Drawing.Size(124, 21);
            this.healthyBox.TabIndex = 9;
            this.healthyBox.Text = "Healthy Option";
            this.healthyBox.UseVisualStyleBackColor = true;
            this.healthyBox.CheckedChanged += new System.EventHandler(this.healthyBox_CheckedChanged);
            // 
            // fancyBox
            // 
            this.fancyBox.AutoSize = true;
            this.fancyBox.Checked = true;
            this.fancyBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyBox.Location = new System.Drawing.Point(23, 72);
            this.fancyBox.Name = "fancyBox";
            this.fancyBox.Size = new System.Drawing.Size(148, 21);
            this.fancyBox.TabIndex = 8;
            this.fancyBox.Text = "Fancy Decorations";
            this.fancyBox.UseVisualStyleBackColor = true;
            this.fancyBox.CheckedChanged += new System.EventHandler(this.fancyBox_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(23, 43);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number of People";
            // 
            // birthdayPartyTab
            // 
            this.birthdayPartyTab.Controls.Add(this.birthdayCost);
            this.birthdayPartyTab.Controls.Add(this.label6);
            this.birthdayPartyTab.Controls.Add(this.cakeWriting);
            this.birthdayPartyTab.Controls.Add(this.tooLongLabel);
            this.birthdayPartyTab.Controls.Add(this.label4);
            this.birthdayPartyTab.Controls.Add(this.fancyBirthday);
            this.birthdayPartyTab.Controls.Add(this.numberBirthday);
            this.birthdayPartyTab.Controls.Add(this.label3);
            this.birthdayPartyTab.Location = new System.Drawing.Point(4, 25);
            this.birthdayPartyTab.Name = "birthdayPartyTab";
            this.birthdayPartyTab.Padding = new System.Windows.Forms.Padding(3);
            this.birthdayPartyTab.Size = new System.Drawing.Size(259, 220);
            this.birthdayPartyTab.TabIndex = 1;
            this.birthdayPartyTab.Text = "Birthday Party";
            this.birthdayPartyTab.UseVisualStyleBackColor = true;
            // 
            // birthdayCost
            // 
            this.birthdayCost.BackColor = System.Drawing.Color.WhiteSmoke;
            this.birthdayCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.birthdayCost.Location = new System.Drawing.Point(84, 175);
            this.birthdayCost.Name = "birthdayCost";
            this.birthdayCost.Size = new System.Drawing.Size(84, 28);
            this.birthdayCost.TabIndex = 7;
            this.birthdayCost.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cost";
            // 
            // cakeWriting
            // 
            this.cakeWriting.Location = new System.Drawing.Point(20, 147);
            this.cakeWriting.Name = "cakeWriting";
            this.cakeWriting.Size = new System.Drawing.Size(208, 22);
            this.cakeWriting.TabIndex = 5;
            this.cakeWriting.Text = "Happy Birthday";
            this.cakeWriting.TextChanged += new System.EventHandler(this.cakeWriting_TextChanged);
            // 
            // tooLongLabel
            // 
            this.tooLongLabel.AutoSize = true;
            this.tooLongLabel.BackColor = System.Drawing.Color.Red;
            this.tooLongLabel.Location = new System.Drawing.Point(110, 115);
            this.tooLongLabel.Name = "tooLongLabel";
            this.tooLongLabel.Size = new System.Drawing.Size(83, 17);
            this.tooLongLabel.TabIndex = 4;
            this.tooLongLabel.Text = "TOO LONG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cake Writing";
            // 
            // fancyBirthday
            // 
            this.fancyBirthday.AutoSize = true;
            this.fancyBirthday.Location = new System.Drawing.Point(20, 78);
            this.fancyBirthday.Name = "fancyBirthday";
            this.fancyBirthday.Size = new System.Drawing.Size(148, 21);
            this.fancyBirthday.TabIndex = 2;
            this.fancyBirthday.Text = "Fancy Decorations";
            this.fancyBirthday.UseVisualStyleBackColor = true;
            this.fancyBirthday.CheckedChanged += new System.EventHandler(this.fancyBirthday_CheckedChanged);
            // 
            // numberBirthday
            // 
            this.numberBirthday.Location = new System.Drawing.Point(19, 39);
            this.numberBirthday.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numberBirthday.Name = "numberBirthday";
            this.numberBirthday.Size = new System.Drawing.Size(120, 22);
            this.numberBirthday.TabIndex = 1;
            this.numberBirthday.ValueChanged += new System.EventHandler(this.numberBirthday_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number of People";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 273);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.dinnerPartyTab.ResumeLayout(false);
            this.dinnerPartyTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.birthdayPartyTab.ResumeLayout(false);
            this.birthdayPartyTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage dinnerPartyTab;
        private System.Windows.Forms.TabPage birthdayPartyTab;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox healthyBox;
        private System.Windows.Forms.CheckBox fancyBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label birthdayCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cakeWriting;
        private System.Windows.Forms.Label tooLongLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox fancyBirthday;
        private System.Windows.Forms.NumericUpDown numberBirthday;
        private System.Windows.Forms.Label label3;
    }
}

