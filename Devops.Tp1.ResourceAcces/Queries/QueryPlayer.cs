using Devops.Tp1.Domain;
using Devops.Tp1.Domain.DTOs;
using Devops.Tp1.Domain.Entities;
using Devops.Tp1.ResourceAcces.Queries.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Tp1.ResourceAcces.Queries
{
    public class QueryPlayer : IQueryPlayer
    {
        private readonly GameContext _gameContext;
        public QueryPlayer(GameContext gameContext)
        {
            this._gameContext = gameContext;
        }
        public List<Player> GetPlayers()
        {
           return this._gameContext.Player.ToList();
        }
    }
}
