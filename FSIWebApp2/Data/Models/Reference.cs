using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace FSIWebApp2.Data.Models
{
    public class StateReference
    {
        [Key]
        [Required]
        public int StateId { get; set; }
        [Required]
        public string State { get; set; } = "";
        [Required]
        public int StateEnumNumber { get; set; }
        [Required]
        public int StateGroup { get; set; }
    }

    public class RegionReference
    {
        [Key]
        [Required]
        public int RegionId { get; set; }
        [Required]
        public string Region { get; set; } = "";
    }

    public class CountryReference
    {
        [Key]
        [Required]
        public int CountryId { get; set; }
        [Required]
        public string Country { get; set; } = "";
    }
    public class ContactRankReference
    {
        [Key]
        [Required]
        public int ContactRankId { get; set; }
        [Required]
        public string ContactRank { get; set; } = "";
    }
    public class RecordTypeReference
    {
        [Key]
        [Required]
        public int RecordTypeId { get; set; }
        [Required]
        public string RecordType { get; set; } = "";
    }
    public class RecordStatusReference
    {
        [Key]
        [Required]
        public int RecordStatusId { get; set; }
        [Required]
        public string RecordStatus { get; set; } = "";
    }

    public class CommunityReference
    {
        [Key]
        [Required]
        public int CommunityId { get; set; }
        [Required]
        public string Community { get; set; } = "";
    }

    public class  PopIntervalReference
    {
        [Key]
        [Required]
        public int PopIntervalId { get; set; }
        [Required]
        public string PopInterval { get; set; } = "";
    }

    public class TypeEmpsReference
    {
        [Key]
        [Required]
        public int TypeEmpsId { get; set; }
        [Required]
        public string TypeEmps { get; set; } = "";
    }

    public class EmsReference
    {
        [Key]
        [Required]
        public int EmsId { get; set; }
        [Required]
        public string Ems { get; set; } = "";
    }

    public class  DispatchReference
    {
        [Key]
        [Required]
        public int DispatchId { get; set; }
        [Required]
        public string Dispatch { get; set; } = "";
    }

    public class  TrainingReference
    {
        [Key]
        [Required]
        public int TrainingId { get; set; }
        [Required]
        public string Training { get; set; } = "";
    }

    public class CodeEnforcementReference
    {
        [Key]
        [Required]
        public int CodeEnforcementId { get; set; }
        [Required]
        public string CodeEnforcement { get; set; } = "";
    }

    //public class AmbulanceReference
    //{
    //    [Key]
    //    [Required]
    //    public int AmbulanceId { get; set; }
    //    [Required]
    //    public string Ambulance { get; set; } = "";
    //}

    //public class VolsCompreference
    //{
    //    [Key]
    //    [Required]
    //    public int VolsCompid { get; set; }
    //    [Required]
    //    public string Volscomp { get; set; } = "";
    //}

}
