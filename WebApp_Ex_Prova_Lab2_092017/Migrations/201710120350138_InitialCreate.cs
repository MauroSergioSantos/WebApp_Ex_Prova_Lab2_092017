namespace WebApp_Ex_Prova_Lab2_092017.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ators",
                c => new
                    {
                        AtorId = c.Int(nullable: false, identity: true),
                        AtorNome = c.String(),
                        FilmeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AtorId);
            
            CreateTable(
                "dbo.Filmes",
                c => new
                    {
                        FilmeId = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        Duracao = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.FilmeId);
            
            CreateTable(
                "dbo.Sessaos",
                c => new
                    {
                        SessaoId = c.Int(nullable: false, identity: true),
                        DataHoraInicio = c.DateTime(nullable: false),
                        DataHoraFim = c.DateTime(nullable: false),
                        ValorInteira = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorMeia = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Encerrada = c.Boolean(nullable: false),
                        SalaId = c.Int(nullable: false),
                        IngressoId = c.Int(nullable: false),
                        FilmeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SessaoId)
                .ForeignKey("dbo.Filmes", t => t.FilmeId, cascadeDelete: true)
                .ForeignKey("dbo.Ingressoes", t => t.IngressoId, cascadeDelete: true)
                .ForeignKey("dbo.Salas", t => t.SalaId, cascadeDelete: true)
                .Index(t => t.SalaId)
                .Index(t => t.IngressoId)
                .Index(t => t.FilmeId);
            
            CreateTable(
                "dbo.Ingressoes",
                c => new
                    {
                        IngressoId = c.Int(nullable: false, identity: true),
                        Tipo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IngressoId);
            
            CreateTable(
                "dbo.Salas",
                c => new
                    {
                        SalaId = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                        Capacidade = c.Int(nullable: false),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.SalaId);
            
            CreateTable(
                "dbo.FilmeAtors",
                c => new
                    {
                        Filme_FilmeId = c.Int(nullable: false),
                        Ator_AtorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Filme_FilmeId, t.Ator_AtorId })
                .ForeignKey("dbo.Filmes", t => t.Filme_FilmeId, cascadeDelete: true)
                .ForeignKey("dbo.Ators", t => t.Ator_AtorId, cascadeDelete: true)
                .Index(t => t.Filme_FilmeId)
                .Index(t => t.Ator_AtorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sessaos", "SalaId", "dbo.Salas");
            DropForeignKey("dbo.Sessaos", "IngressoId", "dbo.Ingressoes");
            DropForeignKey("dbo.Sessaos", "FilmeId", "dbo.Filmes");
            DropForeignKey("dbo.FilmeAtors", "Ator_AtorId", "dbo.Ators");
            DropForeignKey("dbo.FilmeAtors", "Filme_FilmeId", "dbo.Filmes");
            DropIndex("dbo.FilmeAtors", new[] { "Ator_AtorId" });
            DropIndex("dbo.FilmeAtors", new[] { "Filme_FilmeId" });
            DropIndex("dbo.Sessaos", new[] { "FilmeId" });
            DropIndex("dbo.Sessaos", new[] { "IngressoId" });
            DropIndex("dbo.Sessaos", new[] { "SalaId" });
            DropTable("dbo.FilmeAtors");
            DropTable("dbo.Salas");
            DropTable("dbo.Ingressoes");
            DropTable("dbo.Sessaos");
            DropTable("dbo.Filmes");
            DropTable("dbo.Ators");
        }
    }
}
