using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEasyCs72
{
    public partial class Form1 : Form
    {
        private Label[] _labels = new Label[3];
        private TableLayoutPanel tlp;

        public void Display()
        {
            Application.Run(new Form1());
        }
        
        public Form1()
        {
            InitializeComponent();
            this.Text = "Label Test Sample";
            this.Width = 250;
            this.Height = 200;

            tlp = new TableLayoutPanel();
            tlp.Dock = DockStyle.Fill;
            tlp.ColumnCount = 1;
            tlp.RowCount = 3;

            for (int i = 0; i < _labels.Length; i++)
            {
                _labels[i] = new Label();
                _labels[i].Text = string.Format("{0} 号車です。", i);
            }

            _labels[0].ForeColor = Color.Black; // Font Color
            _labels[1].ForeColor = Color.Black;
            _labels[2].ForeColor = Color.Black;
            
            _labels[0].BackColor = Color.Silver;
            _labels[1].BackColor = Color.Gray;
            _labels[2].BackColor = Color.DarkGoldenrod;

            _labels[0].TextAlign = ContentAlignment.TopLeft;
            _labels[1].TextAlign = ContentAlignment.MiddleCenter;
            _labels[2].TextAlign = ContentAlignment.BottomRight;

            _labels[0].BorderStyle = BorderStyle.None;
            _labels[1].BorderStyle = BorderStyle.FixedSingle;
            _labels[2].BorderStyle = BorderStyle.Fixed3D;

            for (int j = 0; j < _labels.Length; j++)
            {
                _labels[j].Parent = tlp;
            }

            tlp.Parent = this;
        }
    }
}