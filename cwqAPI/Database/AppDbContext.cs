using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cwqAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace cwqAPI.Database
{
    /// <summary>
    /// 上下文关系类
    /// </summary>
    public class AppDbContext:DbContext
    {
        //注入DbContext实例
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {

        }
        //指明数据模型的映射
        public DbSet<Post> posts { get; set; }  //帖子类
        public DbSet<Petpicture> petpictures { get; set; } //照片类

    }
}
