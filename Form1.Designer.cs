
namespace Example_2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_SorucePath = new System.Windows.Forms.Label();
            this.TextBox_SourcePath = new System.Windows.Forms.TextBox();
            this.Button_Export = new System.Windows.Forms.Button();
            this.exportDialog = new System.Windows.Forms.SaveFileDialog();
            this.Button_SourcePath = new System.Windows.Forms.Button();
            this.ImportDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // Label_SorucePath
            // 
            this.Label_SorucePath.AutoSize = true;
            this.Label_SorucePath.Location = new System.Drawing.Point(12, 22);
            this.Label_SorucePath.Name = "Label_SorucePath";
            this.Label_SorucePath.Size = new System.Drawing.Size(69, 12);
            this.Label_SorucePath.TabIndex = 0;
            this.Label_SorucePath.Text = "조회할 폴더";
            // 
            // TextBox_SourcePath
            // 
            this.TextBox_SourcePath.AllowDrop = true;
            this.TextBox_SourcePath.Location = new System.Drawing.Point(91, 17);
            this.TextBox_SourcePath.Name = "TextBox_SourcePath";
            this.TextBox_SourcePath.Size = new System.Drawing.Size(601, 21);
            this.TextBox_SourcePath.TabIndex = 1;
            this.TextBox_SourcePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.TextBox_SourcePath.DragOver += new System.Windows.Forms.DragEventHandler(this.textBox1_DragOver);
            // 
            // Button_Export
            // 
            this.Button_Export.Location = new System.Drawing.Point(325, 50);
            this.Button_Export.Name = "Button_Export";
            this.Button_Export.Size = new System.Drawing.Size(89, 20);
            this.Button_Export.TabIndex = 4;
            this.Button_Export.Text = "내보내기";
            this.Button_Export.UseVisualStyleBackColor = true;
            this.Button_Export.Click += new System.EventHandler(this.button1_Click);
            // 
            // exportDialog
            // 
            this.exportDialog.DereferenceLinks = false;
            this.exportDialog.Filter = "텍스트 파일 (*.txt) | *.txt|모든 파일 (*.*) | *.*";
            this.exportDialog.Title = "출력할 경로를 지정해주세요";
            // 
            // Button_SourcePath
            // 
            this.Button_SourcePath.Location = new System.Drawing.Point(704, 17);
            this.Button_SourcePath.Name = "Button_SourcePath";
            this.Button_SourcePath.Size = new System.Drawing.Size(89, 20);
            this.Button_SourcePath.TabIndex = 5;
            this.Button_SourcePath.Text = "경로";
            this.Button_SourcePath.UseVisualStyleBackColor = true;
            this.Button_SourcePath.Click += new System.EventHandler(this.Button_SourcePath_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 82);
            this.Controls.Add(this.Button_SourcePath);
            this.Controls.Add(this.Button_Export);
            this.Controls.Add(this.TextBox_SourcePath);
            this.Controls.Add(this.Label_SorucePath);
            this.Name = "Form1";
            this.Text = "예제";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_SorucePath;
        private System.Windows.Forms.TextBox TextBox_SourcePath;
        private System.Windows.Forms.Button Button_Export;
        private System.Windows.Forms.SaveFileDialog exportDialog;
        private System.Windows.Forms.Button Button_SourcePath;
        private System.Windows.Forms.FolderBrowserDialog ImportDialog;
    }
}

