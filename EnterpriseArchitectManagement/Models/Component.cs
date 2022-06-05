using System.ComponentModel.DataAnnotations;

namespace EnterpriseArchitectManagement.Models
{
    public class Component
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
        public int CodeComplexity { get; set; }
        public int LinesOfCode { get; set; }
        public string SonarQube { get; set; }
        public bool StandardComponent { get; set; }
        public string PatternsUsed { get; set; }
        public string Security { get; set; }
        public string CodeLanguage { get; set; }
        public string Infrastructure { get; set; }
        public string ThirdPartyPackages { get; set; }
        public string UpgradeSuggestions { get; set; }
        public string SecuritySuggestions { get; set; }
        public List<Component> IntegrationComponents { get; set; } = new List<Component>();
        public List<Component> InfrastructureComponents { get; set; } = new List<Component>();
        

    }
}
