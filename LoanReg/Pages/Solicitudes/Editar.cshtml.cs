using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanReg.Data;
using LoanReg.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LoanReg
{
    public class EditarModel : PageModel
    {
        private readonly ISolicitudes solicitudesMethods;
        private readonly IHtmlHelper helper;
        private readonly IClientes clienteMEthods;

        public Solicitud Solicitudes { get; set; }

        public Cliente Clientes { get; set; }

        public IEnumerable<SelectListItem> TipoPago {get;set;}

        public EditarModel(ISolicitudes solicitudesMethods, IHtmlHelper helper, IClientes clienteMEthods)
        {
            this.solicitudesMethods = solicitudesMethods;
            this.helper = helper;
            this.clienteMEthods = clienteMEthods;
        }

        public void OnGet(int? Id)
        {
            TipoPago = helper.GetEnumSelectList<TipoPago>();

            if (Id.HasValue)
            {
                Solicitudes = solicitudesMethods.GetSolicitudById(Id.Value);
                //Clientes = clienteMEthods.GetClientSolId(Id.Value);
            }
            else
            {
                Solicitudes = new Solicitud();
                Clientes = new Cliente();
            }
        }

        public ActionResult OnPost()
        {
            TipoPago = helper.GetEnumSelectList<TipoPago>();

            if (ModelState.IsValid)
            {
                if (Solicitudes.Id == 0)
                {
                    Solicitudes = solicitudesMethods.CreateSolicitud(Solicitudes);
                }
                else
                {
                    Solicitudes = solicitudesMethods.UpdateSolicitud(Solicitudes);
                }

                return RedirectToPage("./Detalles", new { Id = Solicitudes.Id });
            }

            return Page();
        }
    }
}