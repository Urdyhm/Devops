﻿using Devops.Tp1.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Tp1.ResourceAcces.Queries.Interfaces
{
    public interface IQueryPlayer
    {
        List<PlayerDto> GetPlayers();
      
    }
}
