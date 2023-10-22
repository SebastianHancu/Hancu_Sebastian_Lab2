using System.ComponentModel.DataAnnotations;

namespace Hancu_Sebastian_Lab2.Models
{
    public class Authors
    {
        csharp
using System.ComponentModel.DataAnnotations;

public class Authors
    {
        public int ID { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
    }


}
