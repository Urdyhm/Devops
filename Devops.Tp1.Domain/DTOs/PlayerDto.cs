using Devops.Tp1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Tp1.Domain.DTOs
{
    public class PlayerDto
    {
        public int? PlayerId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
    }
}
