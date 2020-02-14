namespace ASPNETMVC.Models
{
    public class IUser
    {
        public int Id { get; set; }

        public string Gender { get; set; }

        public IName Name { get; set; }

        public string Email{ get; set; }

        public IPicture Picture { get; set; }
       
}
}