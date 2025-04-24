using Microsoft.AspNetCore.Components;

namespace Puppies.Components.Pages;

public partial class AdoptionForm
{
    [SupplyParameterFromForm] private PuppyOwner? Model { get; set; }
    protected override void OnInitialized() => Model ??= new PuppyOwner();
    private void Submit() => Logger.LogInformation("Name = {Name}", Model?.Name);
}