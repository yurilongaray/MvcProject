using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcProject.Models {

	public class Cursos {

		public List<CursoModel> listaCursos = new List<CursoModel>();

		public Cursos() {

			listaCursos.Add( new CursoModel {
				nome 		 = "Gastronomia",
				cargaHoraria = "300 hrs",
				segunda 	 = true,
				terca		 = true,
				quarta		 = true,
				quinta		 = true,
				sexta 		 = true,
				sabado		 = false,
				dataInicio 	 = Convert.ToDateTime("01/01/2019")
			});

			listaCursos.Add( new CursoModel {
				nome 		 = "Enfermagem",
				cargaHoraria = "300 hrs",
				segunda 	 = true,
				terca		 = true,
				quarta		 = true,
				quinta		 = true,
				sexta 		 = true,
				sabado		 = false,
				dataInicio 	 = Convert.ToDateTime("01/01/2019")
			});

			listaCursos.Add( new CursoModel {
				nome 		 = "Farmácia",
				cargaHoraria = "300 hrs",
				segunda 	 = true,
				terca		 = true,
				quarta		 = true,
				quinta		 = true,
				sexta 		 = true,
				sabado		 = false,
				dataInicio 	 = Convert.ToDateTime("01/07/2018")
			});

			listaCursos.Add( new CursoModel {
				nome 		 = "Desenvolvimento de Software",
				cargaHoraria = "300 hrs",
				segunda 	 = true,
				terca		 = true,
				quarta		 = true,
				quinta		 = true,
				sexta 		 = true,
				sabado		 = false,
				dataInicio 	 = Convert.ToDateTime("01/01/2018")
			});

			listaCursos.Add( new CursoModel {
				nome 		 = "Administração",
				cargaHoraria = "300 hrs",
				segunda 	 = true,
				terca		 = true,
				quarta		 = true,
				quinta		 = true,
				sexta 		 = true,
				sabado		 = false,
				dataInicio 	 = Convert.ToDateTime("01/07/2019")
			});
		}

	}
}