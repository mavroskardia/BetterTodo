namespace BetterToDo
{
    partial class Options
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelFontColor = new System.Windows.Forms.Panel();
            this.buttonColorPicker = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFileLocation = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFont = new System.Windows.Forms.TextBox();
            this.buttonBrowseFont = new System.Windows.Forms.Button();
            this.checkBoxShowTextOnDesktop = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Font Color:";
            // 
            // panelFontColor
            // 
            this.panelFontColor.BackColor = System.Drawing.SystemColors.ControlText;
            this.panelFontColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFontColor.Location = new System.Drawing.Point(15, 74);
            this.panelFontColor.Name = "panelFontColor";
            this.panelFontColor.Size = new System.Drawing.Size(21, 23);
            this.panelFontColor.TabIndex = 1;
            // 
            // buttonColorPicker
            // 
            this.buttonColorPicker.Location = new System.Drawing.Point(42, 74);
            this.buttonColorPicker.Name = "buttonColorPicker";
            this.buttonColorPicker.Size = new System.Drawing.Size(75, 23);
            this.buttonColorPicker.TabIndex = 2;
            this.buttonColorPicker.Text = "Change...";
            this.buttonColorPicker.UseVisualStyleBackColor = true;
            this.buttonColorPicker.Click += new System.EventHandler(this.buttonColorPicker_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(87, 195);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(168, 195);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "File Location:";
            // 
            // textBoxFileLocation
            // 
            this.textBoxFileLocation.Location = new System.Drawing.Point(15, 126);
            this.textBoxFileLocation.Name = "textBoxFileLocation";
            this.textBoxFileLocation.Size = new System.Drawing.Size(189, 20);
            this.textBoxFileLocation.TabIndex = 6;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(210, 124);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(30, 23);
            this.buttonBrowse.TabIndex = 7;
            this.buttonBrowse.Text = "...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Font:";
            // 
            // textBoxFont
            // 
            this.textBoxFont.Location = new System.Drawing.Point(15, 25);
            this.textBoxFont.Name = "textBoxFont";
            this.textBoxFont.Size = new System.Drawing.Size(189, 20);
            this.textBoxFont.TabIndex = 9;
            // 
            // buttonBrowseFont
            // 
            this.buttonBrowseFont.Location = new System.Drawing.Point(210, 23);
            this.buttonBrowseFont.Name = "buttonBrowseFont";
            this.buttonBrowseFont.Size = new System.Drawing.Size(30, 23);
            this.buttonBrowseFont.TabIndex = 10;
            this.buttonBrowseFont.Text = "...";
            this.buttonBrowseFont.UseVisualStyleBackColor = true;
            this.buttonBrowseFont.Click += new System.EventHandler(this.buttonBrowseFont_Click);
            // 
            // checkBoxShowTextOnDesktop
            // 
            this.checkBoxShowTextOnDesktop.AutoSize = true;
            this.checkBoxShowTextOnDesktop.Location = new System.Drawing.Point(15, 160);
            this.checkBoxShowTextOnDesktop.Name = "checkBoxShowTextOnDesktop";
            this.checkBoxShowTextOnDesktop.Size = new System.Drawing.Size(135, 17);
            this.checkBoxShowTextOnDesktop.TabIndex = 12;
            this.checkBoxShowTextOnDesktop.Text = "Show Text on Desktop";
            this.checkBoxShowTextOnDesktop.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 232);
            this.Controls.Add(this.checkBoxShowTextOnDesktop);
            this.Controls.Add(this.buttonBrowseFont);
            this.Controls.Add(this.textBoxFont);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxFileLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonColorPicker);
            this.Controls.Add(this.panelFontColor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(261, 197);
            this.Name = "Options";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelFontColor;
        private System.Windows.Forms.Button buttonColorPicker;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFileLocation;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFont;
        private System.Windows.Forms.Button buttonBrowseFont;
        private System.Windows.Forms.CheckBox checkBoxShowTextOnDesktop;
    }
}