using System.Diagnostics;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MellmothJdr.Pages;

public class CounterPage : AuthenticatedPage
{
    protected int _currentCount;

    protected void IncrementCount()
    {
        _currentCount++;
    }
}