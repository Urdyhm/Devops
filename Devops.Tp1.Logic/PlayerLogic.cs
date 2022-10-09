using Devops.Tp1.Domain.DTOs;
using Devops.Tp1.Domain.Entities;
using Devops.Tp1.Logic.Interfaces;
using Devops.Tp1.ResourceAcces.Commands.Interfaces;
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
        private readonly ICommandPlayer _commandPlayer;
        public PlayerLogic(IQueryPlayer queryPlayer , ICommandPlayer commandPlayer)
        {
            this._queryPlayer = queryPlayer;
            this._commandPlayer = commandPlayer;
        }

        public void CreatePlayer(Player player)
        {
            this._commandPlayer.CreatePlayer(player);
        }

        public List<PlayerDto> GetPlayers()
        {
            return _queryPlayer.GetPlayers();
        }
    }
}
