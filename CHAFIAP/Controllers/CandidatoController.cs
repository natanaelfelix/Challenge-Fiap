using CHAFIAP.BLL.interfaces;
using CHAFIAP.MODEL.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHAFIAP.Controllers {
    /// <summary>
    /// API Controller
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CandidatoController : ControllerBase {

        private ICandidatoBLL _candidatoBLL;

        public CandidatoController(ICandidatoBLL candidatoBLL) {
            _candidatoBLL = candidatoBLL;
        }
        /// <summary>
        /// Retorno Dos valores da API do fisco
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(string), 400)]
        public async Task<IActionResult> GeallMap() {
            try {
                var OK = await _candidatoBLL.GetAllCandidato();
                return Ok(OK);
            }
            catch (Exception e) {
                return StatusCode(500, e.Message);
            }
        }
        [HttpGet("Nome")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(string), 400)]
        public async Task<IActionResult> GetNome(string nome) {
            try {
                var OK = await _candidatoBLL.GetNome(nome);
                return Ok(OK);
            }
            catch (Exception e) {
                return StatusCode(500, e.Message);
            }
        }
        [HttpGet("Cpf")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(string), 400)]
        public async Task<IActionResult> GetCpf(string cpf) {
            try {
                var OK = await _candidatoBLL.GetCpf(cpf);
                return Ok(OK);
            }
            catch (Exception e) {
                return StatusCode(500, e.Message);
            }
        }
        [HttpGet("Email")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(string), 400)]
        public async Task<IActionResult> GetEmail(string email) {
            try {
                var OK = await _candidatoBLL.GetEmail(email);
                return Ok(OK);
            }
            catch (Exception e) {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost("Filtro")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(string), 400)]
        public async Task<IActionResult> GetFiltro(string skil) {
            try {
                var OK = await _candidatoBLL.GetFiltro(skil);
                return Ok(OK);
            }
            catch (Exception e) {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(string), 400)]
        public async Task<IActionResult> InsertMap([FromBody] List<Candidato> candidato) {
            try {
                await _candidatoBLL.InsertCandidato(candidato);
                return Ok("Order successfully");
            }
            catch (Exception e) {
                return StatusCode(500, e.Message);
            }
        }
    }
}