using Domain.Entities;
using System;
using Xunit;

namespace Test
{
    public class DomainTest
    {
        [Fact]
        public void ClienteValido()
        {
            Cliente cliente = new Cliente("Gabriel", "Biel", new DateTime(2000, 06, 09));

            Assert.NotNull(cliente);
            Assert.True(cliente.Id != Guid.Empty);
        }

        [Fact]
        public void ClienteInvalido_PropriedadesNulas()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                new Cliente(null, null, new DateTime(2000, 06, 09));
            });
        }

        [Fact]
        public void ClienteTrocarNome()
        {
            string novoNome = "Carlos";
            Cliente cliente = new Cliente("Gabriel", "Biel", new DateTime(2000, 06, 09));
            
            Console.WriteLine("Nome instância: " + cliente.Nome);

            cliente.TrocarNome(novoNome);

            Console.WriteLine("Nome trocado: " + cliente.Nome);

            Assert.Equal(cliente.Nome, novoNome);
        }
    }
}
