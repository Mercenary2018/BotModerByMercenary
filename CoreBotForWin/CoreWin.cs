using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.CloudRail.SI;
using Com.CloudRail.SI.Interfaces;
using Com.CloudRail.SI.Services;
using TelegramBotApi;

namespace CoreBotForWin
{
    public abstract class CoreRunBot
    {
        class MainClass
        {
            public static void Main(string[] args)
            {
                CloudRail.AppKey = "[Your CloudRail Key]";

                List<ISMS> services = new List<ISMS>();

                Nexmo nexmo = new Nexmo(null, "[Nexmo API Key]", "[Nexmo API Secret]");
                services.Add(nexmo);

                Twilio twilio = new Twilio(null, "[Twilio Account SID]", "[Twilio Auth Token]");
                services.Add(twilio);

                Twizo twizo = new Twizo(null, "[Twizo Key]");
                services.Add(twizo);

                foreach (ISMS service in services)
                {
                    try
                    {
                        service.SendSMS("[Sending Number]", "[Receiving Number]", "Hello from " + service);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
            }
        }
    }
}
