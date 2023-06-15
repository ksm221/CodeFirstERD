using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstFirmaERD
{

    public partial class FirmaErdContext : DbContext
    {
        public FirmaErdContext()
        {
        }

        public FirmaErdContext(DbContextOptions<FirmaErdContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ametinimetused> Ametinimetuseds { get; set; }

        public virtual DbSet<Firma> Firmas { get; set; }

        public virtual DbSet<Haiguslehed> Haigusleheds { get; set; }

        public virtual DbSet<Harukontor> Harukontors { get; set; }

        public virtual DbSet<Laenutu> Laenutus { get; set; }

        public virtual DbSet<Lapsed> Lapseds { get; set; }

        public virtual DbSet<Ligipääsuload> Ligipääsuloads { get; set; }

        public virtual DbSet<Puhkused> Puhkuseds { get; set; }

        public virtual DbSet<Tervisekontroll> Tervisekontrolls { get; set; }

        public virtual DbSet<Töötaja> Töötajas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseSqlServer("Server=.\\SQLEXpress;Database=FirmaERD; Encrypt=False; Trusted_Connection=True");



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            {
                foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                {
                    relationship.DeleteBehavior = DeleteBehavior.Restrict;
                }

                modelBuilder.Entity<Ametinimetused>(entity =>
            {
                entity.HasKey(e => e.AmetinimetuseId).HasName("PK__Ametinim__4A060287B9200AB9");

                entity.ToTable("Ametinimetused");

                entity.Property(e => e.AmetinimetuseId)
                    .ValueGeneratedNever()
                    .HasColumnName("Ametinimetuse_Id");
                entity.Property(e => e.Ametinimetus)
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.AmetisAl)
                    .HasColumnType("date")
                    .HasColumnName("Ametis_al");
                entity.Property(e => e.AmetisKuni)
                    .HasColumnType("date")
                    .HasColumnName("Ametis_kuni");
                entity.Property(e => e.Kommentaar)
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.Osakond)
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.OtseseÜlemuseEesnimi)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Otsese_ülemuse_eesnimi");
                entity.Property(e => e.OtseseÜlemuseEpost)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Otsese_ülemuse_epost");
                entity.Property(e => e.OtseseÜlemuseKontakttel).HasColumnName("Otsese_ülemuse_kontakttel");
                entity.Property(e => e.OtseseÜlemusePerenimi)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Otsese_ülemuse_perenimi");
                entity.Property(e => e.TöötajaId).HasColumnName("Töötaja_id");
            });

                modelBuilder.Entity<Firma>(entity =>
                {
                    entity.HasKey(e => e.FirmaId).HasName("PK__Firma__19E157A703EFEF79");

                    entity.ToTable("Firma");

                    entity.Property(e => e.FirmaId)
                        .ValueGeneratedNever()
                        .HasColumnName("Firma_Id");
                    entity.Property(e => e.Aadress)
                        .HasMaxLength(255)
                        .IsUnicode(false);
                    entity.Property(e => e.FirmaRegNr)
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnName("Firma_reg_nr");
                    entity.Property(e => e.Koduleht)
                        .HasMaxLength(255)
                        .IsUnicode(false);
                    entity.Property(e => e.Kommentaar)
                        .HasMaxLength(255)
                        .IsUnicode(false);
                    entity.Property(e => e.KontaktEmail)
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnName("Kontakt_email");
                    entity.Property(e => e.KontaktTel).HasColumnName("Kontakt_tel");
                    entity.Property(e => e.Kontaktisik)
                        .HasMaxLength(255)
                        .IsUnicode(false);
                    entity.Property(e => e.Lühinimi)
                        .HasMaxLength(255)
                        .IsUnicode(false);
                    entity.Property(e => e.Nimi)
                        .HasMaxLength(255)
                        .IsUnicode(false);
                });

                modelBuilder.Entity<Haiguslehed>(entity =>
                {
                    entity.HasKey(e => e.HaigusleheId).HasName("PK__Haigusle__E9A72536EE8FEA05");

                    entity.ToTable("Haiguslehed");

                    entity.Property(e => e.HaigusleheId)
                        .ValueGeneratedNever()
                        .HasColumnName("Haiguslehe_Id");
                    entity.Property(e => e.AegunudHaigusepäevi).HasColumnName("Aegunud_haigusepäevi");
                    entity.Property(e => e.AllesolevaidHaigusepäevi).HasColumnName("Allesolevaid_haigusepäevi");
                    entity.Property(e => e.HaigusleheAlgus)
                        .HasColumnType("date")
                        .HasColumnName("Haiguslehe_algus");
                    entity.Property(e => e.HaigusleheLõpp)
                        .HasColumnType("date")
                        .HasColumnName("Haiguslehe_lõpp");
                    entity.Property(e => e.HaiguspäeviKokku).HasColumnName("Haiguspäevi_kokku");
                    entity.Property(e => e.KasutatudHaigusepäevi).HasColumnName("Kasutatud_haigusepäevi");
                    entity.Property(e => e.Kommentaar)
                        .HasMaxLength(255)
                        .IsUnicode(false);
                    entity.Property(e => e.TöötajaId).HasColumnName("Töötaja_id");
                    entity.Property(e => e.ÕigusHaiguslehele).HasColumnName("Õigus_haiguslehele");

                    entity.HasOne(d => d.Töötaja).WithMany(p => p.Haigusleheds)
                        .HasForeignKey(d => d.TöötajaId)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Haigusleh__Tööta__5EBF139D");
                });

                modelBuilder.Entity<Harukontor>(entity =>
                {
                    entity.HasKey(e => e.HarukontoriId).HasName("PK__Harukont__5D9F22E489950D67");

                    entity.ToTable("Harukontor");

                    entity.Property(e => e.HarukontoriId)
                        .ValueGeneratedNever()
                        .HasColumnName("Harukontori_Id");
                    entity.Property(e => e.Aadress)
                        .HasMaxLength(255)
                        .IsUnicode(false);
                    entity.Property(e => e.FirmaId).HasColumnName("Firma_id");
                    entity.Property(e => e.HarukontoriRegNr)
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnName("Harukontori_reg_nr");
                    entity.Property(e => e.Koduleht)
                        .HasMaxLength(255)
                        .IsUnicode(false);
                    entity.Property(e => e.Kommentaar)
                        .HasMaxLength(255)
                        .IsUnicode(false);
                    entity.Property(e => e.KontaktEmail)
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnName("Kontakt_email");
                    entity.Property(e => e.KontaktTel).HasColumnName("Kontakt_tel");
                    entity.Property(e => e.Kontaktisik)
                        .HasMaxLength(255)
                        .IsUnicode(false);
                    entity.Property(e => e.Lühinimi)
                        .HasMaxLength(255)
                        .IsUnicode(false);
                    entity.Property(e => e.Nimi)
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    entity.HasOne(d => d.Firma).WithMany(p => p.Harukontors)
                        .HasForeignKey(d => d.FirmaId)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Harukonto__Firma__4F7CD00D");
                });

                modelBuilder.Entity<Laenutu>(entity =>
                {
                    entity.HasKey(e => e.LaenutuseId).HasName("PK__Laenutus__BBCFA8B57D14502E");

                    entity.Property(e => e.LaenutuseId)
                        .ValueGeneratedNever()
                        .HasColumnName("Laenutuse_Id");
                    entity.Property(e => e.Kommentaar)
                        .HasMaxLength(255)
                        .IsUnicode(false);
                    entity.Property(e => e.LaenutatavaKaubaNimi)
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnName("Laenutatava_kauba_nimi");
                    entity.Property(e => e.LaenutuseAlgus)
                        .HasColumnType("date")
                        .HasColumnName("Laenutuse_algus");
                    entity.Property(e => e.LaenutuseLõpp)
                        .HasColumnType("date")
                        .HasColumnName("Laenutuse_lõpp");
                    entity.Property(e => e.TöötajaId).HasColumnName("Töötaja_id");

                    entity.HasOne(d => d.Töötaja).WithMany(p => p.Laenutus)
                        .HasForeignKey(d => d.TöötajaId)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Laenutus__Töötaj__6754599E");
                });

                modelBuilder.Entity<Lapsed>(entity =>
                {
                    entity.HasKey(e => e.LapseId).HasName("PK__Lapsed__306D9C591FA3469D");

                    entity.ToTable("Lapsed");

                    entity.Property(e => e.LapseId)
                        .ValueGeneratedNever()
                        .HasColumnName("Lapse_Id");
                    entity.Property(e => e.Kommentaar)
                        .HasMaxLength(255)
                        .IsUnicode(false);
                    entity.Property(e => e.LapseEesnimi)
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnName("Lapse_eesnimi");
                    entity.Property(e => e.LapsePerenimi)
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnName("Lapse_perenimi");
                    entity.Property(e => e.LapseSünniaeg)
                        .HasColumnType("date")
                        .HasColumnName("Lapse_sünniaeg");
                    entity.Property(e => e.LapseVanus).HasColumnName("Lapse_vanus");
                    entity.Property(e => e.TöötajaId).HasColumnName("Töötaja_id");

                    entity.HasOne(d => d.Töötaja).WithMany(p => p.Lapseds)
                        .HasForeignKey(d => d.TöötajaId)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Lapsed__Töötaja___5BE2A6F2");
                });

                modelBuilder.Entity<Ligipääsuload>(entity =>
                {
                    entity.HasKey(e => e.LigipääsuloaId).HasName("PK__Ligipääs__B3DD5FEDBD8515CC");

                    entity.ToTable("Ligipääsuload");

                    entity.Property(e => e.LigipääsuloaId)
                        .ValueGeneratedNever()
                        .HasColumnName("Ligipääsuloa_Id");
                    entity.Property(e => e.Kommentaar)
                        .HasMaxLength(255)
                        .IsUnicode(false);
                    entity.Property(e => e.LigipääsuAlgus)
                        .HasColumnType("date")
                        .HasColumnName("Ligipääsu_algus");
                    entity.Property(e => e.LigipääsuLõpp)
                        .HasColumnType("date")
                        .HasColumnName("Ligipääsu_lõpp");
                    entity.Property(e => e.LigipääsuTase)
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnName("Ligipääsu_tase");
                    entity.Property(e => e.LigipääsuÕigus).HasColumnName("Ligipääsu_õigus");
                    entity.Property(e => e.TöötajaId).HasColumnName("Töötaja_id");

                    entity.HasOne(d => d.Töötaja).WithMany(p => p.Ligipääsuloads)
                        .HasForeignKey(d => d.TöötajaId)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Ligipääsu__Tööta__619B8048");
                });

                modelBuilder.Entity<Puhkused>(entity =>
                {
                    entity.HasKey(e => e.PuhkuseId).HasName("PK__Puhkused__4CB6D3D071E43324");

                    entity.ToTable("Puhkused");

                    entity.Property(e => e.PuhkuseId)
                        .ValueGeneratedNever()
                        .HasColumnName("Puhkuse_Id");
                    entity.Property(e => e.AegunudPuhkusepäevad).HasColumnName("Aegunud_puhkusepäevad");
                    entity.Property(e => e.AllesolevadPäevad).HasColumnName("Allesolevad_päevad");
                    entity.Property(e => e.KasutatudPäevad).HasColumnName("Kasutatud_päevad");
                    entity.Property(e => e.Kommentaar)
                        .HasMaxLength(255)
                        .IsUnicode(false);
                    entity.Property(e => e.PuhkuseAlgus)
                        .HasColumnType("date")
                        .HasColumnName("Puhkuse_algus");
                    entity.Property(e => e.PuhkuseLõpp)
                        .HasColumnType("date")
                        .HasColumnName("Puhkuse_lõpp");
                    entity.Property(e => e.PuhkusePäevi).HasColumnName("Puhkuse_päevi");
                    entity.Property(e => e.TöötajaId).HasColumnName("Töötaja_id");

                    entity.HasOne(d => d.Töötaja).WithMany(p => p.Puhkuseds)
                        .HasForeignKey(d => d.TöötajaId)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Puhkused__Töötaj__59063A47");
                });

                modelBuilder.Entity<Tervisekontroll>(entity =>
                {
                    entity.HasKey(e => e.TervisekontrolliId).HasName("PK__Tervisek__7729A979AB2CA450");

                    entity.ToTable("Tervisekontroll");

                    entity.Property(e => e.TervisekontrolliId)
                        .ValueGeneratedNever()
                        .HasColumnName("Tervisekontrolli_Id");
                    entity.Property(e => e.EelmiseTervisekontrolliKp)
                        .HasColumnType("date")
                        .HasColumnName("Eelmise_tervisekontrolli_kp");
                    entity.Property(e => e.Kommentaar)
                        .HasMaxLength(255)
                        .IsUnicode(false);
                    entity.Property(e => e.TervisekontrolliVajadus).HasColumnName("Tervisekontrolli_vajadus");
                    entity.Property(e => e.TöötajaId).HasColumnName("Töötaja_id");
                    entity.Property(e => e.UueTervisekontrolliKp)
                        .HasColumnType("date")
                        .HasColumnName("Uue_tervisekontrolli_kp");

                    entity.HasOne(d => d.Töötaja).WithMany(p => p.Tervisekontrolls)
                        .HasForeignKey(d => d.TöötajaId)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Terviseko__Tööta__6477ECF3");
                });

                modelBuilder.Entity<Töötaja>(entity =>
                {
                    entity.HasKey(e => e.TöötajaId).HasName("PK__Töötaja__99521C8E522D1C41");

                    entity.ToTable("Töötaja");

                    entity.Property(e => e.TöötajaId)
                        .ValueGeneratedNever()
                        .HasColumnName("Töötaja_Id");
                    entity.Property(e => e.AmetinimetuseId).HasColumnName("Ametinimetuse_id");
                    entity.Property(e => e.Eesnimi)
                        .HasMaxLength(255)
                        .IsUnicode(false);
                    entity.Property(e => e.FirmaId).HasColumnName("Firma_Id");
                    entity.Property(e => e.HarukontoriId).HasColumnName("Harukontori_Id");
                    entity.Property(e => e.Kommentaar)
                        .HasMaxLength(255)
                        .IsUnicode(false);
                    entity.Property(e => e.Kontaktaadress)
                        .HasMaxLength(255)
                        .IsUnicode(false);
                    entity.Property(e => e.Perekonnanimi)
                        .HasMaxLength(255)
                        .IsUnicode(false);
                    entity.Property(e => e.TöölAl)
                        .HasColumnType("date")
                        .HasColumnName("Tööl_al");
                    entity.Property(e => e.TöölKuni)
                        .HasColumnType("date")
                        .HasColumnName("Tööl_kuni");

                    entity.HasOne(d => d.Ametinimetuse).WithMany(p => p.Töötajas)
                        .HasForeignKey(d => d.AmetinimetuseId)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Töötaja__Ametini__5441852A");

                    entity.HasOne(d => d.Firma).WithMany(p => p.Töötajas)
                        .HasForeignKey(d => d.FirmaId)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Töötaja__Firma_I__5535A963");

                    entity.HasOne(d => d.Harukontori).WithMany(p => p.Töötajas)
                        .HasForeignKey(d => d.HarukontoriId)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Töötaja__Harukon__5629CD9C");
                });

                OnModelCreatingPartial(modelBuilder);
            }
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}