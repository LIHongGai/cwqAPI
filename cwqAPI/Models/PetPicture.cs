using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cwqAPI.Models
{
    /// <summary>
    /// 宠物照片类
    /// </summary>
    public class Petpicture
    {
        public int Id { get; set; }
        public string Url { get; set; }//照片数据
        public Guid PostId { get; set; }//外键关系
        public Post post { get; set; } //连接属性
    }
}
