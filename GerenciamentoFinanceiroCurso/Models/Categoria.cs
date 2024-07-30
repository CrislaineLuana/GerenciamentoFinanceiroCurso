using System.ComponentModel.DataAnnotations;

namespace GerenciamentoFinanceiroCurso.Models
{
    public class Categoria
    {
        public string CategoriaId { get; set; }

        [Required(ErrorMessage = "Digite a categoria!")]
        public string Nome { get; set; }
    }
}
