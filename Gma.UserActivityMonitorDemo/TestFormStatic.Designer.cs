namespace Gma.UserActivityMonitorDemo
{
    partial class TestFormStatic {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelMousePosition = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.labelWheel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSim = new System.Windows.Forms.Button();
            this.btnIncTT = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.checkBoxKeyUp = new System.Windows.Forms.CheckBox();
            this.checkBoxKeyPress = new System.Windows.Forms.CheckBox();
            this.checkBoxKeyDown = new System.Windows.Forms.CheckBox();
            this.checkBoxMouseWheel = new System.Windows.Forms.CheckBox();
            this.checkBoxMouseDoubleClick = new System.Windows.Forms.CheckBox();
            this.checkBoxOnMouseUp = new System.Windows.Forms.CheckBox();
            this.checkBoxOnMouseDown = new System.Windows.Forms.CheckBox();
            this.checkBoxOnMouseClick = new System.Windows.Forms.CheckBox();
            this.checkBoxOnMouseMove = new System.Windows.Forms.CheckBox();
            this.tbSimNum = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMousePosition
            // 
            this.labelMousePosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMousePosition.AutoSize = true;
            this.labelMousePosition.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMousePosition.Location = new System.Drawing.Point(185, 85);
            this.labelMousePosition.Name = "labelMousePosition";
            this.labelMousePosition.Size = new System.Drawing.Size(162, 16);
            this.labelMousePosition.TabIndex = 2;
            this.labelMousePosition.Text = "x={0:####}; y={1:####}";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLog.Location = new System.Drawing.Point(0, 255);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(353, 145);
            this.textBoxLog.TabIndex = 5;
            this.textBoxLog.WordWrap = false;
            // 
            // labelWheel
            // 
            this.labelWheel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWheel.AutoSize = true;
            this.labelWheel.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWheel.Location = new System.Drawing.Point(185, 103);
            this.labelWheel.Name = "labelWheel";
            this.labelWheel.Size = new System.Drawing.Size(106, 16);
            this.labelWheel.TabIndex = 6;
            this.labelWheel.Text = "Wheel={0:####}";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbSimNum);
            this.groupBox2.Controls.Add(this.btnSim);
            this.groupBox2.Controls.Add(this.btnIncTT);
            this.groupBox2.Controls.Add(this.btnRecord);
            this.groupBox2.Controls.Add(this.checkBoxKeyUp);
            this.groupBox2.Controls.Add(this.labelWheel);
            this.groupBox2.Controls.Add(this.checkBoxKeyPress);
            this.groupBox2.Controls.Add(this.labelMousePosition);
            this.groupBox2.Controls.Add(this.checkBoxKeyDown);
            this.groupBox2.Controls.Add(this.checkBoxMouseWheel);
            this.groupBox2.Controls.Add(this.checkBoxMouseDoubleClick);
            this.groupBox2.Controls.Add(this.checkBoxOnMouseUp);
            this.groupBox2.Controls.Add(this.checkBoxOnMouseDown);
            this.groupBox2.Controls.Add(this.checkBoxOnMouseClick);
            this.groupBox2.Controls.Add(this.checkBoxOnMouseMove);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 255);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // btnSim
            // 
            this.btnSim.Location = new System.Drawing.Point(122, 161);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(103, 36);
            this.btnSim.TabIndex = 9;
            this.btnSim.Text = "SimClick";
            this.btnSim.UseVisualStyleBackColor = true;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // btnIncTT
            // 
            this.btnIncTT.Location = new System.Drawing.Point(231, 161);
            this.btnIncTT.Name = "btnIncTT";
            this.btnIncTT.Size = new System.Drawing.Size(103, 36);
            this.btnIncTT.TabIndex = 9;
            this.btnIncTT.Text = "IncTT";
            this.btnIncTT.UseVisualStyleBackColor = true;
            this.btnIncTT.Click += new System.EventHandler(this.btnIncTT_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(13, 161);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(103, 36);
            this.btnRecord.TabIndex = 9;
            this.btnRecord.Text = "StartRecord";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // checkBoxKeyUp
            // 
            this.checkBoxKeyUp.AutoSize = true;
            this.checkBoxKeyUp.Location = new System.Drawing.Point(190, 62);
            this.checkBoxKeyUp.Name = "checkBoxKeyUp";
            this.checkBoxKeyUp.Size = new System.Drawing.Size(54, 16);
            this.checkBoxKeyUp.TabIndex = 8;
            this.checkBoxKeyUp.Text = "KeyUp";
            this.checkBoxKeyUp.UseVisualStyleBackColor = true;
            this.checkBoxKeyUp.CheckedChanged += new System.EventHandler(this.checkBoxKeyUp_CheckedChanged);
            // 
            // checkBoxKeyPress
            // 
            this.checkBoxKeyPress.AutoSize = true;
            this.checkBoxKeyPress.Location = new System.Drawing.Point(190, 40);
            this.checkBoxKeyPress.Name = "checkBoxKeyPress";
            this.checkBoxKeyPress.Size = new System.Drawing.Size(72, 16);
            this.checkBoxKeyPress.TabIndex = 7;
            this.checkBoxKeyPress.Text = "KeyPress";
            this.checkBoxKeyPress.UseVisualStyleBackColor = true;
            this.checkBoxKeyPress.CheckedChanged += new System.EventHandler(this.checkBoxKeyPress_CheckedChanged);
            // 
            // checkBoxKeyDown
            // 
            this.checkBoxKeyDown.AutoSize = true;
            this.checkBoxKeyDown.Location = new System.Drawing.Point(190, 18);
            this.checkBoxKeyDown.Name = "checkBoxKeyDown";
            this.checkBoxKeyDown.Size = new System.Drawing.Size(66, 16);
            this.checkBoxKeyDown.TabIndex = 6;
            this.checkBoxKeyDown.Text = "KeyDown";
            this.checkBoxKeyDown.UseVisualStyleBackColor = true;
            this.checkBoxKeyDown.CheckedChanged += new System.EventHandler(this.checkBoxKeyDown_CheckedChanged);
            // 
            // checkBoxMouseWheel
            // 
            this.checkBoxMouseWheel.AutoSize = true;
            this.checkBoxMouseWheel.Location = new System.Drawing.Point(13, 126);
            this.checkBoxMouseWheel.Name = "checkBoxMouseWheel";
            this.checkBoxMouseWheel.Size = new System.Drawing.Size(84, 16);
            this.checkBoxMouseWheel.TabIndex = 5;
            this.checkBoxMouseWheel.Text = "MouseWheel";
            this.checkBoxMouseWheel.UseVisualStyleBackColor = true;
            this.checkBoxMouseWheel.CheckedChanged += new System.EventHandler(this.checkBoxMouseWheel_CheckedChanged);
            // 
            // checkBoxMouseDoubleClick
            // 
            this.checkBoxMouseDoubleClick.AutoSize = true;
            this.checkBoxMouseDoubleClick.Location = new System.Drawing.Point(13, 103);
            this.checkBoxMouseDoubleClick.Name = "checkBoxMouseDoubleClick";
            this.checkBoxMouseDoubleClick.Size = new System.Drawing.Size(120, 16);
            this.checkBoxMouseDoubleClick.TabIndex = 4;
            this.checkBoxMouseDoubleClick.Text = "MouseDoubleClick";
            this.checkBoxMouseDoubleClick.UseVisualStyleBackColor = true;
            this.checkBoxMouseDoubleClick.CheckedChanged += new System.EventHandler(this.checkBoxMouseDoubleClick_CheckedChanged);
            // 
            // checkBoxOnMouseUp
            // 
            this.checkBoxOnMouseUp.AutoSize = true;
            this.checkBoxOnMouseUp.Location = new System.Drawing.Point(13, 84);
            this.checkBoxOnMouseUp.Name = "checkBoxOnMouseUp";
            this.checkBoxOnMouseUp.Size = new System.Drawing.Size(66, 16);
            this.checkBoxOnMouseUp.TabIndex = 3;
            this.checkBoxOnMouseUp.Text = "MouseUp";
            this.checkBoxOnMouseUp.UseVisualStyleBackColor = true;
            this.checkBoxOnMouseUp.CheckedChanged += new System.EventHandler(this.checkBoxOnMouseUp_CheckedChanged);
            // 
            // checkBoxOnMouseDown
            // 
            this.checkBoxOnMouseDown.AutoSize = true;
            this.checkBoxOnMouseDown.Location = new System.Drawing.Point(13, 62);
            this.checkBoxOnMouseDown.Name = "checkBoxOnMouseDown";
            this.checkBoxOnMouseDown.Size = new System.Drawing.Size(78, 16);
            this.checkBoxOnMouseDown.TabIndex = 2;
            this.checkBoxOnMouseDown.Text = "MouseDown";
            this.checkBoxOnMouseDown.UseVisualStyleBackColor = true;
            this.checkBoxOnMouseDown.CheckedChanged += new System.EventHandler(this.checkBoxOnMouseDown_CheckedChanged);
            // 
            // checkBoxOnMouseClick
            // 
            this.checkBoxOnMouseClick.AutoSize = true;
            this.checkBoxOnMouseClick.Location = new System.Drawing.Point(13, 40);
            this.checkBoxOnMouseClick.Name = "checkBoxOnMouseClick";
            this.checkBoxOnMouseClick.Size = new System.Drawing.Size(84, 16);
            this.checkBoxOnMouseClick.TabIndex = 1;
            this.checkBoxOnMouseClick.Text = "MouseClick";
            this.checkBoxOnMouseClick.UseVisualStyleBackColor = true;
            this.checkBoxOnMouseClick.CheckedChanged += new System.EventHandler(this.checkBoxOnMouseClick_CheckedChanged);
            // 
            // checkBoxOnMouseMove
            // 
            this.checkBoxOnMouseMove.AutoSize = true;
            this.checkBoxOnMouseMove.Location = new System.Drawing.Point(13, 18);
            this.checkBoxOnMouseMove.Name = "checkBoxOnMouseMove";
            this.checkBoxOnMouseMove.Size = new System.Drawing.Size(78, 16);
            this.checkBoxOnMouseMove.TabIndex = 0;
            this.checkBoxOnMouseMove.Text = "MouseMove";
            this.checkBoxOnMouseMove.UseVisualStyleBackColor = true;
            this.checkBoxOnMouseMove.CheckedChanged += new System.EventHandler(this.checkBoxOnMouseMove_CheckedChanged);
            // 
            // tbSimNum
            // 
            this.tbSimNum.Location = new System.Drawing.Point(105, 217);
            this.tbSimNum.Name = "tbSimNum";
            this.tbSimNum.Size = new System.Drawing.Size(120, 21);
            this.tbSimNum.TabIndex = 10;
            // 
            // TestFormStatic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 400);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.groupBox2);
            this.Name = "TestFormStatic";
            this.Text = "Test for the class HookManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMousePosition;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label labelWheel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxKeyUp;
        private System.Windows.Forms.CheckBox checkBoxKeyPress;
        private System.Windows.Forms.CheckBox checkBoxKeyDown;
        private System.Windows.Forms.CheckBox checkBoxMouseWheel;
        private System.Windows.Forms.CheckBox checkBoxMouseDoubleClick;
        private System.Windows.Forms.CheckBox checkBoxOnMouseUp;
        private System.Windows.Forms.CheckBox checkBoxOnMouseDown;
        private System.Windows.Forms.CheckBox checkBoxOnMouseClick;
        private System.Windows.Forms.CheckBox checkBoxOnMouseMove;
        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnIncTT;
        private System.Windows.Forms.TextBox tbSimNum;
    }
}