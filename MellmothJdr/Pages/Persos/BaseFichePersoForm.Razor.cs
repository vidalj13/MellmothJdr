using MellmothJdr.DAL.Entities;

using Microsoft.AspNetCore.Components;

using MudBlazor;

using NotificationManager.Infrastructure.Entities.Base;

namespace MellmothJdr.Pages.Persos;

public class BaseFichePersoFormComponent : ComponentBase
{
    [Parameter]
    public BaseFichePersoEntity BaseFichePerso  { get;set; }
    [Parameter]
    public List<Race> Races { get; set; }
    public MudForm Form { get; set; }
    public bool IsValid => Form.IsValid;
    public bool IsRaceCustom { get; set; }

    public Task Validate()
    {
        return Form.Validate();
    }
}