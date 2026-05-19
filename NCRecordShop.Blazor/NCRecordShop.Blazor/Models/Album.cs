namespace NCRecordShop.Blazor.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Artist { get; set; } = string.Empty;
        public int ReleaseYear { get; set; }
        public string Genre { get; set; } = string.Empty;
        public int Quantity { get; set; }


    }
   
}
