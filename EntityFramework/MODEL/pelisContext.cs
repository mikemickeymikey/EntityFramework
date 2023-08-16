using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EntityFramework.MODEL
{
    public partial class pelisContext : DbContext
    {
        public pelisContext()
        {
        }

        public pelisContext(DbContextOptions<pelisContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actor> Actor { get; set; }
        public virtual DbSet<ActorInfo> ActorInfo { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Film> Film { get; set; }
        public virtual DbSet<FilmActor> FilmActor { get; set; }
        public virtual DbSet<FilmCategory> FilmCategory { get; set; }
        public virtual DbSet<FilmList> FilmList { get; set; }
        public virtual DbSet<FilmText> FilmText { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<NicerButSlowerFilmList> NicerButSlowerFilmList { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<VFilmList> VFilmList { get; set; }
        public virtual DbSet<VNicerButSlowerFilmList> VNicerButSlowerFilmList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;user id=root;database=pelis;allowuservariables=True", x => x.ServerVersion("10.4.22-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>(entity =>
            {
                entity.ToTable("actor");

                entity.HasIndex(e => e.LastName)
                    .HasName("idx_actor_last_name");

                entity.Property(e => e.ActorId)
                    .HasColumnName("actor_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("current_timestamp()")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<ActorInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("actor_info");

                entity.Property(e => e.ActorId)
                    .HasColumnName("actor_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.FilmInfo)
                    .HasColumnName("film_info")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("address");

                entity.HasIndex(e => e.CityId)
                    .HasName("idx_fk_city_id");

                entity.Property(e => e.AddressId)
                    .HasColumnName("address_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CityId)
                    .HasColumnName("city_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.District)
                    .IsRequired()
                    .HasColumnName("district")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("current_timestamp()")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PostalCode)
                    .HasColumnName("postal_code")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_address_city");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("tinyint(3) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("current_timestamp()")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(25)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("city");

                entity.HasIndex(e => e.CountryId)
                    .HasName("idx_fk_country_id");

                entity.Property(e => e.CityId)
                    .HasColumnName("city_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.City1)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CountryId)
                    .HasColumnName("country_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("current_timestamp()")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_city_country");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("country");

                entity.Property(e => e.CountryId)
                    .HasColumnName("country_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Country1)
                    .IsRequired()
                    .HasColumnName("country")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("current_timestamp()")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<Film>(entity =>
            {
                entity.ToTable("film");

                entity.HasIndex(e => e.LanguageId)
                    .HasName("idx_fk_language_id");

                entity.HasIndex(e => e.OriginalLanguageId)
                    .HasName("idx_fk_original_language_id");

                entity.HasIndex(e => e.Title)
                    .HasName("idx_title");

                entity.Property(e => e.FilmId)
                    .HasColumnName("film_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("language_id")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("current_timestamp()")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Length)
                    .HasColumnName("length")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.OriginalLanguageId)
                    .HasColumnName("original_language_id")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Rating)
                    .HasColumnName("rating")
                    .HasColumnType("enum('G','PG','PG-13','R','NC-17')")
                    .HasDefaultValueSql("'G'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ReleaseYear)
                    .HasColumnName("release_year")
                    .HasColumnType("year(4)");

                entity.Property(e => e.RentalDuration)
                    .HasColumnName("rental_duration")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'3'");

                entity.Property(e => e.RentalRate)
                    .HasColumnName("rental_rate")
                    .HasColumnType("decimal(4,2)")
                    .HasDefaultValueSql("'4.99'");

                entity.Property(e => e.ReplacementCost)
                    .HasColumnName("replacement_cost")
                    .HasColumnType("decimal(5,2)")
                    .HasDefaultValueSql("'19.99'");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(128)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.FilmLanguage)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_film_language");

                entity.HasOne(d => d.OriginalLanguage)
                    .WithMany(p => p.FilmOriginalLanguage)
                    .HasForeignKey(d => d.OriginalLanguageId)
                    .HasConstraintName("fk_film_language_original");
            });

            modelBuilder.Entity<FilmActor>(entity =>
            {
                entity.HasKey(e => new { e.ActorId, e.FilmId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("film_actor");

                entity.HasIndex(e => e.FilmId)
                    .HasName("idx_fk_film_id");

                entity.Property(e => e.ActorId)
                    .HasColumnName("actor_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.FilmId)
                    .HasColumnName("film_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("current_timestamp()")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<FilmCategory>(entity =>
            {
                entity.HasKey(e => new { e.FilmId, e.CategoryId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("film_category");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("fk_film_category_category");

                entity.Property(e => e.FilmId)
                    .HasColumnName("film_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("current_timestamp()")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<FilmList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("film_list");

                entity.Property(e => e.Actors)
                    .HasColumnName("actors")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasColumnType("varchar(25)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Fid)
                    .HasColumnName("FID")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Length)
                    .HasColumnName("length")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(4,2)");

                entity.Property(e => e.Rating)
                    .HasColumnName("rating")
                    .HasColumnType("enum('G','PG','PG-13','R','NC-17')")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(128)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<FilmText>(entity =>
            {
                entity.HasKey(e => e.FilmId)
                    .HasName("PRIMARY");

                entity.ToTable("film_text");

                entity.HasIndex(e => new { e.Title, e.Description })
                    .HasName("idx_title_description")
                    .HasAnnotation("MySql:FullTextIndex", true);

                entity.Property(e => e.FilmId)
                    .HasColumnName("film_id")
                    .HasColumnType("smallint(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.ToTable("language");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("language_id")
                    .HasColumnType("tinyint(3) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("current_timestamp()")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("char(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<NicerButSlowerFilmList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("nicer_but_slower_film_list");

                entity.Property(e => e.Actors)
                    .HasColumnName("actors")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasColumnType("varchar(25)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Fid)
                    .HasColumnName("FID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Length)
                    .HasColumnName("length")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(4,2)")
                    .HasDefaultValueSql("'4.99'");

                entity.Property(e => e.Rating)
                    .HasColumnName("rating")
                    .HasColumnType("enum('G','PG','PG-13','R','NC-17')")
                    .HasDefaultValueSql("'G'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(128)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.ToTable("staff");

                entity.HasIndex(e => e.AddressId)
                    .HasName("fk_staff_address");

                entity.HasIndex(e => e.StoreId)
                    .HasName("fk_staff_store");

                entity.Property(e => e.StaffId)
                    .HasColumnName("staff_id")
                    .HasColumnType("tinyint(3) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.AddressId)
                    .HasColumnName("address_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("current_timestamp()")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_bin");

                entity.Property(e => e.Picture)
                    .HasColumnName("picture")
                    .HasColumnType("blob");

                entity.Property(e => e.StoreId)
                    .HasColumnName("store_id")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(16)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Staff)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_staff_address");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Staff)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_staff_store");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.ToTable("store");

                entity.HasIndex(e => e.AddressId)
                    .HasName("fk_store_address");

                entity.HasIndex(e => e.ManagerStaffId)
                    .HasName("store_ibfk_1");

                entity.Property(e => e.StoreId)
                    .HasColumnName("store_id")
                    .HasColumnType("tinyint(3) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AddressId)
                    .HasColumnName("address_id")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("current_timestamp()")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ManagerStaffId)
                    .HasColumnName("manager_staff_id")
                    .HasColumnType("tinyint(3) unsigned");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Store)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_store_address");

                entity.HasOne(d => d.ManagerStaff)
                    .WithMany(p => p.StoreNavigation)
                    .HasForeignKey(d => d.ManagerStaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("store_ibfk_1");
            });

            modelBuilder.Entity<VFilmList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_film_list");

                entity.Property(e => e.Actors)
                    .HasColumnName("actors")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasColumnType("varchar(25)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Fid)
                    .HasColumnName("FID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Length)
                    .HasColumnName("length")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(4,2)")
                    .HasDefaultValueSql("'4.99'");

                entity.Property(e => e.Rating)
                    .HasColumnName("rating")
                    .HasColumnType("enum('G','PG','PG-13','R','NC-17')")
                    .HasDefaultValueSql("'G'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(128)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<VNicerButSlowerFilmList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_nicer_but_slower_film_list");

                entity.Property(e => e.Actors)
                    .HasColumnName("actors")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasColumnType("varchar(25)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Fid)
                    .HasColumnName("FID")
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Length)
                    .HasColumnName("length")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(4,2)")
                    .HasDefaultValueSql("'4.99'");

                entity.Property(e => e.Rating)
                    .HasColumnName("rating")
                    .HasColumnType("enum('G','PG','PG-13','R','NC-17')")
                    .HasDefaultValueSql("'G'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(128)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
