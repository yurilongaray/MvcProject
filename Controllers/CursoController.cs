using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

using MvcProject.Models;
using MvcProject.ViewModels;

namespace MvcProject.Controllers
{

    public class CursoController : Controller
	{

		private static Cursos dbcursos = new Cursos();
		private static Alunos dbalunos = new Alunos();

		public IActionResult Index()
		{
            return View(dbcursos.listaCursos.ToList());
        }

		public IActionResult Detalhe(int id)
		{
			var curso = dbcursos.GetCurso(id);
			if (curso == null)
			{
				// TODO: Adicionar erro no model
			}

			//Retorna um model:
			return View(curso);
		}

		[HttpGet]
		public IActionResult Inscrever(int id)
		{

			var curso = dbcursos.GetCurso(id);

			if (curso == null)
			{
				// TODO: Adicionar erro no model
			}

			/*
			// converte o model pra view model
			var vm = new AlunoCursoVM();
			{
				Nome = curso.Nome
			}
			*/

			var vm = new AlunoCursoVM();

			vm.NomeCurso = curso.Nome;
			return View(vm);
		}

		/*
		[HttpPost]
		public IActionResult Inscrever(AlunoCursoVM vm)
		{
			if (ModelState.IsValid) {

				AlunoModel aluno = vm.Aluno;

				aluno.Curso = dbcursos.listaCursos.Where(m => m.Id == aluno.Curso.Id.FirstOrDefault());

				//Adiciona o aluno no banco
                dbalunos.Alunos.Add(aluno);

                //Salva as informações no banco
                dbalunos.SaveChanges();

				this.FlashInfo(aluno.Nome + ", Você for matriculado com sucesso.");

                //Retorna para a página Index
                return RedirectToAction("Index");

			}

		}
		*/

	}

}