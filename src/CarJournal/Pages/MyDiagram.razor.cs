using Blazor.Diagrams;

namespace CarJournal.Pages;

public partial class MyDiagram
{
    private BlazorDiagram Diagram { get; set; } = null!;

    protected override void OnInitialized()
    {
        Diagram = new BlazorDiagram();
    }
}