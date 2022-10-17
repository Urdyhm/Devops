using Devops.Tp1.Domain.Entities;
using Devops.Tp1.Logic;
using Devops.Tp1.ResourceAcces.Queries;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Tp1.Test
{
    public class PlayerTest
    {
       
        
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Se_Prueba_La_Salida_Fecha_Por_PlayerDto()
        {
            //ARRANGE
            Player player = new Player()
            {
                Name = "Name",
                LastName = "lastName",
                Birthday = 17102022

            };

            string expected = new DateTime(2022, 10, 17).ToString("dd/MM/yyyy");

            //ACT
            var playerDto = PlayerLogic.TransformPlayerToDto(player);
            
            //ASSERT
            Assert.AreEqual(playerDto.Birthday, expected);
        }

    }
}
