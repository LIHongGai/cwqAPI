using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace cwqAPI.Models
{
    /// <summary>
    /// 帖子类
    /// </summary>
    public class Post
    {
        [Key]  //主键信息
        public Guid Id { get; set; }
        [Required]  //不能为空
        [MaxLength(50)] //设为50个字符 
        public string Title { get; set; }//标题
        [MaxLength] //设置为字符串最大限定格式
        public string Content { get; set; }//内容
        [Required]  //不能为空
        [MaxLength(10)] //设为10个字符 
        public string Username { get; set; }//用户名
        public DateTime Pubdate { get; set; }//发布时间
        
        public string Gender { get; set; } //性别
        public int Grade { get; set; } //等级

        public ICollection<Petpicture> petpictures { get; set; }//外键关系
        = new List<Petpicture>();

    }
}
