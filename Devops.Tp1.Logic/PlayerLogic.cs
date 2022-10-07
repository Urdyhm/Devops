using Devops.Tp1.Domain.DTOs;
using Devops.Tp1.Logic.Interfaces;
using Devops.Tp1.ResourceAcces.Queries.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Tp1.Logic
{
    public class PlayerLogic : IPlayerLogic
    {
        private readonly IQueryPlayer _queryPlayer;
        public PlayerLogic(IQueryPlayer queryPlayer)
        {
            this._queryPlayer = queryPlayer;
        }

        public void CreatePlayer(PlayerDto player)
        {
            this._queryPlayer.CreatePlayer(player);
        }

        public List<PlayerDto> GetPlayers()
        {
            return _queryPlayer.GetPlayers();
        }
    }
}
