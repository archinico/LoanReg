using LoanReg.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanReg.Data
{
    public interface IEmpleados
    {
        IList<Empleado> GetEmpleadoByName(string nombre);

        IList<Empleado> GetAllEmpleados();

        public Empleado GetEmpleadoById(int id);

        Empleado UpdateEmpleado(Empleado updateCliente);

        Empleado CreateEmpleado(Empleado createCliente);
        int GuardarCambios();

        Empleado Eliminar(int id);

        IList<Empleado> GetRoles(Empleado getRoles);

        Empleado RolebyEmpRoleId(int id);
    }
}
