namespace sales.Models
{
    public class RequisitionSkill
    {
        public Guid RequisitionSkillID { get; set; }
        public Guid RequsitionID { get; set; }
        public Guid SkillID { get; set; }
        public string Mandatory { get; set; }
        public int Experience { get; set; }
        public string Comments { get; set; }
    }
}
