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
    [Migration("20211116072617_Reload")]
    partial class Reload
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
                        .HasMaxLength(70)
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<string>("Company")
                        .HasMaxLength(80)
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<string>("Fax")
                        .HasMaxLength(24)
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasMaxLength(24)
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("RowVersion")
                        .HasColumnType("BLOB");

                    b.Property<string>("State")
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

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
