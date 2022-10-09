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
        public List<PlayerDto> GetPlayers()
        {
            var playersJson = JsonConvert.DeserializeObject<PlayersDto>(Environment.GetEnvironmentVariable("LISTPLAYERS"));
            List<PlayerDto> listPlayers = new List<PlayerDto>();
            foreach (var item in playersJson.Results)
            {
                DateTime birhtday;
                DateTime.TryParseExact(item.Birthday.ToString(), "ddMMyyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out birhtday);

                PlayerDto player = new PlayerDto()
                {
                    Name = item.Name,
                    LastName = item.LastName,
                    Birthday = birhtday.ToString("dd/MM/yyyy")
                };

                listPlayers.Add(player);
            }


            return listPlayers;
        }
    }
}
