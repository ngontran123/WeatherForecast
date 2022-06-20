using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Sockets;
using System.IO;
using System.Web;
namespace WeatherForecast
{
    public partial class Graph : Form
    {
        public Graph(string json)
        {
            InitializeComponent();
            dayforecast(json);
           
        }
       
        public void dayforecast(string json)
        {
            try
            {   
                var res = JsonConvert.DeserializeObject<DailyWeatherInfor.Forecastlist>(json);
                DailyWeatherInfor.Forecastlist outp = res;
                Random r = new Random();
                chart.Series["Nhiệt độ cao nhất theo ngày"].Color = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
                chart.Series["Nhiệt độ thấp nhất theo ngày"].Color = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
                chart.ChartAreas["ChartArea1"].AxisX.Title = "(Ngày)";
                chart.ChartAreas["ChartArea1"].AxisY.Title = "(Nhiệt độ)";
                chart.ChartAreas["ChartArea1"].AxisX.TitleAlignment = StringAlignment.Center;
                chart.ChartAreas["ChartArea1"].AxisY.TitleAlignment = StringAlignment.Center;
                chart.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                chart.ChartAreas["ChartArea1"].AxisY.TitleFont = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

                for (int i=1;i<8;i++)
                { string date = convertunittime(outp.list[i].dt, outp.list[i].timezone).ToString("dd/MM/yyyy");
                    chart.Series["Nhiệt độ cao nhất theo ngày"].Points.AddXY(date,KelvintoCelcius(outp.list[i].temp.max));
                    chart.Series["Nhiệt độ thấp nhất theo ngày"].Points.AddXY(date, KelvintoCelcius(outp.list[i].temp.min));

                }


            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public DateTime convertunittime(long unixtime, long timezone)
        {
            DateTime date = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            long cur = 2500;
            if (timezone != cur)
            {
                date = date.AddSeconds(unixtime + timezone);
            }
            else
            {
                date = date.AddSeconds(unixtime);
            }
            return date;
        }
        public double KelvintoCelcius(double n)
        {
            return Math.Round(n - 273.15);
        }
        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Graph_Load(object sender, EventArgs e)
        {

        }
    }
}
