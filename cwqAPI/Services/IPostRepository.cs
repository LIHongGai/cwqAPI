using cwqAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cwqAPI.Services
{
    /// <summary>
    /// 数据接口
    /// </summary>
    public  interface IPostRepository
    {
        //返回一组帖子
        IEnumerable<Post> GetPosts();
        //返回单条帖子
        Post GetPost(Guid PostId);
    }
}
