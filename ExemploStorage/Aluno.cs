using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace ExemploStorage
{
    public class Aluno : TableEntity
    {
        public Aluno(string rm, string cidade) : base(cidade, rm)
        {

        }

        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
