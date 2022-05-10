using System.ComponentModel.DataAnnotations;

namespace WorkShopApi.Model
{
    public class CustomerModel
    {
        [Key]
        public int idCostumer { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ushort Age { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public DateTime DateOfBirth { get; set; } 
        public float Stature { get; set; }
        public bool IsHuman { get; set; }
    }
}
