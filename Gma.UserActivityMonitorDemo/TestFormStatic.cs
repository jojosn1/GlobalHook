using System;
using System.Windows.Forms;
using Gma.UserActivityMonitor;
using System.Collections.Generic;
using TestMouse;
using System.Threading;

namespace Gma.UserActivityMonitorDemo
{
    public partial class TestFormStatic : Form
    {
        public TestFormStatic()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //##################################################################
        #region Check boxes to set or remove particular event handlers.

        private void checkBoxOnMouseMove_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOnMouseMove.Checked)
            {
                HookManager.MouseMove += HookManager_MouseMove;
            }
            else
            {
                HookManager.MouseMove -= HookManager_MouseMove;
            }
        }

        private void checkBoxOnMouseClick_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOnMouseClick.Checked)
            {
                HookManager.MouseClick += HookManager_MouseClick;
            }
            else
            {
                HookManager.MouseClick -= HookManager_MouseClick;
            }
        }

        private void checkBoxOnMouseUp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOnMouseUp.Checked)
            {
                HookManager.MouseUp += HookManager_MouseUp;
            }
            else
            {
                HookManager.MouseUp -= HookManager_MouseUp;
            }
        }

        private void checkBoxOnMouseDown_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOnMouseDown.Checked)
            {
                HookManager.MouseDown += HookManager_MouseDown;
            }
            else
            {
                HookManager.MouseDown -= HookManager_MouseDown;
            }
        }

        private void checkBoxMouseDoubleClick_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMouseDoubleClick.Checked)
            {
                HookManager.MouseDoubleClick += HookManager_MouseDoubleClick;
            }
            else
            {
                HookManager.MouseDoubleClick -= HookManager_MouseDoubleClick;
            }
        }

        private void checkBoxMouseWheel_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMouseWheel.Checked)
            {
                HookManager.MouseWheel += HookManager_MouseWheel;
            }
            else
            {
                HookManager.MouseWheel -= HookManager_MouseWheel;
            }
        }

        private void checkBoxKeyDown_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKeyDown.Checked)
            {
                HookManager.KeyDown += HookManager_KeyDown;
            }
            else
            {
                HookManager.KeyDown -= HookManager_KeyDown;
            }
        }


        private void checkBoxKeyUp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKeyUp.Checked)
            {
                HookManager.KeyUp += HookManager_KeyUp;
            }
            else
            {
                HookManager.KeyUp -= HookManager_KeyUp;
            }
        }

        private void checkBoxKeyPress_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKeyPress.Checked)
            {
                HookManager.KeyPress += HookManager_KeyPress;
            }
            else
            {
                HookManager.KeyPress -= HookManager_KeyPress;
            }
        }

        #endregion

        //##################################################################
        #region Event handlers of particular events. They will be activated when an appropriate checkbox is checked.

        private void HookManager_KeyDown(object sender, KeyEventArgs e)
        {
            //textBoxLog.AppendText(string.Format("KeyDown - {0}\n", e.KeyCode));
            //textBoxLog.ScrollToCaret();
            if (e.KeyCode == Keys.F5)
            {
                getouLoop = true;
                textBoxLog.AppendText(string.Format("F5 is pressed\n"));
            }
        }

        private void HookManager_KeyUp(object sender, KeyEventArgs e)
        {
            textBoxLog.AppendText(string.Format("KeyUp - {0}\n", e.KeyCode));
            textBoxLog.ScrollToCaret();
        }


        private void HookManager_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxLog.AppendText(string.Format("KeyPress - {0}\n", e.KeyChar));
            textBoxLog.ScrollToCaret();
            
        } 


        private void HookManager_MouseMove(object sender, MouseEventArgs e)
        {
            labelMousePosition.Text = string.Format("x={0:0000}; y={1:0000}", e.X, e.Y);
        }

        private void HookManager_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxLog.AppendText(string.Format("MouseClick - {0}\n", e.Button));
            textBoxLog.ScrollToCaret();
        }

        private void HookManager_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxLog.AppendText(string.Format("MouseUp - {0}\n", e.Button));
            textBoxLog.ScrollToCaret();
        }


        private void HookManager_MouseDown(object sender, MouseEventArgs e)
        {
            if (isRecordingClick)
            {
                // record 
                int sleepSecs = (int)TimeSpan.FromTicks(DateTime.Now.Ticks - lastClickTicks).TotalMilliseconds + 1000;
                clickInfoList.Add(new ClickInfo(e.X, e.Y, sleepSecs, false));
                lastClickTicks = DateTime.Now.Ticks;
            }
            else
            {
                textBoxLog.AppendText(string.Format("MouseDown - {0}\n", e.Button));
                textBoxLog.ScrollToCaret();
            }
        }


        private void HookManager_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (isRecordingClick)
            {
                // delete the two click before doubleclick, bcause double click has two single click
                for (int i = 0; i < 2; i++)
                {
                    if (clickInfoList.Count > 0)
                    {
                        clickInfoList.RemoveAt(clickInfoList.Count - 1);
                    }
                } 

                // record 
                int sleepSecs = (int)TimeSpan.FromTicks(DateTime.Now.Ticks - lastClickTicks).TotalMilliseconds + 1000;
                clickInfoList.Add(new ClickInfo(e.X, e.Y, sleepSecs, true));
                lastClickTicks = DateTime.Now.Ticks;
            }
            else
            {
                textBoxLog.AppendText(string.Format("MouseDoubleClick - {0}\n", e.Button));
                textBoxLog.ScrollToCaret();
            }
        }

        private void HookManager_MouseWheel(object sender, MouseEventArgs e)
        {
            labelWheel.Text = string.Format("Wheel={0:000}", e.Delta);
        }

        #endregion

        //##################################################################
        #region record click pos to start simulator
        public struct ClickInfo
        {
            public int x;
            public int y;
            public int sleepMiliSecs;
            public bool isDoubleClick;

            public ClickInfo(int x, int y, int sleepSecs, bool isDoubleClick)
            {
                this.x = x;
                this.y = y;
                this.sleepMiliSecs = sleepSecs;
                this.isDoubleClick = isDoubleClick;
            }
        }

        private List<ClickInfo> clickInfoList = new List<ClickInfo>();
        private bool getouLoop = false;
        private bool isRecordingClick = false;
        private long lastClickTicks = 0;
        private int simClickNum = 1;

        private delegate void invokeDelegate(string content);

        private void log2TextBox(string content)
        {
            textBoxLog.AppendText(content);
        }

        private void startSimLoop(Object outter)
        {
            TestFormStatic guiFormInst = (TestFormStatic)outter;

            getouLoop = false;
            guiFormInst.Invoke(new invokeDelegate(log2TextBox), "start simulate...\n");

            for (int n = 0; n < simClickNum; n++)
            {
                for (int i = 0; i < clickInfoList.Count && !getouLoop; i++)
                {
                    ClickInfo ckInfo = clickInfoList[i];
                    Thread.Sleep(ckInfo.sleepMiliSecs);
                    MouseOperations.SetCursorPosition(ckInfo.x, ckInfo.y);
                    MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftDown);
                    Thread.Sleep(200);
                    MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftUp);
                    if (ckInfo.isDoubleClick)
                    {
                        MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftDown);
                        Thread.Sleep(200);
                        MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftUp);
                    }

                    guiFormInst.Invoke(new invokeDelegate(log2TextBox), string.Format("step {0}\n", i));
                }
            }

            guiFormInst.Invoke(new invokeDelegate(log2TextBox), "simulate ended\n");
            getouLoop = true;
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (isRecordingClick)
            {
                isRecordingClick = false;
                btnRecord.Text = "StartRecord";

                // show all click records
                for (int i = 0; i < clickInfoList.Count; i++)
                {
                    ClickInfo ckInfo = clickInfoList[i];
                    textBoxLog.AppendText(string.Format("Click Record: x={0} y={1} secs={2} isDbl={3}\n",
                        ckInfo.x, ckInfo.y, ckInfo.sleepMiliSecs, ckInfo.isDoubleClick));
                }
                textBoxLog.ScrollToCaret();
            }
            else
            {
                isRecordingClick = true;
                btnRecord.Text = "StopRecord";
                clickInfoList.Clear();
                lastClickTicks = DateTime.Now.Ticks;
            }
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            if (clickInfoList.Count > 0)
            {
                clickInfoList.RemoveAt(clickInfoList.Count - 1);
            }

            simClickNum = int.Parse(tbSimNum.Text);
            Thread simClickThread = new Thread(new ParameterizedThreadStart(startSimLoop));
            simClickThread.Start(this);
        }

        private void btnIncTT_Click(object sender, EventArgs e)
        {
            textBoxLog.AppendText(string.Format("simulate click - {0}\n", (13>12?15:6>7?8:9)));
        }
        #endregion
    }
}