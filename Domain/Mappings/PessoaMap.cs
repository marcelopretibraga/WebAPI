using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Mappings
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("Pessoa");
            builder.Property(p => p.PessoaId).HasColumnName("cd_pessoa").IsRequired();
            builder.Property(p => p.Nome).HasColumnName("nm_pessoa");
            builder.Property(p => p.Telefone).HasColumnName("nr_telefone");
            builder.Property(p => p.Rg).HasColumnName("nr_rg");
            builder.Property(p => p.Cpf).HasColumnName("nr_cpf");
            builder.Property(p => p.DataNascimento).HasColumnName("dt_nascimento");
            builder.HasKey(p => p.PessoaId);
        }
    }
}
