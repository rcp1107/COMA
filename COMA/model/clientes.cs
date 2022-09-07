namespace COMA.model
{
    public class clientes
    {
        public int Id { get; set; }//En este apartado creamos los atributos el Id como clave primaria   
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public string correo_electronico { get; set; }
        public string tipo_usuario { get; set; }

    }
    
}
