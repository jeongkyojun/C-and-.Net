using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1_FormTest
{
    public partial class FrmCreate : Form
    {
        public FrmCreate()
        {
            InitializeComponent();
        }

        private void FrmCreate_Load(object sender, EventArgs e)
        {
            cmbType.Items.Add("None");
            cmbType.Items.Add("FixedSingle");
            cmbType.Items.Add("Fixed3D");
            cmbType.Items.Add("FixedDialog");
            cmbType.Items.Add("Sizable");
            cmbType.Items.Add("FixedToolWindow");
            cmbType.Items.Add("SizableToolWindow");

            cmbPos.Items.Add("Manual");
            cmbPos.Items.Add("CenterScreen");
            cmbPos.Items.Add("WindowsDefaultLocation");
            cmbPos.Items.Add("WndowsDefaultBounds");
            cmbPos.Items.Add("CenterParent");

            cmbMode.Items.Add("모달");
            cmbMode.Items.Add("모달리스");

            cmbType.SelectedIndex = 0;
            cmbPos.SelectedIndex = 0;
            cmbMode.SelectedIndex = 0;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Task1_FormTest.FrmTest testDialog = new Task1_FormTest.FrmTest();

            //속성 설정
            switch(cmbType.SelectedIndex)
            {
                case 0:
                testDialog.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    break;
                case 1:
                    testDialog.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                    break;
                case 2:
                    testDialog.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
                    break;
                case 3:
                    testDialog.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                    break;
                case 4:
                    testDialog.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                    break;
                case 5:
                    testDialog.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                    break;
                case 6:
                    testDialog.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
                    break;
                default:
                    break;
            }
            switch (cmbPos.SelectedIndex)
            {
                case 0:
                    testDialog.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                    break;
                case 1:
                    testDialog.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                    break;
                case 2:
                    testDialog.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
                    break;
                case 3:
                    testDialog.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
                    break;
                case 4:
                    testDialog.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                    break;
                default:
                    break;
            }

            testDialog.lblType.Text = cmbType.SelectedItem.ToString();
            testDialog.lblPos.Text = cmbPos.SelectedItem.ToString();

            switch(cmbMode.SelectedIndex)
            {
                case 0:
                    testDialog.ShowDialog(this);
                    testDialog.Dispose();
                    break;
                case 1:
                    testDialog.Show();
                    break;
                default:
                    break;
            }
        }
    }
}
