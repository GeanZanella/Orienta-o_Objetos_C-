using System;
using AP2_POO.Interfaces;
using AP2_POO.Models;
using AP2_POO.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AP2_POO.Controllers
{
    [ApiController]
    [Route("v1")]
    public class ContaController : ControllerBase
    {
        private readonly IContaRepository contas;
        public ContaController(IContaRepository contaRepository)
        {
            this.contas = contaRepository;
        }

        [HttpGet]
        [Route("conta")]

        public IActionResult GetList()
        {
            var listContas = contas.GetAll();
            if(listContas.Count == 0) return NotFound();
            return  Ok(listContas);  
        }

        [HttpGet]
        [Route("conta/{id}")]
        public IActionResult Get(int id)
        {
            var conta = contas.GetById(id);
            if(conta == null) return NotFound();
            return Ok(conta);
        }

        [HttpPost]
        [Route("conta")]
        public IActionResult Post([FromBody] ContaCreateViewModel model)
        {
            if(!ModelState.IsValid) return BadRequest();
            var resulMedia = model.KwGasto/30;
            var newConta = new Conta
            {
                DataLeitura = DateTime.Now,
                NumLeitura = model.NumLeitura,
                KwGasto =  model.KwGasto,
                ValorPagar =  model.ValorPagar,
                MediaConsumo = resulMedia
            };

            try
            {
                contas.Save(newConta);
                return Ok(new
                {
                    message = "Conta criada com Sucesso!",
                });
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("conta/{id}")]
        public IActionResult Delete([FromRoute]int id)
        {
            var conta = contas.GetById(id);
            if(conta == null) return NotFound();
            try
            {
                contas.Delete(conta); 
                return Ok(new
                {
                    message = "Conta deletada com Sucesso!",
                    id = id
                });
            }
            catch (Exception e)
            {
                return BadRequest();
            }         
        }
        
        [HttpPut]
        [Route("conta/{id}")]
        public IActionResult Put(int id)
        {
            var conta = contas.GetById(id);
            if(conta == null) return NotFound();
            try
            {
                conta.DataPagamento = DateTime.Now;
                conta.PagamentoRealizado = true;

                /*var conta_ = new Conta()
                {
                    DataPagamento = DateTime.Now,
                    PagamentoRealizado = true
                };*/

                contas.Update(conta); 
                return Ok(new
                {
                    message = "Conta Atuaçizada com Sucesso!",
                    id = id
                });
            }
            catch (Exception e)
            {
                return BadRequest();
            }         
        }
    }
}