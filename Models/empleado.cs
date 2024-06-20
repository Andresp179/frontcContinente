namespace ProyectoCantor.Models
{
    public class empleado
    {
        
        public int idEmpleado { get; set; }

        
        public int cedula { get; set; }

        
        public string foto { get; set; }

        
        DateTime fechaIngreso = DateTime.Now;

        
        public string cargoEmpleado { get; set; }

    }
}