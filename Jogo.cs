using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semafore
{
    class Jogo
    {
        char[,] m = new char[3, 4];
        public Jogo()
        {
            int i, j;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    this.m[i, j] = ' ';
                }
            }

        }

        public void setM(int i, int j, char c)
        {
            this.m[i, j] = c;
        }
        public char getM(int i, int j)
        {
            return this.m[i, j];
        }

        public bool verifica()
        {
            if (this.m[0, 0] == this.m[1, 0] && this.m[0, 0] == this.m[2, 0] && this.m[2, 0] != ' ')
            {
                return true;
            }
            if (this.m[0, 1] == this.m[1, 1] && this.m[0, 1] == this.m[2, 1] && this.m[0, 1] != ' ')
            {
                return true;
            }
            if (this.m[0, 2] == this.m[1, 2] && this.m[0, 2] == this.m[2, 2] && this.m[2, 2] != ' ')
            {
                return true;
            }
            if (this.m[0, 0] == this.m[0, 1] && this.m[0, 0] == this.m[0, 2] && this.m[0, 2] != ' ')
            {
                return true;
            }
            if (this.m[1, 0] == this.m[1, 1] && this.m[1, 0] == this.m[1, 2] && this.m[1, 1] != ' ')
            {
                return true;
            }
            if (this.m[2, 0] == this.m[2, 1] && this.m[2, 2] == this.m[2, 0] && this.m[2, 0] != ' ')
            {
                return true;
            }
            if (this.m[0, 0] == this.m[1, 1] && this.m[0, 0] == this.m[2, 2] && this.m[0, 0] != ' ')
            {
                return true;
            }
            if (this.m[0, 2] == this.m[1, 1] && this.m[0, 2] == this.m[2, 0] && this.m[2, 0] != ' ')
            {
                return true;
            }
            if (this.m[0, 3] == this.m[1, 2] && this.m[0, 3] == this.m[2, 1] && this.m[0, 3] != ' ')
            {
                return true;
            }
            if (this.m[0, 1] == this.m[1, 2] && this.m[0, 1] == this.m[2, 3] && this.m[2, 3] != ' ')
            {
                return true;
            }
            if (this.m[0, 3] == this.m[0, 2] && this.m[0, 3] == this.m[0, 1] && this.m[0, 1] != ' ')
            {
                return true;
            }
            if (this.m[1, 1] == this.m[1, 2] && this.m[1, 1] == this.m[1, 3] && this.m[1, 3] != ' ')
            {
                return true;
            }
            if (this.m[2, 1] == this.m[2, 2] && this.m[2, 1] == this.m[2, 3] && this.m[2, 3] != ' ')
            {
                return true;
            }
            if (this.m[0, 3] == this.m[1, 3] && this.m[0, 3] == this.m[2, 3] && this.m[2, 3] != ' ')
            {
                return true;
            }

            return false;
        }

    }
}
