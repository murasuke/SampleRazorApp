using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace SampleRazorApp.Pages
{
    public class FormModel : PageModel
    {

        public string  Message { get; set; }
        
        [DataType(DataType.Text)]
        public string  Name { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Tel { get; set; }

        public void OnGet()
        {
            Message = "何か入力してください。";
        }

        public void OnPost(string name, string password, string mail, string tel)
        {
            Message = $"[name:{name}, password:{password}, mail:{mail}, tel:{tel}]";
        }
    }
}