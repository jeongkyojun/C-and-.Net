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
        //트리노드 선택 변경후 이벤트
        private void treeText_AfterSelect(object sender,TreeViewEventArgs e)
        {
            if(e.Node== treeText.Nodes[0])
            {
                txtMain.Text = "";
                txtMain.Enabled = false;
            }
            else
            {
                txtMain.Text = m_colText[e.Node.Text];
                // txtMain.Text = m_colText["Dd"];
                txtMain.Enabled = true;
            }
        }

        //트리노드 선택 변경전 이벤트
        private void treeText_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (treeText.SelectedNode == null)// 선택한 노드가 없으면
                return;
            
            if(treeText.SelectedNode != treeText.Nodes[0]) //루트가 아닌 노드 선택시
            {
                //원래 있던 아이템을 삭제하고
                m_colText.Remove(treeText.SelectedNode.Text);
                //새 값을 다시 Add해준다.
                m_colText.Add(treeText.SelectedNode.Text, txtMain.Text);
                txtMain.Enabled = true;
            }
        }

        //(저장)
        private void menuFileSave_Click(object sender, EventArgs e)
        {
            if (treeText.SelectedNode == treeText.Nodes[0])
                return;

            String strPath;

            strPath = treeText.SelectedNode.Text;
            if (strPath.IndexOf("\\") == -1) // \를 못찾으면 새로 만들기 문서
                ResaveFile();
            else
                saveFile(strPath);
        }

        //실제로 파일을 저장한다.
        private void saveFile(String strPath)
        {
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(strPath);
            System.IO.FileStream fileTxt;

            //기본 인코딩 타입 얻기
            System.Text.Encoding enc = System.Text.Encoding.Default;

            //기존 파일 삭제
            if(fileInfo != null)
            {
                fileInfo.Delete();
            }

            //파일 저장
            fileTxt = System.IO.File.Open(strPath, System.IO.FileMode.OpenOrCreate);
            fileTxt.Write(enc.GetBytes(txtMain.Text), 0, enc.GetByteCount(txtMain.Text));

            fileTxt.Close();
        }

        //다른 이름으로 저장
        private void menuFileResave_Click(object sender, EventArgs e)
        {
            ResaveFile();
        }
        //다른 이름으로 저장 처리
        private void ResaveFile()
        {
            if(treeText.SelectedNode == treeText.Nodes[0])//루트가 아닌 노드 선택시만 동작
                return;
            String strPath;
            String strDir, strFile;
            String strTxtPath;

            strPath = treeText.SelectedNode.Text;
            if (strPath.IndexOf("\\") == -1)// \를 못찾으면 새로 만들기 문서이다.
                saveDlg.FileName = strPath + ".txt"; //최초 파일 이름을 설정한다.
            else
            {
                //폴더와 파일명을 분리한다. 예를들어 C:\temp\test.txt -> C:\temp 와 test.txt로 분리한다.
                strDir = strPath.Substring(0, strPath.LastIndexOf("\\")); // 가장 마지막의 \를 찾아 잘라낸다.
                strFile = strPath.Substring(strPath.LastIndexOf("\\"), strPath.Length - strPath.LastIndexOf("\\"));
                strFile = strFile.Remove(0, 1);
                saveDlg.InitialDirectory = strDir;  // 파일의 폴더를 오픈할 폴더로 설정한다.
                saveDlg.FileName = strFile;         // 최초 파일 이름을 설정한다.
            }

            // 파일 패스를 얻는다.
            if(saveDlg.ShowDialog() == DialogResult.OK) // 확인 누른경우
            {
                strTxtPath = saveDlg.FileName;
                saveFile(strTxtPath); // 실제 저장을 한다.
            }
        }
    }
}
