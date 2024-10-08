﻿using BarberShop.Core.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop.Core.Interfaces.Services
{
    public interface IClientesServices
    {
        string CadastraCliente(ClienteViewModel cliente);
        List<ClienteViewModel> GetClientes();
    }
}
