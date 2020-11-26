using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5_DocumentEdit
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void menuFileNew_Click(object sender, EventArgs e)
        {
            String str;
            int nIndex;

            //New Text를 삽입한다.
            str = "New Text" + m_colText.Count.ToString();

            //컬렉션 부분에도 삽입한다.
            m_colText.Add(str, "");
            nIndex = treeText.Nodes[0].Nodes.Add(new TreeNode(str, 1, 2));

            //삽입할 항목을 선택한다.
            treeText.SelectedNode = treeText.Nodes[0].Nodes[nIndex];
        }

        //<열기>
        private  void menuFileOpen_Click(object sender, System.EventArgs e)
        {
            String strTxtPath;
            String strText;
            int nIndex;

            //파일 오픈 다이얼로그를 연다.
            if(fileDlg.ShowDialog()==DialogResult.OK)//확인 누른 경우
            {
                strTxtPath = fileDlg.FileName;
                if(GetFileText(strTxtPath,out strText))
                {
                    m_colText.Add(strTxtPath, strText);

                    // 트리 추가
                    nIndex = treeText.Nodes[0].Nodes.Add(new TreeNode(strTxtPath, 1, 2));
                    // 추가항목 선택
                    treeText.SelectedNode = treeText.Nodes[0].Nodes[nIndex];
                }
                else
                {
                    MessageBox.Show(strTxtPath + " 파일 열기에 실패하였습니다.");
                }
            }
        }
        // 파일을 열어서 내용을 얻는다.
        //반환 : 성공/실패
        private bool GetFileText(String strPath, out String strText)
        {
            System.IO.FileStream fileTxt;
            // 기본 인코딩 타입 얻기
            System.Text.Encoding enc = System.Text.Encoding.Default;

            // 파일 오픈
            fileTxt = System.IO.File.Open(strPath, System.IO.FileMode.Open);

            bool b;
            // 파일 오픈 실패
            if(fileTxt == null)
            {
                strText = "";
                b = false;
            }
            else
            {
                // 파일의 내용을 String으로 변경
                Byte[] bytes = new byte[fileTxt.Length + 1];
                fileTxt.Read(bytes, 0, (int)fileTxt.Length);
                strText = enc.GetString(bytes);
                fileTxt.Close();
                b = true;
            }

            return b;
        }
    }
}
