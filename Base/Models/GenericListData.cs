namespace Base.Models
{
    public class GenericListData
    {
        public bool AllowFiltering { get; set; } = true;
        public bool AllowColumnResize { get; set; } = false;
        public bool AllowAlternatingRows { get; set; } = false;
        public bool AllowSorting { get; set; } = true;
        public int PageSize { get; set; } = 5;
        public bool AllowPaging { get; set; } = true;
        public List<DataColumn> DataColumns { get; set; } = new List<DataColumn>();
    }
}
