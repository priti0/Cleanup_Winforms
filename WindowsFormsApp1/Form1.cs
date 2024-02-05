using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private const string TargetDirectory = @"C:\Users\pritid\Desktop\Clean";
        private const string ArchiveDirectory = @"C:\Users\pritid\Desktop\Archive";

        public Form1()
        {
            InitializeComponent();
            cmbSize.SelectedIndex = 0;
            /*progressBar = new ProgressBar();
            Controls.Add(progressBar);
            progressBar.Visible = false; // Initially, set the progress bar as not visible*/
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string directoryPath = TargetDirectory;
                string[] files = Directory.GetFiles(directoryPath, "*", SearchOption.AllDirectories);
                DateTime selectedDate = dateTimePicker.Value;
                long totalSizeBytes = 0;
                int fileCount = 0, fileCountDeleted = 0;
                // Set the maximum value of the progress bar to the total number of files
                /*progressBar.Maximum = files.Length;
                progressBar.Minimum = 0;
                progressBar.Value = 0; // Reset progress bar value
                progressBar.Visible = true; // Make the progress bar visible*/

                foreach (string file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    // Calculate the total size
                    totalSizeBytes += fileInfo.Length;

                    // Increment file count
                    fileCount++;
                    // Update progress bar value
                   /* progressBar.Value = fileCount;*/

                    if (!dateTimePicker.Checked)
                    {
                        // No date selected, delete files older than 2 months directly
                        DateTime thresholdDate = DateTime.Now.AddMonths(-2);

                        if (fileInfo.LastWriteTime < thresholdDate)
                        {
                            File.Delete(file); fileCountDeleted++;
                        }
                    }
                    
                    else
                    {
                        //The combined conditions ensure that the file falls within the 2-month range before the selected date but is not on or after
                        //the selected date. In other words, the file is less than 2 months old but not exactly at the selected date
                        if (fileInfo.LastWriteTime >= selectedDate.AddMonths(-2) && fileInfo.LastWriteTime < selectedDate)
                        {
                            // File is less than 2 months old, show a warning
                            DialogResult result = MessageBox.Show($"This will delete a file ({fileInfo.Name}) that is less than 2 months old. Are you sure you want to proceed?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (result == DialogResult.Yes)
                            {
                                // Proceed with deletion
                                File.Delete(file); fileCountDeleted++;
                            }
                        }
                        else if (fileInfo.LastWriteTime < selectedDate)
                        {
                            File.Delete(file); fileCountDeleted++;
                        } 
                    }

                    
                }
                // Hide the progress bar after the operation is complete
                /*progressBar.Visible = false;*/
                MessageBox.Show($"Files older than {selectedDate.ToShortDateString()} have been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Convert the total size to the selected unit

                ConvertToSelectedUnit((totalSizeBytes / 1024));

               /* // Show the total size in a MessageBox or any other way you prefer
                txtSize.Text = totalSizeInUnit.ToString();*/
                // Display the total file count in the TextBox
                txtTotal.Text = fileCount.ToString();
                txtDelete.Text = fileCountDeleted.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Add this method to convert the total size to the selected unit
            private void ConvertToSelectedUnit(long sizeInBytes)
            {
                if (sizeInBytes < 1024)
                {
                    cmbSize.SelectedIndex = 0;
                    txtSize.Text = (sizeInBytes).ToString();
                }
                else if(sizeInBytes>=1024 && sizeInBytes < 1024*1024)
                {
                    cmbSize.SelectedIndex = 1;
                    txtSize.Text = (sizeInBytes/1024).ToString();
                }
                else if (sizeInBytes >= 1024*1024 && sizeInBytes < 1024 * 1024*1024)
                {
                    cmbSize.SelectedIndex = 2;
                    txtSize.Text = (sizeInBytes / 1024*1024).ToString();
                }
            }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set the default selection of the ComboBox to "KB"
            cmbSize.SelectedItem = "KB";
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            long totalSizeBytes2 = 0, fileCount2 = 0;
            try
            {
                // Get the paths for the target and archive directories from the app settings
                string directoryPath = TargetDirectory;
                string archiveDirectoryPath = ArchiveDirectory;

                // Create the archive directory if it doesn't exist
                if (!Directory.Exists(archiveDirectoryPath))
                {
                    Directory.CreateDirectory(archiveDirectoryPath);
                }

                // Your logic for selecting files to archive (modify this based on your specific requirements)
                string[] filesToArchive = Directory.GetFiles(directoryPath, "*", SearchOption.AllDirectories);

                // Lists to store information about archived files
                List<string> archivedFilePaths = new List<string>();
                int archivedFileCount = 0;


                foreach (string filePath in filesToArchive)
                {
                    FileInfo fileInfo2 = new FileInfo(filePath);
                    // Calculate the total size
                    totalSizeBytes2 += fileInfo2.Length;

                    // Increment file count
                    fileCount2++;
                    // Get information about the file
                    FileInfo fileInfo = new FileInfo(filePath);

                    // Your logic for determining which files to archive (modify this based on your specific requirements)
                    // For example, you might want to archive files older than a certain date
                    if (fileInfo.LastWriteTime < DateTime.Now.AddDays(-10))
                    {
                        // Construct the destination path in the archive directory
                        string archiveFilePath = Path.Combine(archiveDirectoryPath, fileInfo.Name);

                        // Copy or move the file to the archive directory (choose the appropriate method)
                        File.Move(filePath, archiveFilePath);

                        // Track information about the archived file
                        archivedFilePaths.Add(archiveFilePath);
                        archivedFileCount++;

                    }
                   
                    ConvertToSelectedUnit(totalSizeBytes2/1024);
                    // Show the total size in a MessageBox or any other way you prefer
                   
                    // Display the total file count in the TextBox
                    txtTotal.Text = fileCount2.ToString();
                }
                // Update TextBox with information about archived files
                UpdateArchiveInfoTextBox(archivedFilePaths, archivedFileCount);

                // Display a success message
                MessageBox.Show("Files have been archived.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Display an error message if an exception occurs
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateArchiveInfoTextBox(List<string> archivedFilePaths, int archivedFileCount)
        {
            // Display the total number of archived files
            txtArchive.Text = archivedFileCount.ToString();

            // Display the paths of the archived files
            foreach (string filePath in archivedFilePaths)
            {
                txtPath.Text += $"{filePath}{Environment.NewLine}";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
