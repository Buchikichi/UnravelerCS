using System.Data;
using System.Linq;
using System.Windows.Forms;
using UnravelerCS.Data;

namespace UnravelerCS
{
    public partial class MainForm : Form
    {
        #region FileListBox
        private void AddPage(string filename)
        {
            FileListBox.Items.Add(new PageInfo
            {
                Filename = filename,
            });
        }

        private void SelectLatestItem()
        {
            var count = FileListBox.Items.Count;

            if (count == 0)
            {
                return;
            }
            var page = (PageInfo)FileListBox.Items[count - 1];

            FileListBox.SelectedItem = page;
        }

        private void FileListBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                return;
            }
            e.Effect = DragDropEffects.Copy;
        }

        private void FileListBox_DragDrop(object sender, DragEventArgs e)
        {
            var nameList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            var pdfList = nameList.Where(str => str.ToLower().EndsWith(".pdf"))
                .ToList();

            pdfList.ForEach(jpg => AddPage(jpg));
            SelectLatestItem();
        }
        #endregion

        #region Begin/End
        private void Initialize()
        {
            CloseButton.Click += (sender, e) => Close();
        }

        public MainForm()
        {
            InitializeComponent();
            Load += (sender, e) => Initialize();
        }
        #endregion
    }
}
