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
                    Title = "黄山",
                    Description="黄山真好玩",
                    OriginalPrice = 1299,
                    Features = "<p>吃住行游购娱</p>",
                    Fees = "<p>交通费用自理</p>",
                    Notes="<p>小心危险</p>"
                },
                new Post {
                    Id = Guid.NewGuid(),
                    Title = "华山",
                    Description="华山真好玩",
                    OriginalPrice = 1299,
                    Features = "<p>吃住行游购娱</p>",
                    Fees = "<p>交通费用自理</p>",
                    Notes="<p>小心危险</p>"
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
