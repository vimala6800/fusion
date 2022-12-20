namespace sales.Models
{
    public class RequisitionPatner
    { 
        public Guid RequisitionPatnerID { get; set; }
        public Guid RequisitionID { get; set; }
        public Guid PatnerID { get; set; }
    }
}
