/* Program ID: SDraper_Assignment 3
 * 
 * Purpose: Creating a form that allows users to create and manipulate photo albums. 
 * 
 * History:
 *      created July 2020 by Stephen Draper
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoAlbum
{
    public partial class PhotoAlbumForm : Form
    {
        string albumName = "";
        string fileLocation = "";
        List<Photo> photosList = new List<Photo>();
        Photo activePhoto = new Photo();

        public PhotoAlbumForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Button to turn the background Black
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbBlack_CheckedChanged(object sender, EventArgs e)
        {
            picPictureOutput.BackColor = Color.Black;
        }

        /// <summary>
        /// Button to turn the background White
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbWhite_CheckedChanged(object sender, EventArgs e)
        {
            picPictureOutput.BackColor = Color.White;
        }

        /// <summary>
        /// Button to turn the background Grey
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbGrey_CheckedChanged(object sender, EventArgs e)
        {
            picPictureOutput.BackColor = Color.Gray;
        }

        /// <summary>
        /// Create Album button - checks if there's an existing album and if there is asks if they want to save the old one. If not, 
        /// creates a new album with the name entered. Uses child forms to allow for album name input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateAlbum_Click(object sender, EventArgs e)
        {
            CreateNewAlbumForm child = new CreateNewAlbumForm(); // creates album title form
            if(child.ShowDialog(this) == DialogResult.OK)
            {
                bool goForward = true;
                if(albumName != "")
                {
                    SaveForm saveChild = new SaveForm(); // creates save file form
                    saveChild.ShowDialog();

                    if(saveChild.DialogResult == DialogResult.Yes) // if they click save, runs through save form
                    {
                        if (!SaveScript())
                        {
                            goForward = false;
                        }
                    }   
                    else if(saveChild.DialogResult == DialogResult.No) // if they click don't save, still allows progression without stopping the rest
                    {

                    }
                    else // if they click cancel or X then it stops the progression
                    {
                        goForward = false;
                    }    
                }
                if(goForward) // creates a new album with the name provided
                {
                    fileLocation = "";
                    albumName = child.AlbumName;
                    this.Text = $"Photo Album - {albumName}";
                    btnSaveAlbum.Enabled = true;
                    btnAddPhotos.Enabled = true;
                    photosList.Clear();
                    picPictureOutput.Image = null;
                    txtDescription.Text = string.Empty;
                    lblPhotoInfo.Text = string.Empty;
                    ButtonsOff();
                }
            }
        }

        /// <summary>
        /// Allows the user to save the album they have created. Creates a .alb file while stores the file path and description 
        /// for each of the photos within the album. -- now has been refactored to call a simple method, but this is still a good
        /// description so I'll leave it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveAlbum_Click(object sender, EventArgs e)
        {
            SaveScript();
            
        }

        /// <summary>
        /// Sets the active photo's description to whatever they type, assuming it isn't |. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if(txtDescription.Text.Contains("|")) // avoids them putting delineators in their description, just in case.
            {
                //MessageBox.Show("You cannot use '|' in your description.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescription.Text = txtDescription.Text.Replace("|", "");
                txtDescription.SelectionStart = txtDescription.Text.Length; // normally you jump back to the start, this moves the cursor back to the end of the text.
            }
            else
            {
                activePhoto.Description = txtDescription.Text;
            }
        }


        /// <summary>
        /// Allows the user to add photos to the active album. Can add multiple at once. Saves off the file location and creation date
        /// within the photo class so that it can be used easily later. Sets the current info and active class to the first pic pulled.
        /// Enables buttons that were disabled.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPhotos_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Jpeg Files (*.jpg;*.jpeg)|*.jpg;*.jpeg"; // opens our file dialogue filtering for jpgs specifically
            if(openFileDialog.ShowDialog()==DialogResult.OK) // if they click okay after selecting pictures
            {
                int counter = 0;
                foreach (string file in openFileDialog.FileNames) // runs through in case there are multiple pictures added
                {
                    FileInfo fileIn = new FileInfo(file);
                    DateTime creation = fileIn.CreationTime; // I need to look into a potential better way to do this, but it does work.
                    string creationStr = creation.ToString();
                    string filePath = fileIn.FullName;
                    Photo photo = new Photo(filePath,creationStr);
                    Image img = Image.FromFile(filePath);
                    photosList.Add(photo);
                    if (counter == 0) // sets the active photo and current info to the first one added, as per specs
                    {
                        lblPhotoInfo.Text = "";
                        lblPhotoInfo.Text = $"File Created: {photo.PhotoCreated}";
                        picPictureOutput.Image = img;
                        activePhoto = photo;
                    }
                    counter++;
                }
                // enables buttons. It'll do this every time they add a photo. That's okay. 
                ButtonsOn();
            }
        }

        /// <summary>
        /// When the user clicks next we check their position within the list and send them to the next element. If they are at the end, 
        /// loop around to the start.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            int length = photosList.Count;
            int index = photosList.IndexOf(activePhoto);
            if(index != (length-1))
            {
                activePhoto = photosList[index + 1];
            }
            else
            {
                activePhoto = photosList[0];
            }
            ImageReplacement();
        }

        /// <summary>
        /// Same as next. But like. The other way. Goes back one unless they are already at 0, in which case sets them to the length (-1). 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int length = photosList.Count;
            int index = photosList.IndexOf(activePhoto);
            if (index != 0)
            {
                activePhoto = photosList[index - 1];
            }
            else
            {
                activePhoto = photosList[length-1];
            }
            ImageReplacement();
        }

        /// <summary>
        /// Allows user to open an album they have saved. Verifies saving of open project, then after they have selected a new file it blows up
        /// existing list and repopulates it using the text saved in the .alb file. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenAlbum_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Album (*alb)|*.alb";
            if(openFileDialog.ShowDialog()==DialogResult.OK) // allows the user to find the file they want to load
            {
                bool goForward = true;
                if (albumName != "") // if there is an existing album in progress
                {
                    SaveForm saveChild = new SaveForm(); // creates save file form
                    saveChild.ShowDialog();

                    if (saveChild.DialogResult == DialogResult.Yes) // if they click save, runs through save form
                    {
                        if(!SaveScript())
                        {
                            goForward = false;
                        }
                    }
                    else if (saveChild.DialogResult == DialogResult.No) // if they click don't save, still allows progression without stopping the rest
                    {

                    }
                    else // if they click cancel or X then it stops the progression
                    {
                        goForward = false;
                    }
                }

                fileLocation = openFileDialog.FileName;
                if (goForward) // assuming they didn't cancel from the save
                {
                    photosList.Clear(); // blows up existing list
                    int count = 0;
                    string[] photoFromFile = File.ReadAllLines(fileLocation);
                    foreach(string line in photoFromFile) // reads the file and populates our new list
                    {
                        if (count == 0)
                        {
                            albumName = line;
                            this.Text = $"Photo Album - {albumName} - {fileLocation}";
                            btnSaveAlbum.Enabled = true;
                            btnAddPhotos.Enabled = true;
                        }
                        else
                        {
                            string[] fields = line.Split('|');
                            string path = fields[0];
                            string description = fields[1];
                            FileInfo fileIn = new FileInfo(path);
                            DateTime creation = fileIn.CreationTime;
                            string creationStr = creation.ToString();
                            Photo photo = new Photo(path, creationStr, description);
                            photosList.Add(photo);
                            ButtonsOn();
                        }
                        count++;
                    }
                    if(photosList.Count > 0) // just a check in case they load an album with no images, otherwise we'll index error
                    {
                        activePhoto = photosList[0];
                        Image img = Image.FromFile(activePhoto.PhotoPath);
                        picPictureOutput.Image = img;
                        txtDescription.Text = activePhoto.Description;
                        lblPhotoInfo.Text = $"File Created: {activePhoto.PhotoCreated}";
                    }
                    else
                    {
                        picPictureOutput.Image = null;
                        txtDescription.Text = string.Empty;
                        lblPhotoInfo.Text = string.Empty;
                        ButtonsOff();
                    }
                }
            }
        }

        /// <summary>
        /// Gives the user a chance to save before closing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhotoAlbumForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveForm saveChild = new SaveForm(); // creates save file form
            saveChild.ShowDialog();

            if (saveChild.DialogResult == DialogResult.Yes) // if they click save, runs through save form
            {
                if(!SaveScript())
                {
                    e.Cancel = true; // cancels it if they start the save process but then cancel
                }
            }
            else if (saveChild.DialogResult == DialogResult.Cancel)
            {
                e.Cancel = true; // cancels the close if they hit cancel
            }
        }

        /// <summary>
        /// I stopped being lazy and refactored out of the four instances I had of this throughout. Much cleaner. This is the script that allows
        /// the user to select if they want to save or not. Used on creating new album, saving, opening album, or closing form.
        /// </summary>
        /// <returns>True if successful, false if they closed out/canceled, so it doesn't continue</returns>
        public bool SaveScript()
        {
            bool goForward = true;
            if (fileLocation == "") // if there is no path already selected
            {
                saveFileDialog.Filter = "Album (*.alb)|*.alb";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileLocation = saveFileDialog.FileName;
                    WriteToFile();
                }
                else
                {
                    goForward = false;
                }
            }
            else // if a path is already selected, wipes the file and creates all new data
            {
                File.WriteAllText(fileLocation, String.Empty);
                WriteToFile();
            }
            return goForward;
        }

        /// <summary>
        /// Refactored out writing to file since it's used twice above. Opens streamwriter and actually writes what we're saving.
        /// </summary>
        public void WriteToFile()
        {
            using (StreamWriter writer = new StreamWriter(fileLocation, true))
            {
                writer.WriteLine(albumName);
                foreach (var photo in photosList)
                {
                    string stringToWrite = $"{photo.PhotoPath}|{photo.Description}";
                    writer.WriteLine(stringToWrite);
                }
            }
            MessageBox.Show($"Albumn {albumName} saved!", "Saved", MessageBoxButtons.OK);
            this.Text = $"Photo Album - {albumName} - {fileLocation}";
        }

        /// <summary>
        /// Refactored. There were two instances of turning off all buttons when there were no pictures, so it felt useful.
        /// </summary>
        public void ButtonsOff()
        {
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            lblDescription.Enabled = false;
            txtDescription.Enabled = false;
        }

        /// <summary>
        /// Same as above. There were multiple instances of enabling buttons when pictures were added, so I refactored.
        /// </summary>
        public void ButtonsOn()
        {
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            lblDescription.Enabled = true;
            txtDescription.Enabled = true;
        }

        /// <summary>
        /// Used this in both previous and next buttons, so I refactored it out. I've gone crazy.
        /// </summary>
        public void ImageReplacement()
        {
            Image img = Image.FromFile(activePhoto.PhotoPath);
            picPictureOutput.Image = img;
            lblPhotoInfo.Text = "";
            lblPhotoInfo.Text = $"File Created: {activePhoto.PhotoCreated}";
            txtDescription.Text = activePhoto.Description;
            txtDescription.Focus();
            txtDescription.SelectionStart = txtDescription.Text.Length;
        }
    }
}