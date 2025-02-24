using MellmothJdr.Commun;

using MudBlazor;

namespace MellmothJdr.BlazorBase.Custom
{
    public class CustomMudTablePager : MudTablePager
    {
        public CustomMudTablePager()
        {
            RowsPerPageString = Texte.ElementParPage;
            InfoFormat = Texte.InfoFormat;
            PageSizeOptions = new int[] { 10, 100, int.MaxValue };
            AllItemsText = Texte.ToutVoir;
        }
    }
}