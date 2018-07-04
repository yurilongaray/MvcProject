using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcProject.Models {

	public class CursoModel {

		public string nome { get; set; }

		public string cargaHoraria { get; set; }

		//Dias da semana
		public bool segunda { get; set; }
		public bool terca { get; set; }
		public bool quarta { get; set; }
		public bool quinta { get; set; }
		public bool sexta { get; set; }
		public bool sabado { get; set; }

		[DataType(DataType.Date)]
		public DateTime dataInicio { get; set; }
	}

}

