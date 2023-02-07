namespace CGDrawMouse
{
    public partial class Form1 : Form
    {
        Graphics myGraphic;
        Pen myPen1;
        int xStart, yStart , xEnd , yEnd ;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {    
            xStart = int.Parse(txtXS.Text);
            yStart = int.Parse(txtYS.Text);
            xEnd = int.Parse(txtXE.Text);
            yEnd = int.Parse(txtYE.Text);
            if (rdbLine.Checked)
            {
                myGraphic = CreateGraphics();
                myPen1 = new Pen(lblColor.ForeColor,int.Parse(txtW.Text));
                myGraphic.DrawLine(myPen1, xStart, yStart, xEnd, yEnd);
            }
            if (rdbRect.Checked)
            {
                myGraphic = CreateGraphics();
                myPen1 = new Pen(lblColor.ForeColor, int.Parse(txtW.Text));
                myGraphic.DrawRectangle(myPen1, xStart, yStart, xEnd, yEnd);
            }
            if (rdbCir.Checked)
            {
                myGraphic = CreateGraphics();
                myPen1 = new Pen(lblColor.ForeColor, int.Parse(txtW.Text));
                myGraphic.DrawEllipse(myPen1, xStart, yStart, xEnd, yEnd);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            myGraphic.Dispose();
            myPen1.Dispose();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            lblCo.Text = "�ش�ԡѴ (x,y) = " + e.X + " , " + e.Y;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string str = null;
                str = dlg.Color.Name;
                lblColor.Text = str;
                lblColor.ForeColor = dlg.Color;

            }
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            txtXS.Clear();
            txtYS.Clear();
            txtXE.Clear();
            txtYE.Clear();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (chkMouseDraw.Checked)
            {
                xStart = e.X;
                yStart = e.Y;
            }
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (chkMouseDraw.Checked)
            {
                xEnd = e.X;
                yEnd = e.Y;
                myGraphic = CreateGraphics();
                myPen1 = new Pen(lblColor.ForeColor, int.Parse(txtW.Text));
                myGraphic.DrawLine(myPen1, xStart, yStart, xEnd, yEnd);
            }
        }

        private void lblColor_Click(object sender, EventArgs e)
        {

        }

        private void lblColor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}