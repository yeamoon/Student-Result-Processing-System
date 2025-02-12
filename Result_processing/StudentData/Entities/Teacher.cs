namespace StudentData.Entities
{
    using RepositoryPatternEf6;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Teacher")]
    public partial class Teacher : Entity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        public int AddressId { get; set; }

        public int DepartmentId { get; set; }

        public virtual Address Address { get; set; }

        public virtual Department Department { get; set; }
    }
}
