using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherForecast
{
    public partial class ControlForm : Form
    {
        string json1 = "";
        string json2 = "";
        public ControlForm(string json1,string json2)
        {
            InitializeComponent();
            loadgraph(json1);
            this.json1 = json1;
            this.json2 = json2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadgraph(json1);
        }
        private void ControlForm_Load(object sender, EventArgs e)
        {
        }
        public void loadgraph(string json1)
        {
            if (this.mpanel.Controls.Count > 0)
            {
                this.mpanel.Controls.RemoveAt(0);
            }
            Graph g = new Graph(json1);
            g.TopLevel = false;
            g.Dock = DockStyle.Fill;
            this.mpanel.Controls.Add(g);
            this.mpanel.Tag = g;
            g.Show();
        }
        public void loadhourlygraph(string json2)
        {
            if (this.mpanel.Controls.Count > 0)
            {
                this.mpanel.Controls.RemoveAt(0);
            }
            HourlyGraph g = new HourlyGraph(json2);
            g.TopLevel = false;
            g.Dock = DockStyle.Fill;
            this.mpanel.Controls.Add(g);
            this.mpanel.Tag = g;
            g.Show();
        }
        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            loadhourlygraph(json2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
