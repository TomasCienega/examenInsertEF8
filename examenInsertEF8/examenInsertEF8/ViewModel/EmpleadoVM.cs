using examenInsertEF8.Models;

namespace examenInsertEF8.ViewModel
{
    public class EmpleadoVM
    {
        public List<Empleado> ListaEmpleados { get; set; } = new();
        public Empleado EmpleadoModelReference { get; set; } = new();
        public List<Departamento> ListaDepartamentos { get; set; } = new();
    }
}
