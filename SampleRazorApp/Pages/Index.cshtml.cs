using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SampleRazorApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [ViewData]
        public string Message { get; set; }
        private string _name = "no-name";
        private string _mail = "no-mail";
        private string[][] data = { 
            new[] { "taro", "taro@yamada" }, 
            new[] { "hanako", "hanako@flower" }, 
            new[] { "sachiko", "sachiko@happy" } };

        [BindProperty(SupportsGet = true)]
        public int id { get; set; }

        public string getData(int id)
        {
            return $"[名前:{data[id][0]} ,メール:{data[id][1]}]";
        }

        public void OnGet()
        {
            //this.ViewData["message"] = "This is sample message";
            this.Message = "何か入力して下さい";
        }

        public string getData()
        {
            return $"[名前:{_name} ,メール:{_mail}]";
        }
    }
}
