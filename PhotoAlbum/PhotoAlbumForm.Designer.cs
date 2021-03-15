namespace PhotoAlbum
{
    partial class PhotoAlbumForm
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
            this.picPictureOutput = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblPhotoInfo = new System.Windows.Forms.Label();
            this.btnAddPhotos = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.grbCanvasColour = new System.Windows.Forms.GroupBox();
            this.rdbGrey = new System.Windows.Forms.RadioButton();
            this.rdbWhite = new System.Windows.Forms.RadioButton();
            this.rdbBlack = new System.Windows.Forms.RadioButton();
            this.btnCreateAlbum = new System.Windows.Forms.Button();
            this.btnOpenAlbum = new System.Windows.Forms.Button();
            this.btnSaveAlbum = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picPictureOutput)).BeginInit();
            this.grbCanvasColour.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPictureOutput
            // 
            this.picPictureOutput.BackColor = System.Drawing.Color.Black;
            this.picPictureOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPictureOutput.Location = new System.Drawing.Point(13, 13);
            this.picPictureOutput.Name = "picPictureOutput";
            this.picPictureOutput.Size = new System.Drawing.Size(400, 400);
            this.picPictureOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPictureOutput.TabIndex = 0;
            this.picPictureOutput.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Enabled = false;
            this.lblDescription.Location = new System.Drawing.Point(431, 25);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(434, 42);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(260, 122);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // lblPhotoInfo
            // 
            this.lblPhotoInfo.Location = new System.Drawing.Point(434, 176);
            this.lblPhotoInfo.Name = "lblPhotoInfo";
            this.lblPhotoInfo.Size = new System.Drawing.Size(260, 52);
            this.lblPhotoInfo.TabIndex = 3;
            // 
            // btnAddPhotos
            // 
            this.btnAddPhotos.Enabled = false;
            this.btnAddPhotos.Location = new System.Drawing.Point(437, 244);
            this.btnAddPhotos.Name = "btnAddPhotos";
            this.btnAddPhotos.Size = new System.Drawing.Size(75, 23);
            this.btnAddPhotos.TabIndex = 4;
            this.btnAddPhotos.Text = "Add Photos";
            this.btnAddPhotos.UseVisualStyleBackColor = true;
            this.btnAddPhotos.Click += new System.EventHandler(this.btnAddPhotos_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Enabled = false;
            this.btnPrevious.Location = new System.Drawing.Point(529, 244);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(619, 244);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // grbCanvasColour
            // 
            this.grbCanvasColour.Controls.Add(this.rdbGrey);
            this.grbCanvasColour.Controls.Add(this.rdbWhite);
            this.grbCanvasColour.Controls.Add(this.rdbBlack);
            this.grbCanvasColour.Location = new System.Drawing.Point(437, 297);
            this.grbCanvasColour.Name = "grbCanvasColour";
            this.grbCanvasColour.Size = new System.Drawing.Size(257, 56);
            this.grbCanvasColour.TabIndex = 7;
            this.grbCanvasColour.TabStop = false;
            this.grbCanvasColour.Text = "Canvas Colour";
            // 
            // rdbGrey
            // 
            this.rdbGrey.AutoSize = true;
            this.rdbGrey.Location = new System.Drawing.Point(194, 23);
            this.rdbGrey.Name = "rdbGrey";
            this.rdbGrey.Size = new System.Drawing.Size(47, 17);
            this.rdbGrey.TabIndex = 2;
            this.rdbGrey.Text = "Grey";
            this.rdbGrey.UseVisualStyleBackColor = true;
            this.rdbGrey.CheckedChanged += new System.EventHandler(this.rdbGrey_CheckedChanged);
            // 
            // rdbWhite
            // 
            this.rdbWhite.AutoSize = true;
            this.rdbWhite.Location = new System.Drawing.Point(114, 23);
            this.rdbWhite.Name = "rdbWhite";
            this.rdbWhite.Size = new System.Drawing.Size(53, 17);
            this.rdbWhite.TabIndex = 1;
            this.rdbWhite.Text = "White";
            this.rdbWhite.UseVisualStyleBackColor = true;
            this.rdbWhite.CheckedChanged += new System.EventHandler(this.rdbWhite_CheckedChanged);
            // 
            // rdbBlack
            // 
            this.rdbBlack.AutoSize = true;
            this.rdbBlack.Checked = true;
            this.rdbBlack.Location = new System.Drawing.Point(23, 23);
            this.rdbBlack.Name = "rdbBlack";
            this.rdbBlack.Size = new System.Drawing.Size(52, 17);
            this.rdbBlack.TabIndex = 0;
            this.rdbBlack.TabStop = true;
            this.rdbBlack.Text = "Black";
            this.rdbBlack.UseVisualStyleBackColor = true;
            this.rdbBlack.CheckedChanged += new System.EventHandler(this.rdbBlack_CheckedChanged);
            // 
            // btnCreateAlbum
            // 
            this.btnCreateAlbum.Location = new System.Drawing.Point(437, 373);
            this.btnCreateAlbum.Name = "btnCreateAlbum";
            this.btnCreateAlbum.Size = new System.Drawing.Size(86, 23);
            this.btnCreateAlbum.TabIndex = 8;
            this.btnCreateAlbum.Text = "Create Album";
            this.btnCreateAlbum.UseVisualStyleBackColor = true;
            this.btnCreateAlbum.Click += new System.EventHandler(this.btnCreateAlbum_Click);
            // 
            // btnOpenAlbum
            // 
            this.btnOpenAlbum.Location = new System.Drawing.Point(527, 373);
            this.btnOpenAlbum.Name = "btnOpenAlbum";
            this.btnOpenAlbum.Size = new System.Drawing.Size(86, 23);
            this.btnOpenAlbum.TabIndex = 9;
            this.btnOpenAlbum.Text = "Open Album";
            this.btnOpenAlbum.UseVisualStyleBackColor = true;
            this.btnOpenAlbum.Click += new System.EventHandler(this.btnOpenAlbum_Click);
            // 
            // btnSaveAlbum
            // 
            this.btnSaveAlbum.Enabled = false;
            this.btnSaveAlbum.Location = new System.Drawing.Point(619, 373);
            this.btnSaveAlbum.Name = "btnSaveAlbum";
            this.btnSaveAlbum.Size = new System.Drawing.Size(86, 23);
            this.btnSaveAlbum.TabIndex = 10;
            this.btnSaveAlbum.Text = "Save Album";
            this.btnSaveAlbum.UseVisualStyleBackColor = true;
            this.btnSaveAlbum.Click += new System.EventHandler(this.btnSaveAlbum_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Images";
            this.openFileDialog.Multiselect = true;
            // 
            // PhotoAlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 423);
            this.Controls.Add(this.btnSaveAlbum);
            this.Controls.Add(this.btnOpenAlbum);
            this.Controls.Add(this.btnCreateAlbum);
            this.Controls.Add(this.grbCanvasColour);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnAddPhotos);
            this.Controls.Add(this.lblPhotoInfo);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.picPictureOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PhotoAlbumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo Album";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PhotoAlbumForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picPictureOutput)).EndInit();
            this.grbCanvasColour.ResumeLayout(false);
            this.grbCanvasColour.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPictureOutput;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblPhotoInfo;
        private System.Windows.Forms.Button btnAddPhotos;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox grbCanvasColour;
        private System.Windows.Forms.RadioButton rdbGrey;
        private System.Windows.Forms.RadioButton rdbWhite;
        private System.Windows.Forms.RadioButton rdbBlack;
        private System.Windows.Forms.Button btnCreateAlbum;
        private System.Windows.Forms.Button btnOpenAlbum;
        private System.Windows.Forms.Button btnSaveAlbum;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

