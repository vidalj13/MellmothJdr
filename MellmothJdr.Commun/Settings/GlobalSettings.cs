using MellmothJdr.Commun.Interfaces;

namespace MellmothJdr.Commun.Settings
{
    public class GlobalSettings : ICustomOptions
    {
        public static string Section => "GlobalSettings";
        public string SectionName => Section;
        public bool AutoMigrate { get; set; } = true;
        public string ClientIdGoogle { get; set; }
        public string ClientSecretGoolge { get; set; }
    }
}
