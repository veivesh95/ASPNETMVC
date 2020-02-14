namespace ASPNETMVC.Models
{
    public interface IPicture
    {
        public int Id { get; set; }
        
        public string Large { get; set; }

        public string Medium { get; set; }

        public string Thumbnail { get; set; }

    }
}