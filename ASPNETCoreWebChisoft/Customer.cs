using System.ComponentModel.DataAnnotations;

namespace ASPNETCoreWebChisoft
{
    public class Customer
    {
        public int Id { get; set; }

        [Required, StringLength(20)]
        public string Name { get; set; }
    }
}