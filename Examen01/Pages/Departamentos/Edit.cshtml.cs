using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;
using Entity;

namespace WebApp.Pages.Departamentos
{
    public class EditModel : PageModel
    {
        private readonly IDepartamentosService departamentosService;

        public EditModel(IDepartamentosService departamentosService)
        {
            this.departamentosService = departamentosService;
        }

        [BindProperty]
        public DepartamentosEntity Entity { get; set; } = new DepartamentosEntity();

        [BindProperty]
        public int? id { get; set; }

        public async Task<IActionResult> OnGet()
        {

            try
            {
                if (id.HasValue)
                {
                    Entity = await departamentosService.GetById(new() { Id_Departamento = id });
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
                if (Entity.Id_Departamento.HasValue)
                {
                    //Actualizar 
                    var result = await departamentosService.Update(Entity);

                    if (result.CodeError != 0) throw new Exception(result.MsgError);
                    TempData["Msg"] = "Se actualizó correctamente";
                }
                else
                {
                    //Nuevo 
                    var result = await departamentosService.Create(Entity);

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
