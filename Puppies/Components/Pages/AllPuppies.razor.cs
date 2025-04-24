namespace Puppies.Components.Pages;

public partial class AllPuppies
{
    private PuppyList[]? puppies;

    protected override async Task OnInitializedAsync()
    {
        var startDate = DateOnly.FromDateTime(DateTime.Now);
        var summaries = new[]
            { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };
        puppies = Enumerable.Range(1, 5).Select(index => new PuppyList
        {
            BirthDate = startDate.AddDays(index),
            FavoriteWeather = summaries[Random.Shared.Next(summaries.Length)]
        }).ToArray();
    }

    private class PuppyList
    {
        public DateOnly BirthDate { get; set; }
        public string? FavoriteWeather { get; set; }
    }
}