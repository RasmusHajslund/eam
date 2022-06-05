using System.ComponentModel.DataAnnotations;

namespace EnterpriseArchitectManagement.Models
{
    public class Application
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        public DateTime AuditDate { get; set; } = DateTime.Now;
        [DataType(DataType.Date)]
        public DateTime GoLiveDate { get; set; } = DateTime.Now;
        [DataType(DataType.Date)]
        public DateTime EndOfLifeDate { get; set; } = DateTime.Now.AddYears(1);
        public string Description { get; set; } = string.Empty;
        public enum Status
        {
            Planning = 1,
            Analysis = 2,
            Design = 3,
            Development = 4,
            Testing = 5,
            Integration = 6,
            Maintenance = 7,
            Disposition = 8,
            Disposed = 9,
        }
        public List<Application> Components { get; set; } = new List<Application>();
    }
}
