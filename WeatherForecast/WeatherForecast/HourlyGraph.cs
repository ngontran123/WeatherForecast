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
using System.Net;

namespace WeatherForecast
{
    public partial class HourlyGraph : Form
    {
        public HourlyGraph(string json)
        {
            InitializeComponent();
            hourlyforecast(json);
        }
        public void hourlyforecast(string json)
        {
            try
            {
                var res = JsonConvert.DeserializeObject<Hourlyweatherforecast.hourlylist>(json);
                Hourlyweatherforecast.hourlylist outp = res;
                Random r = new Random();
                chart.Series["Nhiệt độ cao nhất theo giờ"].Color = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
                chart.Series["Nhiệt độ thấp nhất theo giờ"].Color = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
                chart.ChartAreas["ChartArea1"].AxisX.Title = "(Giờ)";
                chart.ChartAreas["ChartArea1"].AxisY.Title = "(Nhiệt độ)";
                chart.ChartAreas["ChartArea1"].AxisX.TitleAlignment = StringAlignment.Center;
                chart.ChartAreas["ChartArea1"].AxisY.TitleAlignment = StringAlignment.Center;
                chart.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                chart.ChartAreas["ChartArea1"].AxisY.TitleFont = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

                for (int i = 0; i < 8; i++)
                {
                    string date = convertunittime(outp.list[i].dt, outp.city.timezone).TimeOfDay.ToString();
                    chart.Series["Nhiệt độ cao nhất theo giờ"].Points.AddXY(date, KelvintoCelcius(outp.list[i].main.temp_max));
                    chart.Series["Nhiệt độ thấp nhất theo giờ"].Points.AddXY(date, KelvintoCelcius(outp.list[i].main.temp_min));

                }


            }
            catch (Exception e)
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
    }
}
