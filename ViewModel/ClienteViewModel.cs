using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankAccountPC2.Models;

namespace BankAccountPC2.ViewModel
{
       public class ClienteViewModel
    {
        public Cliente? FormCliente  {get; set;}
        public IEnumerable<Cliente>? ListCliente  {get; set;}
    }
}