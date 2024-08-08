namespace BlazorApp
{
    public class NavItem
    {
        public int Id { get; set; }
        public string? Label { get; set; }
        public bool IsExpanded { get; set; }
        public string? ClassName { get; set; }
        public List<SubNavItem> Children { get; set; }
        public NavItem()
        {
            Children = new List<SubNavItem>();
        }
    }

    public class SubNavItem
    {
        public string? Label { get; set; }
        public string? LinkTo { get; set; } 
        public bool IsActive { get; set; }
        public string? ClassName { get; set; }

    }

    public class NavSpec
    {
        public string? Label { get; set; }
        public string? Folder { get; set; }
        public List<SubNavSpec> Children { get; set; }
    }

    public class SubNavSpec
    {
        public string? Label { get; set; }
        public string? Folder { get; set; }
    }
}
