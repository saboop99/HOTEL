using System;
using System.Collections.Generic;
using System.Text;

namespace HOTEL
{
    //RAFAEL DO NASCIMENTO RODRIGUES 210211
    
    
    //Criação da classe estudante
    class Estudante
    {
        //utilização do encapsulamento autoproperties para a variavel Nome
        public string Nome { get; set; }

        //utilização do encapsulamento autoproperties para a variavel Email
        public string Email { get; set; }

        //Criação do método construtor com os paramentros nome e email e variaveis locais Nome e Email
        public Estudante(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        //método override para sobrescrever e mostrar os dados na tela atulizados com os que usuario digitou (Nome e Email dos estudantes no hotel)
        public override string ToString()
        {
            return Nome + "," + Email;
        }
    }
}
