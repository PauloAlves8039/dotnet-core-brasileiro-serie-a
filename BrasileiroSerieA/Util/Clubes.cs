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
                                                   + "Alcunhas: Furacão, Rubro-Negro"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Fundação: 26/03/1924"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Localização: Curitiba - PR, Brasil"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Prinicpais Títulos:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Paranaense: 25"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Brasileiro Série A: 1 (2001)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Brasileiro Série B: 1 (1995)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa do Brasil: 1 (2019)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa Sul-Americana: 1 (2018)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Levain Cup/CONMEBOL: 1 (2019)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Site oficial:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.athletico.com.br/");
                        break;

                    case "2":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Atlético Goianiense"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Alcunhas: Dragão, Dragão Campineiro"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Fundação: 02/04/1937"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Localização: Goiânia - GO, Brasil"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Prinicpais Títulos:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Goiano: 14"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Brasileiro Série B: 1 (2016)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Brasileiro Série C: 2 (1990, 2008)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Torneio Integração Nacional: 1 (1971)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Taça dos Invictos: 2 (1956, 1957/58)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa Goiás: 2 (1968, 1998)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Site oficial:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "http://www.atleticogoianiense.com.br/");
                        break;

                    case "3":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Atlético Mineiro" 
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Alcunhas: Galo, Alvinegro"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Fundação: 25/03/1908"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Localização: Belo Horizonte - BH, Brasil"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Prinicpais Títulos:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Mineiro: 44"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Brasileiro Série A: 1 (1971)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Brasileiro Série B: 1 (2006)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa do Brasil: 1 (2014)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa Libertadores da América: 1 (2013)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa CONMEBOL: 2 (1992, 1997)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Recopa Sul-Americana: 1 (2015)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Site oficial:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.atletico.com.br/");
                        break;

                    case "4":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Bahia"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Alcunhas: Bahêa, Tricolor de Aço"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Fundação: 01/01/1931"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Localização: Salvador - BA, Brasil"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Prinicpais Títulos:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Baiano: 48"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Brasileiro Série A: 2 (1959, 1988)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa do Nordeste: 3 (2001, 2002, 2017)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Torneio dos Campeões do Nordeste: 1 (1948)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Taça Estado da Bahia 1 (2013)"                                                   
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Site oficial:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.esporteclubebahia.com.br/");
                        break;

                    case "5":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Botafogo"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Alcunhas: Estrela Solitária, Fogão, O Glorioso"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Fundação: 01/07/1904"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Localização: Rio da Janeiro - RJ, Brasil"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Prinicpais Títulos:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Carioca: 21"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Taça Guanabara: 8"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Taça Rio: 7"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Brasileiro Série A: 2 (1968, 1995)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Brasileiro Série B: 1 (2015)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Torneio Rio-São Paulo: 4 (1962, 1964, 1966, 1998)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa Conmebol: 1 (1993)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Site oficial:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.botafogo.com.br/");
                        break;

                    case "6":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Ceará"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Alcunhas: Vovô, Vozão, Gigante Alvinegro"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Fundação: 02/06/1914"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Localização: Fortaleza - CE, Brasil"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Prinicpais Títulos:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Cearense: 45"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Torneio Início do Ceará: 12"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa do Nordeste: 2 (2015, 2020)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Torneio Norte-Nordeste: 1 (1969)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Site oficial:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "http://www.cearasc.com/");
                        break;

                    case "7":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Corinthians"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Alcunhas: Timão, Coringão, Campeão dos Campeões"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Fundação: 02/06/1914"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Localização: São Paulo - SP, Brasil"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Prinicpais Títulos:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Paulista: 30"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Torneio Rio-São Paulo: 5 (1950, 1953, 1954, 1966, 2002)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa do Brasil: 3 (1995, 2002 e 2009)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Supercopa do Brasil: 1 (1991)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Brasileiro Série A: 7 (1990, 1998, 1999, 2005, 2011, 2015, 2017)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa Libertadores da América: 1 (2012)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa do Mundo de Clubes da FIFA: 2 (2000, 2012)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Recopa Sul-Americana: 1 (2013)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Tríplice Coroa Internacional: 1 (2013)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Site oficial:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.corinthians.com.br/");
                        break;

                    case "8":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Coritiba"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Alcunhas: Coxa, Coxa-Branca, Verdão"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Fundação: 12/10/1909"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Localização: Curitiba - PR, Brasil"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Prinicpais Títulos:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Paranaense: 38"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Torneio Início do Paraná: 10"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Brasileiro Série A: 1 (1985)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Brasileiro Série B: 2 (2007, 2010)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Torneio do Povo: 1 (1973)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Site oficial:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.coritiba.com.br/Portal");
                        break;

                    case "9":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Flamengo"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Alcunhas: Mengo, Mengão, Rubro-Negro Carioca"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Fundação: 15/11/1895"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Localização: Rio de Janeiro - RJ, Brasil"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Prinicpais Títulos:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Carioca: 36"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Taça Guanabara: 22"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Taça Rio: 9"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Torneio Rio–São Paulo: 1 (1961)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa do Brasil: 3 (1990, 2006 e 2013)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa dos Campeões: 1 (2001)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Brasileiro Série A: 6"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa Libertadores da América: 2 (1981, 2019)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa Mercosul: 1 (1999)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Recopa Sul-Americana: 1 (2020)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa Intercontinental: 1 (1981)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Site oficial:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.flamengo.com.br/");
                        break;

                    case "10":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Fluminense"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Alcunhas: Tricolor, Flu, Fluzão"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Fundação: 21/07/1902"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Localização: Rio de Janeiro - RJ, Brasil"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Prinicpais Títulos:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Carioca: 31"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Taça Guanabara: 7"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Taça Rio: 4"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Torneio Rio-São Paulo: 2 (1957, 1960)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Brasileiro Série A: 4 (1970, 1984, 2010, 2012)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Brasileiro Série C: 1 (1999)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa do Brasil: 1 (2007)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Site oficial:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.fluminense.com.br/site/");
                        break;

                    case "11":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Fortaleza"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Alcunhas: Tricolor do Pici, Leão do Pici, Rei Leão do Brasil"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Fundação: 18/10/1918"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Localização: Fortaleza - CE, Brasil"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Prinicpais Títulos:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Cearense: 42"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Taça dos Campeões Cearenses: 2 (2016, 2017)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa do Nordeste: 1 (2019)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Brasileiro Série B: 1 (2018)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Torneio Norte–Nordeste: 1 (1970)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Site oficial:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://fortaleza1918.com.br/");
                        break;

                    case "12":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Goiás"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Alcunhas: Verdão, Gigante Esmeralda, Alviverde"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Fundação: 06/04/1943"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Localização: Goiânia - GO, Brasil"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Prinicpais Títulos:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Goiano: 28"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa Centro-Oeste: 3 (2000, 2001, 2002)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Torneio Início do Campeonato Goiano: 8"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Brasileiro Série B: 2 (1999, 2012)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Torneio Norte–Nordeste: 1 (1970)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Site oficial:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.goiasec.com.br/");
                        break;

                    case "13":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Grêmio"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Alcunhas: Tricolor dos Pampas, Imortal Tricolor, Rei de Copas"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Fundação: 15/09/1903"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Localização: Porto Alegre - RS, Brasil"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Prinicpais Títulos:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Gaúcho: 38"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Citadino de Porto Alegre: 29"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa Sul: 1 (1999)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Brasileiro Série B: 1 (2005)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa do Brasil: 5 (1989, 1994, 1997, 2001, 2016)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Brasileiro Série A: 2 (1981, 1996)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Recopa Sul-Americana: 2 (1996, 2018)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa Libertadores da América: 3 (1983, 1995, 2017)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa Intercontinental: 1 (1983)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Site oficial:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://gremio.net/");
                        break;

                    case "14":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Internacional"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Alcunhas: Inter, Colorado, Campeão de Tudo"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Fundação: 04/04/1909"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Localização: Porto Alegre - RS, Brasil"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Prinicpais Títulos:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Gaúcho: 45"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Recopa Gaúcha: 3 (2016, 2017)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Super Copa Gaúcha: 1 (2016)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Brasileiro Série A: 3 (1975, 1976, 1979)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa do Brasil: 1 (1992)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Recopa Sul-Americana: 2 (2007, 2011)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa Sul-Americana: 1 (2008)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa Libertadores da América: 2 (2006, 2010)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa do Mundo de Clubes da FIFA: 1 (2006)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Site oficial:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.internacional.com.br/");
                        break;

                    case "15":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Palmeiras"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Alcunhas: Verdão, Alviverde, Palestra"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Fundação: 26/08/1914"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Localização: São Paulo - SP, Brasil"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Prinicpais Títulos:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Paulista: 22"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Torneio Rio-São Paulo: 5 (1933, 1951, 1965, 1993, 2000)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa dos Campeões: 1 (2000)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Brasileiro Série A: 10"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Brasileiro Série B: 2 (2003, 2013)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa do Brasil: 3 (1998, 2012, 2015)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa Mercosul: 1 (1998)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa Libertadores da América: 1 (1999)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Site oficial:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.palmeiras.com.br/");
                        break;

                    case "16":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Red Bull Bragantino"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Alcunhas: Braga, Massa Bruta"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Fundação: 08/01/1928 - 01/01/2020 Clube Atrlético Bragantino"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Localização: Bragança Paulista - SP, Brasil"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Prinicpais Títulos:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Paulista: 1 (1990)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Paulista Séria A2: 2 (1965, 1998)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Paulista Séria B2: 1 (1979)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Torneio Início: 1 (1991)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Brasileiro Série B: 2 (1989, 2019)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Brasileiro Série C: 1 (2007)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Paulista do Interior: 1 (2020)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Site oficial:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.redbullbragantino.com.br//");
                        break;

                    case "17":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Santos"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Alcunhas: Peixe, Alvinegro Praiano, Alvinegro da Vila"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Fundação: 14/04/1912"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Localização: Santos - SP, Brasil"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Prinicpais Títulos:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Paulista: 22"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Torneio Rio-São Paulo: 5 (1959, 1963, 1964, 1966, 1997)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa do Brasil: 1 (2010)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Brasileiro Série A: 8"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Supercopa Sul-Americana dos Campeões Intercontinentais: 1 (1968)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Recopa Sul-Americana: 1 (2012)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa Conmebol: 1 (1998)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa Libertadores da América: 3 (1962, 1963, 2011)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa Intercontinental: 3 (1962, 1963)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Site oficial:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://www.santosfc.com.br//");
                        break;

                    case "18":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "São Paulo"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Alcunhas: Tricolor Paulista, Tricolor do Morumbi, O Mais Querido"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Fundação: 25/01/1930"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Localização: São Paulo - SP, Brasil"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Prinicpais Títulos:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Paulista: 21"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Torneio Rio-São Paulo: 1 (2001)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Brasileiro Série A: 6 (1977, 1986, 1991, 2006, 2007, 2008)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa Master da Conmebol: 1 (1996)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Recopa Sul-Americana: 2 (1993, 1994)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Supercopa Sul-Americana: 1 (1993)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa Conmebol: 1 (1994)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa Sul-Americana: 1 (2012)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa Libertadores da América: 3 (1992, 1993, 2005)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa Intercontinental: 2 (1992, 1993)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa do Mundo de Clubes da FIFA: 1 (2005)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Site oficial:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "http://www.saopaulofc.net/");
                        break;

                    case "19":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Sport"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Alcunhas: Leão da Ilha, Leão da Praça da Bandeira, Rubro-negro Pernambucano"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Fundação: 13/05/1905"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Localização: Recife - PE, Brasil"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Prinicpais Títulos:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Pernambucano: 42"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Torneio Início: 18"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa do Nordeste: 3 (1994, 2000, 2014)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa do Brasil: 1 (2008)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Brasileiro Série B: 1 (1990)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Brasileiro Série A: 1 (1987)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Site oficial:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "https://sportrecife.com.br/");
                        break;

                    case "20":
                        msgBot.SendTextMessageAsync(e.Message.Chat.Id, "Vasco da Gama"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Alcunhas: Vascão, Gigante da Colina, Time da Virada"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Fundação: 21/08/1998"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Localização: Rio de Janeiro - RJ, Brasil"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Prinicpais Títulos:"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Carioca: 24"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Taça Guanabara: 12"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Taça Rio: 10"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Torneio Rio-São Paulo: 3 (1958, 1966, 1999)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa do Brasil: 1 (2011)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Brasileiro Série B: 1 (2009)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Campeonato Brasileiro Série A: 4 (1974, 1989, 1997, 2000)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa Mercosul: 1 (2000)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "* Copa Libertadores da América: 1 (1998)"
                                                   + Environment.NewLine + Environment.NewLine
                                                   + "Site oficial:"
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
