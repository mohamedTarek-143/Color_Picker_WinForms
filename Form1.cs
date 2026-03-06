using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class Form1 : Form
    {
        ToolTip tt;
        public Form1()
        {
          tt = new ToolTip();
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {


        }
        string getHexaCode(Color color)
        {
            return  "#"+ color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");

        }
        Color getColor(int red, int green, int blue)
        {
            return Color.FromArgb(red, green, blue);
        }
        void setFormColor(Color color)
        {
            this.BackColor = color;
            hexaCodeLbl.Text = getHexaCode(color);
        }
        private void redTrackBar_Scroll(object sender, EventArgs e)
        {
            redLbl.Text = redTrackBar.Value.ToString();
            setFormColor(getColor(redTrackBar.Value, greenTrackBar.Value, blueTrackBar.Value));
            
        }

        private void greenTrackBar_Scroll(object sender, EventArgs e)
        {
            greenLbl.Text = greenTrackBar.Value.ToString();
            setFormColor(getColor(redTrackBar.Value, greenTrackBar.Value, blueTrackBar.Value));
        }

        private void blueTrackBar_Scroll(object sender, EventArgs e)
        {
            blueLbl.Text = blueTrackBar.Value.ToString();
            setFormColor(getColor(redTrackBar.Value, greenTrackBar.Value, blueTrackBar.Value));
        }

        void sendNotification()
        {
            notifyIcon1.Icon = SystemIcons.Information;
            notifyIcon1.ShowBalloonTip(1000, "Success", "Color copied to clipboard", ToolTipIcon.Info);
        }
        void copyColorHexaCodeToClipBoard()
        {
            if (!string.IsNullOrWhiteSpace(hexaCodeLbl.Text))
            {
                Clipboard.SetText(hexaCodeLbl.Text);
                sendNotification();
                tt.Show("Copied!", this, PointToClient(Cursor.Position), 700);
            }
        }
        private void copyBtn_Click(object sender, EventArgs e)
        {
            copyColorHexaCodeToClipBoard();
            
           
        }

        private void chsColorBtn_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
            hexaCodeLbl.Text = getHexaCode(colorDialog1.Color);
            redTrackBar.Value = colorDialog1.Color.R;
            greenTrackBar.Value = colorDialog1.Color.G;
            blueTrackBar.Value = colorDialog1.Color.B;
        }

        private void hexaCodeLbl_Click(object sender, EventArgs e)
        {
            copyColorHexaCodeToClipBoard();
        }

       
    }
}
