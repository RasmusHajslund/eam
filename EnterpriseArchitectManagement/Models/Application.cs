using System.ComponentModel.DataAnnotations;

namespace EnterpriseArchitectManagement.Models
{
    public class Application
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        [DataType(DataType.DateTime)]
        public DateTime AuditDate { get; set; } = DateTime.Now;
        [DataType(DataType.Date)]
        public DateTime GoLiveDate { get; set; } = DateTime.Now;
        [DataType(DataType.Date)]
        public DateTime EndOfLifeDate { get; set; } = DateTime.Now.AddYears(1);
        public string Description { get; set; } = string.Empty;
        public Enums.ApplicationStatus Status { get; set; }
        
        public List<Component> Components { get; set; } = new List<Component>();
    }
}
