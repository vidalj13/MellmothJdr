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
    }

    public static class Ids
    {
        public static class Jeux
        {
            public static Guid DnD = new Guid("0FC4E9F5-E8A8-4269-9DBC-2E5C4AF3B2B1");
            public static Guid ChroniquesOublies = new Guid("1C474C24-F5C9-470E-9B91-046B639275C3");

        }
    }
}
