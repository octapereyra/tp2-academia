﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Http.Extensions;
using Business.Entities;
using Business.Logic;
using UI.Web.Permisos;

namespace UI.Web.Controllers
{
    public class ReportController : Controller
    {
        private readonly IConverter _converter;

        public ReportController(IConverter converter)
        {
            _converter = converter;
        }
        
        public IActionResult InformeCursos()
        {
            List<Curso> cursos = new CursoLogic().GetAll();
            return View(cursos);
        }

        public IActionResult InformePlanes()
        {
            List<Plan> planes = new PlanLogic().GetAll();
            return View(planes);
        }
        [PermisosRol(Persona.TiposPersonas.Docente)]
        public IActionResult Cursos()
        {
            string pagina_actual = HttpContext.Request.Path;
            string url_pagina = HttpContext.Request.GetEncodedUrl();
            url_pagina = url_pagina.Replace(pagina_actual, "");
            url_pagina = $"{url_pagina}/Report/InformeCursos";

            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = new GlobalSettings()
                {
                    PaperSize = PaperKind.A4,
                    Orientation = Orientation.Portrait
                },
                Objects =
                {
                    new ObjectSettings()
                    {
                        Page = url_pagina
                    }
                }
            };

            var archivoPDF = _converter.Convert(pdf);

            return File(archivoPDF,"application/pdf");
        }

        [PermisosRol(Persona.TiposPersonas.Estudiante)]
        public IActionResult Planes()
        {
            string pagina_actual = HttpContext.Request.Path;
            string url_pagina = HttpContext.Request.GetEncodedUrl();
            url_pagina = url_pagina.Replace(pagina_actual, "");
            url_pagina = $"{url_pagina}/Report/InformePlanes";

            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = new GlobalSettings()
                {
                    PaperSize = PaperKind.A4,
                    Orientation = Orientation.Portrait
                },
                Objects =
                {
                    new ObjectSettings()
                    {
                        Page = url_pagina
                    }
                }
            };

            var archivoPDF = _converter.Convert(pdf);

            return File(archivoPDF, "application/pdf");
        }
    }
}
