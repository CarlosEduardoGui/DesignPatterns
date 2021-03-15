using System;

/// <summary>
/// Classe que representa o contrato de Entidade
/// </summary>
public abstract class Entidade
{
    public Guid Id { get; private set; }

    public Entidade()
    {
        Id = Guid.NewGuid();
    }
}
