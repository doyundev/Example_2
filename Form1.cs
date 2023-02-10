using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Example_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 읽을 파일(폴더) 경로 가져오기
        // 파일을 끌어서 마우스 위로 올렸을 때의 동작을 작성함
        private void textBox1_DragOver(object sender, DragEventArgs e)
        {
            // 파일을 드롭할 때, 마우스 포인터 모양 바꾸기임
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        // 파일을 드래그 해서 드롭 했을 때 동작을 작성함
        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            // 드롭한 파일의 경로를 
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (files != null && files.Any())
            {
                TextBox_SourcePath.Text = files.First();
            }
        }

        private void Button_SourcePath_Click(object sender, EventArgs e)
        {
            ShowImportDialog();
        }

        private void ShowImportDialog()
        {
            DialogResult result = this.ImportDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                // 파일 경로를 읽어서 텍스트 박스에 집어넣는다.
                string importPath = ImportDialog.SelectedPath;
                TextBox_SourcePath.Text = importPath;
            }
        }
        #endregion

        // 내보내기 버튼을 클릭했을 때의 동작을 작성함
        private void button1_Click(object sender, EventArgs e)
        {
            ShowExportDialog();
        }

        private void ShowExportDialog()
        {
            DialogResult result = this.exportDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string importPath = TextBox_SourcePath.Text;
                if (Directory.Exists(importPath) == true)
                {
                    string[] files = Directory.GetFiles(importPath);
                    for (int i = 0; i < files.Length; ++i)
                    {
                        files[i] = Path.GetFileName(files[i]);
                    }

                    string textFileContents = string.Join("\t", files);
                    textFileContents = "블라블라" + "(" + textFileContents + ")";

                    string exportPath = exportDialog.FileName;
                    File.WriteAllText(exportPath, textFileContents);

                    MessageBox.Show("완료", "오...");
                }
            }
        }
    }
}
