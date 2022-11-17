using Microsoft.EntityFrameworkCore;

namespace ProjectBank.Usuario
{
    public class Usuario:DbContext 
    {
        public int Id { get; set; }
        public string Nome { get ; set ; }
        public long Cpf { get; set; }
        public int idade { get; set; }

}
}
