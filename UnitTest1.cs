using SistemaKPI_API.Entities;
using SistemaKPI_Test.API_Facade;
using System;
using System.Linq;
using Xunit;

namespace SistemaKPI_Test
{
    public class UnitTest1
    {
        [Fact]
        public void PedidoClientes_HasResults()
        {
            // Arrange
            var wsResult = new HttpClient().HttpGet("PedidoCliente/GetClientesPedido");

            // Act
            // Debe haber más de un pedido de cliente.
            var lstPedidos = wsResult.Payload as PedidoCliente[];

            // Assert
            Assert.NotEmpty(lstPedidos);
        }
        [Fact]
        public void PedidoCliente_Add()
        {
                
        }
    }
}
