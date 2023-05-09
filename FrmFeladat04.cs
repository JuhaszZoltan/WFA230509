using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA230509
{
    public partial class FrmFeladat04 : Form
    {
        #region activator
        //var a = Assembly.GetExecutingAssembly();

        //string mindenType = string.Empty;
        //foreach (var type in a.GetTypes())
        //{
        //    mindenType += type.Name + "\n";
        //}
        //MessageBox.Show(mindenType);

        //var type = a.GetTypes().FirstOrDefault(t => t.Name == "FrmFeladat03");
        //object o = Activator.CreateInstance(type);
        //(o as Form).Show();
        #endregion

        public FrmFeladat04()
        {
            InitializeComponent();
        }

        private void OnBtnKekBetuClick(object sender, EventArgs e)
        {
            label.ForeColor = Color.Blue;
        }

        private void OnBtnFeherHatterClick(object sender, EventArgs e)
        {
            label.BackColor = Color.White;
        }

        private void OnBtnTorlesClick(object sender, EventArgs e)
        {
            label.Text = string.Empty;
        }

        private void OnBtnBakKozepClick(object sender, EventArgs e)
        {
            label.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void OnBtnKozepKozepClick(object sender, EventArgs e)
        {
            label.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void OnBtnJobbKozepClick(object sender, EventArgs e)
        {
            label.TextAlign = ContentAlignment.MiddleRight;
        }

        private void OnBtnNagybetusClick(object sender, EventArgs e)
        {
            label.Text = label.Text.ToUpper();
        }

        private void OnBtnNagyitClick(object sender, EventArgs e)
        {
            string familyName = label.Font.Name;
            float emSize = label.Font.Size;
            emSize += 2;
            label.Font = new(familyName, emSize);

        }

        private void OnBtnKicsinyitClick(object sender, EventArgs e)
        {
            string familyName = label.Font.Name;
            float emSize = label.Font.Size;
            emSize -= 2;
            if (emSize > 0) label.Font = new(familyName, emSize);
        }

        private void OnBtnAlaphelyzetClick(object sender, EventArgs e)
        {
            this.Dispose();
            new FrmFeladat04().ShowDialog();
        }

        private void OnBtnkilepesClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
