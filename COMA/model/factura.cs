namespace COMA.model
{
    public class factura
    {

        public int Id { get; set; }
        public int id_usuario { get; set; }
        public string folio { get; set; }
        public int saldo { get; set; }
        public string fecha_facturacion { get; set; }
        public string fecha_creacion { get; set; }
    }
}
