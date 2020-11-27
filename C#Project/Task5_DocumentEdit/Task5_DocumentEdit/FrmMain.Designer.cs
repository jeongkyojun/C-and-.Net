namespace Task5_DocumentEdit
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeText = new System.Windows.Forms.TreeView();
            this.imglstTree = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtMain = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fileDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveDlg = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Panel1.Controls.Add(this.treeText);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Panel2.Controls.Add(this.txtMain);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 167;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeText
            // 
            this.treeText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeText.HideSelection = false;
            this.treeText.ImageIndex = 0;
            this.treeText.ImageList = this.imglstTree;
            this.treeText.Location = new System.Drawing.Point(0, 21);
            this.treeText.Name = "treeText";
            this.treeText.SelectedImageIndex = 0;
            this.treeText.Size = new System.Drawing.Size(165, 427);
            this.treeText.TabIndex = 1;
            // 
            // imglstTree
            // 
            this.imglstTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstTree.ImageStream")));
            this.imglstTree.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstTree.Images.SetKeyName(0, "root.bmp");
            this.imglstTree.Images.SetKeyName(1, "text.bmp");
            this.imglstTree.Images.SetKeyName(2, "seltext.bmp");
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "문서목록";
            // 
            // txtMain
            // 
            this.txtMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMain.HideSelection = false;
            this.txtMain.Location = new System.Drawing.Point(0, 21);
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(627, 18);
            this.txtMain.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(627, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "이름";
            // 
            // fileDlg
            // 
            this.fileDlg.FileName = "openFileDialog1";
            this.fileDlg.Filter = "\"txt files (*.txt)|*.txt|All files (*.*)|*.*\"";
            // 
            // saveDlg
            // 
            this.saveDlg.Filter = "\"txt files (*.txt)|*.txt|All files (*.*)|*.*\"";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imglstTree;
        private System.Windows.Forms.OpenFileDialog fileDlg;
        private System.Windows.Forms.SaveFileDialog saveDlg;
    }
}

