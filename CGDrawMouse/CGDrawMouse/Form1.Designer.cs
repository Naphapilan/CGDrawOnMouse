namespace CGDrawMouse
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDraw = new System.Windows.Forms.Button();
            this.lblCo = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtW = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtXS = new System.Windows.Forms.TextBox();
            this.txtYE = new System.Windows.Forms.TextBox();
            this.txtYS = new System.Windows.Forms.TextBox();
            this.txtXE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCir = new System.Windows.Forms.RadioButton();
            this.rdbRect = new System.Windows.Forms.RadioButton();
            this.rdbLine = new System.Windows.Forms.RadioButton();
            this.chkMouseDraw = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDraw.Location = new System.Drawing.Point(826, 8);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(76, 23);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "วาดรูป";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // lblCo
            // 
            this.lblCo.AutoSize = true;
            this.lblCo.Location = new System.Drawing.Point(-3, 512);
            this.lblCo.Name = "lblCo";
            this.lblCo.Size = new System.Drawing.Size(53, 15);
            this.lblCo.TabIndex = 1;
            this.lblCo.Text = "จุดพิกัด =";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(14, 16);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "เลือกสี";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(95, 20);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(49, 15);
            this.lblColor.TabIndex = 3;
            this.lblColor.Text = "แสดงค่าสี";
            this.lblColor.TextChanged += new System.EventHandler(this.lblColor_TextChanged);
            this.lblColor.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // txtW
            // 
            this.txtW.Location = new System.Drawing.Point(150, 16);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(28, 23);
            this.txtW.TabIndex = 1;
            this.txtW.Text = "5";
            this.txtW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(827, 37);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "ลบรูป";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtXS
            // 
            this.txtXS.Location = new System.Drawing.Point(62, 42);
            this.txtXS.Name = "txtXS";
            this.txtXS.Size = new System.Drawing.Size(35, 23);
            this.txtXS.TabIndex = 2;
            this.txtXS.Text = "50";
            // 
            // txtYE
            // 
            this.txtYE.Location = new System.Drawing.Point(103, 70);
            this.txtYE.Name = "txtYE";
            this.txtYE.Size = new System.Drawing.Size(35, 23);
            this.txtYE.TabIndex = 5;
            this.txtYE.Text = "102";
            // 
            // txtYS
            // 
            this.txtYS.Location = new System.Drawing.Point(103, 41);
            this.txtYS.Name = "txtYS";
            this.txtYS.Size = new System.Drawing.Size(35, 23);
            this.txtYS.TabIndex = 3;
            this.txtYS.Text = "305";
            // 
            // txtXE
            // 
            this.txtXE.Location = new System.Drawing.Point(62, 70);
            this.txtXE.Name = "txtXE";
            this.txtXE.Size = new System.Drawing.Size(35, 23);
            this.txtXE.TabIndex = 4;
            this.txtXE.Text = "204";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "จุดเริ่ม";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "จุดสิ้นสุด";
            // 
            // btnClearData
            // 
            this.btnClearData.Location = new System.Drawing.Point(827, 65);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(75, 23);
            this.btnClearData.TabIndex = 12;
            this.btnClearData.Text = "ล้างข้อมูล";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbCir);
            this.groupBox1.Controls.Add(this.rdbRect);
            this.groupBox1.Controls.Add(this.rdbLine);
            this.groupBox1.Location = new System.Drawing.Point(193, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 81);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "เลือกประเภท";
            // 
            // rdbCir
            // 
            this.rdbCir.AutoSize = true;
            this.rdbCir.Location = new System.Drawing.Point(9, 49);
            this.rdbCir.Name = "rdbCir";
            this.rdbCir.Size = new System.Drawing.Size(75, 19);
            this.rdbCir.TabIndex = 2;
            this.rdbCir.TabStop = true;
            this.rdbCir.Text = "วงกลม/วงรี";
            this.rdbCir.UseVisualStyleBackColor = true;
            // 
            // rdbRect
            // 
            this.rdbRect.AutoSize = true;
            this.rdbRect.Location = new System.Drawing.Point(73, 24);
            this.rdbRect.Name = "rdbRect";
            this.rdbRect.Size = new System.Drawing.Size(60, 19);
            this.rdbRect.TabIndex = 1;
            this.rdbRect.TabStop = true;
            this.rdbRect.Text = "สี่เหลี่ยม";
            this.rdbRect.UseVisualStyleBackColor = true;
            // 
            // rdbLine
            // 
            this.rdbLine.AutoSize = true;
            this.rdbLine.Location = new System.Drawing.Point(9, 24);
            this.rdbLine.Name = "rdbLine";
            this.rdbLine.Size = new System.Drawing.Size(58, 19);
            this.rdbLine.TabIndex = 0;
            this.rdbLine.TabStop = true;
            this.rdbLine.Text = "เส้นตรง";
            this.rdbLine.UseVisualStyleBackColor = true;
            // 
            // chkMouseDraw
            // 
            this.chkMouseDraw.AutoSize = true;
            this.chkMouseDraw.Location = new System.Drawing.Point(353, 20);
            this.chkMouseDraw.Name = "chkMouseDraw";
            this.chkMouseDraw.Size = new System.Drawing.Size(115, 19);
            this.chkMouseDraw.TabIndex = 14;
            this.chkMouseDraw.Text = "วาดเส้นตรงด้วยเมาส์";
            this.chkMouseDraw.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 527);
            this.Controls.Add(this.chkMouseDraw);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClearData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtXE);
            this.Controls.Add(this.txtYS);
            this.Controls.Add(this.txtYE);
            this.Controls.Add(this.txtXS);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtW);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.lblCo);
            this.Controls.Add(this.btnDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDraw;
        private Label lblCo;
        private Button btnColor;
        private Label lblColor;
        private TextBox txtW;
        private ColorDialog colorDialog1;
        private Button btnClear;
        private TextBox txtXS;
        private TextBox txtYE;
        private TextBox txtYS;
        private TextBox txtXE;
        private Label label1;
        private Label label2;
        private Button btnClearData;
        private GroupBox groupBox1;
        private RadioButton rdbCir;
        private RadioButton rdbRect;
        private RadioButton rdbLine;
        private CheckBox chkMouseDraw;
    }
}