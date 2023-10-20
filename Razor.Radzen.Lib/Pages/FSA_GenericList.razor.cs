using Radzen.Blazor;

namespace Razor.Radzen.Lib.Pages;
public partial class FSA_GenericList<TItem>
{
    public RadzenDataGrid<TItem> MyGrid;

    async Task EditRow(TItem item)
    {
        // orderToUpdate = order;
        // await ordersGrid.EditRow(order);
    }

    async Task DeleteRow(TItem item)
    {
        ReturnToAction.InvokeAsync(item);
    }

    public void Export(string type)
    {

    }
}
