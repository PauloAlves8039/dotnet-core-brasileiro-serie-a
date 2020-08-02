using BrasileiroSerieA.Util;
using System;

namespace BrasileiroSerieA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** ITERAÇÃO COM O USUÁRIO *****");

            ContatoBotTelegram.bot.OnMessage += ContatoBotTelegram.ObterMensagens;

            ContatoBotTelegram.bot.StartReceiving();

            Console.ReadKey();

            ContatoBotTelegram.bot.StopReceiving();
        }
    }
}
