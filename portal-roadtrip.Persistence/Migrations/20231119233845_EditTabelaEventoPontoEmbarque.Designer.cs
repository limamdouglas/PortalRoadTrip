﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using portal_roadtrip.Persistence.Context;

#nullable disable

namespace portal_roadtrip.Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231119233845_EditTabelaEventoPontoEmbarque")]
    partial class EditTabelaEventoPontoEmbarque
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.21");

            modelBuilder.Entity("portal_roadtrip.Domain.Entities.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cargo");
                });

            modelBuilder.Entity("portal_roadtrip.Domain.Entities.CategoriaEvento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CategoriaEvento");
                });

            modelBuilder.Entity("portal_roadtrip.Domain.Entities.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Alergia")
                        .HasColumnType("TEXT");

                    b.Property<string>("CPF")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContatoEmergencia")
                        .HasColumnType("TEXT");

                    b.Property<string>("DataNascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Doença")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("EstadoCivil")
                        .HasColumnType("TEXT");

                    b.Property<bool>("FezCadastro")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Medicamento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrgaoEmissor")
                        .HasColumnType("TEXT");

                    b.Property<string>("RG")
                        .HasColumnType("TEXT");

                    b.Property<string>("RegiaoOndeMora")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente", (string)null);
                });

            modelBuilder.Entity("portal_roadtrip.Domain.Entities.ConexaoUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsuarioId1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsuarioId2")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId1");

                    b.HasIndex("UsuarioId2");

                    b.ToTable("Conexao_Usuario", (string)null);
                });

            modelBuilder.Entity("portal_roadtrip.Domain.Entities.Credito", b =>
                {
                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CreditoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EventoUtilizado")
                        .HasColumnType("TEXT");

                    b.Property<string>("Observacao")
                        .HasColumnType("TEXT");

                    b.Property<string>("QuandoFoiUtilizado")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ValorRestante")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ValorUtilizado")
                        .HasColumnType("TEXT");

                    b.Property<string>("Vencimento")
                        .HasColumnType("TEXT");

                    b.HasKey("ClienteId");

                    b.ToTable("Credito", (string)null);
                });

            modelBuilder.Entity("portal_roadtrip.Domain.Entities.Estorno", b =>
                {
                    b.Property<int>("EstornoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Acompanhamento")
                        .HasColumnType("TEXT");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DataPagamento")
                        .HasColumnType("TEXT");

                    b.Property<string>("DataSolicitacao")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Estornado")
                        .HasColumnType("TEXT");

                    b.Property<int>("EventoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FormaPg")
                        .HasColumnType("TEXT");

                    b.Property<string>("IdTransacao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Motivo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Plataforma")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PorcentagemDevolvida")
                        .HasColumnType("TEXT");

                    b.Property<string>("PrazoEstimado")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantidade")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Valor")
                        .HasColumnType("TEXT");

                    b.HasKey("EstornoId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("EventoId");

                    b.ToTable("Estorno", (string)null);
                });

            modelBuilder.Entity("portal_roadtrip.Domain.Entities.Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoriaEventoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Data")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Preco")
                        .HasColumnType("REAL");

                    b.Property<int>("QuantidadeVagas")
                        .HasColumnType("INTEGER");

                    b.Property<int>("QuantidadeVagasReservas")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Roteiro")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaEventoId");

                    b.ToTable("Evento", (string)null);
                });

            modelBuilder.Entity("portal_roadtrip.Domain.Entities.EventoCliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteID")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EhReserva")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EventoId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EventoId1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("QuantidadeVaga")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ClienteID");

                    b.HasIndex("EventoId");

                    b.HasIndex("EventoId1");

                    b.ToTable("Evento_Cliente", (string)null);
                });

            modelBuilder.Entity("portal_roadtrip.Domain.Entities.EventoFuncionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EventoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("EventoId");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("Evento_Funcionario", (string)null);
                });

            modelBuilder.Entity("portal_roadtrip.Domain.Entities.EventoPontoEmbarque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EventoId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EventoId1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PontoEmbarqueId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("EventoId");

                    b.HasIndex("EventoId1");

                    b.HasIndex("PontoEmbarqueId");

                    b.ToTable("Evento_Ponto_Embarque", (string)null);
                });

            modelBuilder.Entity("portal_roadtrip.Domain.Entities.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CargoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DataAdmissao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DataDemissao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Instagram")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OrgaoEmissor")
                        .HasColumnType("TEXT");

                    b.Property<string>("RG")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CargoId");

                    b.ToTable("Funcionario", (string)null);
                });

            modelBuilder.Entity("portal_roadtrip.Domain.Entities.PontoEmbarque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PontoEmbarque");
                });

            modelBuilder.Entity("portal_roadtrip.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DataCadastro")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DataNascimento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OrgaoEmissor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("portal_roadtrip.Domain.Entities.ConexaoUsuario", b =>
                {
                    b.HasOne("portal_roadtrip.Domain.Entities.Usuario", "Usuario1")
                        .WithMany()
                        .HasForeignKey("UsuarioId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("portal_roadtrip.Domain.Entities.Usuario", "Usuario2")
                        .WithMany()
                        .HasForeignKey("UsuarioId2")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario1");

                    b.Navigation("Usuario2");
                });

            modelBuilder.Entity("portal_roadtrip.Domain.Entities.Credito", b =>
                {
                    b.HasOne("portal_roadtrip.Domain.Entities.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("portal_roadtrip.Domain.Entities.Estorno", b =>
                {
                    b.HasOne("portal_roadtrip.Domain.Entities.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("portal_roadtrip.Domain.Entities.Evento", "Evento")
                        .WithMany()
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Evento");
                });

            modelBuilder.Entity("portal_roadtrip.Domain.Entities.Evento", b =>
                {
                    b.HasOne("portal_roadtrip.Domain.Entities.CategoriaEvento", "CategoriaEvento")
                        .WithMany()
                        .HasForeignKey("CategoriaEventoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoriaEvento");
                });

            modelBuilder.Entity("portal_roadtrip.Domain.Entities.EventoCliente", b =>
                {
                    b.HasOne("portal_roadtrip.Domain.Entities.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("portal_roadtrip.Domain.Entities.Evento", "Evento")
                        .WithMany()
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("portal_roadtrip.Domain.Entities.Evento", null)
                        .WithMany("EventoCliente")
                        .HasForeignKey("EventoId1");

                    b.Navigation("Cliente");

                    b.Navigation("Evento");
                });

            modelBuilder.Entity("portal_roadtrip.Domain.Entities.EventoFuncionario", b =>
                {
                    b.HasOne("portal_roadtrip.Domain.Entities.Evento", "Evento")
                        .WithMany()
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("portal_roadtrip.Domain.Entities.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Evento");

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("portal_roadtrip.Domain.Entities.EventoPontoEmbarque", b =>
                {
                    b.HasOne("portal_roadtrip.Domain.Entities.Evento", "Evento")
                        .WithMany()
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("portal_roadtrip.Domain.Entities.Evento", null)
                        .WithMany("EventoPontoEmbarque")
                        .HasForeignKey("EventoId1");

                    b.HasOne("portal_roadtrip.Domain.Entities.PontoEmbarque", "PontoEmbarque")
                        .WithMany()
                        .HasForeignKey("PontoEmbarqueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Evento");

                    b.Navigation("PontoEmbarque");
                });

            modelBuilder.Entity("portal_roadtrip.Domain.Entities.Funcionario", b =>
                {
                    b.HasOne("portal_roadtrip.Domain.Entities.Cargo", "Cargo")
                        .WithMany()
                        .HasForeignKey("CargoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cargo");
                });

            modelBuilder.Entity("portal_roadtrip.Domain.Entities.Evento", b =>
                {
                    b.Navigation("EventoCliente");

                    b.Navigation("EventoPontoEmbarque");
                });
#pragma warning restore 612, 618
        }
    }
}