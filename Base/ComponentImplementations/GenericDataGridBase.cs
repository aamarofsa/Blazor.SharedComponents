using Base.Models;

namespace Base.ComponentImplementations
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
        public EventCallback<Object> ReturnToAction { get; set; }
    }
}
