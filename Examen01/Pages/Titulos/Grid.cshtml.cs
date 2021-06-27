using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;
using Entity;

namespace WebApp.Pages.Titulos
{
    public class GridModel : PageModel
    {
        private readonly ITitulosService titulosService;

        public GridModel(ITitulosService titulosService)
        {
            this.titulosService = titulosService;
        }

        public IEnumerable<TitulosEntity> GridList { get; set; } = new List<TitulosEntity>();


        public async Task<IActionResult> OnGet()
        {
            try
            {
                GridList = await titulosService.Get();
                return Page();
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
                
            }

        }
    }
}
