using Microsoft.AspNetCore.Components;

namespace Puppies.Components.Pages;

public partial class Profile
{
    [Parameter] public string? Id { get; set; }

    private int _currentCount = 0;

    private void IncrementCount()
    {
        _currentCount++;
    }
}