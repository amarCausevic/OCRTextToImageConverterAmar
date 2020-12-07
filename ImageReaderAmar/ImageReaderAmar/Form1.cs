using ImageReaderAmar.Collection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace ImageReaderAmar
{
    public partial class Form1 : Form
    {
        public OpenFileDialog openFileDialog;
        public SaveFileDialog saveFileDialog;
        public float resX;
        public float resY;
        public int width;
        public int height;
        Size size;
        public CustomPopUp customPop;
        public Form1()
        {
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            InitComboBoxLanguage();
            InitPaginationComboBox();
            InitPaginationToolTip();
        }
        public void InitComboBoxLanguage() {
            langComboBox.DataSource = Languages.GetAllAvailableLanguages();
            langComboBox.DisplayMember = "LangPack";
            langComboBox.ValueMember = "LangCode";
        }
        public void InitPaginationComboBox() {
            ocrPaginationComboBox.DataSource = Enum.GetValues(typeof(PageSegMode));
        }

        public void InitPaginationToolTip() {
            toolTipPagination.ShowAlways = true;
            toolTipPagination.SetToolTip(pictureBox1, "Page segmentation method" + Environment.NewLine +
                 "0 - rientation and script detection (OSD) only." + Environment.NewLine +
                 "1 - Automatic page segmentation with OSD." + Environment.NewLine +
                 "2 - Automatic page segmentation, but no OSD, or OCR." + Environment.NewLine +
                 "3 - Fully automatic page segmentation, but no OSD. (Default)" + Environment.NewLine +
                 "4 - Assume a single column of text of variable sizes." + Environment.NewLine +
                 "5 - Assume a single uniform block of vertically aligned text." + Environment.NewLine +
                 "6 - Assume a single uniform block of text." + Environment.NewLine +
                 "7 - Treat the image as a single text line." + Environment.NewLine +
                 "8 - Treat the image as a single word." + Environment.NewLine +
                 "9 - Treat the image as a single word in a circle." + Environment.NewLine +
                 "10 - Treat the image as a single character." + Environment.NewLine +
                 "11 - Sparse text.Find as much text as possible in no particular order." + Environment.NewLine +
                 "12 - Sparse text with OSD." + Environment.NewLine +
                 "13 - Raw line.Treat the image as a single text line, bypassing hacks that are Tesseract - specific." + Environment.NewLine
                ); 
        }
        private void browseBtn_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Monochrome Bitmap|*.bmp";
            openFileDialog.ShowDialog();
            localPathToImage.Text = openFileDialog.FileName;
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(localPathToImage.Text) &&
                langComboBox.SelectedItem != null &&
                langComboBox.SelectedItem != null)
            {
                // Get current Pagination Mode
                PageSegMode selectedPageSegMode = (PageSegMode)ocrPaginationComboBox.SelectedValue;
                // Get current language code
                var itemFromBox = langComboBox.SelectedItem as Languages;
                string currentLangCode = itemFromBox.LangCode;
                // Get text from image
                // Memory leak fixed on 7.12.2020. It wasnt using IDisposable for imageSourceFromExplorer
                using (Bitmap imageSourceFromExplorer = (Bitmap)Bitmap.FromFile(localPathToImage.Text)) {
                    string result = GetTextFromImage(imageSourceFromExplorer, currentLangCode, selectedPageSegMode);
                    txtBoxTextFromIamge.Text = result;
                }
            }
            else
            {
                MessageBox.Show("Please fill all the required fields");
            }
                
        }

        private void ChangeResolutionOfBMP() {
            if (!String.IsNullOrEmpty(localPathToImageDPI.Text) &&
                !String.IsNullOrEmpty(resolutionX.Text) &&
                !String.IsNullOrEmpty(resolutionY.Text) &&
                !String.IsNullOrEmpty(widthInput.Text) &&
                !String.IsNullOrEmpty(heightInput.Text))
            {
                customPop = new CustomPopUp("Resizing Image ...", "Image Scaling");
                customPop.Show();
                customPop.Refresh();
                using (Bitmap bitmap = (Bitmap)Image.FromFile(localPathToImageDPI.Text))
                {
                    width = int.Parse(widthInput.Text);
                    height = int.Parse(heightInput.Text);
                    size = new Size(width, height);
                    using (Bitmap newBPM = new Bitmap(bitmap, size))
                    {
                        resX = float.Parse(resolutionX.Text);
                        resY = float.Parse(resolutionY.Text);
                        if (resX != 0 && resY != 0)
                        {
                            newBPM.SetResolution(resX, resY);
                            saveFileDialog = new SaveFileDialog();
                            saveFileDialog.Filter = "Bitmap image|*.bmp";
                            saveFileDialog.ShowDialog();
                            string saveToPath = saveFileDialog.FileName;
                            newBPM.Save(saveToPath);
                        }
                        else
                        {
                            throw new Exception("X or Y resolution inputs cannot be empty");
                        }
                    }
                }
                customPop.Close();
            }
            else 
            {
                MessageBox.Show("Please fill all the required fields");
            }

        }

        private String GetTextFromImage(Bitmap imageSource, string langCode, PageSegMode pageSegMode) {
            string textFromImage = "";
            customPop = new CustomPopUp("Extracting Text ...", "Converting Image - Text");
            customPop.Show();
            customPop.Refresh();
            using (var engine = new TesseractEngine(@"./tessdata", langCode, EngineMode.TesseractAndLstm))
            {
                using (var img = PixConverter.ToPix(imageSource))
                {
                    using (var page = engine.Process(img, pageSegMode))
                    {
                        textFromImage = page.GetText();
                    }
                }
            }
            customPop.Close();
            return textFromImage;
        }

        private void browseBtnResoltion_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Bitmap image|*.bmp";
            openFileDialog.ShowDialog();
            localPathToImageDPI.Text = openFileDialog.FileName;
            using (Bitmap bitmap = (Bitmap)Image.FromFile(localPathToImageDPI.Text))
            {
                widthInput.Text = bitmap.Width.ToString();
                heightInput.Text = bitmap.Height.ToString();
            }
        }

        private void convertToBMPBtn_Click(object sender, EventArgs e)
        {
            ChangeResolutionOfBMP();
        }

        private void clearResButton_Click(object sender, EventArgs e)
        {
            resolutionX.Text = "";
            resolutionY.Text = "";
            widthInput.Text = "";
            heightInput.Text = "";
            localPathToImageDPI.Text = "";
        }

        private void clearConvertButton_Click(object sender, EventArgs e)
        {
            localPathToImage.Text = "";
            txtBoxTextFromIamge.Text = "";
        }

        private void copyTextButton_Click(object sender, EventArgs e)
        {
            // TO-DO should I di
            if (!string.IsNullOrEmpty(txtBoxTextFromIamge.Text))
            {
                Clipboard.SetText(txtBoxTextFromIamge.Text);
            }
            else {
                MessageBox.Show("Nothing to copy");
            }
        }
    }

}
