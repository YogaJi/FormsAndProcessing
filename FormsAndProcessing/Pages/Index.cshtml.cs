using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormsAndProcessing.Pages
{
    public class IndexModel : PageModel
    {
        
        
        [Required]
        [Range(0,int.MaxValue)]
        [FromForm]
        public int NumOfDate { get; set; }

        [Required]
        [FromForm]
        public DateTime Dates { get; set; }

        [DataType(DataType.Date)]
        public DateTime? NewDate { get; set; }

        private readonly ILogger<IndexModel> _logger;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            if (ModelState.IsValid) {
            }

        }
        public void OnPost()
        {
            if (ModelState.IsValid)
            { 
                NewDate = Dates.AddDays(NumOfDate);
            }
        }
    }

 
}
