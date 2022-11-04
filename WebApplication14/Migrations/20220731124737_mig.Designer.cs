﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication10.Model;

namespace WebApplication14.Migrations
{
    [DbContext(typeof(AbbDbcontext))]
    [Migration("20220731124737_mig")]
    partial class mig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication10.Model.Department", b =>
                {
                    b.Property<int>("Departmentid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Departmentaddres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Departmentid");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("WebApplication10.Model.Emp", b =>
                {
                    b.Property<int>("idEmp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Departmentid")
                        .HasColumnType("int");

                    b.Property<string>("addres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("fristname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastnema")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("salary")
                        .HasColumnType("float");

                    b.HasKey("idEmp");

                    b.HasIndex("Departmentid");

                    b.ToTable("Emps");
                });

            modelBuilder.Entity("WebApplication10.Model.Employee_detail", b =>
                {
                    b.Property<int>("Employeedetailid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmpididEmp")
                        .HasColumnType("int");

                    b.Property<int?>("Jopidjobid")
                        .HasColumnType("int");

                    b.Property<string>("job")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("salary")
                        .HasColumnType("float");

                    b.Property<string>("skills")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Employeedetailid");

                    b.HasIndex("EmpididEmp");

                    b.HasIndex("Jopidjobid");

                    b.ToTable("employee_Details");
                });

            modelBuilder.Entity("WebApplication10.Model.Jop", b =>
                {
                    b.Property<int>("jobid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Function")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("jobid");

                    b.ToTable("jops");
                });

            modelBuilder.Entity("WebApplication14.Model.EmpSalary", b =>
                {
                    b.Property<int>("EmpSalaryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Date")
                        .HasColumnType("float");

                    b.Property<int?>("SalaryitemsalaryID")
                        .HasColumnType("int");

                    b.Property<double>("Values")
                        .HasColumnType("float");

                    b.Property<int?>("emploesidEmp")
                        .HasColumnType("int");

                    b.HasKey("EmpSalaryId");

                    b.HasIndex("SalaryitemsalaryID");

                    b.HasIndex("emploesidEmp");

                    b.ToTable("empSalaries");
                });

            modelBuilder.Entity("WebApplication14.Model.Salary", b =>
                {
                    b.Property<int>("itemsalaryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("itemSalary")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("itemsalaryID");

                    b.ToTable("Salarys");
                });

            modelBuilder.Entity("WebApplication10.Model.Emp", b =>
                {
                    b.HasOne("WebApplication10.Model.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("Departmentid");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("WebApplication10.Model.Employee_detail", b =>
                {
                    b.HasOne("WebApplication10.Model.Emp", "Empid")
                        .WithMany("employee_list")
                        .HasForeignKey("EmpididEmp");

                    b.HasOne("WebApplication10.Model.Jop", "Jopid")
                        .WithMany("employee_Details")
                        .HasForeignKey("Jopidjobid");

                    b.Navigation("Empid");

                    b.Navigation("Jopid");
                });

            modelBuilder.Entity("WebApplication14.Model.EmpSalary", b =>
                {
                    b.HasOne("WebApplication14.Model.Salary", "Salary")
                        .WithMany()
                        .HasForeignKey("SalaryitemsalaryID");

                    b.HasOne("WebApplication10.Model.Emp", "emploes")
                        .WithMany()
                        .HasForeignKey("emploesidEmp");

                    b.Navigation("emploes");

                    b.Navigation("Salary");
                });

            modelBuilder.Entity("WebApplication10.Model.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("WebApplication10.Model.Emp", b =>
                {
                    b.Navigation("employee_list");
                });

            modelBuilder.Entity("WebApplication10.Model.Jop", b =>
                {
                    b.Navigation("employee_Details");
                });
#pragma warning restore 612, 618
        }
    }
}