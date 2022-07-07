using System.Net;
using DAL.Models.Entity.Enum;

namespace DAL.Models.Entity.Base
{
    public class CoreEntity : IEntity<Guid>
    {
        public CoreEntity()
        {
            CreatedDate = DateTime.Now;
            CreatedIP = GetIpAddress();
            Status = Status.Active;
        }

        public DateTime CreatedDate { get; set; }
        public string CreatedIP { get; set; }
        public Status Status { get; set; }
        public Guid ID { get; set; }


        public static string GetIpAddress()
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
