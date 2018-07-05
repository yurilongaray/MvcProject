using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MvcProject.Models;

namespace MvcProject.Controllers {

    public class CursoController : Controller {

		private static Cursos _cursos = new Cursos();

		public IActionResult Index()
        {
            return View( _cursos.listaCursos );
        }

	}
}