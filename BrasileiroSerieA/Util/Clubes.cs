using System;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace BrasileiroSerieA.Util
{
    /// <summary>
    /// Está classe cria mensagens com informações referentes aos clubes.
    /// </summary>
    public static class Clubes
    {
        /// <value>
        /// Propriedade responsável pelo recebimento do token de comunicação com o bot do Telegram.
        /// </value>
        public static readonly TelegramBotClient msgBot = new TelegramBotClient("ADICIONE UM TOKEN DA API DO TELEGRAM AQUI!");

        /// <summary>
        /// Este método fornece informações sobre os clubes para o usuário no Telegram.
        /// </summary>
        /// <param name="e">Obtem os valores das mensagens selecionanadas pelo usuário</param>
        public static void GerarInformacaoClube(MessageEventArgs e)
        {
            try
            {
                string[] clubes = new string[]
                {
                    "athletico paranaense",
                    "atlético goianiense",
                    "atlético mineiro",
                    "bahia",
                    "botafogo",
                    "ceará",
                    "corinthians",
                    "coritiba",
                    "flamengo",
                    "fluminense",
                    "fortaleza",
                    "goiás",
                    "grêmio",
                    "internacional",
                    "palmeiras",
                    "red bull bragantino",
                    "santos",
                    "são paulo",
                    "sport",
                    "vasco da gama"
                };

                string texto = e.Message.Text;

                switch (texto)
                {
                    case "1":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Athletico Paranaense"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.athletico.com.br/");
                        break;

                    case "2":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Atlético Goianiense"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "http://www.atleticogoianiense.com.br/");
                        break;

                    case "3":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Atlético Mineiro"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.atletico.com.br/");
                        break;

                    case "4":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Bahia"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.esporteclubebahia.com.br/");
                        break;

                    case "5":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Botafogo"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.botafogo.com.br/");
                        break;

                    case "6":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Ceará"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "http://www.cearasc.com/");
                        break;

                    case "7":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Corinthians"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.corinthians.com.br/");
                        break;

                    case "8":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Coritiba"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.coritiba.com.br/Portal");
                        break;

                    case "9":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Flamengo"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.flamengo.com.br/");
                        break;

                    case "10":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Fluminense"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.fluminense.com.br/site/");
                        break;

                    case "11":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Fortaleza"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://fortaleza1918.com.br/");
                        break;

                    case "12":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Goiás"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.goiasec.com.br/");
                        break;

                    case "13":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Grêmio"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://gremio.net/");
                        break;

                    case "14":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Internacional"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.internacional.com.br/");
                        break;

                    case "15":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Palmeiras"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.palmeiras.com.br/");
                        break;

                    case "16":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Red Bull Bragantino"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.redbullbragantino.com.br//");
                        break;

                    case "17":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Santos"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.santosfc.com.br//");
                        break;

                    case "18":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "São Paulo"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "http://www.saopaulofc.net/");
                        break;

                    case "19":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Sport"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://sportrecife.com.br/");
                        break;

                    case "20":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Vasco da Gama"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.vasco.com.br/site/");
                        break;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Ocorreu o seguinte erro: " + ex.Message);
            }
        }
    }
}
