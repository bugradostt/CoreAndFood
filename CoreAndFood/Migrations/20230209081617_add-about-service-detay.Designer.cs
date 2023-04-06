﻿// <auto-generated />
using CoreAndFood.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreAndFood.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230209081617_add-about-service-detay")]
    partial class addaboutservicedetay
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreAndFood.Models.About", b =>
                {
                    b.Property<int>("AboutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutCommet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutPicture")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AboutId");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("CoreAndFood.Models.AboutList", b =>
                {
                    b.Property<int>("AboutListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutListMadde")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AboutListId");

                    b.ToTable("AboutLists");
                });

            modelBuilder.Entity("CoreAndFood.Models.AboutUser", b =>
                {
                    b.Property<int>("AboutUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutUserJob")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutUserPictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AboutUserId");

                    b.ToTable("AboutUsers");
                });

            modelBuilder.Entity("CoreAndFood.Models.AboutYorum", b =>
                {
                    b.Property<int>("AboutYorumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutYorumCommet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutYorumName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AboutYorumId");

                    b.ToTable("AboutYorums");
                });

            modelBuilder.Entity("CoreAndFood.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Role")
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("UserPassword")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("CoreAndFood.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("CoreAndFood.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactAdress")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ContactMail")
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("ContactMaps")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("ContactPhone")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("CoreAndFood.Models.Food", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("FoodId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("CoreAndFood.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MessageLongMessage")
                        .HasMaxLength(700)
                        .HasColumnType("nvarchar(700)");

                    b.Property<string>("MessageMail")
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("MessageName")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("MessageSubject")
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("MessageSurname")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("MessageId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("CoreAndFood.Models.Service", b =>
                {
                    b.Property<int>("ServicesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ServicesHeadding")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServicesHeaddingDepCommet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServicesHeaddingPicture1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServicesHeaddingPicture2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServicesHeaddingPicture3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServicesMatter1Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServicesMatter1Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServicesMatter2Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServicesMatter2Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServicesMatter3Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServicesMatter3Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServicesMatter4Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServicesMatter4Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServicesMatterPicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServicesWriting1Commet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServicesWriting1Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServicesWriting2Commet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServicesWriting2Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServicesWriting3Commet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServicesWriting3Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServicesId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("CoreAndFood.Models.ServiceList", b =>
                {
                    b.Property<int>("ServiceListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ServiceListMadde")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServiceListId");

                    b.ToTable("ServiceLists");
                });

            modelBuilder.Entity("CoreAndFood.Models.Food", b =>
                {
                    b.HasOne("CoreAndFood.Models.Category", "Category")
                        .WithMany("Foods")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CoreAndFood.Models.Category", b =>
                {
                    b.Navigation("Foods");
                });
#pragma warning restore 612, 618
        }
    }
}