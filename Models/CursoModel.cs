using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcProject.Models
{

	public class CursoModel
	{

		public int Id 				{ get; set; }
		public string Nome 			{ get; set; }
		public string Descricao		{ get; set; }
		public string CargaHoraria  { get; set; }
		public string CaminhoImagem { get; set; }
		public string CaminhoVideo  { get; set; }

		//Dias da semana
		public bool Segunda { get; set; }
		public bool Terca   { get; set; }
		public bool Quarta  { get; set; }
		public bool Quinta  { get; set; }
		public bool Sexta   { get; set; }
		public bool Sabado  { get; set; }

		[DataType(DataType.Date)]
		public DateTime DataInicio { get; set; }

	}

}

