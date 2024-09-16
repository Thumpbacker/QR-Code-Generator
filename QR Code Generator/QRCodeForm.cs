using IronBarCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_Code_Generator
{
    public partial class QRCodeForm : Form
    {
        private string imagePath = "";
        private bool hasImage;
        public QRCodeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds an image on button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddImageClick(object sender, EventArgs e)
        {
            //Set the directory
            imageFD.InitialDirectory = "c:\\";
            imageFD.Filter = "png files (*.png)|*.png|jpeg files (*.jpeg)|*.jpeg|pdf files (*.pdf)|*.pdf";
            imageFD.RestoreDirectory = true;

            //Open the dialog
            if(imageFD.ShowDialog() == DialogResult.OK)
            {
                //Set the image path
                imagePath = imageFD.FileName;
                imagePic.Image = Image.FromFile(imagePath);
                hasImage = true;
            }
        }

        /// <summary>
        /// Generates the QR code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateClick(object sender, EventArgs e)
        {
            //Check if the text is a website
            if(websiteTxt.Text.Contains(".com") || websiteTxt.Text.Contains(".net") || websiteTxt.Text.Contains(".gov"))
            {
                GeneratedBarcode qrCode = null;

                //If there is not image selected create a qr code without one
                //Else create a QR code with one
                if(!hasImage)
                {
                    qrCode = QRCodeWriter.CreateQrCode(websiteTxt.Text, 500);
                }
                else
                {
                    qrCode = QRCodeWriter.CreateQrCodeWithLogo(websiteTxt.Text, imagePath, 500);
                }

                //Get a save location
                if(locationSFD.ShowDialog() == DialogResult.OK)
                {
                    //Check to see if it's daved as PNG, JPEG or PDF
                    if (pngRB.Checked)
                    {
                        qrCode.SaveAsPng(locationSFD.FileName + ".png");
                    }
                    else if(jpegRB.Checked)
                    {
                        qrCode.SaveAsJpeg(locationSFD.FileName + ".jpeg");
                    }
                    else if(pdfRB.Checked)
                    {
                        qrCode.SaveAsPdf(locationSFD.FileName + ".pdf");
                    }
                }
                MessageBox.Show("QR code was saved to " + locationSFD.FileName);
            }
            else
            {
                MessageBox.Show("Not a valid website");
            }
        }

        /// <summary>
        /// Clears the image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearImageClick(object sender, EventArgs e)
        {
            hasImage = false;
            imagePic.Image = null;
        }
    }
}
