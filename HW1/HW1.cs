using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1
{
    public partial class HW1 : Form
    {
        public HW1()
        {
            InitializeComponent();
        }

        private void HW1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            All_radioButton.Checked = true;
            label2.Text = textBox1.Text;
            label2.ForeColor = Color.Red;
            label2.Font = new Font("新細明體",9);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            R_numericUpDown.Value = 128;
            G_numericUpDown.Value = 128;
            B_numericUpDown.Value = 128;
            R_hScrollBar.Value = 128;
            G_hScrollBar.Value = 128;
            B_hScrollBar.Value = 128;
            label2.Text = textBox1.Text;
            label2.ForeColor = Color.Red;
            label2.Font = new Font("新細明體", 9);
            label2.BackColor = pictureBox1.BackColor;
            R_numericUpDown.Enabled = true;
            R_hScrollBar.Enabled = true;
            G_numericUpDown.Enabled = true;
            G_hScrollBar.Enabled = true;
            B_numericUpDown.Enabled = true;
            B_hScrollBar.Enabled = true;
            All_radioButton.Checked = true;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (All_radioButton.Checked == true)
            {
                R_numericUpDown.Enabled = true;
                R_hScrollBar.Enabled = true;
                G_numericUpDown.Enabled = true;
                G_hScrollBar.Enabled = true;
                B_numericUpDown.Enabled = true;
                B_hScrollBar.Enabled = true;
            }
            else if(R_radioButton.Checked ==true)
            {
                R_numericUpDown.Enabled = true;
                R_hScrollBar.Enabled = true;
                G_numericUpDown.Enabled = false;
                G_hScrollBar.Enabled = false;
                B_numericUpDown.Enabled = false;
                B_hScrollBar.Enabled = false;
            }
            else if (G_radioButton.Checked == true)
            {
                R_numericUpDown.Enabled = false;
                R_hScrollBar.Enabled = false;
                G_numericUpDown.Enabled = true;
                G_hScrollBar.Enabled = true;
                B_numericUpDown.Enabled = false;
                B_hScrollBar.Enabled = false;
            }
            else if (B_radioButton.Checked == true)
            {
                R_numericUpDown.Enabled = false;
                R_hScrollBar.Enabled = false;
                G_numericUpDown.Enabled = false;
                G_hScrollBar.Enabled = false;
                B_numericUpDown.Enabled = true;
                B_hScrollBar.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
                label2.BackColor = colorDialog1.Color;
            }
            R_numericUpDown.Value = pictureBox1.BackColor.R;
            G_numericUpDown.Value = pictureBox1.BackColor.R;
            B_numericUpDown.Value = pictureBox1.BackColor.B;
            R_hScrollBar.Value = pictureBox1.BackColor.R;
            G_hScrollBar.Value = pictureBox1.BackColor.R;
            B_hScrollBar.Value = pictureBox1.BackColor.B;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = fontDialog1.Color;
            }
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int changeR, changeG, changeB;
            changeR = (int)R_numericUpDown.Value;
            R_hScrollBar.Value = changeR;
            changeG = (int)G_numericUpDown.Value;
            G_hScrollBar.Value = changeG;
            changeB = (int)B_numericUpDown.Value;
            B_hScrollBar.Value = changeB;

            //pictureBox1.BackColor.B = B_hScrollBar.Value;

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            for (int i = 0; i<pictureBox1.Width; i++)
            {
                for (int j = 0; j < pictureBox1.Height; j++)
                {
                    Color pixelColor = Color.FromArgb((int)R_numericUpDown.Value, (int)G_numericUpDown.Value, (int)B_numericUpDown.Value);
                    bmp.SetPixel(i, j,pixelColor);
                }
            }
            pictureBox1.Image = bmp;
            label2.Image = bmp;
        }

        private void hScrollBar_ValueChanged(object sender, EventArgs e)
        {
            int changeR, changeG, changeB;
            changeR = (int)R_hScrollBar.Value;
            R_numericUpDown.Value = changeR;
            changeG = (int)G_hScrollBar.Value;
            G_numericUpDown.Value = changeG;
            changeB = (int)B_hScrollBar.Value;
            B_numericUpDown.Value = changeB;

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            for (int i = 0; i < pictureBox1.Width; i++)
            {
                for (int j = 0; j < pictureBox1.Height; j++)
                {
                    Color pixelColor = Color.FromArgb((int)R_numericUpDown.Value, (int)G_numericUpDown.Value, (int)B_numericUpDown.Value);
                    bmp.SetPixel(i, j, pixelColor);
                }
            }
            pictureBox1.Image = bmp;
            label2.Image = bmp;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Random crandom = new Random();
            int changeR, changeG, changeB;
            changeR = crandom.Next(255);
            changeG = crandom.Next(255);
            changeB = crandom.Next(255);
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            for (int i = 0; i < pictureBox1.Width; i++)
            {
                for (int j = 0; j < pictureBox1.Height; j++)
                {
                    Color pixelColor = Color.FromArgb(changeR, changeG, changeB);
                    bmp.SetPixel(i, j, pixelColor);
                }
            }
            pictureBox1.Image = bmp;
            R_numericUpDown.Value = changeR;
            G_numericUpDown.Value = changeG;
            B_numericUpDown.Value = changeB;
            label2.BackColor = pictureBox1.BackColor;
        }

        private Point currentMousePos;
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            currentMousePos = e.Location;
            label1.Text = "("+ e.X.ToString() +"," + e.Y.ToString()+")";

            //label2.Location = currentMousePos;
            label2.Top = e.Y+120;
            //label2.Bottom = MousePosition.Y;
            label2.Left = e.X;
            //label2.Right = MousePosition.X;
            //Top = MousePosition.Y - _mousePoint.Y;
            //Left = MousePosition.X - _mousePoint.X;
            //label2.Location = new Point(e.X, e.Y + 120);
            label2.BackColor = pictureBox1.BackColor;
            if (label2.Bottom > pictureBox1.Bottom)
                label2.Top = pictureBox1.Bottom - label2.Height;
            else if(label2.Top < pictureBox1.Top)
                label2.Top = pictureBox1.Top;
            if (label2.Right > pictureBox1.Right)
                label2.Left = pictureBox1.Right - label2.Width;
            else if(label2.Left < pictureBox1.Left)
                label2.Left = pictureBox1.Left;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text.ToUpper())
            {
                case "紅色":
                    label2.ForeColor = Color.Red;
                    label2.BackColor = pictureBox1.BackColor;
                    break;
                case "黃色":
                    label2.ForeColor = Color.Yellow;
                    label2.BackColor = pictureBox1.BackColor;
                    break;
                case "綠色":
                    label2.ForeColor = Color.Green;
                    label2.BackColor = pictureBox1.BackColor;
                    break;
                case "藍色":
                    label2.ForeColor = Color.Blue;
                    label2.BackColor = pictureBox1.BackColor;
                    break;
            }
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            decimal size = numericUpDown4.Value;
            if (checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked)
                label2.Font = new Font("新細明體", (float)size, FontStyle.Bold);
            else if (!checkBox1.Checked && checkBox2.Checked && !checkBox3.Checked)
                label2.Font = new Font("新細明體", (float)size, FontStyle.Italic);
            else if (!checkBox1.Checked && !checkBox2.Checked && checkBox3.Checked)
                label2.Font = new Font("新細明體", (float)size, FontStyle.Underline);
            else if (checkBox1.Checked && checkBox2.Checked && !checkBox3.Checked)
                label2.Font = new Font("新細明體", (float)size, FontStyle.Bold | FontStyle.Italic);
            else if (checkBox1.Checked && !checkBox2.Checked && checkBox3.Checked)
                label2.Font = new Font("新細明體", (float)size, FontStyle.Bold | FontStyle.Underline);
            else if (!checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
                label2.Font = new Font("新細明體", (float)size, FontStyle.Italic | FontStyle.Underline);
            else if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
                label2.Font = new Font("新細明體", (float)size, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            else
                label2.Font = new Font("新細明體", (float)size);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
        }

        //private Point _mousePoint;
        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            //Top = MousePosition.Y - _mousePoint.Y;
            //Left = MousePosition.X - _mousePoint.X;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
