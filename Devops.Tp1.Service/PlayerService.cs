using Devops.Tp1.Domain.DTOs;
using Devops.Tp1.Domain.Entities;
using Devops.Tp1.Logic.Interfaces;
using Devops.Tp1.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Tp1.Service
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerLogic _playerLogic;

        public PlayerService(IPlayerLogic playerLogic)
        {
            this._playerLogic = playerLogic;
        }

        public void CreatePlayer(Player player)
        {
            try
            {
                this._playerLogic.CreatePlayer(player);
            }
            catch (Exception ex)
            {

                throw new Exception("No se pudo realizar la acción");
            }
        }

        public List<PlayerDto> GetPlayers()
        {
            try
            {
                return this._playerLogic.GetPlayers();
            }
            catch (Exception ex)
            {

                throw  new Exception("No se pudo realizar la acción");
            }
        }
    }
}
