using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Collections;
namespace WeatherforecastServer
{
    class Program
    {
        public static IPEndPoint iep = null;
        private static Socket server = null;
        private static Socket client = null;
        public static void Main(string[] args)
        {
            Receive();
        }


        public static void Receive()
        {
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            iep = new IPEndPoint(IPAddress.Any, 9995);
            server.Bind(iep);
            server.Listen(10);
            while (true)
            {
                client = server.Accept();
                new ClientThread(client);
            }
        }
    }
    public class ClientThread
    {
        private Thread tuyen;
        private Socket client;
        public static string APIkey = "542ffd081e67f4512b705f89d2a611b2";
        public ClientThread(Socket client)
        {
            this.client = client;
            tuyen = new Thread(new ThreadStart(responsecurrentdate));
            tuyen.Start();
        }

        public void responsecurrentdate()
        {

            string res = "";
            string res1 = "";
            var c1 = 0;
            NetworkStream ns = new NetworkStream(client);
            StreamReader rd = new StreamReader(ns);
            StreamWriter wt = new StreamWriter(ns);

            try
            {
                while (true)
                {
                    string city = rd.ReadLine();
                    c1++;
                    Console.WriteLine(c1);
                    city = city.ToUpper();
                    res = weatherinfor(city) + "\n";
                    res += dailyweatherinfo(city) + "\n";
                    res += hourlyweatherinfo(city);
                    Console.WriteLine(res);
                    byte[] data = Encoding.UTF8.GetBytes(res);
                    Console.WriteLine("Sending...");
                    Console.WriteLine(city);
                    client.Send(data);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }
        }
        public static string weatherinfor(string city)
        {
            string res = "";
            using (WebClient wb = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", city, APIkey);
                try
                {
                    var json = wb.DownloadString(url);
                    res = json;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            }
            return res;
        }
        public static string dailyweatherinfo(string city)
        {
            string res = "";
            using (WebClient wb = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/forecast/daily?q={0}&cnt=8&appid={1}", city, APIkey);
                try
                {
                    var json = wb.DownloadString(url);
                    res = json;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            return res;
        }
        public static string hourlyweatherinfo(string city)
        {
            string res = "";
            using (WebClient wb = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/forecast?q={0}&appid={1}", city, APIkey);
                try
                {
                    var json = wb.DownloadString(url);
                    res = json;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return res;
        }

    }
}