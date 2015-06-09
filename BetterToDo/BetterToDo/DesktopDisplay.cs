using System.ComponentModel;
using System.Windows.Forms;
using BetterToDo.Properties;

namespace BetterToDo
{
    public partial class DesktopDisplay : Form
    {
        private MainForm mainForm;
        
        public DesktopDisplay(MainForm mainForm)
        {
            this.mainForm = mainForm;
            Settings.Default.PropertyChanged += Default_PropertyChanged;
            InitializeComponent();
            this.mainForm.TodoTextInitialized += () => textDisplay.Text = mainForm.TodoText.Text;
            InitializeTextBox();
        }

        void Default_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "FontColor":
                    textDisplay.ForeColor = Settings.Default.FontColor;
                    break;
                case "Font":
                    textDisplay.Font = Settings.Default.Font;
                    break;
            }
        }

        private void InitializeTextBox()
        {
            textDisplay.Font = Settings.Default.Font;
            textDisplay.DataBindings.Add(new Binding("Text", mainForm.TodoText, "Text"));
            PInvokes.SetInBackground(Handle);
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height / 2;
            Top = Screen.PrimaryScreen.Bounds.Height / 2;
            Left = 0;
            textDisplay.Width = Width;
            textDisplay.Height = Height;
            textDisplay.ForeColor = Settings.Default.FontColor;
        }
    }
}