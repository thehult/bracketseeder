namespace BracketSeeder
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
            this.txtSeeds = new System.Windows.Forms.TextBox();
            this.btnRandomSeed = new System.Windows.Forms.Button();
            this.btnRealSeed = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // txtSeeds
            // 
            this.txtSeeds.Location = new System.Drawing.Point(12, 12);
            this.txtSeeds.Multiline = true;
            this.txtSeeds.Name = "txtSeeds";
            this.txtSeeds.Size = new System.Drawing.Size(411, 522);
            this.txtSeeds.TabIndex = 0;
            // 
            // btnRandomSeed
            // 
            this.btnRandomSeed.Location = new System.Drawing.Point(221, 540);
            this.btnRandomSeed.Name = "btnRandomSeed";
            this.btnRandomSeed.Size = new System.Drawing.Size(202, 23);
            this.btnRandomSeed.TabIndex = 1;
            this.btnRandomSeed.Text = "Random Seed";
            this.btnRandomSeed.UseVisualStyleBackColor = true;
            this.btnRandomSeed.Click += new System.EventHandler(this.btnRandomSeed_Click);
            // 
            // btnRealSeed
            // 
            this.btnRealSeed.Location = new System.Drawing.Point(12, 540);
            this.btnRealSeed.Name = "btnRealSeed";
            this.btnRealSeed.Size = new System.Drawing.Size(202, 23);
            this.btnRealSeed.TabIndex = 2;
            this.btnRealSeed.Text = "Real Seed";
            this.btnRealSeed.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 569);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(411, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 601);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRealSeed);
            this.Controls.Add(this.btnRandomSeed);
            this.Controls.Add(this.txtSeeds);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSeeds;
        private System.Windows.Forms.Button btnRandomSeed;
        private System.Windows.Forms.Button btnRealSeed;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

