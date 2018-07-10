using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using MvcProject.Models;

namespace MvcProject.ViewModels
{

	public class AlunoCursoVM
	{
		//Curso
		public int IdCurso		{ get; set; }
		public string NomeCurso { get; set; }

		//Aluno
		//public AlunoModel Aluno { get; set; }

		[DisplayName("Nome Completo:")]
		[Required(ErrorMessage = "Nome não informado")]
		public String NomeAluno { get; set; }

		[DisplayName("Email:")]
		[Required(ErrorMessage="Informe o Email")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inválido.")]
        public string EmailAluno { get; set; }

		[DisplayName("Data de Nascimento:")]
        [DataType(DataType.Date, ErrorMessage = "FUDEU")]
		[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
		[Required(ErrorMessage="Informe uma data")]
        public DateTime DataNascimentoAluno { get; set; }

	}
}