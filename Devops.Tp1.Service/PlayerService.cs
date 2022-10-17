using Devops.Tp1.Domain.DTOs;
using Devops.Tp1.Domain.Entities;
using Devops.Tp1.Domain.Validators;
using Devops.Tp1.Logic.Interfaces;
using Devops.Tp1.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using FluentValidation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Devops.Tp1.Service
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerLogic _playerLogic;

        public PlayerService(IPlayerLogic playerLogic)
        {
            this._playerLogic = playerLogic;
        }

        public PlayerDto CreatePlayer(Player player)
        {
            try
            {
                var validator = new PlayerValidator();
                validator.ValidateAndThrow(player);
                return  this._playerLogic.CreatePlayer(player);
            }
            catch (SqlException)
            {

                throw new Exception(Messeges.NoSePudoCrearPlayer);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void DeletePlayer(int id)
        {
            try
            {
                this._playerLogic.DeletePlayer(id);
            }
            catch (ArgumentNullException)
            {

                throw new Exception(string.Format(Messeges.NoSeEncuentraPlayer,id));
            }
        }

        public List<PlayerDto> GetPlayers()
        {
            try
            {
                return this._playerLogic.GetPlayers();
            }
            catch (SqlException)
            {

                throw  new Exception(Messeges.NoSeEncontraronPlayers);
            }
        }

        public PlayerDto UpdatePlayer(Player player)
        {
            try
            {
                var validator = new PlayerValidator();
                validator.ValidateAndThrow(player);
                return this._playerLogic.UpdatePlayer(player);
            }
            catch (DbUpdateConcurrencyException)
            {

                throw new Exception(string.Format(Messeges.NoSeEncuentraPlayer, player.PlayerId));
            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }

       
    }
}
