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
		banco de dados. Utiliza algumas convenções de nomes
		para algumas tarefas. Quando uma propriedade tem o nome
		de Id ou termina com Id (Ex: ProdutoId) ele automaticamente
		usa essa propriedade como chave primária auto-incrementada
        */
		public int Id 					{ get; set; }
		public String Nome 				{ get; set; }
        public string Email 			{ get; set; }
        public DateTime DataNascimento  { get; set; }
		public int IdCurso				{ get; set; }

	}

}