using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using MvcProject.Models;

namespace MvcProject.Models
{

	public class AlunoViewModel
	{

		public AlunoModel Aluno { get; set; }
    	public List<CursoModel> Curso { get; set; }

	}
}