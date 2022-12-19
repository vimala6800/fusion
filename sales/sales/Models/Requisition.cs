using System.Numerics;

namespace sales.Models
{
    public class Requisition
    {
        public Guid RequisitionID { get; set; }
        public string RequisitionCode { get; set; } 
        public DateTime RequisitionDate { get; set; }
        public string PotentialNumber { get; set; }
        public string Complexity { get; set; }
        public DateTime DeadlineDate { get; set; }
        public string ClientName { get; set; }  
        public Guid ClientCountryID { get; set; }
        public string ProjectType { get; set; }
        public Guid SalesPersionUserID { get; set; }
        public Guid ProjectManagerID { get; set; }  
        public int RequisitionStatus { get; set; }
        public DateTime ExpectedStartDate { get; set; }
        public Guid DepartmentID { get; set; }
        public Double EstimatedBudget { get; set; }
        public Guid CurrencyID { get; set; }
        public string ProjectDescription { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid LastUpdatedBy { get; set; }
        public DateTime LastUpdatedOn { get; set; }
 

    }
}
