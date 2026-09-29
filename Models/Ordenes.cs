namespace Prueba.Models
{
    public class Ordenes
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
    }
}
