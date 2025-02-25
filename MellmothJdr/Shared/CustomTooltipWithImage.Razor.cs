using Microsoft.AspNetCore.Components;

using MudBlazor;

namespace MellmothJdr.Shared;

public class CustomTooltipWithImageComponent : ComponentBase
{
    [Parameter]
    public string SrcImage { get; set; }
    [Parameter]
    public string Titre { get; set; } 
    [Parameter]
    public string Description { get; set; }
    [Parameter]
    public bool Arrow { get; set; }
    [Parameter]
    public Placement Placement { get; set; }
    [Parameter]
    public int Width { get; set; }
}