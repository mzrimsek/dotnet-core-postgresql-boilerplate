using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Core.Models.Database;

namespace Core.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20160829170231_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("Core.Models.Database.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Email")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .HasColumnName("firstname");

                    b.Property<string>("LastName")
                        .HasColumnName("lastname");

                    b.Property<string>("Password")
                        .HasColumnName("password");

                    b.HasKey("Id");

                    b.ToTable("user");
                });
        }
    }
}
