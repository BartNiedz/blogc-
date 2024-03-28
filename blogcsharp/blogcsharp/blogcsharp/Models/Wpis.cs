namespace blogcsharp.Models
{
    public class Wpis
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }

        public string ImageUrl { get; set; }
        public DateTime CreateDate { get; set; }   
        
        public int ID {  get; set; }

        
        public List<Obrazek>  Galeria { get; set; }

    }
}
