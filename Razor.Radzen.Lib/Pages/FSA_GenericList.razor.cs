using Radzen.Blazor;

namespace Razor.Radzen.Lib.Pages;
public partial class FSA_GenericList<TItem>
{
    public RadzenDataGrid<TItem> MyGrid;

    async Task EditRow(TItem item)
    {
        ReturnToAction.InvokeAsync(("edit", item));
    }

    async Task DeleteRow(TItem item)
    {
        ReturnToAction.InvokeAsync(("delete", item));
    }

    public void Export(string type)
    {

    }
}
