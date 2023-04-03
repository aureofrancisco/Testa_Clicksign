using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Testa_Clicksign.Models;

namespace Testa_Clicksign.Data
{
    public class PedidoContext : DbContext
    {
        public PedidoContext(DbContextOptions<PedidoContext> options)
            : base(options)
        {
        }

        public DbSet<Pedido> Pedidos { get; set; }
    }
}
