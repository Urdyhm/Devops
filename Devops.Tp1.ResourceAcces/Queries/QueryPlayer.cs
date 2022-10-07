using Devops.Tp1.Domain.DTOs;
using Devops.Tp1.Domain.Entities;
using Devops.Tp1.ResourceAcces.Queries.Interfaces;
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
        static Player Player1 = new Player()
        {
            Name = "German",
            LastName = "Obregón",
            Birthday = new DateTime(1989,11,27)
        };

        static Player Player2 = new Player()
        {
            Name = "Sebastián",
            LastName = "Galván",
            Birthday = new DateTime(1996,06,23)
        };

        static List<Player> PlayersList = new List<Player>()
        {
            Player1,
            Player2
        };

        public void CreatePlayer(PlayerDto player)
        {
           
            Player AddPlayer = new Player()
            {
                Name = player.Name,
                LastName = player.LastName,
                Birthday = DateTime.Parse(player.Birthday)
        };

            PlayersList.Add(AddPlayer);
        }

        public List<PlayerDto> GetPlayers()
        {
            var playersList = PlayersList.Select(P => new PlayerDto()
            {
                Name = P.Name,
                LastName = P.LastName,
                Birthday = P.Birthday.ToString("dd/MM/yyyy")
            }).ToList();

            return playersList;
        }
    }
}
