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
    public class EditModel : PageModel
    {
        private readonly ITitulosService titulosService;

        public EditModel(ITitulosService titulosService)
        {
            this.titulosService = titulosService;
        }

        [BindProperty]
        public TitulosEntity Entity { get; set; } = new TitulosEntity();

        [BindProperty]
        public int? id { get; set; }

        public async Task<IActionResult> OnGet()
        {

            try
            {
                if (id.HasValue)
                {
                    Entity = await titulosService.GetById(new() { Id_Titulo = id });
                }

                return Page();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }

        }

        public async Task<IActionResult> OnPostAsync()
        {

            try
            {
                if (Entity.Id_Titulo.HasValue)
                {
                    //Actualizar 
                    var result = await titulosService.Update(Entity);

                    if (result.CodeError != 0) throw new Exception(result.MsgError);
                    TempData["Msg"] = "Se actualizó correctamente";
                }
                else
                {
                    //Nuevo 
                    var result = await titulosService.Create(Entity);

                    if (result.CodeError != 0) throw new Exception(result.MsgError);
                    TempData["Msg"] = "Se agregó correctamente";

                }

                return RedirectToPage("Grid");
            }



            catch (Exception ex)
            {

                return Content(ex.Message);
            }

        }

    }
}
