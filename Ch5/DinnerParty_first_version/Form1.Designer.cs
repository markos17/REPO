﻿namespace DinnerParty_first_version
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.healthyBox = new System.Windows.Forms.CheckBox();
            this.fancyBox = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTooLong = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCakewWriting = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBirthdayCost = new System.Windows.Forms.Label();
            this.chbFancyBirthday = new System.Windows.Forms.CheckBox();
            this.nrNumberBirthday = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrNumberBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(182, 173);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.costLabel);
            this.tabPage1.Controls.Add(this.healthyBox);
            this.tabPage1.Controls.Add(this.fancyBox);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(174, 147);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dinner Party";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cost";
            // 
            // costLabel
            // 
            this.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(61, 93);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(71, 19);
            this.costLabel.TabIndex = 10;
            // 
            // healthyBox
            // 
            this.healthyBox.AutoSize = true;
            this.healthyBox.Location = new System.Drawing.Point(26, 65);
            this.healthyBox.Name = "healthyBox";
            this.healthyBox.Size = new System.Drawing.Size(96, 17);
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
            this.fancyBox.Location = new System.Drawing.Point(26, 42);
            this.fancyBox.Name = "fancyBox";
            this.fancyBox.Size = new System.Drawing.Size(115, 17);
            this.fancyBox.TabIndex = 8;
            this.fancyBox.Text = "Fancy Decorations";
            this.fancyBox.UseVisualStyleBackColor = true;
            this.fancyBox.CheckedChanged += new System.EventHandler(this.fancyBox_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(26, 16);
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
            this.numericUpDown1.Size = new System.Drawing.Size(89, 20);
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
            this.label1.Location = new System.Drawing.Point(23, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number of People";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblTooLong);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtCakewWriting);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lblBirthdayCost);
            this.tabPage2.Controls.Add(this.chbFancyBirthday);
            this.tabPage2.Controls.Add(this.nrNumberBirthday);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(174, 147);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Birthday Party";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTooLong
            // 
            this.lblTooLong.AutoSize = true;
            this.lblTooLong.BackColor = System.Drawing.Color.Red;
            this.lblTooLong.Location = new System.Drawing.Point(97, 66);
            this.lblTooLong.Name = "lblTooLong";
            this.lblTooLong.Size = new System.Drawing.Size(63, 13);
            this.lblTooLong.TabIndex = 14;
            this.lblTooLong.Text = "TOO LONG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cake writing";
            // 
            // txtCakewWriting
            // 
            this.txtCakewWriting.Location = new System.Drawing.Point(26, 85);
            this.txtCakewWriting.Name = "txtCakewWriting";
            this.txtCakewWriting.Size = new System.Drawing.Size(100, 20);
            this.txtCakewWriting.TabIndex = 12;
            this.txtCakewWriting.Text = "Happy Birthday!";
            this.txtCakewWriting.TextChanged += new System.EventHandler(this.txtCakewWriting_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cost";
            // 
            // lblBirthdayCost
            // 
            this.lblBirthdayCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBirthdayCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdayCost.Location = new System.Drawing.Point(61, 116);
            this.lblBirthdayCost.Name = "lblBirthdayCost";
            this.lblBirthdayCost.Size = new System.Drawing.Size(71, 19);
            this.lblBirthdayCost.TabIndex = 10;
            // 
            // chbFancyBirthday
            // 
            this.chbFancyBirthday.AutoSize = true;
            this.chbFancyBirthday.Checked = true;
            this.chbFancyBirthday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbFancyBirthday.Location = new System.Drawing.Point(26, 42);
            this.chbFancyBirthday.Name = "chbFancyBirthday";
            this.chbFancyBirthday.Size = new System.Drawing.Size(115, 17);
            this.chbFancyBirthday.TabIndex = 8;
            this.chbFancyBirthday.Text = "Fancy Decorations";
            this.chbFancyBirthday.UseVisualStyleBackColor = true;
            this.chbFancyBirthday.CheckedChanged += new System.EventHandler(this.chbFancyBirthday_CheckedChanged);
            // 
            // nrNumberBirthday
            // 
            this.nrNumberBirthday.Location = new System.Drawing.Point(26, 16);
            this.nrNumberBirthday.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nrNumberBirthday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nrNumberBirthday.Name = "nrNumberBirthday";
            this.nrNumberBirthday.Size = new System.Drawing.Size(89, 20);
            this.nrNumberBirthday.TabIndex = 7;
            this.nrNumberBirthday.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nrNumberBirthday.ValueChanged += new System.EventHandler(this.nrNumberBirthday_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Number of People";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 168);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrNumberBirthday)).EndInit();
            this.ResumeLayout(false);

         }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.CheckBox healthyBox;
        private System.Windows.Forms.CheckBox fancyBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblTooLong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCakewWriting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBirthdayCost;
        private System.Windows.Forms.CheckBox chbFancyBirthday;
        private System.Windows.Forms.NumericUpDown nrNumberBirthday;
        private System.Windows.Forms.Label label5;
    }
 }
