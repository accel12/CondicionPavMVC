using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CondicionPavMVC.Models;

public partial class CrudBdContext : DbContext
{
    public CrudBdContext()
    {
    }

    public CrudBdContext(DbContextOptions<CrudBdContext> options)
        : base(options)
    {
    }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=DESKTOP-K4JT48O\\SQLEXPRESS01; Database=CrudBD; Trusted_Connection=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {



        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
