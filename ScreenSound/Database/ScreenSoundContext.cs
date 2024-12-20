﻿using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ScreenSound.Modelos;

namespace ScreenSound.Database
{
    internal class ScreenSoundContext : DbContext
    {
        public DbSet<Artista> Artistas {  get; set; }
        public DbSet<Musica> Musicas { get; set; }
        private string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB" +
            ";Initial Catalog=ScreenSoundV1;Integrated Security=True;Encrypt=False;" +
            "Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString).UseLazyLoadingProxies();
        }
    }
}
