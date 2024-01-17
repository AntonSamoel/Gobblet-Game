using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gobblet_Game
{
	public class Piece(int id, int size, string playerName, string Color, Image image)
    {
        public int Id { get; set; } = id;
        public string Color { get; set; } = Color;
        public Image Image { get; set; } = image;

        public int Size { get; set; } = size;
        public string PlayerName { get; set; } = playerName;

    }
}
