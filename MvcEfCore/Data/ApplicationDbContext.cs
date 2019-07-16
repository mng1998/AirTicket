using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcEfCore.Models;

namespace MvcEfCore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //public DbSet<Team> Teams { get; set; }
        //public DbSet<Player> Players { get; set; }

        public DbSet<ThamSo> ThamSos { get; set; }
        public DbSet<SanBay> SanBays { get; set; }
       
        public DbSet<LichChuyenBay> LichChuyenBays { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<HangVe> HangVes { get; set; }
        public DbSet<PhieuDatCho> PhieuDatChos { get; set; }
        public DbSet<PhieuDatVe> PhieuDatVes { get; set; }
        public DbSet<ChiTietTrungGian> ChiTietTrungGians { get; set; }
       
    }
}
