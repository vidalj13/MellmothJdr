using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MellmothJdr.Commun.Constantes
{
    public static class Routes
    {
        public const string Home = "/Home";
        public const string Logout = "/Identity/Logout";
        public const string Login = "/Identity/Login";
        public const string DnDHome = "/dnd/home";
        public const string ChroniquesOubliesHome = "/ChroniquesOublies/home";
        public const string MesGamesTemplate = "/game/{GameId:guid}/my-game";
        public static string MesGamesDnd => MesGamesTemplate.Replace("{GameId:guid}",Ids.Jeux.DnD.ToString());
        public static string MesGamesChroniquesOublies => MesGamesTemplate.Replace("{GameId:guid}",Ids.Jeux.ChroniquesOublies.ToString());
    }
}
