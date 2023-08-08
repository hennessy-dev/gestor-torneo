
namespace gestorTaller;
public class Empleado : Persona
{
    public string Especialidad { get; set; }
    public Empleado(int cc, string nombre, string apellido, int telefono, string especialidad): base(cc , nombre, apellido, telefono)
    {
        this.Especialidad = especialidad;
    }
}
