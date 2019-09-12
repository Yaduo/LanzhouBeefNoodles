using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.Models
{
    public class Feedback
    {
        [BindNever]
        public int Id { get; set; }

        [Required(ErrorMessage = "请留下你的名字")]
        [StringLength(50, ErrorMessage = "名字不能超过20个字")]
        public string Name { get; set; }

        [Required(ErrorMessage = "请留下你的email")]
        [StringLength(50, ErrorMessage = "email不能超过50个字符")]
        [DataType(DataType.EmailAddress, ErrorMessage = "请填写正确的email格式")]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "请填写正确的email格式")]
        public string Email { get; set; }

        [Required(ErrorMessage = "请留下你的反馈意见")]
        [StringLength(400, ErrorMessage = "反馈意见不能超过200个字")]
        public string Message { get; set; }
        public DateTime CreateDateUTC { get; set; }
    }
}
