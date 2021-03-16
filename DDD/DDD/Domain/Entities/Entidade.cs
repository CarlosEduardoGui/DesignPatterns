using System;

/// <summary>
/// Classe que representa o contrato de Entidade
/// </summary>
namespace Domain.Entities
{
    public abstract class Entidade
    {
        public Guid? Id { get; protected set; }

        public Entidade()
        {
            Id = NovoId ? Guid.NewGuid() : Id;
        }

        private bool NovoId => Id == null || Id == Guid.Empty;
    }
}
