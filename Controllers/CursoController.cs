using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.IO;

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
				return RedirectToAction("Index");
			}

			var inicio = curso.DataInicio.Year;

			ViewData["Inicio"] = inicio;

			if (curso.Segunda == true){
				ViewData["Segunda"] = "X";
			}

			if (curso.Terca == true){
				ViewData["Terca"] = "X";
			}

			if (curso.Quarta == true){
				ViewData["Quarta"] = "X";
			}

			if (curso.Quinta == true){
				ViewData["Quinta"] = "X";
			}

			if (curso.Sexta == true){
				ViewData["Sexta"] = "X";
			}

			if (curso.Sabado == true){
				ViewData["Sabado"] = "X";
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
				return RedirectToAction("Index");
			}

			var vm = new AlunoCursoVM();

			vm.IdCurso	 = curso.Id;
			vm.NomeCurso = curso.Nome;
			return View(vm);
		}


		[HttpPost]
		public IActionResult Inscrever(AlunoCursoVM vm)
		{

			if (ModelState.IsValid)
			{
				AlunoModel aluno = vm.Aluno;

				var anoNascimento = aluno.DataNascimento.Year;
				var anoAtual	  = DateTime.Now.Year;
				var totalIdade 	  = anoAtual - anoNascimento;

				if (totalIdade < 18 )
				{
					ViewData["ErroNascimento"] = "O aluno precisa ser maior de 18 anos";
					return View(vm);
				}

				//Adiciona o aluno no banco
                dbalunos.listaAlunos.Add(aluno);

                //Retorna para a p�gina Index
                return RedirectToAction("Index");

			} else
			{
				return View(vm);
			}

		}


	}

}