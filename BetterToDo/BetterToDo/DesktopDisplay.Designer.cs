namespace BetterToDo
{
    partial class DesktopDisplay
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
            this.textDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textDisplay
            // 
            this.textDisplay.BackColor = System.Drawing.Color.Transparent;
            this.textDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textDisplay.Location = new System.Drawing.Point(0, 0);
            this.textDisplay.Name = "textDisplay";
            this.textDisplay.Size = new System.Drawing.Size(519, 212);
            this.textDisplay.TabIndex = 0;
            this.textDisplay.Text = "textBox";
            this.textDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DesktopDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(519, 212);
            this.ControlBox = false;
            this.Controls.Add(this.textDisplay);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "DesktopDisplay";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "DesktopDisplay";
            this.TransparencyKey = System.Drawing.SystemColors.Desktop;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label textDisplay;



    }
}