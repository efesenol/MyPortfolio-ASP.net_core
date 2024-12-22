using Azure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using MyPage.entity;

namespace MyPage.Data
{
    public class MyPageContext : DbContext
    {
        public MyPageContext(DbContextOptions<MyPageContext> options) : base(options)
        {

        }
        public DbSet<User> Users => Set<User>();

    }
}