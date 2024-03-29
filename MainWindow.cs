﻿#region Using's
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Ionic.BZip2;
#endregion

namespace RBLXCompressor
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

            try
            {
                processStatus.Text = "Compressing...";
                selectButton.Enabled = false; // Let's not allow the user to select another map while one is already compressing...
                using (var compressor = new ParallelBZip2OutputStream(output))
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
            catch (Exception ex)
            {
                successful = false;
                MessageBox.Show("Something went wrong: \n" + ex.Message, "Place Compressor - Oh Noes!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                selectButton.Enabled = true;

                if (!successful) 
                { 
                    processStatus.Text = "Error"; 
                }
                else 
                { 
                    processStatus.Text = "Compression finished!"; 
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
            Process.Start("https://bitl.itch.io/novetus");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/IDeletedSystem64/rblx-compressor");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://system64.dev");
        }
    }
}
