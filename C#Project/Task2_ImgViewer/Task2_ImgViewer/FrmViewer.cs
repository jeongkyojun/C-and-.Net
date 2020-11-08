using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2_ImgViewer
{
    public partial class FrmViewer : Form
    {
        private Int32 m_nSelLabel { get; set; }
        private int m_nCnt { get; set; }
        public FrmViewer()
        {
            InitializeComponent();
        }

        private int SetDrive()
        {
            String[] strDrives;
            String strTmp;

            // Up항목을 추가한다.
            lstDir.Items.Add("..", 0);

            // 드라이브 목록을 얻는다.
            strDrives = System.IO.Directory.GetLogicalDrives();

            // 얻어진 드라이브 목록을 리스트뷰에 입력한다.
            foreach(string str in strDrives)
            {
                strTmp = str.Remove(2,1);
                lstDir.Items.Add(strTmp, 1);
            }
            return lstDir.Items.Count;
        }

        // 하위 폴더를 화면에 출력한다.
        // 반환값 : 성공, 실패
        private bool SetFolder(String strParentPath)
        {
            MessageBox.Show(strParentPath);
            System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo(strParentPath);
            // 리스트뷰의 아이템을 모두 삭제한 후
            lstDir.Items.Clear();
            // 드라이브 정보를 보여준다.
            m_nCnt = SetDrive();
            lblPath.Text = "";
            try
            {
                foreach (System.IO.DirectoryInfo dirInfoCurDir in dirInfo.GetDirectories("*"))
                {
                    lstDir.Items.Add(dirInfoCurDir.Name.ToString(), 2);
                }
                lblPath.Text = strParentPath.Remove(strParentPath.Length - 1, 1);
            }
            catch
            {
                MessageBox.Show("접근에 실패하였습니다.");
                return false;
            }
            return true;
        }

        // 리스트뷰 더블클릭
        // 폴더/드라이브 변경 처리
        private void lstDir_DoubleClick(object sender, EventArgs e)
        {
            int nSel;
            String strSelText;
            String strTmp;
            
            // 선택된 항목의 텍스트와 인덱스를 얻는다.
            nSel = lstDir.SelectedItems[0].Index;
            strSelText = lstDir.SelectedItems[0].SubItems[0].Text;
            m_nSelLabel = -1;
            picSelect.Image = null;

            if (nSel == 0)//위로
            {
                int nStart;
                nStart = lblPath.Text.LastIndexOf("\\");
                if (nStart == -1)
                {
                    return;
                }

                strTmp = lblPath.Text.Remove(nStart, lblPath.Text.Length - nStart) + "\\";
            }
            else if (m_nCnt > nSel)
            {
                strTmp = strSelText + "\\";
            }
            else
                strTmp = lblPath.Text + "\\" + strSelText + "\\";

            // 하위 폴더를 보여준다.

            if (SetFolder(strTmp))
            {
                SetImgFile(strTmp);
            }
            // 툴팁 연결
            tipPath.SetToolTip(lblPath, lblPath.Text);
        }
        private void SetImgFile(String strParentPath)
        {
            System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo(strParentPath);
            int nCnt;
            splitContainer1.Panel2.Controls.Clear();
            nCnt = 0;

            try
            {
                foreach(System.IO.FileInfo fileInfo in dirInfo.GetFiles("*.*"))
                {
                    if(IsImgFile(fileInfo.Extension))
                    {
                        MakePicCtrl(nCnt, fileInfo.FullName);
                        nCnt += 1;
                        MakeLblCtrl(nCnt, fileInfo.Name);
                        nCnt += 1;
                        Application.DoEvents();
                    }
                }
                lblPath.Text = strParentPath.Remove(strParentPath.Length - 1, 1);
            }
            catch
            {

            }
        }

        private bool IsImgFile(String strExi)
        {
            //확장자를 통해 그림파일의 유무를 파악한다.
            //BMP,WMF,EMF,ICO,JPG,Gif,PNG
            String strTmp;
            strTmp = strExi.ToUpper();
            if (strTmp.IndexOf(".BMP") != -1)
                return true;
            else if (strTmp.IndexOf(".WMF") != -1)
                return true;
            else if (strTmp.IndexOf(".EMF") != -1)
                return true;
            else if (strTmp.IndexOf(".ICO") != -1)
                return true;
            else if (strTmp.IndexOf(".JPG") != -1)
                return true;
            else if (strTmp.IndexOf(".GIF") != -1)
                return true;
            else if (strTmp.IndexOf(".PNG") != -1)
                return true;
            else
                return false;
        }

        private void MakePicCtrl(int nIndex, String strFilePath)
        {
            //픽처박스 컨트롤을 생성한다.
            PictureBox pic = new PictureBox();
            Point pos;

            pic.Name = "pic" + nIndex.ToString();// 이름
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Tag = nIndex.ToString();
            pic.Size = new Size(80, 80);

            GetPos(nIndex, out pos);

            pic.Location = pos;
            pic.BorderStyle = BorderStyle.FixedSingle; 
            splitContainer1.Panel2.Controls.Add(pic); // splitContainer1의 Panel2에 패널을 추가

            try
            {
                pic.Image = System.Drawing.Bitmap.FromFile(strFilePath); // 그림 보여주기
            }
            catch
            {
                pic.Image = null;
            }

            // 클릭/더블클릭 이벤트와 연결
            pic.Click += new System.EventHandler(Ctrl_Click);
            pic.DoubleClick += new System.EventHandler(Ctrl_DoubleClick);
        }
        private void MakeLblCtrl(int nIndex, String strFilePath)
        {
            //픽처박스 컨트롤을 생성한다.
            Label lbl = new Label();
            Point pos;

            lbl.Name = "lbl" + nIndex.ToString();// 이름
            lbl.Tag = nIndex.ToString();
            lbl.Size = new Size(80, 80);

            GetPos(nIndex, out pos);

            lbl.Location = pos;
            lbl.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Panel2.Controls.Add(lbl); // splitContainer1의 Panel2에 패널을 추가

            try
            {
                lbl.Image = System.Drawing.Bitmap.FromFile(strFilePath); // 그림 보여주기
            }
            catch
            {
                lbl.Image = null;
            }

            // 클릭/더블클릭 이벤트와 연결
            lbl.Click += new System.EventHandler(Ctrl_Click);
            lbl.DoubleClick += new System.EventHandler(Ctrl_DoubleClick);
        }
        private void GetPos(int nIndex, out Point pos)
        {
            pos = new Point();
            Size sizePan = new Size(splitContainer1.Panel2.Width, splitContainer1.Panel2.Height);
            int nXCnt;
            int i;

            if(nIndex %2 ==0) // 픽처박스 컨트롤 일 경우
            {
                nXCnt = (int)(sizePan.Width / 85);
                if(nXCnt <= 0)
                {
                    return;
                }

                i = (int)(nIndex / 2) % nXCnt;
                pos.X = (i * 80) + (5 * i) + 5;
                i = (int)((nIndex / 2) / nXCnt);
                pos.Y = (i * 80) + (35 * i) + 5;
            }
            else // 라벨 컨트롤일 경우
            {
                nXCnt = (int)(sizePan.Width/85);
                if (nXCnt <= 0)
                    return;
                i = (int)(nIndex / 2) & nXCnt;
                pos.X = (i * 80) + (5 * i) + 5;
                i = (int)((nIndex / 2) / nXCnt);
                pos.Y = (i * 80) + (35 * i) + 5 + 82;
            }
        }

        private void Ctrl_Click(object sender, EventArgs e)
        {
            PictureBox pic;
            Label lbl;
            // 어떤것을 클릭했는지 확인

            // 1. 클릭한 컨트롤이 픽쳐박스 컨트롤인 경우
            if(sender.GetType().Name.IndexOf("PictureBox")!=-1)
            {
                pic = (System.Windows.Forms.PictureBox)sender;

                // 라벨 컨트롤을 얻는다.
                lbl = (System.Windows.Forms.Label)GetCtrl("Label",Convert.ToInt32(pic.Tag)+1);
            }
            else// 2. 클릭한 컨트롤이 라벨 컨트롤일 경우
            {
                lbl = (System.Windows.Forms.Label)sender;

                // 픽쳐박스 컨트롤을 얻는다.
                pic = (System.Windows.Forms.PictureBox)GetCtrl("PictureBox", Convert.ToInt32(lbl.Tag) - 1);
            }
            // 클릭한 픽쳐박스의 내용을 picSelect에 보여준다.
            picSelect.Image = pic.Image;

            // 선택한 라벨 컨트롤의 색을 노란색으로 한다.
            lbl.BackColor = Color.Yellow;

            // 이전에 선택한 라벨 컨트롤의 색을 GreenYellow로 한다.
            if (m_nSelLabel != -1 && m_nSelLabel != Convert.ToInt32(lbl.Tag))
            {
                GetCtrl("Label", m_nSelLabel).BackColor = Color.GreenYellow;
            }
            m_nSelLabel = Convert.ToInt32(lbl.Tag);
        }
        private Control GetCtrl(String strCtrlName, int nTag)
        {
            Control.ControlCollection myCtrl = splitContainer1.Panel2.Controls;
            
            foreach(Control ctrl in myCtrl)
            {
                //컨트롤 종류가 일치하고
                if(ctrl.GetType().Name.IndexOf(strCtrlName) != -1)
                {
                    // 태그가 일치하면
                    if(Convert.ToInt32(ctrl.Tag.ToString())==nTag)
                    {
                        return ctrl;
                    }
                }
            }

            // 일치하지 않는경우 null 반환
            return null;
        }
        private void Ctrl_DoubleClick(object sender, EventArgs e)
        {
            PictureBox pic;
            Label lbl;

            if(sender.GetType().Name.IndexOf("PictureBox")!=-1) // 클릭한 컨트롤이 픽쳐박스일 경우
            {
                pic = (System.Windows.Forms.PictureBox)sender;

                //라벨 컨트롤을 얻는다.
                lbl = (System.Windows.Forms.Label)GetCtrl("Label", Convert.ToInt32(pic.Tag) + 1);
            }
            else// 클릭한 컨트롤이 라벨일 경우
            {
                lbl = (System.Windows.Forms.Label)sender;
            }

            //폼을 생성한다.
            Task2_ImgViewer.FrmSelect dlg = new Task2_ImgViewer.FrmSelect();
            Size sizePic = new Size();

            //폼의 캡션을 그림의 전체 경로로 한다.
            dlg.Text = "그림 선택-" + lblPath.Text + "\\" + lbl.Text;
            //선택한 그림을 picSel에 보여준다.
            dlg.picSel.Image = System.Drawing.Bitmap.FromFile(lblPath.Text + "\\" + lbl.Text);

            //폼의 크기를 적당히 조절한다.
            sizePic = dlg.picSel.Size;
            sizePic.Height += 30;
            sizePic.Width += 15;

            dlg.Size = sizePic;
            dlg.picSel.Location = new Point(5, 5);

            // 폼을 모달 형태로 보여준다.
            dlg.ShowDialog();
        }

        private void MovePicCtrl()
        {
            int i = 0;
            Point pos;

            Control.ControlCollection myCtrl = splitContainer1.Panel2.Controls;

            foreach (Control ctrl in myCtrl)
            {
                GetPos(i, out pos);
                ctrl.Location = pos;
                i++;
            }
        }
        private void splitContainer1_Panel2_SizedChanged(object sender, EventArgs e)
        {
            MovePicCtrl();
        }

        private void FrmViewer_Load(object sender, EventArgs e)
        {
            SetDrive();
        }
    }
    
}
