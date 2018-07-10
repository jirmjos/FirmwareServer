﻿// <auto-generated />
using System;
using FirmwareServer.EntityLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FirmwareServer.EntityLayer.Migrations
{
    [DbContext(typeof(Database))]
    partial class DatabaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799");

            modelBuilder.Entity("FirmwareServer.EntityLayer.Models.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApMac");

                    b.Property<int?>("ChipSize");

                    b.Property<int>("ChipType");

                    b.Property<DateTimeOffset>("Created");

                    b.Property<int?>("CurrentFirmwareId");

                    b.Property<int?>("DeviceTypeId");

                    b.Property<int?>("FirmwareId");

                    b.Property<int?>("FreeSpace");

                    b.Property<DateTimeOffset>("LastOnline");

                    b.Property<string>("Name");

                    b.Property<string>("SdkVersion");

                    b.Property<string>("StaMac");

                    b.Property<string>("Version");

                    b.HasKey("Id");

                    b.ToTable("Device");
                });

            modelBuilder.Entity("FirmwareServer.EntityLayer.Models.DeviceLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("Created");

                    b.Property<int?>("DeviceId");

                    b.Property<int>("Level");

                    b.Property<string>("Message");

                    b.HasKey("Id");

                    b.ToTable("DeviceLog");
                });

            modelBuilder.Entity("FirmwareServer.EntityLayer.Models.DeviceType", b =>
                {
                    b.Property<int>("Id");

                    b.Property<bool>("Active");

                    b.Property<int>("ChipType");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("DeviceType");
                });

            modelBuilder.Entity("FirmwareServer.EntityLayer.Models.Firmware", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("Created");

                    b.Property<byte[]>("Data");

                    b.Property<string>("Description");

                    b.Property<int>("DeviceTypeId");

                    b.Property<string>("Filename");

                    b.Property<string>("MD5");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Firmware");
                });
#pragma warning restore 612, 618
        }
    }
}