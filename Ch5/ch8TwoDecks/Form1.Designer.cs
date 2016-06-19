namespace ch8TwoDecks
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMoveToDeck2 = new System.Windows.Forms.Button();
            this.btnMoveToDeck1 = new System.Windows.Forms.Button();
            this.bnReset1 = new System.Windows.Forms.Button();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.btnShuffle1 = new System.Windows.Forms.Button();
            this.btnShuffle2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 251);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(214, 22);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(148, 251);
            this.listBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Deck #1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Deck #2";
            // 
            // btnMoveToDeck2
            // 
            this.btnMoveToDeck2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveToDeck2.Location = new System.Drawing.Point(168, 82);
            this.btnMoveToDeck2.Name = "btnMoveToDeck2";
            this.btnMoveToDeck2.Size = new System.Drawing.Size(40, 25);
            this.btnMoveToDeck2.TabIndex = 4;
            this.btnMoveToDeck2.Text = ">>";
            this.btnMoveToDeck2.UseVisualStyleBackColor = true;
            this.btnMoveToDeck2.Click += new System.EventHandler(this.btnMoveToDeck2_Click);
            // 
            // btnMoveToDeck1
            // 
            this.btnMoveToDeck1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveToDeck1.Location = new System.Drawing.Point(168, 124);
            this.btnMoveToDeck1.Name = "btnMoveToDeck1";
            this.btnMoveToDeck1.Size = new System.Drawing.Size(40, 25);
            this.btnMoveToDeck1.TabIndex = 5;
            this.btnMoveToDeck1.Text = "<<";
            this.btnMoveToDeck1.UseVisualStyleBackColor = true;
            this.btnMoveToDeck1.Click += new System.EventHandler(this.btnMoveToDeck1_Click);
            // 
            // bnReset1
            // 
            this.bnReset1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnReset1.Location = new System.Drawing.Point(12, 290);
            this.bnReset1.Name = "bnReset1";
            this.bnReset1.Size = new System.Drawing.Size(150, 23);
            this.bnReset1.TabIndex = 6;
            this.bnReset1.Text = "Reset Deck #1";
            this.bnReset1.UseVisualStyleBackColor = true;
            this.bnReset1.Click += new System.EventHandler(this.bnReset1_Click);
            // 
            // btnReset2
            // 
            this.btnReset2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset2.Location = new System.Drawing.Point(212, 290);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(150, 23);
            this.btnReset2.TabIndex = 7;
            this.btnReset2.Text = "Reset Deck #2";
            this.btnReset2.UseVisualStyleBackColor = true;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click);
            // 
            // btnShuffle1
            // 
            this.btnShuffle1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffle1.Location = new System.Drawing.Point(12, 319);
            this.btnShuffle1.Name = "btnShuffle1";
            this.btnShuffle1.Size = new System.Drawing.Size(150, 23);
            this.btnShuffle1.TabIndex = 8;
            this.btnShuffle1.Text = "Shuffle Deck #1";
            this.btnShuffle1.UseVisualStyleBackColor = true;
            this.btnShuffle1.Click += new System.EventHandler(this.btnShuffle1_Click);
            // 
            // btnShuffle2
            // 
            this.btnShuffle2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffle2.Location = new System.Drawing.Point(212, 319);
            this.btnShuffle2.Name = "btnShuffle2";
            this.btnShuffle2.Size = new System.Drawing.Size(150, 23);
            this.btnShuffle2.TabIndex = 9;
            this.btnShuffle2.Text = "Shuffle Deck #1";
            this.btnShuffle2.UseVisualStyleBackColor = true;
            this.btnShuffle2.Click += new System.EventHandler(this.btnShuffle2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 362);
            this.Controls.Add(this.btnShuffle2);
            this.Controls.Add(this.btnShuffle1);
            this.Controls.Add(this.btnReset2);
            this.Controls.Add(this.bnReset1);
            this.Controls.Add(this.btnMoveToDeck1);
            this.Controls.Add(this.btnMoveToDeck2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Two Decks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMoveToDeck2;
        private System.Windows.Forms.Button btnMoveToDeck1;
        private System.Windows.Forms.Button bnReset1;
        private System.Windows.Forms.Button btnReset2;
        private System.Windows.Forms.Button btnShuffle1;
        private System.Windows.Forms.Button btnShuffle2;
    }
}

