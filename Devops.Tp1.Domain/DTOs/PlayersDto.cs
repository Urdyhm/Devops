using Devops.Tp1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Tp1.Domain.DTOs
{
    public class PlayersDto
    {
        public ICollection<Player> Results { get; set; }
    }
}
