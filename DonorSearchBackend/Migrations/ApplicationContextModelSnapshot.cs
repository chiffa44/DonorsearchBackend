// <auto-generated />
using System;
using DonorSearchBackend.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DonorSearchBackend.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("DonorSearchBackend.DAL.Donation", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Img")
                        .HasColumnType("text");

                    b.Property<DateTime>("appointment_date_from");

                    b.Property<DateTime>("appointment_date_to");

                    b.Property<int>("blood_class_ids");

                    b.Property<int?>("confirm_visitid");

                    b.Property<DateTime?>("donation_date");

                    b.Property<bool?>("donation_success");

                    b.Property<int?>("ds_Id");

                    b.Property<bool>("finished");

                    b.Property<DateTime?>("previous_donation_date");

                    b.Property<DateTime?>("recomendation_timestamp");

                    b.Property<string>("station_address");

                    b.Property<int?>("station_id");

                    b.Property<string>("station_title");

                    b.Property<int>("vk_id");

                    b.HasKey("id");

                    b.HasIndex("confirm_visitid");

                    b.HasIndex("id")
                        .IsUnique();

                    b.ToTable("Donations");
                });

            modelBuilder.Entity("DonorSearchBackend.DAL.User", b =>
                {
                    b.Property<int>("vk_id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("about_self");

                    b.Property<DateTime?>("bdate");

                    b.Property<int>("blood_class_ids");

                    b.Property<string>("blood_type");

                    b.Property<bool?>("bone_marrow");

                    b.Property<bool?>("cant_to_be_donor");

                    b.Property<int?>("city_id");

                    b.Property<string>("city_title");

                    b.Property<DateTime?>("donor_pause_to");

                    b.Property<string>("first_name")
                        .IsRequired();

                    b.Property<int?>("gender");

                    b.Property<bool?>("has_registration");

                    b.Property<bool?>("is_first_donor");

                    b.Property<string>("last_name")
                        .IsRequired();

                    b.Property<string>("maiden_name");

                    b.Property<string>("region_title");

                    b.Property<string>("second_name");

                    b.HasKey("vk_id");

                    b.HasIndex("vk_id")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DonorSearchBackend.DAL.ValidationVisit", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("date_from");

                    b.Property<DateTime?>("date_to");

                    b.Property<bool?>("success");

                    b.Property<DateTime?>("visit_date");

                    b.Property<bool?>("without_donation");

                    b.HasKey("id");

                    b.ToTable("ValidationVisit");
                });

            modelBuilder.Entity("DonorSearchBackend.DAL.Donation", b =>
                {
                    b.HasOne("DonorSearchBackend.DAL.ValidationVisit", "confirm_visit")
                        .WithMany()
                        .HasForeignKey("confirm_visitid");
                });
#pragma warning restore 612, 618
        }
    }
}
