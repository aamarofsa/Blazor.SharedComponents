namespace Base.Helpers.DataTypes
{
    public class GenericListData
    {
        public SelectionMode SelectionMode { get; set; } = SelectionMode.Single;
        public bool AllowVirtualization { get; set; } = false;
        public bool AllowFiltering { get; set; } = true;
        public bool AllowColumnResize { get; set; } = false;
        public bool AllowAlternatingRows { get; set; } = false;
        public bool AllowSorting { get; set; } = true;
        public bool AllowMultiColumnSorting { get; set; } = true;
        public bool AllowColumnReorder { get; set; } = true;
        public int PageSize { get; set; } = 5;
        public bool AllowPaging { get; set; } = true;
        public bool AllowGrouping { get; set; } = true;
        public bool AllowColumnPicking { get; set; } = true;
        public DataDensity Density { get; set; } = DataDensity.Compact;
        public bool AllowActions { get; set; } = true;
        public List<DataColumn> DataColumns { get; set; } = new List<DataColumn>();
    }

    public class DataColumn
    {
        public string Property { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;

        public bool IsSelected { get; set; }

        public bool Filterable { get; set; } = false;
        public bool Sortable { get; set; } = false;
        public bool Groupable { get; set; } = true;
        public bool Pickable { get; set; } = true;
        public bool Frozen { get; set; } = false;
        public bool Visible { get; set; } = true;

        public string Width { get; set; } = string.Empty;
    }

    public enum SelectionMode
    {
        Single,
        Multiple
    }
    public enum DataDensity
    {
        Default,
        Compact
    }

    public enum EntityAction
    {
        Add,
        Update,
        Remove,
        Detail
    }
}
