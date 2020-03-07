namespace BilgeKoleji2020.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Header = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Content = c.String(nullable: false),
                        Status = c.Int(nullable: false),
                        CreatedDate = c.DateTime(name: "Created Date", nullable: false),
                        Owner_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Login", t => t.Owner_ID)
                .Index(t => t.Owner_ID);
            
            CreateTable(
                "dbo.Login",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        OgrenciTCKimlikNumarasi = c.String(nullable: false),
                        OkulNumarasi = c.String(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Status = c.Int(nullable: false),
                        CreatedDate = c.DateTime(name: "Created Date", nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        ID1 = c.Guid(nullable: false),
                        ID = c.String(nullable: false),
                        Şube = c.String(nullable: false),
                        Status = c.Int(nullable: false),
                        CreatedDate = c.DateTime(name: "Created Date", nullable: false),
                    })
                .PrimaryKey(t => t.ID1);
            
            CreateTable(
                "dbo.Lessons",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        DersKodu = c.String(nullable: false),
                        DersAdi = c.String(nullable: false),
                        HaftalikDers = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        CreatedDate = c.DateTime(name: "Created Date", nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PreRegister",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        TCKimlikNumarası = c.String(name: "TC Kimlik Numarası", nullable: false),
                        ÖğrenciAdıSoyadı = c.String(name: "Öğrenci Adı Soyadı", nullable: false),
                        Cinsiyet = c.String(nullable: false),
                        BitirdiğiOkul = c.String(name: "Bitirdiği Okul", nullable: false),
                        NotOrtalaması = c.Decimal(name: "Not Ortalaması", nullable: false, precision: 18, scale: 2),
                        VeliAdıSoyadı = c.String(name: "Veli Adı Soyadı", nullable: false),
                        CepTelefonu = c.Int(name: "Cep Telefonu", nullable: false),
                        DiğerTelefon = c.Int(name: "Diğer Telefon"),
                        EvAdresi = c.String(name: "Ev Adresi", nullable: false, maxLength: 200),
                        İlçeveİl = c.String(name: "İlçe ve İl", nullable: false),
                        Role = c.Int(),
                        Status = c.Int(nullable: false),
                        CreatedDate = c.DateTime(name: "Created Date", nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Register",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        TCKimlikNumarası = c.String(name: "TC Kimlik Numarası", nullable: false),
                        AdıSoyadı = c.String(name: "Adı Soyadı", nullable: false),
                        Cinsiyet = c.String(nullable: false),
                        GeldiğiOkul = c.String(name: "Geldiği Okul", nullable: false),
                        CepTelefonu = c.Int(name: "Cep Telefonu", nullable: false),
                        DiğerTelefon = c.Int(name: "Diğer Telefon"),
                        EvAdresi = c.String(name: "Ev Adresi", nullable: false, maxLength: 200),
                        İlçeveİl = c.String(name: "İlçe ve İl", nullable: false),
                        Role = c.Int(),
                        Status = c.Int(nullable: false),
                        CreatedDate = c.DateTime(name: "Created Date", nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        TcKimlikNumarası = c.String(name: "Tc Kimlik Numarası", nullable: false),
                        OkulNumarası = c.String(name: "Okul Numarası", nullable: false),
                        Sınıf = c.String(nullable: false),
                        Adı = c.String(nullable: false),
                        Soyadı = c.String(nullable: false),
                        Cinsiyet = c.String(nullable: false),
                        Password = c.String(),
                        Status = c.Int(nullable: false),
                        CreatedDate = c.DateTime(name: "Created Date", nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Adı = c.String(nullable: false),
                        Soyadı = c.String(nullable: false),
                        Branş = c.String(nullable: false),
                        Sırası = c.String(nullable: false),
                        KullanıcıAdı = c.String(name: "Kullanıcı Adı", nullable: false),
                        Şifre = c.String(nullable: false),
                        Status = c.Int(nullable: false),
                        CreatedDate = c.DateTime(name: "Created Date", nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Articles", "Owner_ID", "dbo.Login");
            DropIndex("dbo.Articles", new[] { "Owner_ID" });
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
            DropTable("dbo.Register");
            DropTable("dbo.PreRegister");
            DropTable("dbo.Lessons");
            DropTable("dbo.Classes");
            DropTable("dbo.Login");
            DropTable("dbo.Articles");
        }
    }
}
