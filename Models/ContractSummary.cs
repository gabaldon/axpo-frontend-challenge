namespace AxpoContractOnboarding.Models
{
    public class ContractSummary
    {
        public string Title { get; set; } = "Overview";
        public bool DefaultExpanded { get; set; } = true;
        public string ContractType { get; set; } = string.Empty;
        public string CountryName { get; set; } = string.Empty;
        public string Period { get; set; } = string.Empty;
        public string Commodity { get; set; } = string.Empty;
        public string SignatureDate { get; set; } = string.Empty;
    }
}