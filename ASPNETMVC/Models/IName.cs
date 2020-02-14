namespace ASPNETMVC.Models
{
    public interface IName
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
    }
}