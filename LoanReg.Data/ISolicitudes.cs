using LoanReg.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanReg.Data
{
    public interface ISolicitudes
    {
        public Solicitud GetSolicitudById(int id);
        Solicitud CreateSolicitud(Solicitud createSolicitud);
        Solicitud UpdateSolicitud(Solicitud updateSolicitud);
        int GuardarCambios();
    }
}
