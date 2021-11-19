﻿// <auto-generated />
using System;
using Chinook.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Chinook.Core.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Chinook.Core.Models.Album", b =>
                {
                    b.Property<long>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("ArtistId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("NVARCHAR(160)");

                    b.HasKey("AlbumId");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("Chinook.Core.Models.Artist", b =>
                {
                    b.Property<long>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(120)");

                    b.HasKey("ArtistId");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("Chinook.Core.Models.Customer", b =>
                {
                    b.Property<long>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("NVARCHAR(70)");

                    b.Property<string>("City")
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<string>("Company")
                        .HasColumnType("NVARCHAR(80)");

                    b.Property<string>("Country")
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(60)");

                    b.Property<string>("Fax")
                        .HasColumnType("NVARCHAR(24)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("Phone")
                        .HasColumnType("NVARCHAR(24)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("NVARCHAR(10)");

                    b.Property<string>("State")
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<long?>("SupportRepId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Chinook.Core.Models.Employee", b =>
                {
                    b.Property<long>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("NVARCHAR(70)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("DATETIME");

                    b.Property<string>("City")
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<string>("Country")
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(60)");

                    b.Property<string>("Fax")
                        .HasColumnType("NVARCHAR(24)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("DATETIME");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("Phone")
                        .HasColumnType("NVARCHAR(24)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("NVARCHAR(10)");

                    b.Property<long>("ReportsTo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("State")
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<string>("Title")
                        .HasColumnType("NVARCHAR(30)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Chinook.Core.Models.Genre", b =>
                {
                    b.Property<long>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(120)");

                    b.HasKey("GenreId");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("Chinook.Core.Models.Invoice", b =>
                {
                    b.Property<long>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BillingAddress")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(70)");

                    b.Property<string>("BillingCity")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<string>("BillingCountry")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<string>("BillingPostalCode")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(10)");

                    b.Property<string>("BillingState")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<long>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Total")
                        .HasColumnType("NUMERIC(10,2)");

                    b.HasKey("InvoiceId");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("Chinook.Core.Models.InvoiceItem", b =>
                {
                    b.Property<long>("InvoiceLineItemId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("InvoiceId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<long>("TrackId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("NUMERIC(10,2)");

                    b.HasKey("InvoiceLineItemId", "InvoiceId");

                    b.ToTable("InvoiceItem");
                });

            modelBuilder.Entity("Chinook.Core.Models.MediaType", b =>
                {
                    b.Property<int>("MediaTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(120)");

                    b.HasKey("MediaTypeId");

                    b.ToTable("MediaType");
                });

            modelBuilder.Entity("Chinook.Core.Models.Playlist", b =>
                {
                    b.Property<int>("PlaylistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(120)");

                    b.HasKey("PlaylistId");

                    b.ToTable("Playlist");
                });

            modelBuilder.Entity("Chinook.Core.Models.PlaylistTrack", b =>
                {
                    b.Property<int>("PlaylistId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("PlaylistId");

                    b.Property<int>("TrackId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("TrackId");

                    b.ToTable("PlaylistTracks");
                });

            modelBuilder.Entity("Chinook.Core.Models.Track", b =>
                {
                    b.Property<int>("TrackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("AlbumId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Bytes")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Composer")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(220)");

                    b.Property<long>("GenreId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("MediaTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Milliseconds")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(200)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("NUMERIC(10,2)");

                    b.HasKey("TrackId");

                    b.HasIndex("AlbumId");

                    b.ToTable("Track");
                });

            modelBuilder.Entity("Chinook.Core.Models.Track", b =>
                {
                    b.HasOne("Chinook.Core.Models.Album", null)
                        .WithMany("Tracks")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Chinook.Core.Models.Album", b =>
                {
                    b.Navigation("Tracks");
                });
#pragma warning restore 612, 618
        }
    }
}
