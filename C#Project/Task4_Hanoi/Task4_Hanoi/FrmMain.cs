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
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

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
                for(i=0;i<=BLOCK_START_Y-(nIndex*BLOCK_HEIGHT);i+=2)
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

        // pic 마우스다운 이벤트
        private void pic_MouseDown(object sender, MouseEventArgs e)
        {

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
    }
}
