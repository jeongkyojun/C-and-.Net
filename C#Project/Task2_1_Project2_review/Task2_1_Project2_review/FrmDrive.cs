using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2_1_Project2_review
{
    public partial class FrmDrive : Form
    {
        private int m_nCnt;
        public FrmDrive()
        {
            InitializeComponent();
        }
        private int SetDrive()
        {
            // ListView lstDir이 존재(컨트롤)
            String[] strDrives;
            String strTmp;

            // 드라이브 목록을 얻는다.
            // Directory.GetLogicalDrives() : Directory 클래스에서 논리 드라이브를 호출할때 사용
            strDrives = System.IO.Directory.GetLogicalDrives();

            // 얻어진 드라이브 목록을 리스트뷰에 입력한다.
            foreach (string str in strDrives)
            {
                strTmp = str.Remove(2, 1);
                
                lstDir.Items.Add(strTmp, 1);
            }
            return lstDir.Items.Count;
        }
        private bool SetFolder(String strParentPath = "")
        {
            MessageBox.Show(strParentPath);
            System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo(strParentPath);
            // 리스트뷰의 아이템을 모두 삭제한 후
            lstDir.Items.Clear();

            // Up항목을 추가한다.
            lstDir.Items.Add("..", 0); // .. 으로 표시된 이전으로 돌아가기 항목을 얻는다.
            
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
        private void Form1_Load(object sender, EventArgs e)
        {
            SetDrive();
        }
    }
}
