using Devops.Tp1.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Tp1.Service.Interfaces
{
    public interface IPlayerService
    {
        List<PlayerDto> GetPlayers();
        void CreatePlayer(PlayerDto player);
    }
}
