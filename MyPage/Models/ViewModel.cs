using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Hosting;
using MyPage.entity;

namespace MyPage.Models
{
    public class PostsViewModel
    {
        public List<User> Users { get; set; } = new();

        public User? isuser { get; set; }



    }
}
