using Devops.Tp1.Domain.DTOs;
using Devops.Tp1.Domain.Entities;
using Devops.Tp1.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devops.Tp1.WebApi.Controllers
{
    [ApiController]
    [Route("api/players")]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerService _playerService;
        public PlayerController(IPlayerService playerService)
        {
            this._playerService = playerService;
        }

        [HttpGet]
        public IActionResult GetPlayers()
        {
            try
            {
                return new JsonResult(_playerService.GetPlayers()) { StatusCode = 200 };
            }
            catch (Exception ex)
            {

                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpPost]
        /// <summary>
        /// Agregar Player.
        /// </summary>
        /// <param name="newPlayer">El formato de Birthday debe ser ddMMyyyy sin caracteres especiales</param>
        /// <returns></returns>
        public IActionResult CreatePlayer([FromBody] Player newPlayer)
        {
            try
            {
                this._playerService.CreatePlayer(newPlayer);
                return new JsonResult(newPlayer) { StatusCode = 201 };
            }
            catch (Exception ex)
            {

                return BadRequest(new { error = ex.Message });
            }
            

        }
    }
}
