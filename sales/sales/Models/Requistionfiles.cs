namespace sales.Models
{
    public class Requistionfiles
    {
        public Guid RequsitionFileID { get; set; }
        public Guid RequsitionID { get; set; }
        public string Filename { get; set; }
        public string FileTypeDescription { get; set; }
    }
}
