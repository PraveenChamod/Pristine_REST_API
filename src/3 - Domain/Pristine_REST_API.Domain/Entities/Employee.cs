using System.ComponentModel.DataAnnotations;

namespace Pristine_REST_API.Domain.Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(10)]
        public required string EmpNo { get; set; }

        [MaxLength(100)]
        public required string EmpName { get; set; }

        [MaxLength(100)]
        public required string EmpAddressLine1 { get; set; }

        [MaxLength(100)]
        public string? EmpAddressLine2 { get; set; }

        [MaxLength(100)]
        public string? EmpAddressLine3 { get; set; }

        public required DateTime EmpDateOfJoin { get; set; }

        public required bool EmpStatus { get; set; }

        public required string EmpImage { get; set; }
    }
}
