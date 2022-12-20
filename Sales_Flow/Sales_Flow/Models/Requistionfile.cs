using System.ComponentModel.DataAnnotations;

namespace Sales_Flow.Models
{
    public class Requistionfile
    {
        [Key]
        public Guid RequsitionFileID { get; set; }
        public Guid RequsitionID { get; set; }
        public string Filename { get; set; }
        public string FileTypeDescription { get; set; }
    }
}
