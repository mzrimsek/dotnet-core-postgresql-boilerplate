using System.ComponentModel.DataAnnotations.Schema;

namespace Integration.EntityFramework.Models
{
    [Table("user")]
    public class UserDatabaseModel
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("firstname")]
        public string FirstName { get; set; }
        [Column("lastname")]
        public string LastName { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("password")]
        public string Password { get; set; }
    }
}
