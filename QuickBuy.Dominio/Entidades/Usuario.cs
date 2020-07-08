﻿using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        /// <summary
        /// Usuario pode ter nenhum ou muitos Pedidos
        /// </summary
        public ICollection<Pedido> Pedidos { get; set; }

    }
}
