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
    public partial class FrmReplace : Form
    {
        FrmMain m_parentDlg;
        public FrmReplace()
        {
            InitializeComponent();
        }

        private void FrmReplace_Load(object sender, EventArgs e)
        {

        }
        public void Init(FrmMain parentDlg)
        {
            m_parentDlg = parentDlg;
            rdoDown.Checked = true;
        }

        
    }
}
