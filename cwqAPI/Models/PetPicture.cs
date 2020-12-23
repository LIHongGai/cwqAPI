using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cwqAPI.Models
{
    /// <summary>
    /// 宠物照片类
    /// </summary>
    public class Petpicture
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  //自增类型
        public int Id { get; set; }
        [MaxLength(150)]  //设置长度为150个字符
        public string Url { get; set; }//照片数据
        [ForeignKey("PostId")]  //与Post中的Id相连
        public Guid PostId { get; set; }//外键关系
        public Post post { get; set; } //连接属性
    }
}
