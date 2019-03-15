using AgendaClinica.Core;
using AgendaClinica.Core.Service;
using AgendaClinica.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AgendaClinica.Controllers
{
    public class AgendaController : Controller
    {

        // GET: Agenda
        public ActionResult Index()
        {
            return View();
        }

        // GET: Agenda/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Agenda/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Agenda/Create
        [HttpPost]
        public async Task<ActionResult> Create(Massagem massagem)
        {
            try
            {



                MassagemPI msgPI = new MassagemPI();


                msgPI.idMassagem = massagem.idMassagem;
                msgPI.idcliente = massagem.cliente.idPessoa;
                msgPI.idatendente = massagem.atendente.idPessoa;
                msgPI.idTipomassagem = massagem.idTipomassagem.idTipoMassagem;
                msgPI.DataAgendamento = massagem.DataAgendamento;

                // TODO: Add insert logic here
                string Baseurl = "http://localhost:55966/";
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Baseurl);

                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage Res = await client.PostAsJsonAsync("api/Agenda/AgendarMassagem", msgPI);

                    if (Res.IsSuccessStatusCode)
                    {
                        var result = Res.Content.ReadAsStringAsync().Result;

                    }

                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Agenda/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Agenda/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                ContextAgenda _context = new ContextAgenda();

                Massagem massagem = _context.GetMassagem(id);

                MassagemPI msgPI = new MassagemPI();


                msgPI.idMassagem = massagem.idMassagem;
                msgPI.idcliente = massagem.cliente.idPessoa;
                msgPI.idatendente = massagem.atendente.idPessoa;
                msgPI.idTipomassagem = massagem.idTipomassagem.idTipoMassagem;
                msgPI.DataAgendamento = massagem.DataAgendamento;

                // TODO: Add insert logic here
                string Baseurl = "http://localhost:55966/";
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Baseurl);

                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage Res = await client.PostAsJsonAsync("api/Agenda/ReagendarMassagem", msgPI);

                    if (Res.IsSuccessStatusCode)
                    {
                        var result = Res.Content.ReadAsStringAsync().Result;

                    }

                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Agenda/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Agenda/Delete/5
        [HttpPost]
        public async Task<ActionResult> Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                ContextAgenda _context = new ContextAgenda();

                Massagem massagem = _context.GetMassagem(id);

                MassagemPI msgPI = new MassagemPI();


                msgPI.idMassagem = massagem.idMassagem;
                msgPI.idcliente = massagem.cliente.idPessoa;
                msgPI.idatendente = massagem.atendente.idPessoa;
                msgPI.idTipomassagem = massagem.idTipomassagem.idTipoMassagem;
                msgPI.DataAgendamento = massagem.DataAgendamento;


                string Baseurl = "http://localhost:55966/";
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Baseurl);

                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage Res = await client.PostAsJsonAsync("api/Agenda/CancelarMassagem", msgPI);

                    if (Res.IsSuccessStatusCode)
                    {
                        var result = Res.Content.ReadAsStringAsync().Result;

                    }

                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult List()
        {
            return PartialView(ContextAgenda.Massagens);
        }
    }
}
