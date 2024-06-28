using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Data.Migrations
{
  [DbContext(typeof(ApplicationDbContext))]
  [Migration("00000000000000_CreateIdentitySchema")]
  partial class CreateIdentitySchema
  {
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
      modelBuilder
          .HasAnnotation("ProductVersion", "3.0.0")
          .HasAnnotation("Relational:MaxIdentifierLength", 128);

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
      {
        b.Property<string>("Id")
                  .HasColumnType("TEXT")
                  .IsRequired()
                  .HasMaxLength(450);

        b.Property<string>("ConcurrencyStamp")
                  .HasColumnType("TEXT")
                  .IsConcurrencyToken();

        b.Property<string>("Name")
                  .HasColumnType("TEXT")
                  .HasMaxLength(256);

        b.Property<string>("NormalizedName")
                  .HasColumnType("TEXT")
                  .HasMaxLength(256);

        b.HasKey("Id");

        b.HasIndex("NormalizedName")
                  .IsUnique()
                  .HasDatabaseName("RoleNameIndex")
                  .HasFilter("[NormalizedName] IS NOT NULL");

        b.ToTable("AspNetRoles");
      });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
      {
        b.Property<int>("Id")
                  .ValueGeneratedOnAdd()
                  .HasColumnType("INTEGER");

        b.Property<string>("ClaimType")
                  .HasColumnType("TEXT");

        b.Property<string>("ClaimValue")
                  .HasColumnType("TEXT");

        b.Property<string>("RoleId")
                  .IsRequired()
                  .HasColumnType("TEXT")
                  .HasMaxLength(450);

        b.HasKey("Id");

        b.HasIndex("RoleId");

        b.ToTable("AspNetRoleClaims");
      });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
      {
        b.Property<string>("Id")
                  .HasColumnType("TEXT")
                  .IsRequired()
                  .HasMaxLength(450);

        b.Property<int>("AccessFailedCount")
                  .HasColumnType("INTEGER");

        b.Property<string>("ConcurrencyStamp")
                  .HasColumnType("TEXT")
                  .IsConcurrencyToken();

        b.Property<string>("Email")
                  .HasColumnType("TEXT")
                  .HasMaxLength(256);

        b.Property<bool>("EmailConfirmed")
                  .HasColumnType("INTEGER")
                  .IsRequired();

        b.Property<bool>("LockoutEnabled")
                  .HasColumnType("INTEGER")
                  .IsRequired();

        b.Property<DateTimeOffset?>("LockoutEnd")
                  .HasColumnType("TEXT");

        b.Property<string>("NormalizedEmail")
                  .HasColumnType("TEXT")
                  .HasMaxLength(256);

        b.Property<string>("NormalizedUserName")
                  .HasColumnType("TEXT")
                  .HasMaxLength(256);

        b.Property<string>("PasswordHash")
                  .HasColumnType("TEXT");

        b.Property<string>("PhoneNumber")
                  .HasColumnType("TEXT");

        b.Property<bool>("PhoneNumberConfirmed")
                  .HasColumnType("INTEGER")
                  .IsRequired();

        b.Property<string>("SecurityStamp")
                  .HasColumnType("TEXT");

        b.Property<bool>("TwoFactorEnabled")
                  .HasColumnType("INTEGER")
                  .IsRequired();

        b.Property<string>("UserName")
                  .HasColumnType("TEXT")
                  .HasMaxLength(256);

        b.HasKey("Id");

        b.HasIndex("NormalizedEmail")
                  .HasDatabaseName("EmailIndex");

        b.HasIndex("NormalizedUserName")
                  .IsUnique()
                  .HasDatabaseName("UserNameIndex")
                  .HasFilter("[NormalizedUserName] IS NOT NULL");

        b.ToTable("AspNetUsers");
      });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
      {
        b.Property<int>("Id")
                  .ValueGeneratedOnAdd()
                  .HasColumnType("INTEGER");

        b.Property<string>("ClaimType")
                  .HasColumnType("TEXT");

        b.Property<string>("ClaimValue")
                  .HasColumnType("TEXT");

        b.Property<string>("UserId")
                  .IsRequired()
                  .HasColumnType("TEXT")
                  .HasMaxLength(450);

        b.HasKey("Id");

        b.HasIndex("UserId");

        b.ToTable("AspNetUserClaims");
      });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
      {
        b.Property<string>("LoginProvider")
                  .HasColumnType("TEXT")
                  .IsRequired()
                  .HasMaxLength(128);

        b.Property<string>("ProviderKey")
                  .HasColumnType("TEXT")
                  .IsRequired()
                  .HasMaxLength(128);

        b.Property<string>("ProviderDisplayName")
                  .HasColumnType("TEXT");

        b.Property<string>("UserId")
                  .IsRequired()
                  .HasColumnType("TEXT")
                  .HasMaxLength(450);

        b.HasKey("LoginProvider", "ProviderKey");

        b.HasIndex("UserId");

        b.ToTable("AspNetUserLogins");
      });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
      {
        b.Property<string>("UserId")
                  .HasColumnType("TEXT")
                  .IsRequired()
                  .HasMaxLength(450);

        b.Property<string>("RoleId")
                  .HasColumnType("TEXT")
                  .IsRequired()
                  .HasMaxLength(450);

        b.HasKey("UserId", "RoleId");

        b.HasIndex("RoleId");

        b.ToTable("AspNetUserRoles");
      });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
      {
        b.Property<string>("UserId")
                  .HasColumnType("TEXT")
                  .IsRequired()
                  .HasMaxLength(450);

        b.Property<string>("LoginProvider")
                  .HasColumnType("TEXT")
                  .IsRequired()
                  .HasMaxLength(128);

        b.Property<string>("Name")
                  .HasColumnType("TEXT")
                  .IsRequired()
                  .HasMaxLength(128);

        b.Property<string>("Value")
                  .HasColumnType("TEXT");

        b.HasKey("UserId", "LoginProvider", "Name");

        b.ToTable("AspNetUserTokens");
      });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
      {
        b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                  .WithMany()
                  .HasForeignKey("RoleId")
                  .OnDelete(DeleteBehavior.Cascade)
                  .IsRequired();
      });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
      {
        b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                  .WithMany()
                  .HasForeignKey("UserId")
                  .OnDelete(DeleteBehavior.Cascade)
                  .IsRequired();
      });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
      {
        b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                  .WithMany()
                  .HasForeignKey("UserId")
                  .OnDelete(DeleteBehavior.Cascade)
                  .IsRequired();
      });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
      {
        b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                  .WithMany()
                  .HasForeignKey("RoleId")
                  .OnDelete(DeleteBehavior.Cascade)
                  .IsRequired();

        b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                  .WithMany()
                  .HasForeignKey("UserId")
                  .OnDelete(DeleteBehavior.Cascade)
                  .IsRequired();
      });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
      {
        b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                  .WithMany()
                  .HasForeignKey("UserId")
                  .OnDelete(DeleteBehavior.Cascade)
                  .IsRequired();
      });
    }
  }
}

