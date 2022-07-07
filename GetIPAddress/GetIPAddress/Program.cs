using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net; //Ip adresi yakalamak icin ihtiyacimiz olan kutuphane

namespace GetIPAddress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetIPAddress());
            Console.Read();
        }

        public static string GetIPAddress()
        {
            string ip = "";

            IPAddress[] localIps = Dns.GetHostAddresses(Dns.GetHostName());

            foreach (var item in localIps)
            {
                if (item.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    ip = item.ToString();
                }
            }

            return ip;
        }
    }
}
