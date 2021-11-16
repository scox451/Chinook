﻿// <auto-generated />
using System;
using Chinook.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Chinook.Core.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211116092154_Reload3")]
    partial class Reload3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                        .HasColumnType("TEXT");

                    b.HasKey("AlbumId");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("Chinook.Core.Models.Artist", b =>
                {
                    b.Property<long>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

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
                        .HasColumnType("NVARCHAR(60)");

                    b.Property<string>("Fax")
                        .HasColumnType("NVARCHAR(24)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("NVARCHAR");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("Phone")
                        .HasColumnType("NVARCHAR(24)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("NVARCHAR(10)");

                    b.Property<byte[]>("RowVersion")
                        .HasColumnType("BLOB");

                    b.Property<string>("State")
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<long>("SupportRepId")
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
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fax")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .HasColumnType("TEXT");

                    b.Property<long>("ReportsTo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("State")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Chinook.Core.Models.Genre", b =>
                {
                    b.Property<long>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("GenreId");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("Chinook.Core.Models.Invoice", b =>
                {
                    b.Property<long>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BillingAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("BillingCity")
                        .HasColumnType("TEXT");

                    b.Property<string>("BillingCountry")
                        .HasColumnType("TEXT");

                    b.Property<string>("BillingPostalCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("BillingState")
                        .HasColumnType("TEXT");

                    b.Property<long>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Total")
                        .HasColumnType("TEXT");

                    b.HasKey("InvoiceId");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("Chinook.Core.Models.InvoiceItem", b =>
                {
                    b.Property<long>("InvoiceItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("InvoiceId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<long>("TrackId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("TEXT");

                    b.HasKey("InvoiceItemId");

                    b.ToTable("InvoiceItem");
                });

            modelBuilder.Entity("Chinook.Core.Models.MediaType", b =>
                {
                    b.Property<int>("MediaTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("MediaTypeId");

                    b.ToTable("MediaType");
                });

            modelBuilder.Entity("Chinook.Core.Models.Playlist", b =>
                {
                    b.Property<int>("PlaylistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

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
                        .HasColumnType("TEXT");

                    b.Property<long>("GenreId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("MediaTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Milliseconds")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("TEXT");

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
