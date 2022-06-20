using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using Newtonsoft.Json;
using System.Threading;
using System.Windows.Forms;
using System.Globalization;
using System.Net.Http;
using System.Text.RegularExpressions;
namespace WeatherForecast
{
    public partial class WeatherForecast : Form
    {
       public Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public IPEndPoint iep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9995);
        public System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        string json1 = "";
        string json2 = "";
        public WeatherForecast()
        {
            InitializeComponent();
            Connect();
            Sender("tokyo");
            CheckForIllegalCrossThreadCalls = false;
            combobox1.Text = "Thành phố:";
            player.SoundLocation= "MP3DOWNLOAD.TO_-Attack-on-Titan-Season-4-OST_-Ashes-on-Fire-_-Main-Theme-320k.wav";
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void Connect()
        {
            client.Connect(iep);
        }
        public void Sender(string city)
        {
            NetworkStream ns = new NetworkStream(client);
           StreamReader rd = new StreamReader(ns);
          StreamWriter wt = new StreamWriter(ns);
            string kq = "";
                wt.WriteLine(city);
                wt.Flush();
                byte[] data = new byte[1024];
                int len = client.Receive(data);
                 MemoryStream mmr = new MemoryStream();
                while (len > 0)
                {
                    mmr.Write(data, 0, len);
                    if (client.Available > 0)
                    {
                        len = client.Receive(data);
                    }
                    else
                    {
                        break;
                    }
                }
                byte[] kq1 = mmr.ToArray();


            kq = Encoding.UTF8.GetString(kq1);
            var kq2 = kq.Split('\n');
            json1 = kq2[1];
            json2 = kq2[2];
            currentWeather(kq2[0]);
            forecastWeather(kq2[1]);
            hourlyWeatherForecast(kq2[2]);

        }
        Boolean checkconnect(Socket client)
        {
            if(client.Connected)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void currentWeather(string json)
        {
            try
            {
                var res = JsonConvert.DeserializeObject<CurrentWeatherInfor.root>(json);
                CurrentWeatherInfor.root outp = res;
               if(outp==null)
                {
                    MessageBox.Show("Không có thành phố này");
                    return;
                }
                RegionInfo culture = new RegionInfo(outp.sys.country);
                String countryname = culture.EnglishName;
                City.Text = string.Format("{0}", (outp.name));
                lon1.Text = string.Format("{0}", outp.coord.lon);
                lat1.Text = string.Format("{0}", outp.coord.lat);
                country1.Text = string.Format("{0}", Powerfirstword(countryname));
                cond.Text = string.Format("{0}", Powerfirstword(outp.weather[0].main));
                des.Text = string.Format("{0}", Powerfirstword(outp.weather[0].description));
                humid.Text = string.Format("{0}%", outp.main.humidity);
                wind.Text = string.Format("{0} MpH", outp.wind.speed);
                press.Text = string.Format("{0} hpa", outp.main.pressure);
                temp_max.Text = string.Format("{0}°C", KelvintoCelcius(outp.main.temp_max));
                temp_min.Text = string.Format("{0}°C", KelvintoCelcius(outp.main.temp_min));
                degree.Text = string.Format("{0}", KelvintoCelcius(outp.main.temp));
                fah.Text = string.Format("{0}", CelciustoFah(KelvintoCelcius(outp.main.temp)));
                sr.Text = string.Format("{0}", convertunittime(outp.sys.sunrise, outp.timezone).ToString("HH:mm"));
                ss.Text = string.Format("{0}", convertunittime(outp.sys.sunset, outp.timezone).ToString("HH:mm"));
                pictureBox1.Image = rotateImage(@"D:\download (4) (1).png", outp.wind.deg);
                sunr.ImageLocation = @"C:\Users\Acer\Source\Repos\WeatherForecast\WeatherForecast\bin\Debug\COLOR_EXPAND_WEATHER-48.png";
                suns.ImageLocation = @"C:\Users\Acer\Source\Repos\WeatherForecast\WeatherForecast\bin\Debug\COLOR_EXPAND_WEATHER-24.png";
                datetime.Text = string.Format("{0},{1}", convertunittime(outp.dt, outp.timezone).DayOfWeek, convertunittime(outp.dt, outp.timezone).ToString("dd/MM/yyyy HH:mm"));
                images.ImageLocation = smallIcon(datetime.Text, cond.Text, des.Text);
                feels.Text = string.Format("{0}°C", KelvintoCelcius(outp.main.feels_like));
            }
            catch(ArgumentNullException e)
            {
               
            }
           
        }
       
        public void forecastWeather(string json)
        {
            try
            {
                var res = JsonConvert.DeserializeObject<DailyWeatherInfor.Forecastlist>(json);
                DailyWeatherInfor.Forecastlist outp = res;
                if(outp==null)
                {
                    return;
                }
                FCD fcd = new FCD();
                this.Forecastpanel.Controls.Clear();
                for (int i = 1; i < 8; i++)
                {
                    fcd = new FCD();
                    fcd.condition.Text =Powerfirstword(outp.list[i].weather[0].main);
                    fcd.humid.Text = outp.list[i].humidity.ToString() + "%";
                    fcd.des.Text =Powerfirstword(outp.list[i].weather[0].description);
                    fcd.temp.Text = KelvintoCelcius(outp.list[i].temp.min).ToString() + "/" + KelvintoCelcius(outp.list[i].temp.max).ToString() + " °C";
                    DateTime t = convertunittime(outp.list[i].dt, outp.list[i].timezone);
                    fcd.date.Text =t.DayOfWeek.ToString();
                    string date= string.Format("{0},{1}", convertunittime(outp.list[i].dt, outp.list[i].timezone).DayOfWeek, convertunittime(outp.list[i].dt, outp.list[i].timezone).ToString("dd/MM/yyyy HH:mm"));
                    fcd.pic.ImageLocation = smallIcon(date, fcd.condition.Text, fcd.des.Text);
                    Forecastpanel.Controls.Add(fcd);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
                
            }
        public string Powerfirstword(string s)
        {
            s = s.ToLower();
            string t2 = "";
            var t = s.Split(' ');
            var t1 = t[0];
            t2 += t1[0].ToString().ToUpper();
            t2 += t1.Substring(1)+" ";
            for(int i=1;i<t.Length;i++)
            {
                t2 += t[i] + " ";
            }
            t2 = t2.TrimEnd();
            return t2;
        }
        public string getDayTime(string t)
        {
            string t1 = Regex.Replace(t, @"\d", "");
            return t1;
        }
        public string smallIcon(string day,string des,string des1)
        {
            var d = day.Split(',');
            var d1 = d[1].Split(' ');
            var d2 = d1[1].Split(':');
            var d3 = Int32.Parse(d2[0]);
            string res = "";
            if(d3>=6&&d3<18)
            {
                switch(des)
                {
                    case "Thunderstorm":res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-06.png";break;
                    case "Drizzle":res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-03.png";break;
                    case "Rain":if(des1=="freezing rain") { res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-10.png"; }else if(des1=="light intensity shower rain"||des1=="ragged shower rain"||des1=="shower rain"||des1=="heavy intensity shower rain") { res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-08.png"; } else { res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-17.png"; }break;
                    case "Snow":res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-12.png";break;
                    case "Mist":res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-15.png";break;
                    case "Smoke": res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-15.png"; break;
                    case "Haze": res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-15.png"; break;
                    case "Dust": res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-15.png"; break;
                    case "Fog": res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-15.png"; break;
                    case "Sand": res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-15.png"; break;
                    case "Ash": res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-15.png"; break;
                    case "Sqall": res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-15.png"; break;
                    case "Tornado": res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-15.png"; break;
                    case "Clear": res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-48.png"; break;
                    case "Clouds": res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-04.png"; break;
                }

            }
            else
            {
                switch (des)
                {
                    case "Thunderstorm": res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-06.png"; break;
                    case "Drizzle": res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-03.png"; break;
                    case "Rain": if (des1 == "freezing rain") { res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-20.png"; } else if (des1 == "light intensity shower rain" || des1 == "ragged shower rain" || des1 == "shower rain" || des1 == "heavy intensity shower rain") { res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-08.png"; } else { res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-19.png"; } break;
                    case "Snow": res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-20.png"; break;
                    case "Mist": res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-15.png"; break;
                    case "Smoke": res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-15.png"; break;
                    case "Haze": res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-15.png"; break;
                    case "Dust": res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-15.png"; break;
                    case "Fog": res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-15.png"; break;
                    case "Sand": res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-15.png"; break;
                    case "Ash": res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-15.png"; break;
                    case "Sqall": res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-15.png"; break;
                    case "Tornado": res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-15.png"; break;
                    case "Clear": res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-34.png"; break;
                    case "Clouds": res = @"C:\Users\Acer\Downloads\WeatherIcon\COLOR_EXPAND_WEATHER-09.png"; break;
                }
            }
            return res;
        }
       public void hourlyWeatherForecast(string json)
        {
            try
            {
                var res = JsonConvert.DeserializeObject<Hourlyweatherforecast.hourlylist>(json);
                Hourlyweatherforecast.hourlylist outp = res;
                if(outp==null)
                {
                    return;
                }
                HFC hfc=new HFC();
                hourlypanel.Controls.Clear();
                for(int i=0;i<8;i++)
                {
                    hfc = new HFC();
                    hfc.temp.Text = KelvintoCelcius(outp.list[i].main.temp_min).ToString() + "/" + KelvintoCelcius(outp.list[i].main.temp_max).ToString()+ "(°C)";
                    var t = convertunittime(outp.list[i].dt, outp.city.timezone);
                    var t1 = t.TimeOfDay;
                    
                    hfc.time.Text = t1.ToString();
                    string date= string.Format("{0},{1}", convertunittime(outp.list[i].dt, outp.city.timezone).DayOfWeek, convertunittime(outp.list[i].dt, outp.city.timezone).ToString("dd/MM/yyyy HH:mm"));
                    hfc.pictureBox1.ImageLocation=smallIcon(date,outp.list[i].weather[0].main,outp.list[i].weather[0].description);
                    hourlypanel.Controls.Add(hfc);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }
        public Bitmap rotateImage(string image,int angle)
        {
            Bitmap bmp;
            Image img = Image.FromFile(image);

            bmp = new Bitmap(img.Width,img.Height);
            bmp.SetResolution(img.HorizontalResolution, img.VerticalResolution);
            Graphics g = Graphics.FromImage(bmp);
            g.TranslateTransform(bmp.Width / 2, bmp.Height / 2);
            g.RotateTransform(angle);
            g.TranslateTransform(-bmp.Width / 2, -bmp.Height / 2);
            g.DrawImage(img,0,0);
            return bmp;
        }
        public DateTime convertunittime(long unixtime,long timezone)
        {
            DateTime date = new DateTime(1970, 1, 1, 0, 0, 0, 0,DateTimeKind.Utc);
            long cur = 2500;
            if (timezone !=cur)
            {
                date = date.AddSeconds(unixtime + timezone);
            }
            else
            {
                date = date.AddSeconds(unixtime);
            }
            return date;
        }
        public string TranslateText(string s)
        {
            string url = string.Format("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}", "en", "vi",Uri.EscapeDataString(s));
            HttpClient http = new HttpClient();
            string res = http.GetStringAsync(url).Result;
            var jsondata = JsonConvert.DeserializeObject<List<dynamic>>(res);
            var item = jsondata[0];
            string translation = "";
            foreach(object ini in item)
            {
                IEnumerable translateobject =ini as IEnumerable;
                IEnumerator translateobline = translateobject.GetEnumerator();
                translateobline.MoveNext();
                translation += string.Format("{0}", Convert.ToString(translateobline.Current));
            }
            return translation;
        }
        public double KelvintoCelcius(double n)
        {
           return Math.Round(n-273.15);
        }
        public double CelciustoFah(double n)
        {
            return (n * 2) + 30;
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pressure_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void longtitude_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
          
            string city = cityname.Text;
            Sender(city);

            
        }
     

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cityname.Text = combobox1.SelectedItem.ToString();
        }

        private void cityname_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cityname_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                button1.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void con1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Forecastpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Opacity==1)
            {
                timer1.Stop();
            }
            Opacity += 0.2;
        }

        private void sunr_Click(object sender, EventArgs e)
        {

        }

        public class TranslatorService
        {
        }

        private void rain_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ControlForm g = new ControlForm(json1, json2);
            g.ShowDialog();
        }

        private void degree_Click(object sender, EventArgs e)
        {

        }
    }
}
