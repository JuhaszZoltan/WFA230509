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


    public partial class FrmNav : Form
    {
        public FrmNav()
        {
            InitializeComponent();
            GenUI();
            this.AutoSize = true;
            
        }

        private void GenUI()
        {

            int index = 0;
            foreach (var type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (type.Name.StartsWith("FrmFeladat"))
                {
                    string nev = type.Name;
                    int rat = 50;
                    var b = new Button()
                    {
                        Text = $"{nev[^2..]}. feladat",
                        Bounds = new()
                        {
                            Height = rat,
                            Width = 4*rat,
                            X = 0,
                            Y = index * rat,
                        },
                        Font = new Font("Times New Roman", rat / 3),
                        Name = nev,
                    };
                    index++;
                    b.Click += OnButtonClick;
                    this.Controls.Add(b);
                }
            }
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            this.Hide();
            //_ = (Activator.CreateInstance(
            //    Assembly
            //    .GetExecutingAssembly()
            //    .GetTypes().First(t => t.Name == (sender as Button).Name)) as Form)
            //    .ShowDialog();

            Assembly assembly = Assembly.GetExecutingAssembly();
            Type type = assembly.GetTypes().First(t => t.Name == btn.Name);
            using Form form = (Form)Activator.CreateInstance(type);
            _ = form.ShowDialog();

            this.Show();
        }
    }
}
