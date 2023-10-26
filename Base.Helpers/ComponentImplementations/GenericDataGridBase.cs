using Base.Helpers.DataTypes;
using Microsoft.AspNetCore.Components;

namespace Base.Helpers.ComponentImplementations
{
    public class GenericDataGridBase<TItem> : ComponentBase
    {
        [Parameter]
        [EditorRequired]
        public IList<TItem> Items { get; set; } = default;

        [Parameter]
        [EditorRequired]
        public GenericListData GenericData { get; set; } = new();

        public bool allowRowSelectOnRowClick = true;
        public IList<TItem> selectedItems = default;

        [Parameter]
        public EventCallback<(object, object)> ReturnToAction { get; set; }
    }
}
