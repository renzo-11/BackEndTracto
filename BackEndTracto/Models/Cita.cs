namespace BackEndTracto.Models
{

    public class Cita
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoServicio { get; set; }

        public Usuario Usuario { get; set; }
    }
}
