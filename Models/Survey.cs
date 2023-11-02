public class Survey{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Ubicacion { get; set; }
    public string Lenguaje { get; set; }
    public string Descripcion { get; set; }



    // Constructor por defecto
    public Survey()
    {
    }

    // Constructor parametrizado
    public Survey(string nombre, string apellido, string ubicacion, string lenguaje, string descripcion)
    {
        Nombre = nombre;
        Apellido = apellido;
        Ubicacion = ubicacion;
        Lenguaje = lenguaje;
        Descripcion = descripcion;
    }

}