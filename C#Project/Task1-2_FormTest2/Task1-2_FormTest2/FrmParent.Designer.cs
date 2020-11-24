namespace Task1_2_FormTest2
{
    partial class FrmParent
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnModalLess = new System.Windows.Forms.RadioButton();
            this.rbtnModal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnSizableToolWindow = new System.Windows.Forms.RadioButton();
            this.rbtnFixedToolWindow = new System.Windows.Forms.RadioButton();
            this.rbtnSizable = new System.Windows.Forms.RadioButton();
            this.rbtnFixedDialog = new System.Windows.Forms.RadioButton();
            this.rbtnFixed3D = new System.Windows.Forms.RadioButton();
            this.rbtnFixedSingle = new System.Windows.Forms.RadioButton();
            this.rbtnNone = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbtnWindowsDefaultBounds = new System.Windows.Forms.RadioButton();
            this.rbtnWindowDefaultLocation = new System.Windows.Forms.RadioButton();
            this.rbtnCenterScreen = new System.Windows.Forms.RadioButton();
            this.rbtnManual = new System.Windows.Forms.RadioButton();
            this.btnMake = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 5;
            // 
            // rbtnModalLess
            // 
            this.rbtnModalLess.AutoSize = true;
            this.rbtnModalLess.Location = new System.Drawing.Point(80, 24);
            this.rbtnModalLess.Name = "rbtnModalLess";
            this.rbtnModalLess.Size = new System.Drawing.Size(88, 19);
            this.rbtnModalLess.TabIndex = 4;
            this.rbtnModalLess.TabStop = true;
            this.rbtnModalLess.Text = "모달리스";
            this.rbtnModalLess.UseVisualStyleBackColor = true;
            this.rbtnModalLess.CheckedChanged += new System.EventHandler(this.rbtnModalLess_CheckedChanged);
            // 
            // rbtnModal
            // 
            this.rbtnModal.AutoSize = true;
            this.rbtnModal.Location = new System.Drawing.Point(6, 24);
            this.rbtnModal.Name = "rbtnModal";
            this.rbtnModal.Size = new System.Drawing.Size(58, 19);
            this.rbtnModal.TabIndex = 3;
            this.rbtnModal.TabStop = true;
            this.rbtnModal.Text = "모달";
            this.rbtnModal.UseVisualStyleBackColor = true;
            this.rbtnModal.CheckedChanged += new System.EventHandler(this.rbtnModal_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnModalLess);
            this.groupBox1.Controls.Add(this.rbtnModal);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 58);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "모달/모달리스";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnSizableToolWindow);
            this.groupBox2.Controls.Add(this.rbtnFixedToolWindow);
            this.groupBox2.Controls.Add(this.rbtnSizable);
            this.groupBox2.Controls.Add(this.rbtnFixedDialog);
            this.groupBox2.Controls.Add(this.rbtnFixed3D);
            this.groupBox2.Controls.Add(this.rbtnFixedSingle);
            this.groupBox2.Controls.Add(this.rbtnNone);
            this.groupBox2.Location = new System.Drawing.Point(12, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 103);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "타입";
            // 
            // rbtnSizableToolWindow
            // 
            this.rbtnSizableToolWindow.AutoSize = true;
            this.rbtnSizableToolWindow.Location = new System.Drawing.Point(6, 74);
            this.rbtnSizableToolWindow.Name = "rbtnSizableToolWindow";
            this.rbtnSizableToolWindow.Size = new System.Drawing.Size(157, 19);
            this.rbtnSizableToolWindow.TabIndex = 9;
            this.rbtnSizableToolWindow.TabStop = true;
            this.rbtnSizableToolWindow.Text = "SizableToolWindow";
            this.rbtnSizableToolWindow.UseVisualStyleBackColor = true;
            this.rbtnSizableToolWindow.CheckedChanged += new System.EventHandler(this.rbtnSizableToolWindow_CheckedChanged);
            // 
            // rbtnFixedToolWindow
            // 
            this.rbtnFixedToolWindow.AutoSize = true;
            this.rbtnFixedToolWindow.Location = new System.Drawing.Point(237, 49);
            this.rbtnFixedToolWindow.Name = "rbtnFixedToolWindow";
            this.rbtnFixedToolWindow.Size = new System.Drawing.Size(145, 19);
            this.rbtnFixedToolWindow.TabIndex = 8;
            this.rbtnFixedToolWindow.TabStop = true;
            this.rbtnFixedToolWindow.Text = "FixedToolWindow";
            this.rbtnFixedToolWindow.UseVisualStyleBackColor = true;
            this.rbtnFixedToolWindow.CheckedChanged += new System.EventHandler(this.rbtnFixedToolWindow_CheckedChanged);
            // 
            // rbtnSizable
            // 
            this.rbtnSizable.AutoSize = true;
            this.rbtnSizable.Location = new System.Drawing.Point(117, 49);
            this.rbtnSizable.Name = "rbtnSizable";
            this.rbtnSizable.Size = new System.Drawing.Size(76, 19);
            this.rbtnSizable.TabIndex = 7;
            this.rbtnSizable.TabStop = true;
            this.rbtnSizable.Text = "Sizable";
            this.rbtnSizable.UseVisualStyleBackColor = true;
            this.rbtnSizable.CheckedChanged += new System.EventHandler(this.rbtnSizable_CheckedChanged);
            // 
            // rbtnFixedDialog
            // 
            this.rbtnFixedDialog.AutoSize = true;
            this.rbtnFixedDialog.Location = new System.Drawing.Point(6, 49);
            this.rbtnFixedDialog.Name = "rbtnFixedDialog";
            this.rbtnFixedDialog.Size = new System.Drawing.Size(105, 19);
            this.rbtnFixedDialog.TabIndex = 6;
            this.rbtnFixedDialog.TabStop = true;
            this.rbtnFixedDialog.Text = "FixedDialog";
            this.rbtnFixedDialog.UseVisualStyleBackColor = true;
            this.rbtnFixedDialog.CheckedChanged += new System.EventHandler(this.rbtnFixedDialog_CheckedChanged);
            // 
            // rbtnFixed3D
            // 
            this.rbtnFixed3D.AutoSize = true;
            this.rbtnFixed3D.Location = new System.Drawing.Point(237, 24);
            this.rbtnFixed3D.Name = "rbtnFixed3D";
            this.rbtnFixed3D.Size = new System.Drawing.Size(82, 19);
            this.rbtnFixed3D.TabIndex = 5;
            this.rbtnFixed3D.TabStop = true;
            this.rbtnFixed3D.Text = "Fixed3D";
            this.rbtnFixed3D.UseVisualStyleBackColor = true;
            this.rbtnFixed3D.CheckedChanged += new System.EventHandler(this.rbtnFixed3D_CheckedChanged);
            // 
            // rbtnFixedSingle
            // 
            this.rbtnFixedSingle.AutoSize = true;
            this.rbtnFixedSingle.Location = new System.Drawing.Point(117, 24);
            this.rbtnFixedSingle.Name = "rbtnFixedSingle";
            this.rbtnFixedSingle.Size = new System.Drawing.Size(104, 19);
            this.rbtnFixedSingle.TabIndex = 4;
            this.rbtnFixedSingle.TabStop = true;
            this.rbtnFixedSingle.Text = "FixedSingle";
            this.rbtnFixedSingle.UseVisualStyleBackColor = true;
            this.rbtnFixedSingle.CheckedChanged += new System.EventHandler(this.rbtnFixedSingle_CheckedChanged);
            // 
            // rbtnNone
            // 
            this.rbtnNone.AutoSize = true;
            this.rbtnNone.Location = new System.Drawing.Point(6, 24);
            this.rbtnNone.Name = "rbtnNone";
            this.rbtnNone.Size = new System.Drawing.Size(62, 19);
            this.rbtnNone.TabIndex = 3;
            this.rbtnNone.TabStop = true;
            this.rbtnNone.Text = "None";
            this.rbtnNone.UseVisualStyleBackColor = true;
            this.rbtnNone.CheckedChanged += new System.EventHandler(this.rbtnNone_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.rbtnWindowsDefaultBounds);
            this.groupBox3.Controls.Add(this.rbtnWindowDefaultLocation);
            this.groupBox3.Controls.Add(this.rbtnCenterScreen);
            this.groupBox3.Controls.Add(this.rbtnManual);
            this.groupBox3.Location = new System.Drawing.Point(12, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(476, 79);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "위치";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(237, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(112, 19);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "CenterParent";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbtnWindowsDefaultBounds
            // 
            this.rbtnWindowsDefaultBounds.AutoSize = true;
            this.rbtnWindowsDefaultBounds.Location = new System.Drawing.Point(6, 49);
            this.rbtnWindowsDefaultBounds.Name = "rbtnWindowsDefaultBounds";
            this.rbtnWindowsDefaultBounds.Size = new System.Drawing.Size(184, 19);
            this.rbtnWindowsDefaultBounds.TabIndex = 6;
            this.rbtnWindowsDefaultBounds.TabStop = true;
            this.rbtnWindowsDefaultBounds.Text = "WindowsDefaultBounds";
            this.rbtnWindowsDefaultBounds.UseVisualStyleBackColor = true;
            this.rbtnWindowsDefaultBounds.CheckedChanged += new System.EventHandler(this.rbtnWindowsDefaultBounds_CheckedChanged);
            // 
            // rbtnWindowDefaultLocation
            // 
            this.rbtnWindowDefaultLocation.AutoSize = true;
            this.rbtnWindowDefaultLocation.Location = new System.Drawing.Point(237, 24);
            this.rbtnWindowDefaultLocation.Name = "rbtnWindowDefaultLocation";
            this.rbtnWindowDefaultLocation.Size = new System.Drawing.Size(190, 19);
            this.rbtnWindowDefaultLocation.TabIndex = 5;
            this.rbtnWindowDefaultLocation.TabStop = true;
            this.rbtnWindowDefaultLocation.Text = "WindowsDefaultLocation";
            this.rbtnWindowDefaultLocation.UseVisualStyleBackColor = true;
            this.rbtnWindowDefaultLocation.CheckedChanged += new System.EventHandler(this.rbtnWindowDefaultLocation_CheckedChanged);
            // 
            // rbtnCenterScreen
            // 
            this.rbtnCenterScreen.AutoSize = true;
            this.rbtnCenterScreen.Location = new System.Drawing.Point(117, 24);
            this.rbtnCenterScreen.Name = "rbtnCenterScreen";
            this.rbtnCenterScreen.Size = new System.Drawing.Size(116, 19);
            this.rbtnCenterScreen.TabIndex = 4;
            this.rbtnCenterScreen.TabStop = true;
            this.rbtnCenterScreen.Text = "CenterScreen";
            this.rbtnCenterScreen.UseVisualStyleBackColor = true;
            this.rbtnCenterScreen.CheckedChanged += new System.EventHandler(this.rbtnCenterScreen_CheckedChanged);
            // 
            // rbtnManual
            // 
            this.rbtnManual.AutoSize = true;
            this.rbtnManual.Location = new System.Drawing.Point(6, 24);
            this.rbtnManual.Name = "rbtnManual";
            this.rbtnManual.Size = new System.Drawing.Size(75, 19);
            this.rbtnManual.TabIndex = 3;
            this.rbtnManual.TabStop = true;
            this.rbtnManual.Text = "Manual";
            this.rbtnManual.UseVisualStyleBackColor = true;
            this.rbtnManual.CheckedChanged += new System.EventHandler(this.rbtnManual_CheckedChanged);
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(12, 293);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(221, 32);
            this.btnMake.TabIndex = 11;
            this.btnMake.Text = "만들기";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(267, 293);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(221, 32);
            this.btnEnd.TabIndex = 12;
            this.btnEnd.Text = "종료";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // FrmParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 337);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnMake);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmParent";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmParent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnModalLess;
        private System.Windows.Forms.RadioButton rbtnModal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnFixedSingle;
        private System.Windows.Forms.RadioButton rbtnNone;
        private System.Windows.Forms.RadioButton rbtnSizableToolWindow;
        private System.Windows.Forms.RadioButton rbtnFixedToolWindow;
        private System.Windows.Forms.RadioButton rbtnSizable;
        private System.Windows.Forms.RadioButton rbtnFixedDialog;
        private System.Windows.Forms.RadioButton rbtnFixed3D;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbtnWindowsDefaultBounds;
        private System.Windows.Forms.RadioButton rbtnWindowDefaultLocation;
        private System.Windows.Forms.RadioButton rbtnCenterScreen;
        private System.Windows.Forms.RadioButton rbtnManual;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.Button btnEnd;
    }
}

