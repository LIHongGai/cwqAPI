using cwqAPI.Database;
using cwqAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cwqAPI.Services
{
    /// <summary>
    /// 数据库连接类
    /// </summary>
    public class PostRepository:IPostRepository
    {
        private readonly AppDbContext _context;
        public PostRepository(AppDbContext context)
        {
            _context = context;
        }

        public Post GetPost(Guid PostId)
        {
            //返回单条的帖子
            return _context.posts.FirstOrDefault(n => n.Id == PostId);
        }

        public IEnumerable<Post> GetPosts()
        {
            //返回所有帖子
            return _context.posts;
        }
    }
}
