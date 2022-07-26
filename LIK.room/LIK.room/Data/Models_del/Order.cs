using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LIK.room.Data.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }

        [Display(Name = "Ім'я")]
        [StringLength(15)]
        [Required(ErrorMessage = "Введіть ім'я")]
        public string Name { get; set; }

        [Display(Name = "Фамілія")]
        [StringLength(20)]
        [Required(ErrorMessage = "Введіть фамілію")]
        public string Surname { get; set; }

        [Display(Name = "Місто")]
        [StringLength(25)]
        [Required(ErrorMessage = "Назва міста не менше 4 символів")]
        public string Adress { get; set; }

        [Display(Name = "Телефон")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(10)]       
        [Required(ErrorMessage = "Номер телефона не менше 10 символів")]
        public string Phone { get; set; }

        [Display(Name = "Електрона пошта")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Введене значення не відповідає формату електронної пошти")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
