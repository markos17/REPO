namespace ch5InheritanceBeesPart2
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
            this.btnNextShift = new System.Windows.Forms.Button();
            this.txtReport = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nrShits = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbJob = new System.Windows.Forms.ComboBox();
            this.btnAssignJob = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrShits)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNextShift
            // 
            this.btnNextShift.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNextShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNextShift.Location = new System.Drawing.Point(294, 12);
            this.btnNextShift.Name = "btnNextShift";
            this.btnNextShift.Size = new System.Drawing.Size(147, 114);
            this.btnNextShift.TabIndex = 0;
            this.btnNextShift.Text = "Work the next shift";
            this.btnNextShift.UseVisualStyleBackColor = true;
            this.btnNextShift.Click += new System.EventHandler(this.btnNextShift_Click);
            // 
            // txtReport
            // 
            this.txtReport.Location = new System.Drawing.Point(21, 132);
            this.txtReport.Multiline = true;
            this.txtReport.Name = "txtReport";
            this.txtReport.Size = new System.Drawing.Size(420, 175);
            this.txtReport.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nrShits);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbJob);
            this.groupBox1.Controls.Add(this.btnAssignJob);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 114);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Assignments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Shifts";
            // 
            // nrShits
            // 
            this.nrShits.Location = new System.Drawing.Point(151, 41);
            this.nrShits.Name = "nrShits";
            this.nrShits.Size = new System.Drawing.Size(110, 20);
            this.nrShits.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Job";
            // 
            // cbJob
            // 
            this.cbJob.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbJob.FormattingEnabled = true;
            this.cbJob.Items.AddRange(new object[] {
            "Nectar collector",
            "Honey manufacturing",
            "Egg care",
            "Baby bee tutoring",
            "Hive maintenance",
            "Sting patrol"});
            this.cbJob.Location = new System.Drawing.Point(6, 41);
            this.cbJob.Name = "cbJob";
            this.cbJob.Size = new System.Drawing.Size(121, 21);
            this.cbJob.TabIndex = 7;
            // 
            // btnAssignJob
            // 
            this.btnAssignJob.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAssignJob.Location = new System.Drawing.Point(6, 75);
            this.btnAssignJob.Name = "btnAssignJob";
            this.btnAssignJob.Size = new System.Drawing.Size(256, 23);
            this.btnAssignJob.TabIndex = 6;
            this.btnAssignJob.Text = "Assign this job to a bee";
            this.btnAssignJob.UseVisualStyleBackColor = true;
            this.btnAssignJob.Click += new System.EventHandler(this.btnAssignJob_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 320);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtReport);
            this.Controls.Add(this.btnNextShift);
            this.Name = "Form1";
            this.Text = "Beehive Management System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrShits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNextShift;
        private System.Windows.Forms.TextBox txtReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nrShits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbJob;
        private System.Windows.Forms.Button btnAssignJob;
    }
}

