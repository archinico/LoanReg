using LoanReg.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanReg.Data
{
    public interface IClientes
    {
        IList<Cliente> GetClienteByName(string nombre);

        public Cliente GetClienteById(int id);

        Cliente UpdateCliente(Cliente updateCliente);

        Cliente CreateCliente(Cliente createCliente);
        int GuardarCambios();


    }
}
