using Devops.Tp1.Domain.DTOs;
using Devops.Tp1.Domain.Entities;
using Devops.Tp1.Logic.Interfaces;
using Devops.Tp1.ResourceAcces.Commands.Interfaces;
using Devops.Tp1.ResourceAcces.Queries.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Tp1.Logic
{
    public class PlayerLogic : IPlayerLogic
    {
        private readonly IQueryPlayer _queryPlayer;
        private readonly IGenericRepository _repository;
        public PlayerLogic(IQueryPlayer queryPlayer , IGenericRepository repository)
        {
            this._queryPlayer = queryPlayer;
            this._repository = repository;
        }

        public PlayerDto CreatePlayer(Player player)
        {
            this._repository.Add<Player>(player);

            PlayerDto response = new PlayerDto()
            {
                PlayerId = player.PlayerId,
                Name = player.Name,
                LastName = player.LastName,
                Birthday = DateTransform(player.Birthday).ToString("dd/MM/yyyy")
            };

            return response;
        }

        public List<PlayerDto> GetPlayers()
        {
            var players = _queryPlayer.GetPlayers();
            List<PlayerDto> listPlayers = new List<PlayerDto>();
            foreach (var player in players)
            {
                DateTime birhtday = DateTransform(player.Birthday);
                
                PlayerDto playerDto = new PlayerDto()
                {
                    PlayerId = player.PlayerId,
                    Name = player.Name,
                    LastName = player.LastName,
                    Birthday = birhtday.ToString("dd/MM/yyyy")
                };

                listPlayers.Add(playerDto);
            }
            return listPlayers;
        }

        public DateTime DateTransform(int date)
        {
            DateTime birhtday;
            DateTime.TryParseExact(date.ToString(), "ddMMyyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out birhtday);

            return birhtday;
        }

        public void DeletePlayer(int id)
        {
            this._repository.Delete<Player>(id);
        }

        public PlayerDto UpdatePlayer(Player player)
        {
            this._repository.Update<Player>(player);
            PlayerDto response = new PlayerDto()
            {
                Name = player.Name,
                LastName = player.LastName,
                Birthday = DateTransform(player.Birthday).ToString("dd/MM/yyyy")
            };

            return response;
        }
    }
}
