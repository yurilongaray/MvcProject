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
		public AlunoModel Aluno { get; set; }
		public CursoModel Curso	{ get; set; }
		public string NomeCurso { get; set; }

		/*
		public int IdAluno 	 { get; set; } //Aluno
		public int IdCurso 	 { get; set; } //Curso
		public int NomeCurso { get; set; } //Curso
		*/
	}
}