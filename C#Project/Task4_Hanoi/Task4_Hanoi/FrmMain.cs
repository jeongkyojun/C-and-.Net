using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4_Hanoi
{
    public partial class FrmMain : Form
    {
        const int BLOCK_START_X = 10;
        const int BLOCK_START_Y = 200;
        const int BLOCK_WIDTH = 160;
        const int BLOCK_HEIGHT = 30;

        private String m_strDragTag { get; set; }
        private int m_nMoveCnt { get; set; }
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            InitHanoi(Convert.ToInt32(nudCnt.Value));
        }

        private void InitHanoi(int nIndex)
        {
            panLeft.Controls.Clear();
            panRight.Controls.Clear();
            panCenter.Controls.Clear();

            m_nMoveCnt = 0;
            lblCnt.Text = m_nMoveCnt.ToString() + "번";
            for (int i = 0; i < nIndex; i++)
            {
                MakeBlock(panLeft, i, i, false);
            }
        }
        // picturebox 생성
        // pan 컨트롤 추가
        private void MakeBlock(Panel pan, int nIndex, int nImage, bool bMoving)
        {
            PictureBox pic;
            int i;
            pic = new PictureBox();
            pan.Controls.Add(pic);

            pic.Size = new Size(BLOCK_WIDTH, BLOCK_HEIGHT);
            pic.Location = new Point(BLOCK_START_X, 0);
            pic.SizeMode = PictureBoxSizeMode.CenterImage;
            pic.BackColor = Color.FromArgb(213, 236, 253);

            // 조건에 맞는 이미지 저장
            pic.Image = new Bitmap(GetType(), "h" + nImage.ToString() + ".bmp");

            // tag 값은 가장 아래에 있는 컨트롤이 0이 된다.
            // 앞자리는 panLeft : 0 , panCenter : 1 , PanRight : 2 가 된다.
            if (pan == panLeft)
                pic.Tag = "0" + nImage.ToString();
            else if (pan == panCenter)
                pic.Tag = "1" + nImage.ToString();
            else
                pic.Tag = "2" + nImage.ToString();

            //pic를 제 위치로 이동시킨다.
            //(위에서 아래로 떨어지는 효과)
            if(bMoving)
            {
                for(i=0;i <= BLOCK_START_Y - (nIndex*BLOCK_HEIGHT);i+=2)
                {
                    pic.Location = new Point(BLOCK_START_X,i);
                    Application.DoEvents();
                }
            }
            else
                pic.Location = new Point(BLOCK_START_X, BLOCK_START_Y - (nIndex * BLOCK_HEIGHT));

            //pic.MouseDown += new System.EventHandler(pic.MouseDown);
            pic.MouseDown += new MouseEventHandler(pic_MouseDown);
        }

        //동적 생성 컨트롤의 클릭/ 더블클릭 이벤트
        // pic 마우스다운 이벤트
        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            if (isGameEnd(Convert.ToInt32(nudCnt.Value))) return;

            if (e.Button == MouseButtons.Left)
            {
                PictureBox pic = (PictureBox)sender;

                //invoke the drag and drop operation
                if (isDragPic(pic))
                {
                    m_strDragTag = pic.Tag.ToString();

                    // 우선 모든 Panel의 AllowDrop을 true로 한다.
                    panLeft.AllowDrop = true;
                    panCenter.AllowDrop = true;
                    panRight.AllowDrop = true;

                    // 현재 클릭한 pic의 부모 panel은 false로 한다.
                    GetPanCtrl(pic.Tag.ToString()).AllowDrop = false;

                    pic.DoDragDrop(pic.Image, DragDropEffects.Move);
                }
                else
                    m_strDragTag = "";
            }
        }

        private bool isDragPic(PictureBox pic)
        {
            int i, nMax;
            Panel pan;

            pan = GetPanCtrl(pic.Tag.ToString());
            nMax = -1;

            // 패널에 있는 pic 컨트롤의 최대 수(두번째 자리수)를 구한다.
            for(i = 0; i<pan.Controls.Count;i++)
            {
                if (Convert.ToInt32(pan.Controls[i].Tag.ToString().Substring(1, 1)) > nMax)
                    nMax = Convert.ToInt32(pan.Controls[i].Tag.ToString().Substring(1, 1));
            }

            // 비교값이 컨트롤의 tag와 같으면 true이다.
            if (nMax == Convert.ToInt32(pic.Tag.ToString().Substring(1, 1)))
                return true;
            else
                return false;
        }

        private bool isGameEnd(int nCnt)
        {
            // 오른쪽 Panel에 블럭 갯수가 전체 블럭 갯수와 같으면 끝
            if (panRight.Controls.Count == nCnt)
                return true;
            else
            {
                if (panCenter.Controls.Count == nCnt)
                    return true;
                return false;
            }
        }

        // 블록 제거
        // 옮겨진 pic(블럭)을 삭제한다.
        private void RemoveBlock(String strTag)
        {
            Panel pan;
            int i;
            pan = GetPanCtrl(strTag);

            //Tag 값을 비교해 삭제 한다.
            for(i=0;i<pan.Controls.Count; i++)
            {
                if (pan.Controls[i].Tag.ToString().Equals(strTag))
                    pan.Controls.RemoveAt(i);
            }
        }

        //부모 Panel을 얻는다.
        private Panel GetPanCtrl(String strTag)
        {
            //tag를 비교해 어떤 Panel인지 결정한다.
            if (strTag.ToString().Substring(0, 1) == "0")
                return panLeft;
            else if (strTag.ToString().Substring(0, 1) == "1")
                return panCenter;
            else
                return panRight;
        }

        //drop 이벤트가 시작될 때
        private void pan_DragEnter(object sender, DragEventArgs e)
        {
            // 데이터를 검사한다
            if(e.Data.GetDataPresent(DataFormats.Bitmap)&&m_strDragTag !="")
            {
                Panel pan;
                pan = (Panel)sender;

                if (isDragEnter(pan, m_strDragTag))
                    e.Effect = DragDropEffects.Move;
                else
                    e.Effect = DragDropEffects.None;
            }
        }

        //DragEnter가 가능한지 검사
        private bool isDragEnter(Panel pan, String strTag)
        {
            int i, nMax;

            nMax = -1;

            //패널에 있는 pic 컨트롤의 최대수(두번째 자리 수)를 구한다.
            for(i=0;i<pan.Controls.Count; i++)
            {
                if (Convert.ToInt32(pan.Controls[i].Tag.ToString().Substring(1, 1)) > nMax)
                    nMax = Convert.ToInt32(pan.Controls[i].Tag.ToString().Substring(1, 1));
            }

            // 비어있는 panel 이면 true
            if (nMax == -1) return true;

            // 비교값이 컨트롤의 tag값보다 더 작을 때
            // (드래그한 블럭이 더 좁은 블럭이면)
            if (nMax <Convert.ToInt32(strTag.ToString().Substring(1,1)))
                return true;
            else
                return false;
        }

        private void pan_DragDrop(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.Bitmap) && m_strDragTag != "")
            {
                int nCnt;
                Panel pan;

                pan = (Panel)sender;

                //Drag 할 panel에 PictureBox 갯수를 저장한다.
                nCnt = pan.Controls.Count;

                // 이동한 블럭을 삭제한다.
                RemoveBlock(m_strDragTag);

                //pic를 만든다.(블럭을 이동시킨다)
                MakeBlock(pan, nCnt, Convert.ToInt32(m_strDragTag.ToString().Substring(1, 1)), true);
                
                m_nMoveCnt += 1;
                lblCnt.Text = m_nMoveCnt.ToString() + "번";

                //게임 종료 검사
                if (isGameEnd(Convert.ToInt32(nudCnt.Value)))
                    MessageBox.Show("게임 끝!");
            }
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            // 하노이 초기화
            InitHanoi(Convert.ToInt32(nudCnt.Value));
            
            AutoHanoi(Convert.ToInt32(nudCnt.Value), panLeft, panCenter, panRight);
        }

        // 자동으로 블럭을 이동시킨다.
        // 재귀호출을 이용한다.
        private void AutoHanoi(int nCnt, Panel panFrom, Panel panBy, Panel panTo)
        {
            if (nCnt == 1)
                MoveBlock(panFrom, panTo);
            else
            {
                AutoHanoi(nCnt - 1, panFrom, panTo, panBy);
                MoveBlock(panFrom, panTo);
                AutoHanoi(nCnt - 1, panBy, panFrom, panTo);
            }
        }

        private void MoveBlock(Panel panFrom, Panel panTo)
        {
            // panFrom의 최 상위 pic를 찾는다.
            // 최 상위 pic는 tag의 두번째 자리수가 제일 큰 경우이다.
            int i, nMax;
            PictureBox picMax = new PictureBox();

            nMax = 1;

            // 패널에 있는 pic컨트롤의 최대 수(두번째 자리 수)를 구한다.
            for (i = 0; i < panFrom.Controls.Count; i++)
            {
                if (Convert.ToInt32(panFrom.Controls[i].Tag.ToString().Substring(1, 1)) > nMax)
                    nMax = Convert.ToInt32(panFrom.Controls[i].Tag.ToString().Substring(1, 1));
                picMax = (PictureBox)panFrom.Controls[i];
            }

            //찾은 pic를 옮겨준다.
            int nCnt;

            // Drop할 Panel에 PictureBox 갯수를 저장한다.
            nCnt = panTo.Controls.Count;
            // 이동한 블럭을 삭제한다.
            RemoveBlock(picMax.Tag.ToString());
            //pic를 만든다(블럭을 이동시킨다.)
            MakeBlock(panTo, nCnt, Convert.ToInt32(picMax.Tag.ToString().Substring(1, 1)), true);

            m_nMoveCnt += 1;
            lblCnt.Text = m_nMoveCnt.ToString() + "번";

            // 게임 종료 검사
            if (isGameEnd(Convert.ToInt32(nudCnt.Value)))
                MessageBox.Show("게임 끝 !!");
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            InitHanoi(Convert.ToInt32(nudCnt.Value));
        }

        private void nudCnt_ValueChanged(object sender, EventArgs e)
        {
            InitHanoi(Convert.ToInt32(nudCnt.Value));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
