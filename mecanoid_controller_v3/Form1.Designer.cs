namespace mecanoid_controller_v3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnWalkFront = new System.Windows.Forms.Button();
            this.btnWalkTurnLeft = new System.Windows.Forms.Button();
            this.btnWalkStop = new System.Windows.Forms.Button();
            this.btnWalkTurnRight = new System.Windows.Forms.Button();
            this.btnWalkBack = new System.Windows.Forms.Button();
            this.btnTorqueOn = new System.Windows.Forms.Button();
            this.btnTorqueOff = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.textBoxPortNum = new System.Windows.Forms.TextBox();
            this.btnMecanumFR = new System.Windows.Forms.Button();
            this.btnMecanumF = new System.Windows.Forms.Button();
            this.btnMecanumFL = new System.Windows.Forms.Button();
            this.btnMecanumR = new System.Windows.Forms.Button();
            this.btnMecanumStop = new System.Windows.Forms.Button();
            this.btnMecanumL = new System.Windows.Forms.Button();
            this.btnMecanumBR = new System.Windows.Forms.Button();
            this.btnMecanumB = new System.Windows.Forms.Button();
            this.btnMecanumBL = new System.Windows.Forms.Button();
            this.btnStandPose = new System.Windows.Forms.Button();
            this.btnTransformToMecanum = new System.Windows.Forms.Button();
            this.btnTransformToWalk = new System.Windows.Forms.Button();
            this.btnMecanumPose = new System.Windows.Forms.Button();
            this.checkBoxPadEnable = new System.Windows.Forms.CheckBox();
            this.textBoxBaudRate = new System.Windows.Forms.TextBox();
            this.btnMecanumTurnR = new System.Windows.Forms.Button();
            this.btnMecanumTurnL = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelPadState = new System.Windows.Forms.Label();
            this.btnStairRight = new System.Windows.Forms.Button();
            this.btnStairLeft = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWalkFront
            // 
            this.btnWalkFront.Location = new System.Drawing.Point(106, 28);
            this.btnWalkFront.Name = "btnWalkFront";
            this.btnWalkFront.Size = new System.Drawing.Size(78, 50);
            this.btnWalkFront.TabIndex = 4;
            this.btnWalkFront.Text = "Forward";
            this.btnWalkFront.UseVisualStyleBackColor = true;
            this.btnWalkFront.Click += new System.EventHandler(this.btnWalkFront_Click);
            // 
            // btnWalkTurnLeft
            // 
            this.btnWalkTurnLeft.Location = new System.Drawing.Point(22, 84);
            this.btnWalkTurnLeft.Name = "btnWalkTurnLeft";
            this.btnWalkTurnLeft.Size = new System.Drawing.Size(78, 50);
            this.btnWalkTurnLeft.TabIndex = 4;
            this.btnWalkTurnLeft.Text = "Turn Right";
            this.btnWalkTurnLeft.UseVisualStyleBackColor = true;
            this.btnWalkTurnLeft.Click += new System.EventHandler(this.btnWalkTurnLeft_Click);
            // 
            // btnWalkStop
            // 
            this.btnWalkStop.Location = new System.Drawing.Point(106, 84);
            this.btnWalkStop.Name = "btnWalkStop";
            this.btnWalkStop.Size = new System.Drawing.Size(78, 50);
            this.btnWalkStop.TabIndex = 4;
            this.btnWalkStop.Text = "Stop";
            this.btnWalkStop.UseVisualStyleBackColor = true;
            this.btnWalkStop.Click += new System.EventHandler(this.btnWalkStop_Click);
            // 
            // btnWalkTurnRight
            // 
            this.btnWalkTurnRight.Location = new System.Drawing.Point(190, 84);
            this.btnWalkTurnRight.Name = "btnWalkTurnRight";
            this.btnWalkTurnRight.Size = new System.Drawing.Size(78, 50);
            this.btnWalkTurnRight.TabIndex = 4;
            this.btnWalkTurnRight.Text = "Turn Left";
            this.btnWalkTurnRight.UseVisualStyleBackColor = true;
            this.btnWalkTurnRight.Click += new System.EventHandler(this.btnWalkTurnRight_Click);
            // 
            // btnWalkBack
            // 
            this.btnWalkBack.Location = new System.Drawing.Point(106, 140);
            this.btnWalkBack.Name = "btnWalkBack";
            this.btnWalkBack.Size = new System.Drawing.Size(78, 50);
            this.btnWalkBack.TabIndex = 4;
            this.btnWalkBack.Text = "Back";
            this.btnWalkBack.UseVisualStyleBackColor = true;
            this.btnWalkBack.Click += new System.EventHandler(this.btnWalkBack_Click);
            // 
            // btnTorqueOn
            // 
            this.btnTorqueOn.Location = new System.Drawing.Point(328, 138);
            this.btnTorqueOn.Name = "btnTorqueOn";
            this.btnTorqueOn.Size = new System.Drawing.Size(112, 23);
            this.btnTorqueOn.TabIndex = 5;
            this.btnTorqueOn.Text = "Torque On";
            this.btnTorqueOn.UseVisualStyleBackColor = true;
            this.btnTorqueOn.Click += new System.EventHandler(this.btnTorqueOn_Click);
            // 
            // btnTorqueOff
            // 
            this.btnTorqueOff.Location = new System.Drawing.Point(446, 138);
            this.btnTorqueOff.Name = "btnTorqueOff";
            this.btnTorqueOff.Size = new System.Drawing.Size(112, 23);
            this.btnTorqueOff.TabIndex = 6;
            this.btnTorqueOff.Text = "Torque Off";
            this.btnTorqueOff.UseVisualStyleBackColor = true;
            this.btnTorqueOff.Click += new System.EventHandler(this.btnTorqueOff_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(481, 47);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(102, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = " Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(481, 76);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(102, 23);
            this.btnDisconnect.TabIndex = 8;
            this.btnDisconnect.Text = " Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // textBoxPortNum
            // 
            this.textBoxPortNum.Location = new System.Drawing.Point(388, 49);
            this.textBoxPortNum.Name = "textBoxPortNum";
            this.textBoxPortNum.Size = new System.Drawing.Size(80, 21);
            this.textBoxPortNum.TabIndex = 0;
            this.textBoxPortNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnMecanumFR
            // 
            this.btnMecanumFR.Location = new System.Drawing.Point(753, 55);
            this.btnMecanumFR.Name = "btnMecanumFR";
            this.btnMecanumFR.Size = new System.Drawing.Size(48, 23);
            this.btnMecanumFR.TabIndex = 10;
            this.btnMecanumFR.Text = "FR";
            this.btnMecanumFR.UseVisualStyleBackColor = true;
            this.btnMecanumFR.Click += new System.EventHandler(this.btnMecanumFR_Click);
            // 
            // btnMecanumF
            // 
            this.btnMecanumF.Location = new System.Drawing.Point(699, 55);
            this.btnMecanumF.Name = "btnMecanumF";
            this.btnMecanumF.Size = new System.Drawing.Size(48, 23);
            this.btnMecanumF.TabIndex = 11;
            this.btnMecanumF.Text = "F";
            this.btnMecanumF.UseVisualStyleBackColor = true;
            this.btnMecanumF.Click += new System.EventHandler(this.btnMecanumF_Click);
            // 
            // btnMecanumFL
            // 
            this.btnMecanumFL.Location = new System.Drawing.Point(645, 55);
            this.btnMecanumFL.Name = "btnMecanumFL";
            this.btnMecanumFL.Size = new System.Drawing.Size(48, 23);
            this.btnMecanumFL.TabIndex = 12;
            this.btnMecanumFL.Text = "FL";
            this.btnMecanumFL.UseVisualStyleBackColor = true;
            this.btnMecanumFL.Click += new System.EventHandler(this.btnMecanumFL_Click);
            // 
            // btnMecanumR
            // 
            this.btnMecanumR.Location = new System.Drawing.Point(753, 84);
            this.btnMecanumR.Name = "btnMecanumR";
            this.btnMecanumR.Size = new System.Drawing.Size(48, 23);
            this.btnMecanumR.TabIndex = 13;
            this.btnMecanumR.Text = "R";
            this.btnMecanumR.UseVisualStyleBackColor = true;
            this.btnMecanumR.Click += new System.EventHandler(this.btnMecanumR_Click);
            // 
            // btnMecanumStop
            // 
            this.btnMecanumStop.Location = new System.Drawing.Point(699, 84);
            this.btnMecanumStop.Name = "btnMecanumStop";
            this.btnMecanumStop.Size = new System.Drawing.Size(48, 23);
            this.btnMecanumStop.TabIndex = 14;
            this.btnMecanumStop.Text = "Stop";
            this.btnMecanumStop.UseVisualStyleBackColor = true;
            this.btnMecanumStop.Click += new System.EventHandler(this.btnMecanumStop_Click);
            // 
            // btnMecanumL
            // 
            this.btnMecanumL.Location = new System.Drawing.Point(645, 84);
            this.btnMecanumL.Name = "btnMecanumL";
            this.btnMecanumL.Size = new System.Drawing.Size(48, 23);
            this.btnMecanumL.TabIndex = 15;
            this.btnMecanumL.Text = "L";
            this.btnMecanumL.UseVisualStyleBackColor = true;
            this.btnMecanumL.Click += new System.EventHandler(this.btnMecanumL_Click);
            // 
            // btnMecanumBR
            // 
            this.btnMecanumBR.Location = new System.Drawing.Point(753, 113);
            this.btnMecanumBR.Name = "btnMecanumBR";
            this.btnMecanumBR.Size = new System.Drawing.Size(48, 23);
            this.btnMecanumBR.TabIndex = 16;
            this.btnMecanumBR.Text = "BR";
            this.btnMecanumBR.UseVisualStyleBackColor = true;
            this.btnMecanumBR.Click += new System.EventHandler(this.btnMecanumBR_Click);
            // 
            // btnMecanumB
            // 
            this.btnMecanumB.Location = new System.Drawing.Point(699, 113);
            this.btnMecanumB.Name = "btnMecanumB";
            this.btnMecanumB.Size = new System.Drawing.Size(48, 23);
            this.btnMecanumB.TabIndex = 17;
            this.btnMecanumB.Text = "B";
            this.btnMecanumB.UseVisualStyleBackColor = true;
            this.btnMecanumB.Click += new System.EventHandler(this.btnMecanumB_Click);
            // 
            // btnMecanumBL
            // 
            this.btnMecanumBL.Location = new System.Drawing.Point(645, 113);
            this.btnMecanumBL.Name = "btnMecanumBL";
            this.btnMecanumBL.Size = new System.Drawing.Size(48, 23);
            this.btnMecanumBL.TabIndex = 18;
            this.btnMecanumBL.Text = "BL";
            this.btnMecanumBL.UseVisualStyleBackColor = true;
            this.btnMecanumBL.Click += new System.EventHandler(this.btnMecanumBL_Click);
            // 
            // btnStandPose
            // 
            this.btnStandPose.Location = new System.Drawing.Point(190, 296);
            this.btnStandPose.Name = "btnStandPose";
            this.btnStandPose.Size = new System.Drawing.Size(105, 23);
            this.btnStandPose.TabIndex = 19;
            this.btnStandPose.Text = "Stand pose";
            this.btnStandPose.UseVisualStyleBackColor = true;
            this.btnStandPose.Click += new System.EventHandler(this.btnStandPose_Click);
            // 
            // btnTransformToMecanum
            // 
            this.btnTransformToMecanum.Location = new System.Drawing.Point(301, 279);
            this.btnTransformToMecanum.Name = "btnTransformToMecanum";
            this.btnTransformToMecanum.Size = new System.Drawing.Size(285, 23);
            this.btnTransformToMecanum.TabIndex = 20;
            this.btnTransformToMecanum.Text = "--> Transform to mecanum wheel mode -->";
            this.btnTransformToMecanum.UseVisualStyleBackColor = true;
            this.btnTransformToMecanum.Click += new System.EventHandler(this.btnTransformToMecanum_Click);
            // 
            // btnTransformToWalk
            // 
            this.btnTransformToWalk.Location = new System.Drawing.Point(301, 313);
            this.btnTransformToWalk.Name = "btnTransformToWalk";
            this.btnTransformToWalk.Size = new System.Drawing.Size(285, 23);
            this.btnTransformToWalk.TabIndex = 21;
            this.btnTransformToWalk.Text = "<-- Transform to walking mode <--";
            this.btnTransformToWalk.UseVisualStyleBackColor = true;
            this.btnTransformToWalk.Click += new System.EventHandler(this.btnTransformToWalk_Click);
            // 
            // btnMecanumPose
            // 
            this.btnMecanumPose.Location = new System.Drawing.Point(592, 296);
            this.btnMecanumPose.Name = "btnMecanumPose";
            this.btnMecanumPose.Size = new System.Drawing.Size(113, 23);
            this.btnMecanumPose.TabIndex = 22;
            this.btnMecanumPose.Text = "Mecanum pose";
            this.btnMecanumPose.UseVisualStyleBackColor = true;
            this.btnMecanumPose.Click += new System.EventHandler(this.btnMecanumPose_Click);
            // 
            // checkBoxPadEnable
            // 
            this.checkBoxPadEnable.AutoSize = true;
            this.checkBoxPadEnable.Location = new System.Drawing.Point(380, 199);
            this.checkBoxPadEnable.Name = "checkBoxPadEnable";
            this.checkBoxPadEnable.Size = new System.Drawing.Size(128, 16);
            this.checkBoxPadEnable.TabIndex = 3;
            this.checkBoxPadEnable.Text = "패드 조종 사용하기";
            this.checkBoxPadEnable.UseVisualStyleBackColor = true;
            this.checkBoxPadEnable.CheckedChanged += new System.EventHandler(this.checkBoxPadEnable_CheckedChanged);
            // 
            // textBoxBaudRate
            // 
            this.textBoxBaudRate.Location = new System.Drawing.Point(388, 78);
            this.textBoxBaudRate.Name = "textBoxBaudRate";
            this.textBoxBaudRate.Size = new System.Drawing.Size(80, 21);
            this.textBoxBaudRate.TabIndex = 1;
            this.textBoxBaudRate.Text = "1000000";
            this.textBoxBaudRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnMecanumTurnR
            // 
            this.btnMecanumTurnR.Location = new System.Drawing.Point(726, 149);
            this.btnMecanumTurnR.Name = "btnMecanumTurnR";
            this.btnMecanumTurnR.Size = new System.Drawing.Size(75, 23);
            this.btnMecanumTurnR.TabIndex = 25;
            this.btnMecanumTurnR.Text = "Turn Left";
            this.btnMecanumTurnR.UseVisualStyleBackColor = true;
            this.btnMecanumTurnR.Click += new System.EventHandler(this.btnMecanumTurnR_Click);
            // 
            // btnMecanumTurnL
            // 
            this.btnMecanumTurnL.Location = new System.Drawing.Point(645, 149);
            this.btnMecanumTurnL.Name = "btnMecanumTurnL";
            this.btnMecanumTurnL.Size = new System.Drawing.Size(75, 23);
            this.btnMecanumTurnL.TabIndex = 26;
            this.btnMecanumTurnL.Text = "Turn Right";
            this.btnMecanumTurnL.UseVisualStyleBackColor = true;
            this.btnMecanumTurnL.Click += new System.EventHandler(this.btnMecanumTurnL_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(689, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "보정";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelPadState
            // 
            this.labelPadState.AutoSize = true;
            this.labelPadState.Location = new System.Drawing.Point(396, 218);
            this.labelPadState.Name = "labelPadState";
            this.labelPadState.Size = new System.Drawing.Size(82, 12);
            this.labelPadState.TabIndex = 28;
            this.labelPadState.Text = "labelPadState";
            // 
            // btnStairRight
            // 
            this.btnStairRight.Location = new System.Drawing.Point(147, 212);
            this.btnStairRight.Name = "btnStairRight";
            this.btnStairRight.Size = new System.Drawing.Size(103, 23);
            this.btnStairRight.TabIndex = 30;
            this.btnStairRight.Text = "계단 오르기 (R)";
            this.btnStairRight.UseVisualStyleBackColor = true;
            this.btnStairRight.Click += new System.EventHandler(this.btnStairRight_Click);
            // 
            // btnStairLeft
            // 
            this.btnStairLeft.Location = new System.Drawing.Point(38, 212);
            this.btnStairLeft.Name = "btnStairLeft";
            this.btnStairLeft.Size = new System.Drawing.Size(103, 23);
            this.btnStairLeft.TabIndex = 31;
            this.btnStairLeft.Text = "계단 오르기 L";
            this.btnStairLeft.UseVisualStyleBackColor = true;
            this.btnStairLeft.Click += new System.EventHandler(this.btnStairLeft_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 12);
            this.label1.TabIndex = 32;
            this.label1.Text = "Port number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 33;
            this.label2.Text = "Baud rate:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 354);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStairLeft);
            this.Controls.Add(this.btnStairRight);
            this.Controls.Add(this.labelPadState);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMecanumTurnL);
            this.Controls.Add(this.btnMecanumTurnR);
            this.Controls.Add(this.textBoxBaudRate);
            this.Controls.Add(this.checkBoxPadEnable);
            this.Controls.Add(this.btnMecanumPose);
            this.Controls.Add(this.btnTransformToWalk);
            this.Controls.Add(this.btnTransformToMecanum);
            this.Controls.Add(this.btnStandPose);
            this.Controls.Add(this.btnMecanumBL);
            this.Controls.Add(this.btnMecanumB);
            this.Controls.Add(this.btnMecanumBR);
            this.Controls.Add(this.btnMecanumL);
            this.Controls.Add(this.btnMecanumStop);
            this.Controls.Add(this.btnMecanumR);
            this.Controls.Add(this.btnMecanumFL);
            this.Controls.Add(this.btnMecanumF);
            this.Controls.Add(this.btnMecanumFR);
            this.Controls.Add(this.textBoxPortNum);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnTorqueOff);
            this.Controls.Add(this.btnTorqueOn);
            this.Controls.Add(this.btnWalkBack);
            this.Controls.Add(this.btnWalkTurnRight);
            this.Controls.Add(this.btnWalkStop);
            this.Controls.Add(this.btnWalkTurnLeft);
            this.Controls.Add(this.btnWalkFront);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWalkFront;
        private System.Windows.Forms.Button btnWalkTurnLeft;
        private System.Windows.Forms.Button btnWalkStop;
        private System.Windows.Forms.Button btnWalkTurnRight;
        private System.Windows.Forms.Button btnWalkBack;
        private System.Windows.Forms.Button btnTorqueOn;
        private System.Windows.Forms.Button btnTorqueOff;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox textBoxPortNum;
        private System.Windows.Forms.Button btnMecanumFR;
        private System.Windows.Forms.Button btnMecanumF;
        private System.Windows.Forms.Button btnMecanumFL;
        private System.Windows.Forms.Button btnMecanumR;
        private System.Windows.Forms.Button btnMecanumStop;
        private System.Windows.Forms.Button btnMecanumL;
        private System.Windows.Forms.Button btnMecanumBR;
        private System.Windows.Forms.Button btnMecanumB;
        private System.Windows.Forms.Button btnMecanumBL;
        private System.Windows.Forms.Button btnStandPose;
        private System.Windows.Forms.Button btnTransformToMecanum;
        private System.Windows.Forms.Button btnTransformToWalk;
        private System.Windows.Forms.Button btnMecanumPose;
        private System.Windows.Forms.CheckBox checkBoxPadEnable;
        private System.Windows.Forms.TextBox textBoxBaudRate;
        private System.Windows.Forms.Button btnMecanumTurnR;
        private System.Windows.Forms.Button btnMecanumTurnL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelPadState;
        private System.Windows.Forms.Button btnStairRight;
        private System.Windows.Forms.Button btnStairLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

