namespace PhotoAlbum
{
    partial class SaveForm
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
            this.lblSaveText = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDontSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSaveText
            // 
            this.lblSaveText.AutoSize = true;
            this.lblSaveText.Location = new System.Drawing.Point(21, 19);
            this.lblSaveText.Name = "lblSaveText";
            this.lblSaveText.Size = new System.Drawing.Size(292, 13);
            this.lblSaveText.TabIndex = 0;
            this.lblSaveText.Text = "Would you like to save your current project before closing it?";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnSave.Location = new System.Drawing.Point(24, 44);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDontSave
            // 
            this.btnDontSave.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnDontSave.Location = new System.Drawing.Point(136, 44);
            this.btnDontSave.Name = "btnDontSave";
            this.btnDontSave.Size = new System.Drawing.Size(72, 23);
            this.btnDontSave.TabIndex = 2;
            this.btnDontSave.Text = "Don\'t Save";
            this.btnDontSave.UseVisualStyleBackColor = true;
            this.btnDontSave.Click += new System.EventHandler(this.btnDontSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(241, 44);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 84);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDontSave);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSaveText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Save";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaveText;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDontSave;
        private System.Windows.Forms.Button btnCancel;
    }
}