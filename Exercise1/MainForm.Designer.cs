namespace Exercise1
{
    partial class MainForm
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
            this.IterateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IterateButton
            // 
            this.IterateButton.Location = new System.Drawing.Point(12, 167);
            this.IterateButton.Name = "IterateButton";
            this.IterateButton.Size = new System.Drawing.Size(75, 23);
            this.IterateButton.TabIndex = 0;
            this.IterateButton.Text = "Iterate";
            this.IterateButton.UseVisualStyleBackColor = true;
            this.IterateButton.Click += new System.EventHandler(this.IterateButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.IterateButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IterateButton;
    }
}

