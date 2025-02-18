namespace MellmothJdr.Pages;

public class CounterPage : AuthenticatedPage
{
    protected int _currentCount;

    protected void IncrementCount()
    {
        _currentCount++;
    }
}