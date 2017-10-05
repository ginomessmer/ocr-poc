using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace OcrPoc
{
    public partial class OcrForm : Form
    {
        public string TessdataDirectoryPath { get; set; }
        public string OcrLocale { get; set; }

        public OcrForm()
        {
            InitializeComponent();
        }

        private void cmdSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var path = dialog.FileName;
                FileInfo file = new FileInfo(path);

                string filePath = file.FullName;

                imgInput.ImageLocation = filePath;
                ReadTextFromImage(filePath);
            }
        }

        private void ReadTextFromImage(string path)
        {
            if(!String.IsNullOrEmpty(this.TessdataDirectoryPath))
            {
                try
                {
                    using (var tesseract = new TesseractEngine(this.TessdataDirectoryPath, this.OcrLocale))
                    {
                        using (var img = Pix.LoadFromFile(path))
                        {
                            using (var page = tesseract.Process(img))
                            {
                                var text = page.GetText();
                                txtOutput.Text = text;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "There has been an error while processing the image");
                }
            }
            else
            {
                MessageBox.Show("tessdata path hasn't been set yet. Make sure to set it first before attempting to scan images.");
            }
        }

        private void cmdBrowseTessdataDir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                this.TessdataDirectoryPath = dialog.FileName;
                FileInfo file = new FileInfo(TessdataDirectoryPath);

                this.TessdataDirectoryPath = file.DirectoryName;
                this.OcrLocale = file.Name.Replace($"{file.Extension}", null);

                txtTessdataDir.Text = this.TessdataDirectoryPath;
                txtLanguage.Text = this.OcrLocale;
            }
        }
    }
}
