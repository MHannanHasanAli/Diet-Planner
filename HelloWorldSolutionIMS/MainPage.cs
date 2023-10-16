using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldSolutionIMS
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            int w = 1200;
            int h = 737;
            //this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

            loadform(new Registration());
        }

        public void loadform(object Form)
        {
             if(this.mainpanel.Controls.Count > 0 )
                this.mainpanel.Controls.RemoveAt(0);

            Form f = Form as Form;
        f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        private void guna2TileButton9_Click(object sender, EventArgs e)
        {
            loadform(new Registration());
        }

        private void guna2TileButton6_Click(object sender, EventArgs e)
        {
            loadform(new Appointment());
        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            loadform(new Instruction());

        }

        private void guna2TileButton12_Click(object sender, EventArgs e)
        {
            loadform(new Ingredient());
        }
    }
}
