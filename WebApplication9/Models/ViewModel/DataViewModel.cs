using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace WebApplication9.Models.ViewModel
{
    public class DataViewModel
    {
        [DisplayName("#")]
        public int ID { get; set; }
        [DisplayName("類別")]
        public string Category { get; set; }
        [DisplayName("金額")]
        public int Money { get; set; }
        [DisplayName("日期")]
        public string InputDate { get; set; }
        [DisplayName("備註")]
        public string Message { get; set; }
    }
}