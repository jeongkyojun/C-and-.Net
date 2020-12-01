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
    public partial class FrmFind : Form
    {
        FrmMain m_parentDlg;
        public FrmFind()
        {
            InitializeComponent();
        }

        public void Init(FrmMain parentDlg)
        {
            m_parentDlg = parentDlg;
            rdoDown.Checked = true;
        }

        //찾기
        private bool FindText()
        {
            //찾기
            int nFind;
            int nLen;
            String strTmpTxt, strTmpFind;

            if (chkCase.Checked)
            {
                strTmpTxt = m_parentDlg.txtMain.Text;
                strTmpFind = txtFind.Text;
            }
            else//대소문자 구분 안할때 소문자로 바꿔서 비교
            {
                strTmpTxt = m_parentDlg.txtMain.Text.ToLower();
                strTmpFind = txtFind.Text.ToLower();
            }

            nLen = txtFind.Text.Length;

            if (rdoUp.Checked) // 위로
            {
                if (m_parentDlg.txtMain.SelectionStart - m_parentDlg.txtMain.SelectionLength < 0)
                    nFind = -1;
                else
                    nFind = strTmpTxt.LastIndexOf(strTmpFind, m_parentDlg.txtMain.SelectionStart - m_parentDlg.txtMain.SelectionLength);
            }
            else // 아래로
                nFind = strTmpTxt.IndexOf(strTmpFind, m_parentDlg.txtMain.SelectionStart + m_parentDlg.txtMain.SelectionLength);

            if (nFind == -1)
                return false;
            else// 찾은 문자열을 하이라이트(선택표시) 한다.
            {
                m_parentDlg.txtMain.SelectionStart = nFind;
                m_parentDlg.txtMain.SelectionLength = nLen;
                m_parentDlg.txtMain.Focus();
                return true;
            }
        }
    }
}
