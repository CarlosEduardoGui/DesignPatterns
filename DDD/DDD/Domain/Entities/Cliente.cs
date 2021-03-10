using System;

namespace Domain.Entities
{
    public class Cliente
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Apelido { get; private set; }
        public DateTime DataNascimento { get; private set; }

        public Cliente(Guid? id, string nome, string apelido, DateTime dataNascimento)
        {
            Id = id ?? Guid.NewGuid();
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Apelido = apelido ?? throw new ArgumentNullException(nameof(apelido));
            DataNascimento = dataNascimento > DateTime.Now ?
                throw new ApplicationException("A data de nascimento não pode ser maior que a data atual")
                : dataNascimento;
        }

        public void TrocarApelido(string apelido)
        {
            Apelido = apelido ?? throw new ArgumentNullException(nameof(apelido));
        }
    }
}
