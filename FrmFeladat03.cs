using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA230509
{
    public partial class FrmFeladat03 : Form
    {
        public FrmFeladat03()
        {

            InitializeComponent();
            foreach (var control in this.Controls)
            {
                if (control is PictureBox) (control as Control).Click += OnPictureBoxClick;
            }
            btnAlaphelyzet.Click += OnBtnAlaphelyzetClick;
            btnKilepes.Click += OnBtnKilepesClick;
        }

        private void OnBtnKilepesClick(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void OnBtnAlaphelyzetClick(object? sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }

        private void OnPictureBoxClick(object? sender, EventArgs e)
        {
            this.BackColor = (sender as Control)!.BackColor;
        }
    }
}
