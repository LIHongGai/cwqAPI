using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cwqAPI.Models
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Title { get; set; }//标题
        public string Content { get; set; }//内容
        public string Username { get; set; }//用户名
        public DateTime Pubdate { get; set; }//发布时间
        public bool Gender { get; set; } //性别
        public int Grade { get; set; } //等级
        
        public ICollection<Petpicture> petpictures { get; set; }//外键关系

    }
}
