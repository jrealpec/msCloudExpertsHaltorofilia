using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Data.SqlClient;
using System.Text;


using com.jrealpec.mscloudexperts.halterofilia.Models;

namespace com.jrealpec.mscloudexperts.halterofilia.Controllers
{
    public class CompetenciaController : gcBaseController
    {
        private readonly IConfiguration _configuration;
        Competencia competencia = new Competencia();
        
        public CompetenciaController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {

            var competenciaList = GetCompetenciaList();
            //ViewBag.competencia = competenciaList;
            return View(competenciaList);
        }

        public IEnumerable<Competencia> GetCompetenciaList()
        {
            List<Competencia> competencialist = new List<Competencia>();

            using (var ctx = new msCloudbd_Context())
            {
                List<Competencia> competencialistTmp = ctx.Competencia.FromSqlRaw("SP_GetCompetenciaList").ToList();
                foreach (var competencia in competencialistTmp)
                {
                    competencialist.Add(new Competencia
                    {
                        CodCompetencia = competencia.CodCompetencia,
                        Etapa = competencia.Etapa,
                        CodDeportista = competencia.CodDeportista,
                        CodModalidad = competencia.CodModalidad,
                        Nom_Pais = competencia.Nom_Pais,
                        Nom_Deportista = competencia.Nom_Deportista,
                        Nom_Modalidad = competencia.Nom_Modalidad,
                        Cantidad = competencia.Cantidad
                    });

                }
            }
            return competencialist;
        }
        public Competencia GetCompetenciaByIdList(int? Id)
        {
            List<Competencia> competencialist = new List<Competencia>();

            using (var ctx = new msCloudbd_Context())
            {
                List<Competencia> competencialistTmp = ctx.Competencia.FromSqlRaw("SP_GetCompetenciaByIdList {0}", Id).ToList();
                Competencia competenciaTmp = new Competencia();
                foreach (var competencia in competencialistTmp)
                {
                    competencialist.Add(new Competencia
                    {
                        CodCompetencia = competencia.CodCompetencia,
                        Etapa = competencia.Etapa,
                        CodDeportista = competencia.CodDeportista,
                        CodModalidad = competencia.CodModalidad,
                        Nom_Pais = competencia.Nom_Pais,
                        Nom_Deportista = competencia.Nom_Deportista,
                        Nom_Modalidad = competencia.Nom_Modalidad,
                        Cantidad = competencia.Cantidad
                    });
                    competenciaTmp = competencia;
                }
                competencia = competenciaTmp;
            }
            return competencia;
        }
        public ActionResult AddEditCompetencia(int? id)
        {
            try
            {
                SelectList PaisList = new SelectList(GetPaisList(), "CodPais", "NomPais");
                SelectList Modalidadlist = new SelectList(GetModalidadList(), "CodModalidad", "NomModalidad");
                SelectList Deportistalist = new SelectList(GetDeportistaList(), "CodDeportista", "NomDeportista");
                ViewBag.PaisList = PaisList;
                ViewBag.ModalidadList = Modalidadlist;
                ViewBag.Deportistalist = Deportistalist;
                if (id >= 0)
                {
                    competencia = this.GetCompetenciaByIdList(id);
                }

                return View(competencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        public ActionResult AddEditCompetencia(Competencia model)
        {
            SelectList PaisList = new SelectList(GetPaisList(), "CodPais", "NomPais");
            SelectList Modalidadlist = new SelectList(GetModalidadList(), "CodModalidad", "NomModalidad");
            SelectList Deportistalist = new SelectList(GetDeportistaList(), "CodDeportista", "NomDeportista");
            ViewBag.PaisList = PaisList;
            ViewBag.ModalidadList = Modalidadlist;
            ViewBag.Deportistalist = Deportistalist;

            if (ModelState.IsValid)
            {
                if (this.AddUpdateCompetencia(model))
                {
                    return RedirectToAction("Index", "Competencia");
                }
                else
                {
                    ViewData["ErrorMessage"] = "There is an error in save Competencia!!";
                    return View(model);
                }
            }

            return View(model);
        }

        private bool AddUpdateCompetencia(Competencia model)
        {
            //********************************
            int Cod_Competencia = model.CodCompetencia;
            int Etapa = model.Etapa;
            int Cod_Deportista = model.CodDeportista;
            string Nom_Deportista = model.Nom_Deportista;
            int Cod_Modalidad = model.CodModalidad;
            string Nom_modalidad = model.Nom_Modalidad;
            int Cod_Pais = model.CodPais;
            string Nom_Pais = model.Nom_Pais;
            int Cantidad = model.Cantidad;
            //********************************
            var ctx = new msCloudbd_Context();
            var sqlCod_Competencia = new SqlParameter("@Cod_Competencia", Cod_Competencia);
            var sqlEtapa = new SqlParameter("@Etapa", Etapa);
            var sqlCod_Deportista = new SqlParameter("@Cod_Deportista", Cod_Deportista);
            var sqlCod_Modalidad = new SqlParameter("@Cod_Modalidad", Cod_Modalidad);
            var sqlCod_Pais = new SqlParameter("@Cod_Pais", Cod_Pais);
            var sqlCantidad = new SqlParameter("@Cantidad", Cantidad);
            //********************************
            var intFilasAfectadas = ctx.Database.ExecuteSqlCommand("EXEC SP_InsertUpdateCompetencia @Cod_Competencia,@Etapa,@Cod_Deportista,@Cod_Modalidad,@Cod_Pais,@Cantidad", sqlCod_Competencia, sqlEtapa, sqlCod_Deportista, sqlCod_Modalidad, sqlCod_Pais, sqlCantidad);
            //var intFilasAfectadas = ctx.Competencia.FromSqlRaw("EXEC SP_InsertUpdateCompetencia @Cod_Competencia,@Etapa,@Cod_Deportista,@Cod_Modalidad,@Cod_Pais,@Cantidad", sqlCod_Competencia,sqlEtapa,sqlCod_Deportista,sqlCod_Modalidad,sqlCod_Pais, sqlCantidad);
            if (intFilasAfectadas >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        private List<Pais> GetPaisList()
        {
            List<Pais> Paislist = new List<Pais>();

            using (var ctx = new msCloudbd_Context())
            {
                List<Pais> paislistTmp = ctx.Pais.FromSqlRaw("SP_GetPaisList").ToList();
                foreach (var Pais in paislistTmp)
                {
                    Paislist.Add(new Pais
                    {
                        CodPais=Pais.CodPais,
                        NomPais=Pais.NomPais
                    });

                }
            }
            return Paislist;
        }
        private List<Modalidad> GetModalidadList()
        {
            List<Modalidad> Modalidadlist = new List<Modalidad>();

            using (var ctx = new msCloudbd_Context())
            {
                List<Modalidad> modadlidadlistTmp = ctx.Modalidad.FromSqlRaw("SP_GetModalidadList").ToList();
                foreach (var Modalidad in modadlidadlistTmp)
                {
                    Modalidadlist.Add(new Modalidad
                    {
                        CodModalidad = Modalidad.CodModalidad,
                        NomModalidad = Modalidad.NomModalidad
                    });

                }
            }
            return Modalidadlist;
        }
        private List<Deportista> GetDeportistaList()
        {
            List<Deportista> Deportistalist = new List<Deportista>();

            using (var ctx = new msCloudbd_Context())
            {
                List<Deportista> deportistalistTmp = ctx.Deportista.FromSqlRaw("SP_GetDeportistaList").ToList();
                foreach (var Deportista in deportistalistTmp)
                {
                    Deportistalist.Add(new Deportista
                    {
                        CodDeportista = Deportista.CodDeportista,
                        NomDeportista = Deportista.NomDeportista,
                        CodPaisNavigation = Deportista.CodPaisNavigation,
                        CodPais = Deportista.CodPais
                    });

                }
            }
            return Deportistalist;
        }
    }
}
