using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Equinox.Application.ViewModels
{
    public class CustomerViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The Model is Required")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Model")]
        public string NameModel { get; set; }

        [Required(ErrorMessage = "The Model Year is Required")]
        [DisplayName("Model Year")]
        public int ModelYear { get; set; }

        [Required(ErrorMessage = "The Manifacturing Year is Required")]
        [DisplayName("Manifacturing Year")]
        public int ManifacturingYear { get; set; }
    }
}
