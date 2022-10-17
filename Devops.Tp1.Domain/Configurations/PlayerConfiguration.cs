using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devops.Tp1.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Devops.Tp1.Domain.Configurations
{
    public class PlayerConfiguration
    {
        public PlayerConfiguration(EntityTypeBuilder<Player> player)
        {
            player.HasKey(X => X.PlayerId);

            player.Property(X => X.Name)
                .IsRequired()
                .HasMaxLength(50);

            player.Property(X => X.LastName)
                .IsRequired()
                .HasMaxLength(50);

            player.Property(X => X.Birthday)
                .IsRequired();

            player.HasData( new Player() { PlayerId = 1, Name = "German", LastName = "Obregon", Birthday = 27111989 });
              
            player.HasData( new Player() { PlayerId = 2, Name = "Sebastian", LastName = "Galvan", Birthday = 23061996 });
        }
      
    }
}
