namespace Base.Models
{
    public class DataColumn
    {
        public string Property { get; set; } = string.Empty;
        public bool Filterable { get; set; } = false;
        public bool Sortable { get; set; } = false;
        public string Title { get; set; } = string.Empty;
        public bool Frozen { get; set; } = false;
        public bool Visible { get; set; } = true;
    }
}
