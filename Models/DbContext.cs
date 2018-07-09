using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcProject.Models
{

	public class Cursos
	{

		public List<CursoModel> listaCursos = new List<CursoModel>();

		public Cursos() {

			listaCursos.Add( new CursoModel {
				Id			  = 1,
				Nome 		  = "Gastronomia",
				Descricao	  = "Lorem ipsum viverra ultricies non consectetur tincIdunt eget sem commodo interdum, maecenas etiam nunc felis nullam integer suscipit orci mattis, maecenas ultricies urna etiam fusce rutrum at et ac. aliquam mi sem sodales lorem nisl vulputate inceptos ac pharetra, mattis fermentum tristique donec euismod aliquam cursus mi commodo congue, luctus nibh inceptos ultricies quam congue eu lectus. tempor eu eget maecenas bibendum odio aliquam platea pharetra aptent ut, cras congue nec amet vulputate interdum lacinia quis velit, nunc interdum per curabitur convallis aenean nulla nibh nostra. adipiscing aliquet fusce habitant velit turpis in molestie, massa nisi mauris cursus sollicitudin senectus.",
				CargaHoraria  = "300 hrs",
				Segunda 	  = true,
				Terca		  = true,
				Quarta		  = true,
				Quinta		  = true,
				Sexta 		  = true,
				Sabado		  = false,
				DataInicio 	  = Convert.ToDateTime("01/01/2019"),
				CaminhoImagem = "../images/gastronomia.jpg",
				CaminhoVideo  = "https://www.youtube.com/embed/m6QM_IPlK-I"
			});
			//<iframe wIdth="560" height="315" src="https://www.youtube.com/embed/m6QM_IPlK-I" frameborder="0" allow="autoplay; encrypted-media" allowfullscreen></iframe>

			listaCursos.Add( new CursoModel {
				Id			  = 2,
				Nome 		  = "Enfermagem",
				Descricao	  = "Lorem ipsum viverra ultricies non consectetur tincIdunt eget sem commodo interdum, maecenas etiam nunc felis nullam integer suscipit orci mattis, maecenas ultricies urna etiam fusce rutrum at et ac. aliquam mi sem sodales lorem nisl vulputate inceptos ac pharetra, mattis fermentum tristique donec euismod aliquam cursus mi commodo congue, luctus nibh inceptos ultricies quam congue eu lectus. tempor eu eget maecenas bibendum odio aliquam platea pharetra aptent ut, cras congue nec amet vulputate interdum lacinia quis velit, nunc interdum per curabitur convallis aenean nulla nibh nostra. adipiscing aliquet fusce habitant velit turpis in molestie, massa nisi mauris cursus sollicitudin senectus. ",
				CargaHoraria  = "300 hrs",
				Segunda 	  = true,
				Terca		  = true,
				Quarta		  = true,
				Quinta		  = true,
				Sexta 		  = true,
				Sabado		  = false,
				DataInicio 	  = Convert.ToDateTime("01/01/2019"),
				CaminhoImagem = "../images/enfermagem.jpg",
				CaminhoVideo  = "https://www.youtube.com/embed/sDF0K8Mhz4Q"
			});
			//<iframe wIdth="560" height="315" src="https://www.youtube.com/embed/sDF0K8Mhz4Q" frameborder="0" allow="autoplay; encrypted-media" allowfullscreen></iframe>

			listaCursos.Add( new CursoModel {
				Id			  = 3,
				Nome 		  = "Farmácia",
				Descricao	  = "Lorem ipsum viverra ultricies non consectetur tincIdunt eget sem commodo interdum, maecenas etiam nunc felis nullam integer suscipit orci mattis, maecenas ultricies urna etiam fusce rutrum at et ac. aliquam mi sem sodales lorem nisl vulputate inceptos ac pharetra, mattis fermentum tristique donec euismod aliquam cursus mi commodo congue, luctus nibh inceptos ultricies quam congue eu lectus. tempor eu eget maecenas bibendum odio aliquam platea pharetra aptent ut, cras congue nec amet vulputate interdum lacinia quis velit, nunc interdum per curabitur convallis aenean nulla nibh nostra. adipiscing aliquet fusce habitant velit turpis in molestie, massa nisi mauris cursus sollicitudin senectus. ",
				CargaHoraria  = "300 hrs",
				Segunda 	  = false,
				Terca		  = false,
				Quarta		  = false,
				Quinta		  = false,
				Sexta 		  = true,
				Sabado		  = true,
				DataInicio 	  = Convert.ToDateTime("01/07/2018"),
				CaminhoImagem = "../images/farmacia.jpg",
				CaminhoVideo  = "https://www.youtube.com/embed/wsgRiJw1JJM"
			});
			//<iframe wIdth="560" height="315" src="https://www.youtube.com/embed/wsgRiJw1JJM" frameborder="0" allow="autoplay; encrypted-media" allowfullscreen></iframe>

			listaCursos.Add( new CursoModel {
				Id			  = 4,
				Nome 		  = "Desenvolvimento de Software",
				Descricao	  = "Lorem ipsum viverra ultricies non consectetur tincIdunt eget sem commodo interdum, maecenas etiam nunc felis nullam integer suscipit orci mattis, maecenas ultricies urna etiam fusce rutrum at et ac. aliquam mi sem sodales lorem nisl vulputate inceptos ac pharetra, mattis fermentum tristique donec euismod aliquam cursus mi commodo congue, luctus nibh inceptos ultricies quam congue eu lectus. tempor eu eget maecenas bibendum odio aliquam platea pharetra aptent ut, cras congue nec amet vulputate interdum lacinia quis velit, nunc interdum per curabitur convallis aenean nulla nibh nostra. adipiscing aliquet fusce habitant velit turpis in molestie, massa nisi mauris cursus sollicitudin senectus. ",
				CargaHoraria  = "300 hrs",
				Segunda 	  = false,
				Terca		  = false,
				Quarta		  = false,
				Quinta		  = true,
				Sexta 		  = true,
				Sabado		  = false,
				DataInicio 	  = Convert.ToDateTime("01/01/2018"),
				CaminhoImagem = "../images/desenvolvimentodesoftware.jpg",
				CaminhoVideo  = "https://www.youtube.com/embed/3Smbhnmue7Y"
			});
			//<iframe wIdth="560" height="315" src="https://www.youtube.com/embed/3Smbhnmue7Y" frameborder="0" allow="autoplay; encrypted-media" allowfullscreen></iframe>

			listaCursos.Add( new CursoModel {
				Id			  = 5,
				Nome 		  = "Administração",
				Descricao	  = "Lorem ipsum viverra ultricies non consectetur tincIdunt eget sem commodo interdum, maecenas etiam nunc felis nullam integer suscipit orci mattis, maecenas ultricies urna etiam fusce rutrum at et ac. aliquam mi sem sodales lorem nisl vulputate inceptos ac pharetra, mattis fermentum tristique donec euismod aliquam cursus mi commodo congue, luctus nibh inceptos ultricies quam congue eu lectus. tempor eu eget maecenas bibendum odio aliquam platea pharetra aptent ut, cras congue nec amet vulputate interdum lacinia quis velit, nunc interdum per curabitur convallis aenean nulla nibh nostra. adipiscing aliquet fusce habitant velit turpis in molestie, massa nisi mauris cursus sollicitudin senectus. ",
				CargaHoraria  = "300 hrs",
				Segunda 	  = false,
				Terca		  = false,
				Quarta		  = true,
				Quinta		  = true,
				Sexta 		  = true,
				Sabado		  = false,
				DataInicio 	  = Convert.ToDateTime("01/07/2019"),
				CaminhoImagem = "../images/administracao.jpg",
				CaminhoVideo  = "https://www.youtube.com/embed/0OIv-s4MSx0"
			});
			//<iframe wIdth="560" height="315" src="https://www.youtube.com/embed/0OIv-s4MSx0" frameborder="0" allow="autoplay; encrypted-media" allowfullscreen></iframe>
		}

		public CursoModel GetCurso(int Id)
		{
			return this.listaCursos.FirstOrDefault(curso => curso.Id == Id);
		}

	}

	public class Alunos
	{
		public List<AlunoModel> listaAlunos = new List<AlunoModel>();

		public Alunos() {
			listaAlunos.Add( new AlunoModel {
				Id 			   = 1,
				Nome 		   = "Carlos Andrade",
				Email 		   = "carlosandrade@gmail.com",
				DataNascimento = Convert.ToDateTime("01/01/1990")
			});
		}
	}
}