namespace gestorTaller;
public class Persona
{
    public int Cc;
    public string Nombre;
    public string Apellido;
    public int Telefono;

    public int GetCc() => this.Cc;
    public void SetCc(int Cc) => this.Cc = Cc;
    public string GetNombre() => this.Nombre;
    public void SetNombre(string Nombre) => this.Nombre = Nombre;
    public string GetApellido() => this.Apellido;
    public void SetApellido(string Apellido) => this.Apellido = Apellido;
    public int GetTelefono() => this.Telefono;
    public void SetTelefono(int Telefono) => this.Telefono = Telefono;

    public Persona(int Cc, string Nombre, string Apellido, int Telefono)
    {
        this.Cc = Cc;
        this.Nombre = Nombre;
        this.Apellido = Apellido;
        this.Telefono = Telefono;
    }
}