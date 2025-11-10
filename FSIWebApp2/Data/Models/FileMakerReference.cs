using System.ComponentModel.DataAnnotations;

namespace FSIWebApp2.Data.Models
{
    public class FileMakerReference
    {
        [Key]
        public int Id { get; set; }
        public string? FileMakerName { get; set; } = "";
        public string? NewFsiName { get; set; } = "";
        public string? SQLDataType { get; set; } = "";
        public string? GenericDataType { get; set; } = "";
        public string? Key { get; set; } = "";
        public bool Nullable { get; set; }
        public bool InUse { get; set; }
    }
}
