using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcProject.Models
{
    [Table("Alunos")]
	public class AlunoModel
	{

		/*
		O EntityFramework, que usamos para facilitar o acesso ao
		banco de dados. Utiliza algumas conven��es de nomes
		para algumas tarefas. Quando uma propriedade tem o nome
		de Id ou termina com Id (Ex: ProdutoId) ele automaticamente
		usa essa propriedade como chave prim�ria auto-incrementada
        */
		public int Id { get; set; }

		[DisplayName("Nome Completo:")]
		[Required(ErrorMessage = "Nome n�o informado")]
		public String Nome { get; set; }


		[DisplayName("Email:")]
		[Required(ErrorMessage="Informe o Email")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inv�lido.")]
        public string Email { get; set; }


		[DisplayName("Data de Nascimento:")]
		[Required(ErrorMessage="Informe uma data no formato dd/mm/aaaa ")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

	}

}