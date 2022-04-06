using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }

        List<Game> games { get; set; }

        public void AddGame(Game game)
        {
            games.Add(game);
        }




    }
}
