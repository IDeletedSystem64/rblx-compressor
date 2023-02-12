#region Using's
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
#endregion

namespace WindowsFormsApp3
{
    public partial class MainWindow : Form
    {
        private string currFile;
        private bool successful;

        public MainWindow()
        {
            InitializeComponent();
            currentFile.Text = "No file selected!";
            processStatus.Text = "Idle";
        }

        public void Compress(string currFile) 
        {
            var newFile = currFile + ".bz2";
            var input = File.OpenRead(currFile);
            var output = File.Create(newFile);
            /*
            if (File.Exists(newFile))
            {
                MessageBox.Show("The file " + newFile + " already exists, are you sure you want to continue? This will overwrite the existing file.","Map Compressor - Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            } // If the output file already exists, Prompt the user weather or not they want to continue. 
            else
            */
            {
                try
                {
                    {
                        processStatus.Text = "Compressing...";
                        using (var compressor = new Ionic.BZip2.ParallelBZip2OutputStream(output))
                        {
                            byte[] buffer = new byte[2048];
                            int n;
                            while ((n = input.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                compressor.Write(buffer, 0, n);
                            }
                            successful = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    successful = false;
                    MessageBox.Show("Something went wrong: \n" + ex.Message, "Place Compressor - Oh Noes!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally
                {
                    if (!successful) {   processStatus.Text = "Error"; }
                    else { processStatus.Text = "Compression finished!"; }
                }

                }
            }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            {
                ofd.Filter = "Roblox Level (*.rbxl)|*.rbxl|Roblox Level (*.rbxlx)|*.rbxlx";
                ofd.FilterIndex = 1;
                ofd.Title = "Load Roblox Level...";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    currentFile.Text = ofd.SafeFileName;
                    currFile = Path.GetFullPath(ofd.FileName);
                    Compress(currFile);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://bitl.itch.io/novetus");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/IDeletedSystem64/rblx-compressor");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://system64.dev");
        }
    }
}
