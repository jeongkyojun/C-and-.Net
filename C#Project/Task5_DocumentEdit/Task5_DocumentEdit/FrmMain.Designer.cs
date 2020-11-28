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
            this.imglstTree = new System.Windows.Forms.ImageList(this.components);
            this.fileDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveDlg = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileResave = new System.Windows.Forms.ToolStripMenuItem();
            this.구분선ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.MenuFileEnd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditPast = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeText = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMain = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.삭제LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuEditAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuEditDown = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditUp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSearchFind = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSearchReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imglstTree
            // 
            this.imglstTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstTree.ImageStream")));
            this.imglstTree.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstTree.Images.SetKeyName(0, "root.bmp");
            this.imglstTree.Images.SetKeyName(1, "text.bmp");
            this.imglstTree.Images.SetKeyName(2, "seltext.bmp");
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuEdit,
            this.MenuSearch});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFileNew,
            this.MenuFileOpen,
            this.MenuFileSave,
            this.MenuFileResave,
            this.구분선ToolStripMenuItem,
            this.MenuFileEnd});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(70, 24);
            this.MenuFile.Text = "파일(&F)";
            // 
            // MenuFileNew
            // 
            this.MenuFileNew.Name = "MenuFileNew";
            this.MenuFileNew.Size = new System.Drawing.Size(242, 26);
            this.MenuFileNew.Text = "새로 만들기(&N)";
            // 
            // MenuFileOpen
            // 
            this.MenuFileOpen.Name = "MenuFileOpen";
            this.MenuFileOpen.Size = new System.Drawing.Size(242, 26);
            this.MenuFileOpen.Text = "열기(&O)";
            // 
            // MenuFileSave
            // 
            this.MenuFileSave.Name = "MenuFileSave";
            this.MenuFileSave.Size = new System.Drawing.Size(242, 26);
            this.MenuFileSave.Text = "저장(&S)";
            // 
            // MenuFileResave
            // 
            this.MenuFileResave.Name = "MenuFileResave";
            this.MenuFileResave.Size = new System.Drawing.Size(242, 26);
            this.MenuFileResave.Text = "다른 이름으로 저장(&A)";
            // 
            // 구분선ToolStripMenuItem
            // 
            this.구분선ToolStripMenuItem.Name = "구분선ToolStripMenuItem";
            this.구분선ToolStripMenuItem.Size = new System.Drawing.Size(239, 6);
            // 
            // MenuFileEnd
            // 
            this.MenuFileEnd.Name = "MenuFileEnd";
            this.MenuFileEnd.Size = new System.Drawing.Size(242, 26);
            this.MenuFileEnd.Text = "종료(&E)";
            // 
            // MenuEdit
            // 
            this.MenuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuEditCut,
            this.MenuEditCopy,
            this.MenuEditPast,
            this.삭제LToolStripMenuItem,
            this.toolStripMenuItem1,
            this.MenuEditAll,
            this.MenuEditTime,
            this.toolStripMenuItem2,
            this.MenuEditDown,
            this.MenuEditUp});
            this.MenuEdit.Name = "MenuEdit";
            this.MenuEdit.Size = new System.Drawing.Size(71, 24);
            this.MenuEdit.Text = "편집(&E)";
            // 
            // MenuEditCut
            // 
            this.MenuEditCut.Name = "MenuEditCut";
            this.MenuEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.MenuEditCut.Size = new System.Drawing.Size(228, 26);
            this.MenuEditCut.Text = "잘라내기(&T)";
            // 
            // MenuEditCopy
            // 
            this.MenuEditCopy.Name = "MenuEditCopy";
            this.MenuEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.MenuEditCopy.Size = new System.Drawing.Size(228, 26);
            this.MenuEditCopy.Text = "복사(&C)";
            // 
            // MenuEditPast
            // 
            this.MenuEditPast.Name = "MenuEditPast";
            this.MenuEditPast.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.MenuEditPast.Size = new System.Drawing.Size(228, 26);
            this.MenuEditPast.Text = "붙여넣기(&P)";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
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
            this.splitContainer1.Size = new System.Drawing.Size(800, 422);
            this.splitContainer1.SplitterDistance = 167;
            this.splitContainer1.TabIndex = 1;
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
            this.treeText.Size = new System.Drawing.Size(165, 399);
            this.treeText.TabIndex = 1;
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
            // 삭제LToolStripMenuItem
            // 
            this.삭제LToolStripMenuItem.Name = "삭제LToolStripMenuItem";
            this.삭제LToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.삭제LToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.삭제LToolStripMenuItem.Text = "삭제(&L)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(225, 6);
            // 
            // MenuEditAll
            // 
            this.MenuEditAll.Name = "MenuEditAll";
            this.MenuEditAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.MenuEditAll.Size = new System.Drawing.Size(228, 26);
            this.MenuEditAll.Text = "전체선택(&A)";
            // 
            // MenuEditTime
            // 
            this.MenuEditTime.Name = "MenuEditTime";
            this.MenuEditTime.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.MenuEditTime.Size = new System.Drawing.Size(228, 26);
            this.MenuEditTime.Text = "시간/날짜(&D)";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(225, 6);
            // 
            // MenuEditDown
            // 
            this.MenuEditDown.Name = "MenuEditDown";
            this.MenuEditDown.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.MenuEditDown.Size = new System.Drawing.Size(228, 26);
            this.MenuEditDown.Text = "소문자로(&K)";
            // 
            // MenuEditUp
            // 
            this.MenuEditUp.Name = "MenuEditUp";
            this.MenuEditUp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.MenuEditUp.Size = new System.Drawing.Size(228, 26);
            this.MenuEditUp.Text = "대문자로(&U)";
            // 
            // MenuSearch
            // 
            this.MenuSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSearchFind,
            this.MenuSearchReplace});
            this.MenuSearch.Name = "MenuSearch";
            this.MenuSearch.Size = new System.Drawing.Size(71, 24);
            this.MenuSearch.Text = "찾기(&S)";
            // 
            // MenuSearchFind
            // 
            this.MenuSearchFind.Name = "MenuSearchFind";
            this.MenuSearchFind.Size = new System.Drawing.Size(224, 26);
            this.MenuSearchFind.Text = "찾기(&F)";
            // 
            // MenuSearchReplace
            // 
            this.MenuSearchReplace.Name = "MenuSearchReplace";
            this.MenuSearchReplace.Size = new System.Drawing.Size(224, 26);
            this.MenuSearchReplace.Text = "바꾸기(&S)";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imglstTree;
        private System.Windows.Forms.OpenFileDialog fileDlg;
        private System.Windows.Forms.SaveFileDialog saveDlg;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuFileNew;
        private System.Windows.Forms.ToolStripMenuItem MenuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuFileSave;
        private System.Windows.Forms.ToolStripMenuItem MenuFileResave;
        private System.Windows.Forms.ToolStripSeparator 구분선ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuFileEnd;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem MenuEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuEditCut;
        private System.Windows.Forms.ToolStripMenuItem MenuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem MenuEditPast;
        private System.Windows.Forms.ToolStripMenuItem 삭제LToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuEditAll;
        private System.Windows.Forms.ToolStripMenuItem MenuEditTime;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MenuEditDown;
        private System.Windows.Forms.ToolStripMenuItem MenuEditUp;
        private System.Windows.Forms.ToolStripMenuItem MenuSearch;
        private System.Windows.Forms.ToolStripMenuItem MenuSearchFind;
        private System.Windows.Forms.ToolStripMenuItem MenuSearchReplace;
    }
}

