using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace GerenciamentoFinanceiroCurso.Models
{
    public class Financeiro
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite uma descrição!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Digite um valor!")]
        public double Valor { get; set; }

        [Required(ErrorMessage = "Digite uma data!")]
        public  DateTime DataDaOperacao { get; set; }

        [Required(ErrorMessage = "Selecione uma categoria!")]
        public string CategoriaId { get;  set; }

        [ValidateNever]
        public Categoria Categoria { get; set; }

        [Required(ErrorMessage = "Selecione uma transação!")]
        public string TransacaoId { get; set; }


        [ValidateNever]
        public Transacao transacao { get; set; }


    }
}
