using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tech_test_payment_api.Models;
using System.ComponentModel.DataAnnotations;

namespace tech_test_payment_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        /// <summary>
        /// Cria nova Venda
        /// </summary>
        /// <param name="venda"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(Venda venda)
        {   
            return Ok(venda);
        }


        /// <summary>
        /// Atualiza o Status da Venda
        /// </summary>
        /// <param name="id"></param>
        /// <param name="venda"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        /// <remarks>
        /// Status <br/>
        /// 1 = Pagamento Aprovado <br/>
        /// 2 = Enviado para Transportadora <br/>
        /// 3 = Entregue <br/> 
        /// 4 = Cancelada <br/>
        ///
        /// </remarks>
        [HttpPut("Atualizar{id}")]
        public IActionResult Atualizar(int id, Venda venda, EnumStatusVenda status)
        {
            venda.StatusVenda = status;
            venda.Status = status.ToString();

            return Ok(venda);
        }
    }
}