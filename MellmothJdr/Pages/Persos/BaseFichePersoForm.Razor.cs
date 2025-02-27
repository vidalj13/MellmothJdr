using MellmothJdr.DAL.Entities;

using Microsoft.AspNetCore.Components;

using MudBlazor;

using NotificationManager.Infrastructure.Entities.Base;

namespace MellmothJdr.Pages.Persos;

public class BaseFichePersoFormComponent : ComponentBase
{
    public int spacing { get; set; } = 4;
    [Parameter]
    public BaseFichePersoEntity BaseFichePerso  { get;set; }
    [Parameter]
    public List<Race> Races { get; set; }
    public MudForm Form1 { get; set; }
    public MudForm Form2 { get; set; }
    public bool IsValid => Form1.IsValid;
    public bool IsRaceCustom { get; set; }

    public Task Validate()
    {
        return Form1.Validate();
    }
}