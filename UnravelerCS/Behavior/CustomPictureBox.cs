using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using UnravelerCS.Data;

namespace UnravelerCS.Behavior
{
    public partial class CustomPictureBox : PictureBox
    {
        #region Image
        public void ShowPage(int number)
        {
            if (ImageList.Count <= number)
            {
                return;
            }
            var imgconv = new ImageConverter();

            Image?.Dispose();
            Image = (Image)imgconv.ConvertFrom(ImageList[number]);
        }
        #endregion

        #region PDF
        private void LoadPDF(string filename)
        {
            ImageList.Clear();
            using (var reader = new PdfReader(filename))
            {
                var parser = new PdfReaderContentParser(reader);
                var listener = new RenderListener();

                for (int pageNumber = 1; pageNumber <= reader.NumberOfPages; pageNumber++)
                {
                    parser.ProcessContent(pageNumber, listener);
                }
                ImageList.AddRange(listener.Images);
            }
            ShowPage(0);
        }
        #endregion

        #region Begin/End
        public CustomPictureBox()
        {
            InitializeComponent();
            SizeMode = PictureBoxSizeMode.Zoom;
        }
        #endregion

        #region Attributes
        public PageInfo Page
        {
            set
            {
                LoadPDF(value.Filename);
            }
        }
        public List<byte[]> ImageList = new List<byte[]>();
        #endregion
    }

    class RenderListener : IRenderListener
    {

        public void BeginTextBlock() { }
        public void RenderText(TextRenderInfo renderInfo) { }
        public void EndTextBlock() { }

        public void RenderImage(ImageRenderInfo renderInfo)
        {
            var image = renderInfo.GetImage();

            using (var stream = new MemoryStream(image.GetImageAsBytes()))
            {
                Images.Add(stream.ToArray());
            }
        }

        #region Attributes
        public List<byte[]> Images = new List<byte[]>();
        #endregion
    }
}
