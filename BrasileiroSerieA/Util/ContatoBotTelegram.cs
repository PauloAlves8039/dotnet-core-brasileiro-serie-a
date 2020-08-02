using System;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace BrasileiroSerieA.Util
{
    /// <summary>
    /// Está classe cria uma iteração do bot com o usuário no Telegram.
    /// </summary>
    public static class ContatoBotTelegram
    {
        /// <value>
        /// Propriedade responsável pelo recebimento do token de comunicação com o bot do Telegram.
        /// </value>
        public static readonly TelegramBotClient bot = new TelegramBotClient("ADICIONE UM TOKEN DA API DO TELEGRAM AQUI!");

        /// <summary>
        /// Método responsável por obter o carregamento das mensagens.
        /// </summary>
        /// <param name="sender">Obtem referência as propriedades dos textos.</param>
        /// <param name="e">Obtem os valores dos textos no Telegram.</param>
        public static void ObterMensagens(object sender, MessageEventArgs e)
        {
            try
            {
                GerarMensagensUsuario(e);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Ocorreu o seguinte erro: " + ex.Message);
            }
        }

        /// <summary>
        /// Este método gera mensagens de respostas para o usuário do Telegram.
        /// </summary>
        /// <param name="e">Obtem os valores das mensagens digitas pelo usuário.</param>
        private static async void GerarMensagensUsuario(MessageEventArgs e)
        {
            try
            {
                Console.WriteLine("O usuário " + e.Message.Chat.FirstName + " diz: " + e.Message.Text);

                string[] msgUsuario = new string[]
                {
                    "oi",
                    "olá",
                    "estou bem",
                    "sim",
                    "ok",
                    "não"
                };

                if ((e.Message.Text.ToLower() == msgUsuario[0] || e.Message.Text.ToLower() == msgUsuario[1])
                   || ((e.Message.Text.ToUpper() == msgUsuario[0] || e.Message.Text.ToUpper() == msgUsuario[1])))
                {
                    await bot.SendTextMessageAsync(e.Message.Chat.Id, "Olá Sr(a) "
                                                   + e.Message.Chat.FirstName
                                                   + ", tudo bom?");
                }

                if (e.Message.Text.ToLower() == msgUsuario[2] || e.Message.Text.ToLower() == msgUsuario[2])
                {
                    await bot.SendTextMessageAsync(e.Message.Chat.Id, "Que ótimo Sr(a) "
                                                    + e.Message.Chat.FirstName
                                                    + "!"
                                                    + Environment.NewLine + Environment.NewLine
                                                    + "Deseja saber um breve resumo sobre algum clube do Campoenato Brasiliero da Serie A 2020?");
                }
                else if (e.Message.Text.ToLower() == msgUsuario[3] || e.Message.Text.ToLower() == msgUsuario[3])
                {
                    await bot.SendTextMessageAsync(e.Message.Chat.Id, "Pois não Sr(a) "
                                                   + e.Message.Chat.FirstName
                                                   + "!"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Digite o número referente a seu clube: "
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* 1 - Athletico Paranaense"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* 2 - Atlético Goianiense"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* 3 - Atlético Mineiro"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* 4 - Bahia"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* 5 - Botafogo"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* 6 - Ceará"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* 7 - Corinthians"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* 8 - Coritiba"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* 9 - Flamengo"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* 10 - Fluminense"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* 11 - Fortaleza"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* 12 - Goiás"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* 13 - Grêmio"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* 14 - Internacional"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* 15 - Palmeiras"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* 16 - Red Bull Bragantino"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* 17 - Santos"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* 18 - São Paulo"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* 19 - Sport"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* 20 - Vasco da Gama");

                }

                else if (e.Message.Text.ToLower() == msgUsuario[4] || e.Message.Text.ToLower() == msgUsuario[4])
                {
                    await bot.SendTextMessageAsync(e.Message.Chat.Id, "Sr(a) "
                                                   + e.Message.Chat.FirstName
                                                   + ", caso queria consultar outro clube:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Digite um número referente a seu clube desejado." 
                                                   + Environment.NewLine + Environment.NewLine 
                                                   + "* Ou digite 'não' para encerrar.");
                }

                else if (e.Message.Text.ToLower() == msgUsuario[5] || e.Message.Text.ToLower() == msgUsuario[5])
                {
                    await bot.SendTextMessageAsync(e.Message.Chat.Id, "Pois não Sr(a) "
                                                   + e.Message.Chat.FirstName
                                                   + "!"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Agradecemos o seu contato, ate a próxima!");
                }

                GerarInformacaoClube(e);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu o seguinte erro: " + ex.Message);
            }
        }

        /// <summary>
        /// Este método fornece informações sobre os clubes para o usuário no Telegram.
        /// </summary>
        /// <param name="e">Obtem os valores das mensagens selecionanadas pelo usuário</param>
        private static void GerarInformacaoClube(MessageEventArgs e) 
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
                        bot.SendTextMessageAsync(e.Message.Chat.Id, "Athletico Paranaense"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.athletico.com.br/");
                        break;

                    case "2":
                        bot.SendTextMessageAsync(e.Message.Chat.Id, "Atlético Goianiense"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "http://www.atleticogoianiense.com.br/");
                        break;

                    case "3":
                        bot.SendTextMessageAsync(e.Message.Chat.Id, "Atlético Mineiro"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.atletico.com.br/"); 
                        break;

                    case "4":
                        bot.SendTextMessageAsync(e.Message.Chat.Id, "Bahia"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.esporteclubebahia.com.br/");
                        break;

                    case "5":
                        bot.SendTextMessageAsync(e.Message.Chat.Id, "Botafogo"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.botafogo.com.br/");
                        break;

                    case "6":
                        bot.SendTextMessageAsync(e.Message.Chat.Id, "Ceará"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "http://www.cearasc.com/");
                        break;

                    case "7":
                        bot.SendTextMessageAsync(e.Message.Chat.Id, "Corinthians"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.corinthians.com.br/");
                        break;

                    case "8":
                        bot.SendTextMessageAsync(e.Message.Chat.Id, "Coritiba"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.coritiba.com.br/Portal");
                        break;

                    case "9":
                        bot.SendTextMessageAsync(e.Message.Chat.Id, "Flamengo"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.flamengo.com.br/");
                        break;

                    case "10":
                        bot.SendTextMessageAsync(e.Message.Chat.Id, "Fluminense"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.fluminense.com.br/site/");
                        break;

                    case "11":
                        bot.SendTextMessageAsync(e.Message.Chat.Id, "Fortaleza"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://fortaleza1918.com.br/");
                        break;

                    case "12":
                        bot.SendTextMessageAsync(e.Message.Chat.Id, "Goiás"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.goiasec.com.br/");
                        break;

                    case "13":
                        bot.SendTextMessageAsync(e.Message.Chat.Id, "Grêmio"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://gremio.net/");
                        break;

                    case "14":
                        bot.SendTextMessageAsync(e.Message.Chat.Id, "Internacional"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.internacional.com.br/");
                        break;

                    case "15":
                        bot.SendTextMessageAsync(e.Message.Chat.Id, "Palmeiras"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.palmeiras.com.br/");
                        break;

                    case "16":
                        bot.SendTextMessageAsync(e.Message.Chat.Id, "Red Bull Bragantino"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.redbullbragantino.com.br//");
                        break;

                    case "17":
                        bot.SendTextMessageAsync(e.Message.Chat.Id, "Santos"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.santosfc.com.br//");
                        break;

                    case "18":
                        bot.SendTextMessageAsync(e.Message.Chat.Id, "São Paulo"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "http://www.saopaulofc.net/");
                        break;

                    case "19":
                        bot.SendTextMessageAsync(e.Message.Chat.Id, "Sport"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://sportrecife.com.br/");
                        break;

                    case "20":
                        bot.SendTextMessageAsync(e.Message.Chat.Id, "Vasco da Gama"
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
