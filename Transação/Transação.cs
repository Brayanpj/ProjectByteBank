using Microsoft.EntityFrameworkCore;

namespace ProjectBank.Transação
{
    public class Transação : DbContext
    {
        public int Id { get; set; }
        public int Valor { get; set; }
        public string Tipo { get; set; }
        public string Devedor { get; set; }
        public long Data { get; set; }
        public string Credor { get; set; }




    }
}
