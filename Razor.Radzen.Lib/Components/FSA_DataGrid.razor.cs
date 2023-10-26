using Base.Models;
using Radzen.Blazor;

namespace Razor.Radzen.Lib.Components;
public partial class FSA_DataGrid<TItem>
{
    public RadzenDataGrid<TItem> DataGrid { get; set; }

    async Task EditRow(TItem item)
    {
        ReturnToAction.InvokeAsync((EntityAction.Update, item));
        //ReturnToAction.InvokeAsync((Actions.Update, item));
    }

    async Task DeleteRow(TItem item)
    {
        ReturnToAction.InvokeAsync((EntityAction.Remove, item));
    }

    public void Export(string type)
    {

    }

    public void Refresh()
    {
        try
        {
            DataGrid.Reload();
        }
        catch (Exception)
        {
        }
    }
}
