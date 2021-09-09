using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaskSoftline.Models
{
    public class ResultCart
    {
        [Display(Name = "Наименование")]
        public string Name { get; set; }

        [Display(Name = "Количество")]
        public int Amount { get; set; }

        [Display(Name = "Поставщик")]
        public string ProviderName { get; set; }

        [Display(Name = "Итоговая стоимость")]
        public decimal TotalCost { get; set; }

        [Display(Name = "Крайний срок доставки")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DLData { get; set; }        
    }
}