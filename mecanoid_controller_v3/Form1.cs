using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenJigWare;

namespace mecanoid_controller_v3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Ojw.CMonster motor = new Ojw.CMonster();
        Ojw.CJoystick pad = new Ojw.CJoystick(Ojw.CJoystick._ID_0);

        bool walking = false;
        bool mecanumMode = false;

        int mecanumSpeed = 80;
        double mecanumAdd = 1.8;
        double mecanumAdd2 = 2.5;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            motor.Open(Convert.ToInt32(textBoxPortNum.Text), Convert.ToInt32(textBoxBaudRate.Text));
            //motor.AutoSet();

            motor.Delay(1000);
            motor.SetTorq(true);
            motor.Delay(500);
            motor.SetTorq(true);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            motor.SetTorq(false);
            motor.Close();
        }

        private void btnTorqueOn_Click(object sender, EventArgs e)
        {
            motor.SetTorq(true);
        }

        private void btnTorqueOff_Click(object sender, EventArgs e)
        {
            motor.SetTorq(false);
        }

        private void btnWalkFront_Click(object sender, EventArgs e)
        {
            motor.SetTorq(true);
            Random rand = new Random();
            bool rightStep = rand.Next(0, 2) == 0;
            walking = true;
            /*
            if (rightStep)
            {
                motor.Motion_Play(@"motions\new_walking_start_right.dmt");
                rightStep = false;
            }
            else
            {
                motor.Motion_Play(@"motions\new_walking_start_left.dmt");
                rightStep = true;
            }

            while (walking)
            {
                if (rightStep)
                {
                    motor.Motion_Play(@"motions\new_walking_walking_right.dmt");
                    rightStep = false;
                }
                else
                {
                    motor.Motion_Play(@"motions\new_walking_walking_left.dmt");
                    rightStep = true;
                }
            }
            if (rightStep == false)
            {
                motor.Motion_Play(@"motions\new_walking_end_left.dmt");
            }
            else
            {
                motor.Motion_Play(@"motions\new_walking_end_right.dmt");
            }*/
            if (rightStep)
            {
                motor.Motion_Play(@"motions\walk_forward_start_right_45.dmt");
                rightStep = false;
            }
            else
            {
                motor.Motion_Play(@"motions\walk_forward_start_left_45.dmt");
                rightStep = true;
            }

            while (walking)
            {
                if (rightStep)
                {
                    motor.Motion_Play(@"motions\walk_forward_walking_right_45.dmt");
                    rightStep = false;
                }
                else
                {
                    motor.Motion_Play(@"motions\walk_forward_walking_left_45.dmt");
                    rightStep = true;
                }
            }
            if (rightStep == false)
            {
                motor.Motion_Play(@"motions\walk_forward_end_left_45.dmt");
            }
            else
            {
                motor.Motion_Play(@"motions\walk_forward_end_right_45.dmt");
            }
            motor.Motion_Play(@"motions\stand2.dmt");
        }

        private void btnWalkTurnLeft_Click(object sender, EventArgs e)
        {
            walking = true;
            motor.Motion_Play(@"motions\turnLeftStart.dmt");
            while (walking)
            {
                motor.Motion_Play(@"motions\turnLeftWalking.dmt");
            }
            motor.Motion_Play(@"motions\turnLeftEnd.dmt");
            motor.Motion_Play(@"motions\stand2.dmt");
        }

        private void btnWalkTurnRight_Click(object sender, EventArgs e)
        {
            walking = true;
            motor.Motion_Play(@"motions\turnRightStart.dmt");
            motor.Motion_Play(@"motions\turnRightEnd.dmt");
            motor.Motion_Play(@"motions\stand2.dmt");
        }

        private void btnWalkBack_Click(object sender, EventArgs e)
        {
            walking = true;
            motor.Motion_Play(@"motions\walkBackStartR.dmt");
            bool rightStep = true;
            while (walking)
            {
                if (rightStep)
                {
                    motor.Motion_Play(@"motions\walkBackWalkingL.dmt");
                    rightStep = false;
                }
                else
                {
                    motor.Motion_Play(@"motions\walkBackWalkingR.dmt");
                    rightStep = true;
                }
            }
            if (rightStep == true)
            {
                motor.Motion_Play(@"motions\walkBackEndL.dmt");
            }
            else
            {
                motor.Motion_Play(@"motions\walkBackEndR.dmt");
            }
            motor.Motion_Play(@"motions\stand2.dmt");
        }

        private void btnWalkStop_Click(object sender, EventArgs e)
        {
            walking = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            motor.SetTorq(false);
            motor.Close();
        }

        private void btnStandPose_Click(object sender, EventArgs e)
        {
            motor.SetTorq(true);
            motor.Motion_Play(@"motions\stand2Slow.dmt");
            mecanumMode = false;
        }

        private void btnMecanumPose_Click(object sender, EventArgs e)
        {
            motor.SetTorq(true);
            motor.Motion_Play(@"motions\mecanum_pose_new.dmt");
            motor.SetTorq(true);
            mecanumMode = true;
            motor.Set_Turn(30, 0);
            motor.Set_Turn(31, 0);
            motor.Set_Turn(32, 0);
            motor.Set_Turn(33, 0);
            motor.Send_Motor(10);
            motor.Wait();
        }

        private void btnTransformToMecanum_Click(object sender, EventArgs e)
        {
            motor.SetTorq(true);
            motor.Motion_Play(@"motions\transform_to_mecanum3.dmt");
            mecanumMode = true;

            motor.Set_Turn(30, 0);
            motor.Set_Turn(31, 0);
            motor.Set_Turn(32, 0);
            motor.Set_Turn(33, 0);
            motor.Send_Motor(10);
            motor.Wait(20);

            motor.Set_Turn(30, -80);
            motor.Set_Turn(31, 80);
            motor.Set_Turn(32, -80);
            motor.Set_Turn(33, 80);
            motor.Send_Motor(10);
            motor.Wait(200);

            motor.Set_Turn(30, 0);
            motor.Set_Turn(31, 0);
            motor.Set_Turn(32, 0);
            motor.Set_Turn(33, 0);
            motor.Send_Motor(10);
            motor.Wait(20);
            motor.Motion_Play(@"motions\mecanum_pose_new.dmt");
        }

        private void btnTransformToWalk_Click(object sender, EventArgs e)
        {
            motor.SetTorq(true);
            motor.Motion_Play(@"motions\transform_to_stand2.dmt");
            mecanumMode = false;

        }

        private void btnMecanumStop_Click(object sender, EventArgs e)
        {
            motor.Set_Turn(30, 0);
            motor.Set_Turn(31, 0);
            motor.Set_Turn(32, 0);
            motor.Set_Turn(33, 0);
            motor.Send_Motor(1);
        }

        private void btnMecanumF_Click(object sender, EventArgs e)
        {
            motor.Set_Turn(30, -mecanumSpeed);
            motor.Set_Turn(31, -mecanumSpeed);
            motor.Set_Turn(32, mecanumSpeed);
            motor.Set_Turn(33, mecanumSpeed);
            motor.Send_Motor(1);
        }

        private void btnMecanumFR_Click(object sender, EventArgs e)
        {
            motor.Set_Turn(30, 0);
            motor.Set_Turn(31, -mecanumSpeed);
            motor.Set_Turn(32, 0);
            motor.Set_Turn(33, mecanumSpeed);
            motor.Send_Motor(1);
        }

        private void btnMecanumFL_Click(object sender, EventArgs e)
        {
            motor.Set_Turn(30, -mecanumSpeed);
            motor.Set_Turn(31, 0);
            motor.Set_Turn(32, mecanumSpeed);
            motor.Set_Turn(33, 0);
            motor.Send_Motor(1);
        }

        private void btnMecanumBR_Click(object sender, EventArgs e)
        {
            motor.Set_Turn(30, mecanumSpeed);
            motor.Set_Turn(31, 0);
            motor.Set_Turn(32, -mecanumSpeed);
            motor.Set_Turn(33, 0);
            motor.Send_Motor(1);
        }

        private void btnMecanumB_Click(object sender, EventArgs e)
        {
            motor.Set_Turn(30, mecanumSpeed);
            motor.Set_Turn(31, mecanumSpeed);
            motor.Set_Turn(32, -mecanumSpeed);
            motor.Set_Turn(33, -mecanumSpeed);
            motor.Send_Motor(1);
        }

        private void btnMecanumBL_Click(object sender, EventArgs e)
        {
            motor.Set_Turn(30, 0);
            motor.Set_Turn(31, mecanumSpeed);
            motor.Set_Turn(32, 0);
            motor.Set_Turn(33, -mecanumSpeed);
            motor.Send_Motor(1);
        }

        private void btnMecanumR_Click(object sender, EventArgs e)
        {
            motor.Set_Turn(30, mecanumSpeed);
            motor.Set_Turn(31, -mecanumSpeed);
            motor.Set_Turn(32, -mecanumSpeed);
            motor.Set_Turn(33, mecanumSpeed);
            motor.Send_Motor(1);
        }

        private void btnMecanumL_Click(object sender, EventArgs e)
        {
            motor.Set_Turn(30, -mecanumSpeed);
            motor.Set_Turn(31, mecanumSpeed);
            motor.Set_Turn(32, mecanumSpeed);
            motor.Set_Turn(33, -mecanumSpeed);
            motor.Send_Motor(1);
        }

        private void btnMecanumTurnR_Click(object sender, EventArgs e)
        {
            motor.Set_Turn(30, mecanumSpeed);
            motor.Set_Turn(31, mecanumSpeed);
            motor.Set_Turn(32, mecanumSpeed);
            motor.Set_Turn(33, mecanumSpeed);
            motor.Send_Motor(1);
        }

        private void btnMecanumTurnL_Click(object sender, EventArgs e)
        {
            motor.Set_Turn(30, -mecanumSpeed);
            motor.Set_Turn(31, -mecanumSpeed);
            motor.Set_Turn(32, -mecanumSpeed);
            motor.Set_Turn(33, -mecanumSpeed);
            motor.Send_Motor(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 보정 기능
            motor.Set_Turn(30, -50);
            motor.Set_Turn(31, 50);
            motor.Set_Turn(32, -50);
            motor.Set_Turn(33, 50);
            motor.Send_Motor(150);
            motor.Wait();

            motor.Set_Turn(30, 0);
            motor.Set_Turn(31, 0);
            motor.Set_Turn(32, 0);
            motor.Set_Turn(33, 0);
            motor.Send_Motor(1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pad.Update();
            pad_check_alive();
            if(pad.IsValid == true & checkBoxPadEnable.Checked == true)
            {
                pad_check_data();
            }
        }

        private void pad_check_alive()
        {
            if(pad.IsValid == false)
            {
                // 조이스틱이 연결 안되었을때
                labelPadState.Text = "Pad state: Not connected";
                checkBoxPadEnable.Enabled = false;
                checkBoxPadEnable.Checked = false;
                pad = new Ojw.CJoystick(Ojw.CJoystick._ID_0);
            }
            else
            {
                labelPadState.Text = "Pad state: Connected";
            }
        }

        private void pad_check_data()
        {
            double mecFB = 0;
            double mecRL = 0;
            double mecT = 0;
            int inside = 0;
            if (mecanumMode == true)//메카넘모드일때
            {
                if (pad.dY1 > 0.52 | pad.dY1 < 0.48)
                {
                    mecFB = -(pad.dY1 - 0.5) * mecanumSpeed * mecanumAdd;
                }
                if (pad.dX1 > 0.52 | pad.dX1 < 0.48)
                {
                    mecRL = (pad.dX1 - 0.5) * mecanumSpeed * mecanumAdd;
                }
                /*if (pad.dX0 > 0.55 | pad.dX0 < 0.45)
                {
                    mecT = (pad.dX0 - 0.5) * mecanumSpeed * mecanumAdd;
                    light = true;
                }*/
                if (pad.Slide > 0.52 | pad.Slide < 0.48)
                {
                    mecT = -(pad.Slide - 0.5) * mecanumSpeed * mecanumAdd;
                }
                if (pad.dX0 > 0.52 | pad.dX0 < 0.48 | pad.dY0 > 0.52 | pad.dY0 < 0.48)
                {
                    mecFB = -(pad.dY0 - 0.5) * mecanumSpeed * mecanumAdd2;
                    mecT = (pad.dX0 - 0.5) * mecanumSpeed * mecanumAdd2;
                    /*if (mecFB < 0)
                    {
                        mecT = -mecT;
                    }*/
                }

                if (pad.IsDown(Ojw.CJoystick.PadKey.Button1) == true)
                {
                    // A   보정 기능
                    inside = 100;
                }

                if (pad.IsDown(Ojw.CJoystick.PadKey.POVUp) == true) //위 버튼
                {
                    mecFB = mecanumSpeed;
                }
                else if (pad.IsDown(Ojw.CJoystick.PadKey.POVDown) == true) //아래 버튼
                {
                    mecFB = -mecanumSpeed;
                }
                if (pad.IsDown(Ojw.CJoystick.PadKey.POVRight) == true)
                {
                    mecRL = mecanumSpeed;
                }
                else if (pad.IsDown(Ojw.CJoystick.PadKey.POVLeft) == true)
                {
                    mecRL = -mecanumSpeed;
                }

                motor.Set_Turn(30, (int)(-mecFB + mecRL + mecT - inside));
                motor.Set_Turn(31, (int)(-mecFB - mecRL + mecT + (2 * inside)));
                motor.Set_Turn(32, (int)(mecFB - mecRL + mecT - (2 * inside)));
                motor.Set_Turn(33, (int)(mecFB + mecRL + mecT + inside));
                
                motor.Send_Motor(10);
                motor.Wait(10);
            }
            else//걷기모드일때
            {
                if (!walking) //걷고있지 않을때
                {
                    if (pad.IsDown_Event(Ojw.CJoystick.PadKey.POVUp) == true) //위 버튼
                    {
                        btnWalkFront_Click(null, null);
                    }
                    else if (pad.IsDown_Event(Ojw.CJoystick.PadKey.POVDown) == true) //아래 버튼
                    {
                        btnWalkBack_Click(null, null);
                    }
                    else if (pad.IsDown_Event(Ojw.CJoystick.PadKey.POVRight) == true)
                    {
                        btnWalkTurnRight_Click(null, null);
                    }
                    else if (pad.IsDown_Event(Ojw.CJoystick.PadKey.POVLeft) == true)
                    {
                        btnWalkTurnLeft_Click(null, null);
                    }
                    //X버튼
                    if (pad.IsDown_Event(Ojw.CJoystick.PadKey.Button3) == true)
                    {
                        btnStairLeft_Click(null, null);
                    }
                    if (pad.IsDown_Event(Ojw.CJoystick.PadKey.Button4) == true)
                    {
                        btnStairRight_Click(null, null);
                    }
                }
                //B 버튼
                if (pad.IsDown(Ojw.CJoystick.PadKey.Button2) == true)
                {
                    btnWalkStop_Click(null, null);
                }
            }
            //왼쪽 트리거 버튼
            if (pad.IsDown_Event(Ojw.CJoystick.PadKey.Button5) == true) // 보행 모드
            {
                if (mecanumMode == true) //메카넘 모드일때
                {
                    btnTransformToWalk_Click(null, null);
                }
                else
                {
                    btnStandPose_Click(null, null);
                }
            }
            //오른쪽 트리거 버튼
            if (pad.IsDown_Event(Ojw.CJoystick.PadKey.Button6) == true) // 메카넘 모드 버튼
            {
                if (mecanumMode == false) //보행 모드일때
                {
                    btnTransformToMecanum_Click(null, null);
                }
                else
                {
                    btnMecanumPose_Click(null, null);
                }
            }
            if (pad.IsDown_Event(Ojw.CJoystick.PadKey.Button7) == true)
            {
                // BACK
                motor.SetTorq(false);
            }
            if (pad.IsDown_Event(Ojw.CJoystick.PadKey.Button8) == true)
            {
                // START
                motor.SetTorq(true);
            }
        }

        private void checkBoxPadEnable_CheckedChanged(object sender, EventArgs e)
        {
            /*
            if (checkBoxPadEnable.Checked == true)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBoxPadEnable.Checked = true;
        }

        private void btnHide(bool isWalking)
        {
            btnWalkBack.Enabled = false;
            btnWalkFront.Enabled = false;
            btnWalkTurnRight.Enabled = false;
            btnWalkTurnLeft.Enabled = false;
            btnTransformToMecanum.Enabled = false;
            btnTransformToWalk.Enabled = false;
            btnStandPose.Enabled = false;
            btnMecanumPose.Enabled = false;
            btnMecanumR.Enabled = false;
            btnMecanumL.Enabled = false;
            btnMecanumFR.Enabled = false;
            btnMecanumFL.Enabled = false;
            btnMecanumBR.Enabled = false;
            btnMecanumBL.Enabled = false;

        }

        private void btnStairLeft_Click(object sender, EventArgs e)
        {
            motor.Motion_Play(@"motions\climbStairLeft3.dmt");
        }

        private void btnStairRight_Click(object sender, EventArgs e)
        {
            motor.Motion_Play(@"motions\climbStairRight3.dmt");
            //motor.Motion_Play(@"D:\Mecanoid project\new_new_new\transform_to_stand - 복사본.dmt");
        }
    }
}
