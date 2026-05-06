namespace NCRecordShop.Models
{
    public class Album
    {
        public int ID { get; set; }
        public string Title { get; set; } = "";
        public string Artist { get; set; } = "";
        public int ReleaseYear { get; set; }
        public Genre Genre { get; set; }
        public int Quantity { get; set; }
        public DateTime DateAdded {get; set;}

    }
}
