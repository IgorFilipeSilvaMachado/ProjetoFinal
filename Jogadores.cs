using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semafore
{
    class Jogadores
    {
        string nome;
        int vitoria;

        public Jogadores()
        {
        }
        public Jogadores ( string nome, int vitoria)
        {
            this.nome = nome;
            this.vitoria = vitoria;
            
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }


        public void setVitoria(int vitoria)
        {
            this.vitoria = vitoria;
        }
        public int getVitoria()
        {
            return this.vitoria;
        }      
    }
}