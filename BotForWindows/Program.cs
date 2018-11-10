using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Com.CloudRail.SI;
using Com.CloudRail.SI.Interfaces;
using Com.CloudRail.SI.ServiceCode.Commands.CodeRedirect;
using Com.CloudRail.SI.Services;
using Com.CloudRail.SI.Types;

namespace UnifiedCloudStorage
{
    class Program
    {

        static WebProxy wp = new WebProxy(GetGoodProxy.ParseProxies(), true);

        private static readonly TelegramBotClient Bot = new TelegramBotClient("782234550:AAGcEovj-Y88buRmSCXXT4cERe24ObFgsJs", wp);
        static void Main(string[] args)
        {
            Console.WriteLine("Телеграм-бот \"SHARP_POLICE\"");
            Console.WriteLine("Адресс прокси: " + GetGoodProxy.ParseProxies());
            try
            {
                Bot.OnMessage += Bot_OnMessage;
                Bot.OnMessageEdited += Bot_OnMessage;
                Bot.StartReceiving();
                Console.ReadLine();
                Bot.StopReceiving();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }
        private static void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
           
        }
    }
}