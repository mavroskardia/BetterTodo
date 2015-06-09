using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BetterToDo.Properties;
using System;

namespace BetterToDo
{
    public partial class Options : Form
    {
        private Font tmpFont;

        public Options()
        {
            InitializeComponent();
            textBoxFont.Text = Settings.Default.Font.Name;
            textBoxFont.Font = Settings.Default.Font;
            textBoxFileLocation.Text = Settings.Default.FileLocation;
            panelFontColor.BackColor = Settings.Default.FontColor;
            checkBoxShowTextOnDesktop.Checked = Settings.Default.ShowOnDesktop;
        }

        private void buttonColorPicker_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                panelFontColor.BackColor = cd.Color;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private bool IsValidInput()
        {
            if (textBoxFileLocation.Text.Trim().Length < 1)
            {
                MessageBox.Show("Must specify a file.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Directory.Exists(Path.GetDirectoryName(textBoxFileLocation.Text)))
            {
                return true;
            }

            MessageBox.Show("Must specify a valid file location.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            return false;
        }

        private void buttonSave_Click(object sender, System.EventArgs e)
        {
            if (!IsValidInput())
            {
                return;
            }

            if (tmpFont != null)
            {
                Settings.Default.Font = tmpFont;
            }

            Settings.Default.FileLocation = textBoxFileLocation.Text;
            Settings.Default.FontColor = panelFontColor.BackColor;
            Settings.Default.ShowOnDesktop = checkBoxShowTextOnDesktop.Checked;
            Settings.Default.Save();
            DialogResult = DialogResult.OK;
        }

        private void buttonBrowse_Click(object sender, System.EventArgs e)
        {
            var ofd = new OpenFileDialog { CheckFileExists = false, CheckPathExists = true };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxFileLocation.Text = ofd.FileName;
            }
        }

        private void buttonBrowseFont_Click(object sender, System.EventArgs e)
        {
            var fd = new FontDialog
            {
                AllowVectorFonts = false,
                AllowSimulations = false,
                AllowVerticalFonts = false,
                FontMustExist = true
            };

            try
            {
                if (fd.ShowDialog() != DialogResult.OK) return;
                tmpFont = fd.Font;
                textBoxFont.Text = fd.Font.Name;
                textBoxFont.Font = fd.Font;
            }
            catch (Exception)
            {
                MessageBox.Show("Chose an invalid font. Please try again.");
            }
        }
    }
}