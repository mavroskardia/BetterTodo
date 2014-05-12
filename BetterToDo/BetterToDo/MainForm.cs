using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using BetterToDo.Properties;

namespace BetterToDo
{
    public partial class MainForm : Form
    {
        private GlobalHotkeys globalHotKeys;
        private bool dirtyTextBox = false;
        private TodoFile todoFile;
        private TodoFileWatcher todoFileWatcher;
        private DesktopDisplay desktopDisplay;

        public delegate void TodoTextInitializedHandler();

        public event TodoTextInitializedHandler TodoTextInitialized;

        public RichTextBox TodoText
        {
            get { return todoText; }
        }

        public MainForm()
        {
            InitializeComponent();

            if (!InitialSetupComplete()) return;

			System.Console.Write(Environment.OSVersion);
			
            if (Settings.Default.ShowOnDesktop)
            {
                desktopDisplay = new DesktopDisplay(this);
                desktopDisplay.Show();
            }

            InitializeTodoText();
            Settings.Default.PropertyChanged += new PropertyChangedEventHandler(Default_PropertyChanged);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetupHotKey();
        }

        private void SetupHotKey()
        {
            globalHotKeys = new GlobalHotkeys();
            globalHotKeys.RegisterGlobalHotKey((int) Keys.F2, GlobalHotkeys.MOD_ALT, Handle);
        }

        private bool InitialSetupComplete()
        {
            if (string.IsNullOrEmpty(Settings.Default.FileLocation))
            {
                if (new Options().ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("Cannot start application without specifying todo file.", "Error Starting " + Text,
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Exit(false);
                    return false;
                }
            }
            return true;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == GlobalHotkeys.WM_HOTKEY)
            {
                if ((short)m.WParam == globalHotKeys.HotkeyID)
                    ToggleActivate();
            }
        }

        private void InitializeTodoText()
        {
            todoFile = new TodoFile();
            todoText.Font = Settings.Default.Font;
            todoText.Text = todoFile.GetFileContents();
            dirtyTextBox = false;
            todoText.Select(todoText.TextLength, 0);

            todoFileWatcher = new TodoFileWatcher(todoFile);

            fileTimer.Enabled = true;
            if (TodoTextInitialized != null)
                TodoTextInitialized();
        }

        private void Default_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "FileLocation":
                    todoFileWatcher.FileSystemWatcher.Dispose();
                    InitializeTodoText();
                    break;
                case "Font":
                    todoText.Font = Settings.Default.Font;
                    break;
                case "ShowOnDesktop":
                    if (Settings.Default.ShowOnDesktop)
                    {
                        if (desktopDisplay == null)
                            desktopDisplay = new DesktopDisplay(this);
                        desktopDisplay.Show();
                    }
                    else
                    {
                        if (desktopDisplay != null)
                            desktopDisplay.Close();
                        desktopDisplay = null;
                    }
                    break;
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            ToggleActivate();
        }

        private void ToggleActivate()
        {
            Show();
            WindowState = FormWindowState.Normal;
            Activate();
        }

        private void fileSaveTimer_Tick(object sender, EventArgs e)
        {
            if (todoFile.Dirty)
                todoText.Text = todoFile.GetFileContents();

            if (dirtyTextBox)
            {
                todoFile.SaveFileContents(todoText.Text);
                dirtyTextBox = false;
            }
        }

        private void todoText_TextChanged(object sender, EventArgs e)
        {
            if (todoFile.Dirty)
                todoFile.Dirty = false;
            else
                dirtyTextBox = true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.WindowsShutDown)
            {
                WindowState = FormWindowState.Minimized;
                e.Cancel = true;
            }
            else
            {
                Exit(true);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit(true);
        }

        private void todoText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Options().ShowDialog();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            todoText.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            todoText.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            todoText.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            todoText.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            todoText.SelectAll();
        }

        private void optionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Options().ShowDialog();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Exit(true);
        }

        public void Exit(bool saveCurrentFile)
        {
            if (saveCurrentFile)
                todoFile.SaveFileContents(todoText.Text);
            globalHotKeys.UnregisterGlobalHotKey();
            Dispose();
        }

        private void strikeoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font f = todoText.SelectionFont;
            todoText.SelectionFont = new Font(f, FontStyle.Strikeout);
        }
    }
}