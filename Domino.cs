using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Domino
{
    class Desk
    {
        public int endLineValue;
        public int beginLineValue;
        public List<Domino> deskDomino = new List<Domino>();

        public void AddDomino(Domino domino)
        {
            deskDomino.Add(domino);
        }
    }

    class Player
    {
        public List<Domino> dominoes = new List<Domino>();
        Random random = new Random(DateTime.Now.Millisecond);

        public Player(int countTiles)
        {
            for(int i = 0; i < countTiles; i++)
            {
                var tile = new Domino(random.Next(0,6), random.Next(0, 6));
                dominoes.Add(tile);
            }
        }

        public void PutOnDesk(Domino domino, Desk desk)
        {
            desk.AddDomino(domino);
            dominoes.Remove(domino);
        }
    }

    class Domino
    {
        public int sideOne;
        public int sideTwo;

        public Domino(int sideOne, int sideTwo)
        {
            this.sideOne = sideOne;
            this.sideTwo = sideTwo;
        }
    }
}
