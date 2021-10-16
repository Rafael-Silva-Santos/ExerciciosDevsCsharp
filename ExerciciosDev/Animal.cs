using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDev
{
    class Animal
    {
        //atributos da classe
        private string nome;
        private string tipo;

        //Métodos construtores
        public Animal() { }

        public Animal(string nome, string tipo)
        {
            this.nome = nome;
            this.tipo = tipo;
        }
        //Métodos acessores
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }

        public void setTipo( string tipo)
        {
            this.tipo = tipo;
        }

        public string getTipo()
        {
            return this.tipo;
        }
    }
}
