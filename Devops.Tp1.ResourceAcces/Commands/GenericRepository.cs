using Devops.Tp1.Domain;
using Devops.Tp1.ResourceAcces.Commands.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Tp1.ResourceAcces.Commands
{
    public class GenericRepository : IGenericRepository
    {
        private readonly GameContext _gameContext;
        public GenericRepository(GameContext gameContext)
        {
            this._gameContext = gameContext;
        }

        public void Add<T>(T entity) where T : class
        {
            this._gameContext.Add(entity);
            this._gameContext.SaveChanges();
        }

        public void Delete<T>(int id) where T : class
        {
            this._gameContext.Remove(_gameContext.Find<T>(id));
            this._gameContext.SaveChanges();
        }

        public void Update<T>(T entity) where T : class
        {
            this._gameContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this._gameContext.SaveChanges();
        }
    }
}
