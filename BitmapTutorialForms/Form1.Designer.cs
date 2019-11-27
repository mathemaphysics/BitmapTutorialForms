using System;
using System.Drawing;
using System.Windows.Forms;

namespace BitmapTutorialForms
{
    partial class Form1
    {
        Bitmap image1;

        private void Button1_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                // Retrieve the image.
                image1 = new Bitmap(@"C:\Documents and Settings\All Users\"
                    + @"Documents\My Music\music.bmp", true);

                int x, y;

                // Loop through the images pixels to reset color.
                for (x = 0; x < image1.Width; x++)
                {
                    for (y = 0; y < image1.Height; y++)
                    {
                        Color pixelColor = image1.GetPixel(x, y);
                        Color newColor = Color.FromArgb(pixelColor.R, 0, 0);
                        image1.SetPixel(x, y, newColor);
                    }
                }

                // Set the PictureBox to display the image.
                PictureBox1.Image = image1;

                // Display the pixel format in Label1.
                Label1.Text = "Pixel format: " + image1.PixelFormat.ToString();

            }
            catch (ArgumentException)
            {
                MessageBox.Show("There was an error." +
                    "Check the path to the image file.");
            }
        }

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
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

