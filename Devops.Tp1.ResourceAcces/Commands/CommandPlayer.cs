using Devops.Tp1.Domain.DTOs;
using Devops.Tp1.Domain.Entities;
using Devops.Tp1.ResourceAcces.Commands.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Tp1.ResourceAcces.Commands
{
    public class CommandPlayer : ICommandPlayer
    {
        public void CreatePlayer(Player player)
        {
            var playersJson = JsonConvert.DeserializeObject<PlayersDto>(Environment.GetEnvironmentVariable("LISTPLAYERS"));
            playersJson.Results.Add(player);
            var setObject = JsonConvert.SerializeObject(playersJson);
            Environment.SetEnvironmentVariable("LISTPLAYERS", setObject);


        }
    }
}
