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
				nome 		  = "Gastronomia",
				cargaHoraria  = "300 hrs",
				segunda 	  = true,
				terca		  = true,
				quarta		  = true,
				quinta		  = true,
				sexta 		  = true,
				sabado		  = false,
				dataInicio 	  = Convert.ToDateTime("01/01/2019"),
				caminhoImagem = "../images/gastronomia.jpg",
				caminhoVideo  = "https://www.youtube.com/embed/m6QM_IPlK-I"
			});
			//<iframe width="560" height="315" src="https://www.youtube.com/embed/m6QM_IPlK-I" frameborder="0" allow="autoplay; encrypted-media" allowfullscreen></iframe>

			listaCursos.Add( new CursoModel {
				nome 		  = "Enfermagem",
				cargaHoraria  = "300 hrs",
				segunda 	  = true,
				terca		  = true,
				quarta		  = true,
				quinta		  = true,
				sexta 		  = true,
				sabado		  = false,
				dataInicio 	  = Convert.ToDateTime("01/01/2019"),
				caminhoImagem = "../images/enfermagem.jpg",
				caminhoVideo  = "https://www.youtube.com/embed/sDF0K8Mhz4Q"
			});
			//<iframe width="560" height="315" src="https://www.youtube.com/embed/sDF0K8Mhz4Q" frameborder="0" allow="autoplay; encrypted-media" allowfullscreen></iframe>

			listaCursos.Add( new CursoModel {
				nome 		  = "Farmácia",
				cargaHoraria  = "300 hrs",
				segunda 	  = true,
				terca		  = true,
				quarta		  = true,
				quinta		  = true,
				sexta 		  = true,
				sabado		  = false,
				dataInicio 	  = Convert.ToDateTime("01/07/2018"),
				caminhoImagem = "../images/farmacia.jpg",
				caminhoVideo  = "https://www.youtube.com/embed/wsgRiJw1JJM"
			});
			//<iframe width="560" height="315" src="https://www.youtube.com/embed/wsgRiJw1JJM" frameborder="0" allow="autoplay; encrypted-media" allowfullscreen></iframe>

			listaCursos.Add( new CursoModel {
				nome 		  = "Desenvolvimento de Software",
				cargaHoraria  = "300 hrs",
				segunda 	  = true,
				terca		  = true,
				quarta		  = true,
				quinta		  = true,
				sexta 		  = true,
				sabado		  = false,
				dataInicio 	  = Convert.ToDateTime("01/01/2018"),
				caminhoImagem = "../images/desenvolvimentodesoftware.jpg",
				caminhoVideo  = "https://www.youtube.com/embed/3Smbhnmue7Y"
			});
			//<iframe width="560" height="315" src="https://www.youtube.com/embed/3Smbhnmue7Y" frameborder="0" allow="autoplay; encrypted-media" allowfullscreen></iframe>

			listaCursos.Add( new CursoModel {
				nome 		  = "Administração",
				cargaHoraria  = "300 hrs",
				segunda 	  = true,
				terca		  = true,
				quarta		  = true,
				quinta		  = true,
				sexta 		  = true,
				sabado		  = false,
				dataInicio 	  = Convert.ToDateTime("01/07/2019"),
				caminhoImagem = "../images/administracao.jpg",
				caminhoVideo  = "https://www.youtube.com/embed/0OIv-s4MSx0"
			});
			//<iframe width="560" height="315" src="https://www.youtube.com/embed/0OIv-s4MSx0" frameborder="0" allow="autoplay; encrypted-media" allowfullscreen></iframe>
		}

	}
}