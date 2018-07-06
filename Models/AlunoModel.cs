using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcProject.Models
{
	public class AlunoModel
	{
		public int Id { get; set; }

		[DisplayName("Nome Completo:")]
		[Required(ErrorMessage = "Nome não informado")]
		public String Nome { get; set; }

		[Required(ErrorMessage="Informe o Email")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inválido.")]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [DisplayName("Curso")]
        public virtual CursoModel Curso { get; set; }

	}

}