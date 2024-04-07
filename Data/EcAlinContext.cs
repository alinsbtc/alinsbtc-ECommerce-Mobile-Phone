using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using E_Commerce_Mobile_Phone.ViewModels;

namespace E_Commerce_Mobile_Phone.Data;

public partial class EcAlinContext : DbContext
{
    public EcAlinContext()
    {
    }

    public EcAlinContext(DbContextOptions<EcAlinContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DbCategory> DbCategories { get; set; }

    public virtual DbSet<DbConfig> DbConfigs { get; set; }

    public virtual DbSet<DbContact> DbContacts { get; set; }

    public virtual DbSet<DbContent> DbContents { get; set; }

    public virtual DbSet<DbCustomer> DbCustomers { get; set; }

    public virtual DbSet<DbOrder> DbOrders { get; set; }

    public virtual DbSet<DbOrderdetail> DbOrderdetails { get; set; }

    public virtual DbSet<DbProducer> DbProducers { get; set; }

    public virtual DbSet<DbProduct> DbProducts { get; set; }

    public virtual DbSet<DbUser> DbUsers { get; set; }

    public virtual DbSet<DbUsergroup> DbUsergroups { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-PDE9TC1I\\SQLEXPRESS;Initial Catalog=Ec_Alin;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DbCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_category");

            entity.ToTable("db_category");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Access)
                .HasDefaultValue(true)
                .HasColumnName("access");
            entity.Property(e => e.Color)
                .HasMaxLength(7)
                .HasColumnName("color");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasColumnName("created_by");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.Link)
                .HasMaxLength(255)
                .HasColumnName("link");
            entity.Property(e => e.Metadesc)
                .HasMaxLength(155)
                .HasColumnName("metadesc");
            entity.Property(e => e.Metakey)
                .HasMaxLength(155)
                .HasColumnName("metakey");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Orders)
                .HasMaxLength(5)
                .HasColumnName("orders");
            entity.Property(e => e.Parentid).HasColumnName("parentid");
            entity.Property(e => e.Status)
                .HasDefaultValue(true)
                .HasColumnName("status");
            entity.Property(e => e.Trash)
                .HasDefaultValue(true)
                .HasColumnName("trash");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<DbConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__db_confi__3213E83FF796B5E8");

            entity.ToTable("db_config");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Keyword).HasColumnName("keyword");
            entity.Property(e => e.MailInfo)
                .HasMaxLength(64)
                .HasColumnName("mail_info");
            entity.Property(e => e.MailNoreply)
                .HasMaxLength(64)
                .HasColumnName("mail_noreply");
            entity.Property(e => e.MailPassword)
                .HasMaxLength(64)
                .HasColumnName("mail_password");
            entity.Property(e => e.MailPort).HasColumnName("mail_port");
            entity.Property(e => e.MailSmtp)
                .HasMaxLength(64)
                .HasColumnName("mail_smtp");
            entity.Property(e => e.PriceShip).HasColumnName("priceShip");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnName("title");
        });

        modelBuilder.Entity<DbContact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__db_conta__3213E83F71D5068A");

            entity.ToTable("db_contact");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContactView)
                .HasDefaultValue(1)
                .HasColumnName("contact_view");
            entity.Property(e => e.Content)
                .HasMaxLength(255)
                .HasColumnName("content");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Fullname)
                .HasMaxLength(80)
                .HasColumnName("fullname");
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .HasColumnName("phone");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.Trash)
                .HasDefaultValue(1)
                .HasColumnName("trash");
        });

        modelBuilder.Entity<DbContent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__db_conte__3213E83F3907E449");

            entity.ToTable("db_content");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Access)
                .HasDefaultValue(true)
                .HasColumnName("access");
            entity.Property(e => e.Alias)
                .HasMaxLength(255)
                .HasColumnName("alias");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasDefaultValue("Super Admin")
                .HasColumnName("created_by");
            entity.Property(e => e.Fulltext).HasColumnName("fulltext");
            entity.Property(e => e.Img)
                .HasMaxLength(255)
                .HasColumnName("img");
            entity.Property(e => e.Introtext).HasColumnName("introtext");
            entity.Property(e => e.Metadesc)
                .HasMaxLength(155)
                .HasColumnName("metadesc");
            entity.Property(e => e.Metakey)
                .HasMaxLength(155)
                .HasColumnName("metakey");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .HasDefaultValue("Super Admin")
                .HasColumnName("modified_by");
            entity.Property(e => e.Status)
                .HasDefaultValue(true)
                .HasColumnName("status");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.Trash)
                .HasDefaultValue(true)
                .HasColumnName("trash");
        });

        modelBuilder.Entity<DbCustomer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__db_custo__3213E83FF5DB3639");

            entity.ToTable("db_customer");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Access)
                .HasDefaultValue(true)
                .HasColumnName("access");
            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .HasColumnName("address");
            entity.Property(e => e.Birthday).HasColumnName("birthday");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Fullname)
                .HasMaxLength(100)
                .HasColumnName("fullname");
            entity.Property(e => e.Gender).HasColumnName("gender");
            entity.Property(e => e.Password)
                .HasMaxLength(32)
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(13)
                .HasColumnName("phone");
            entity.Property(e => e.Status)
                .HasDefaultValue(true)
                .HasColumnName("status");
            entity.Property(e => e.Trash)
                .HasDefaultValue(true)
                .HasColumnName("trash");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .HasColumnName("username");
        });

        modelBuilder.Entity<DbOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__db_order__3213E83FD3AF2FEE");

            entity.ToTable("db_order");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.Customerid).HasColumnName("customerid");
            entity.Property(e => e.District).HasColumnName("district");
            entity.Property(e => e.Fullname)
                .HasMaxLength(100)
                .HasColumnName("fullname");
            entity.Property(e => e.Money).HasColumnName("money");
            entity.Property(e => e.OrderCode)
                .HasMaxLength(6)
                .HasColumnName("orderCode");
            entity.Property(e => e.Orderdate)
                .HasColumnType("datetime")
                .HasColumnName("orderdate");
            entity.Property(e => e.Phone)
                .HasMaxLength(100)
                .HasColumnName("phone");
            entity.Property(e => e.Province).HasColumnName("province");
            entity.Property(e => e.Status)
                .HasDefaultValue(true)
                .HasColumnName("status");
            entity.Property(e => e.Trash)
                .HasDefaultValue(true)
                .HasColumnName("trash");

            entity.HasOne(d => d.Customer).WithMany(p => p.DbOrders)
                .HasForeignKey(d => d.Customerid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_order_customer");
        });

        modelBuilder.Entity<DbOrderdetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__db_order__3213E83FD59C8E12");

            entity.ToTable("db_orderdetail");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.Orderid).HasColumnName("orderid");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Productid).HasColumnName("productid");
            entity.Property(e => e.Status)
                .HasDefaultValue(true)
                .HasColumnName("status");
            entity.Property(e => e.Trash)
                .HasDefaultValue(true)
                .HasColumnName("trash");

            entity.HasOne(d => d.Order).WithMany(p => p.DbOrderdetails)
                .HasForeignKey(d => d.Orderid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_orderdetail_order");

            entity.HasOne(d => d.Product).WithMany(p => p.DbOrderdetails)
                .HasForeignKey(d => d.Productid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_orderdetail_product");
        });

        modelBuilder.Entity<DbProducer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__db_produ__3213E83FB7CB757A");

            entity.ToTable("db_producer");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Keyword)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("keyword");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Trash)
                .HasDefaultValue(1)
                .HasColumnName("trash");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.DbProducerCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_producer_user_created");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.DbProducerModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_producer_user_modified");
        });

        modelBuilder.Entity<DbProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__db_produ__3213E83F884DE7D3");

            entity.ToTable("db_product");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Access)
                .HasDefaultValue((byte)1)
                .HasColumnName("access");
            entity.Property(e => e.Alias)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("alias");
            entity.Property(e => e.Avatar)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("avatar");
            entity.Property(e => e.Catid).HasColumnName("catid");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("HDL")
                .HasColumnName("created_by");
            entity.Property(e => e.Detail)
                .HasColumnType("text")
                .HasColumnName("detail");
            entity.Property(e => e.Img)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("img");
            entity.Property(e => e.Metadesc)
                .HasMaxLength(155)
                .IsUnicode(false)
                .HasColumnName("metadesc");
            entity.Property(e => e.Metakey)
                .HasMaxLength(155)
                .IsUnicode(false)
                .HasColumnName("metakey");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("HDL")
                .HasColumnName("modified_by");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Number).HasColumnName("number");
            entity.Property(e => e.NumberBuy).HasColumnName("number_buy");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.PriceSale).HasColumnName("price_sale");
            entity.Property(e => e.Producer)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("producer");
            entity.Property(e => e.Sale)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("sale");
            entity.Property(e => e.SortDesc)
                .HasColumnType("text")
                .HasColumnName("sortDesc");
            entity.Property(e => e.Status)
                .HasDefaultValue((byte)1)
                .HasColumnName("status");
            entity.Property(e => e.Trash)
                .HasDefaultValue((byte)1)
                .HasColumnName("trash");

            entity.HasOne(d => d.Cat).WithMany(p => p.DbProducts)
                .HasForeignKey(d => d.Catid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_product_category");
        });

        modelBuilder.Entity<DbUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__db_user__3213E83FC1450ED0");

            entity.ToTable("db_user");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Access)
                .HasDefaultValue((byte)1)
                .HasColumnName("access");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Fullname)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("fullname");
            entity.Property(e => e.Gender).HasColumnName("gender");
            entity.Property(e => e.Img)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("img");
            entity.Property(e => e.Password)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Role).HasColumnName("role");
            entity.Property(e => e.Status)
                .HasDefaultValue((byte)1)
                .HasColumnName("status");
            entity.Property(e => e.Trash)
                .HasDefaultValue((byte)1)
                .HasColumnName("trash");
            entity.Property(e => e.Username)
                .HasMaxLength(225)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<DbUsergroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__db_userg__3213E83F44AF81DE");

            entity.ToTable("db_usergroup");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Access)
                .HasDefaultValue((byte)1)
                .HasColumnName("access");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Status)
                .HasDefaultValue((byte)1)
                .HasColumnName("status");
            entity.Property(e => e.Trash)
                .HasDefaultValue((byte)1)
                .HasColumnName("trash");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

public DbSet<E_Commerce_Mobile_Phone.ViewModels.RegisterVM> RegisterVM { get; set; } = default!;
}
