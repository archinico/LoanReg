using LoanReg.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanReg.Data
{
    public interface IPrestamos
    {
        public Prestamo GetPrestamoById(int id);
        Prestamo CreateSolicitud(Prestamo createPrestamo);
        Prestamo UpdateSolicitud(Prestamo updatePrestamo);
        int GuardarCambios();
    }
}
