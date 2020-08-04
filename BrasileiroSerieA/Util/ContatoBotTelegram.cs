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

                Clubes.GerarInformacaoClube(e);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu o seguinte erro: " + ex.Message);
            }
        }  
    }
}
