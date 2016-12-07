using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NEF_Filter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<string> AllJPGs = new List<string>();
        private List<string> AllNEFs = new List<string>();

        private void SearchPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog objDialog = new FolderBrowserDialog();
            objDialog.Description = "Ordner mit JPG's und NEF's auswählen";
            objDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DialogResult objResult = objDialog.ShowDialog(this);
            if (objResult == DialogResult.OK)
            {
                AllJPGs = Directory.GetFiles(objDialog.SelectedPath, "*.JPG", SearchOption.TopDirectoryOnly).ToList();
                AllNEFs = Directory.GetFiles(objDialog.SelectedPath, "*.NEF", SearchOption.TopDirectoryOnly).ToList();
                if (AllJPGs.Count > 1 && AllNEFs.Count > 1)
                {
                    for (int i = 0; i < AllJPGs.Count; i++)
                    {
                        AllJPGs[i] = Path.GetFileNameWithoutExtension(AllJPGs[i]);
                    }
                    FilterButton.Enabled = true;
                    PathTextBox.Text = objDialog.SelectedPath;
                }
                else
                {
                    FilterButton.Enabled = false;
                    PathTextBox.Text = string.Empty;
                }
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            FilterButton.Enabled = false;
            for (int i = 0; i < AllNEFs.Count; i++)
            {
                if (!AllJPGs.Contains(Path.GetFileNameWithoutExtension(AllNEFs[i])))
                {
                    try
                    {
                        File.Delete(AllNEFs[i]);
                    } catch { }
                }
            }
            FilterButton.Enabled = true;
            MessageBox.Show("Die Bilder wurden erfolgreich gefiltert.");
        }

    }
}
