using cwqAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cwqAPI.Services
{
    /// <summary>
    /// 假的数据仓库
    /// </summary>
    public class MockPostRepository : IPostRepository
    {
        private List<Post> _routes;

        public MockPostRepository()
        {
            if (_routes == null)
            {
                InitializePost();
            }
        }

        private void InitializePost()
        {
            _routes = new List<Post>
            {
                new Post {
                    Id = Guid.NewGuid(),
                    Username="狗狗主人",
                    Gender="男",
                    Grade=5,
                    Title = "狗狗已经好几天没吃饭了。",
                    Content="狗狗这几天闷闷不乐的，饭就只吃了一点点，怎么回事。"
                    
                },
                new Post {
                    Id = Guid.NewGuid(),
                    Username="猫咪主人",
                    Gender="女",
                    Grade=5,
                    Title = "猫咪越来越大了。",
                    Content="刚开始养它的时候比拳头还小，喂了一周多已经这么胖了！！"
                }
            };
        }
        public Post GetPost(Guid PostId)
        {
            // linq
            return _routes.FirstOrDefault(n => n.Id == PostId);
        }

        public IEnumerable<Post> GetPosts()
        {
            return _routes;
        }
    }
}
