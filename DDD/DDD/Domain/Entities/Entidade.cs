using System;

/// <summary>
/// Classe que representa o contrato de Entidade
/// </summary>
namespace Domain.Entities
{
    public abstract class Entidade
    {
        public Guid Id { get; private set; }

        public Entidade()
        {
            Id = Guid.NewGuid();
        }
    }
}
