
namespace QR_Code_Generator
{
    partial class QRCodeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRCodeForm));
            this.imageFD = new System.Windows.Forms.OpenFileDialog();
            this.websiteTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imgBtn = new System.Windows.Forms.Button();
            this.imagePic = new System.Windows.Forms.PictureBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.locationSFD = new System.Windows.Forms.SaveFileDialog();
            this.pngRB = new System.Windows.Forms.RadioButton();
            this.jpegRB = new System.Windows.Forms.RadioButton();
            this.pdfRB = new System.Windows.Forms.RadioButton();
            this.clearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagePic)).BeginInit();
            this.SuspendLayout();
            // 
            // imageFD
            // 
            this.imageFD.FileName = "openFileDialog1";
            // 
            // websiteTxt
            // 
            this.websiteTxt.Location = new System.Drawing.Point(243, 125);
            this.websiteTxt.Name = "websiteTxt";
            this.websiteTxt.Size = new System.Drawing.Size(294, 20);
            this.websiteTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Website";
            // 
            // imgBtn
            // 
            this.imgBtn.Location = new System.Drawing.Point(314, 168);
            this.imgBtn.Name = "imgBtn";
            this.imgBtn.Size = new System.Drawing.Size(67, 23);
            this.imgBtn.TabIndex = 2;
            this.imgBtn.Text = "Add Image";
            this.imgBtn.UseVisualStyleBackColor = true;
            this.imgBtn.Click += new System.EventHandler(this.AddImageClick);
            // 
            // imagePic
            // 
            this.imagePic.Location = new System.Drawing.Point(314, 197);
            this.imagePic.Name = "imagePic";
            this.imagePic.Size = new System.Drawing.Size(136, 122);
            this.imagePic.TabIndex = 3;
            this.imagePic.TabStop = false;
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(329, 386);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(102, 23);
            this.generateBtn.TabIndex = 4;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.GenerateClick);
            // 
            // pngRB
            // 
            this.pngRB.AutoSize = true;
            this.pngRB.Checked = true;
            this.pngRB.Location = new System.Drawing.Point(243, 346);
            this.pngRB.Name = "pngRB";
            this.pngRB.Size = new System.Drawing.Size(90, 17);
            this.pngRB.TabIndex = 5;
            this.pngRB.TabStop = true;
            this.pngRB.Text = "Save as PNG";
            this.pngRB.UseVisualStyleBackColor = true;
            // 
            // jpegRB
            // 
            this.jpegRB.AutoSize = true;
            this.jpegRB.Location = new System.Drawing.Point(335, 346);
            this.jpegRB.Name = "jpegRB";
            this.jpegRB.Size = new System.Drawing.Size(94, 17);
            this.jpegRB.TabIndex = 6;
            this.jpegRB.Text = "Save as JPEG";
            this.jpegRB.UseVisualStyleBackColor = true;
            // 
            // pdfRB
            // 
            this.pdfRB.AutoSize = true;
            this.pdfRB.Location = new System.Drawing.Point(427, 346);
            this.pdfRB.Name = "pdfRB";
            this.pdfRB.Size = new System.Drawing.Size(88, 17);
            this.pdfRB.TabIndex = 7;
            this.pdfRB.Text = "Save as PDF";
            this.pdfRB.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(387, 168);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(67, 23);
            this.clearBtn.TabIndex = 8;
            this.clearBtn.Text = "Clear Image";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.ClearImageClick);
            // 
            // QRCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.pdfRB);
            this.Controls.Add(this.jpegRB);
            this.Controls.Add(this.pngRB);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.imagePic);
            this.Controls.Add(this.imgBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.websiteTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QRCodeForm";
            this.Text = "QRCodeForm";
            ((System.ComponentModel.ISupportInitialize)(this.imagePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog imageFD;
        private System.Windows.Forms.TextBox websiteTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button imgBtn;
        private System.Windows.Forms.PictureBox imagePic;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.SaveFileDialog locationSFD;
        private System.Windows.Forms.RadioButton pngRB;
        private System.Windows.Forms.RadioButton jpegRB;
        private System.Windows.Forms.RadioButton pdfRB;
        private System.Windows.Forms.Button clearBtn;
    }
}