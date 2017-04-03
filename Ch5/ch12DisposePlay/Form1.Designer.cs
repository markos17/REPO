namespace ch12DisposePlay
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
            this.btnClone1 = new System.Windows.Forms.Button();
            this.bynClone2 = new System.Windows.Forms.Button();
            this.btnGc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClone1
            // 
            this.btnClone1.Location = new System.Drawing.Point(40, 23);
            this.btnClone1.Name = "btnClone1";
            this.btnClone1.Size = new System.Drawing.Size(75, 23);
            this.btnClone1.TabIndex = 0;
            this.btnClone1.Text = "Clone1";
            this.btnClone1.UseVisualStyleBackColor = true;
            this.btnClone1.Click += new System.EventHandler(this.btnClone1_Click);
            // 
            // bynClone2
            // 
            this.bynClone2.Location = new System.Drawing.Point(40, 65);
            this.bynClone2.Name = "bynClone2";
            this.bynClone2.Size = new System.Drawing.Size(75, 23);
            this.bynClone2.TabIndex = 1;
            this.bynClone2.Text = "Clone 2";
            this.bynClone2.UseVisualStyleBackColor = true;
            this.bynClone2.Click += new System.EventHandler(this.bynClone2_Click);
            // 
            // btnGc
            // 
            this.btnGc.Location = new System.Drawing.Point(40, 109);
            this.btnGc.Name = "btnGc";
            this.btnGc.Size = new System.Drawing.Size(75, 23);
            this.btnGc.TabIndex = 2;
            this.btnGc.Text = "GC";
            this.btnGc.UseVisualStyleBackColor = true;
            this.btnGc.Click += new System.EventHandler(this.btnGc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(160, 154);
            this.Controls.Add(this.btnGc);
            this.Controls.Add(this.bynClone2);
            this.Controls.Add(this.btnClone1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClone1;
        private System.Windows.Forms.Button bynClone2;
        private System.Windows.Forms.Button btnGc;
    }
}

