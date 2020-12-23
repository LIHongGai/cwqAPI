using cwqAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cwqAPI.Controllers
{
    /// <summary>
    /// 控制器
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        //创建数据仓库的私有变量
        private IPostRepository _postRepository;

        //构建函数，注入数据仓库服务
        public PostsController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        //使用数据仓库，并提取所有帖子的信息
        public IActionResult GerPosts()
        {
            var routes = _postRepository.GetPosts();
            return Ok(routes);
        }
    }
}
