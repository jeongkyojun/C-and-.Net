using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 그룹 박스와 라디오 박스를 이용한 폼 생성기
 */
namespace Task1_2_FormTest2
{
    public partial class FrmParent : Form
    {
        private int ModeNum { get; set; }
        private int TypeNum { get; set; }
        private int PosNum { get; set; }
        public FrmParent()
        {
            InitializeComponent();
        }

        private void FrmParent_Load(object sender, EventArgs e)
        {
            ModeNum = 0;
            TypeNum = 0;
            PosNum = 0;
            rbtnNone.Checked = true;
            rbtnModal.Checked = true;
            rbtnManual.Checked = true;
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            Task1_2_FormTest2.FrmChild frmChild = new Task1_2_FormTest2.FrmChild();

            switch(TypeNum)
            {
                case 0:
                    frmChild.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    break;
                case 1:
                    frmChild.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                    break;
                case 2:
                    frmChild.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
                    break;
                case 3:
                    frmChild.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                    break;
                case 4:
                    frmChild.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                    break;
                case 5:
                    frmChild.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                    break;
                case 6:
                    frmChild.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
                    break;
                    
                default:
                    MessageBox.Show("타입선택에 차질이 생겼습니다! fixedSingle로 설정합니다.");
                    frmChild.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                    break;
            }

            switch (PosNum)
            {
                case 0:
                    frmChild.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                    break;
                case 1:
                    frmChild.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                    break;
                case 2:
                    frmChild.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
                    break;
                case 3:
                    frmChild.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
                    break;
                case 4:
                    frmChild.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                    break;
                default:
                    MessageBox.Show("위치선택에 차질이 생겼습니다! Manual로 설정합니다.");
                    frmChild.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                    break;
            }
            if (ModeNum == 0)
            {
                //모달
                frmChild.ShowDialog(this);
                frmChild.Dispose();
            }
            else
            {
                // 모달리스
                frmChild.Show();
            }
        }

        #region 그룹 1(모드)
        private void rbtnModal_CheckedChanged(object sender, EventArgs e)
        {
            ModeNum = 0;
        }

        private void rbtnModalLess_CheckedChanged(object sender, EventArgs e)
        {
            ModeNum = 1;
        }

        #endregion

        #region 그룹 2(타입)
        private void rbtnNone_CheckedChanged(object sender, EventArgs e)
        {
            TypeNum = 0;
        }
        private void rbtnFixedSingle_CheckedChanged(object sender, EventArgs e)
        {
            TypeNum = 1;
        }
        private void rbtnFixed3D_CheckedChanged(object sender, EventArgs e)
        {
            TypeNum = 2;
        }
        private void rbtnFixedDialog_CheckedChanged(object sender, EventArgs e)
        {
            TypeNum = 3;
        }
        private void rbtnSizable_CheckedChanged(object sender, EventArgs e)
        {
            TypeNum = 4;
        }
        private void rbtnFixedToolWindow_CheckedChanged(object sender, EventArgs e)
        {
            TypeNum = 5;
        }
        private void rbtnSizableToolWindow_CheckedChanged(object sender, EventArgs e)
        {
            TypeNum = 6;
        }


        #endregion

        #region 그룹 3(위치)

        private void rbtnManual_CheckedChanged(object sender, EventArgs e)
        {
            PosNum = 0;
        }
        
        private void rbtnCenterScreen_CheckedChanged(object sender, EventArgs e)
        {
            PosNum = 1;
        }

        private void rbtnWindowDefaultLocation_CheckedChanged(object sender, EventArgs e)
        {
            PosNum = 2;
        }

        private void rbtnWindowsDefaultBounds_CheckedChanged(object sender, EventArgs e)
        {
            PosNum = 3;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            PosNum = 4;
        }

        #endregion

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
