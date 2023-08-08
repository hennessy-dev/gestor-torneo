namespace gestorTaller.clases
{
    public class Cliente : Persona
    {
        public string Email { get; set; }
        public string FechaRegistro { get; set; }
        public List<Vehiculo> ListaVehiculos { get; set;}
        public Cliente(int cc, string nombre, string apellido, int telefono, string email, string fechaRegistro): base(cc, nombre, apellido, telefono)
        {
            Email = email;
            FechaRegistro = fechaRegistro;
        }
    }
}