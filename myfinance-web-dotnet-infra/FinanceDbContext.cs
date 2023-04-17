﻿using Microsoft.EntityFrameworkCore;
using myfinance_web_dotnet_domain.Entities;

namespace myfinance_web_dotnet_infra;
public class FinanceDbContext : DbContext
{
    public DbSet<PlanoConta> PlanoConta { get; set; }
    public DbSet<Transacao> Transacao { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=myfinance;User Id=myUsername;Password=myPassword;");
    }

}
