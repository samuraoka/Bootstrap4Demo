namespace Bootstrap4Demo.Models
{
    public class ContactViewModel
    {
        public ContactViewModel()
        {
            Favorite = string.Empty;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Favorite { get; set; }
        public string Reason { get; set; }
        public string Message { get; set; }
    }
}
