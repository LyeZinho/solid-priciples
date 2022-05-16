﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.LSP
{
    /*
    So encontrei em java 
    e não consegui reproduzir em c#
    qualquer um que queira dar uma ajuda 
    pode fazer pull request 
    */
    public class A
    {
        public void getNome()
        {
            Console.WriteLine("Nome: A");
        }
    }

    public class B : A
    {
        public new void getNome()
        {
            Console.WriteLine("Nome: B");
        }
    }

    public class Imprimir
    {
        public void print(A objeto)
        {
            objeto.getNome();
        }
    }
}
