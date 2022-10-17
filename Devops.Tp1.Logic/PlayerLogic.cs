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
       
            return TransformPlayerToDto(player);
        }

        public List<PlayerDto> GetPlayers()
        {
            var players = _queryPlayer.GetPlayers();
            List<PlayerDto> listPlayers = new List<PlayerDto>();
            foreach (var player in players)
            {

                PlayerDto playerDto = TransformPlayerToDto(player);

                listPlayers.Add(playerDto);
            }
            return listPlayers;
        }

        public static PlayerDto TransformPlayerToDto(Player player)
        {
            DateTime birhtday;
            DateTime.TryParseExact(player.Birthday.ToString(), "ddMMyyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out birhtday);
            PlayerDto response = new PlayerDto()
            {
                PlayerId = player.PlayerId,
                Name = player.Name,
                LastName = player.LastName,
                Birthday = birhtday.ToString("dd/MM/yyyy")
            };

            return response;
        }

        public void DeletePlayer(int id)
        {
            this._repository.Delete<Player>(id);
        }

        public PlayerDto UpdatePlayer(Player player)
        {
            this._repository.Update<Player>(player);
            PlayerDto response = TransformPlayerToDto(player);

            return response;
        }
    }
}
