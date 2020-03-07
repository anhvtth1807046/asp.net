using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace myapp.Models
{
    public class Student
    {
        [DisplayName("Ma so sinh vien")]
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [DisplayName("Hinh thuc phat")]
        public string Type { get; set; }
        [DisplayName("So tien nop phat")]
        public int Money { get; set; }
        [DisplayName("Ngay nop phat")]
        [DisplayFormat(DataFormatString = "{0: MM/dd/yyyy}")]
        public DateTime CreatedTime { get; set; }

        public Student()
        {
            this.CreatedTime = DateTime.Now;
        }
    }
}