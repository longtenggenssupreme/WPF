using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemo.Client.Models
{
    /// <summary>
    /// 菜品信息
    /// </summary>
    public class Dish
    {
        private string name;
        /// <summary>
        /// 菜品 名称
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string category;
        /// <summary>
        /// 菜品 分类
        /// </summary>
        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        private string comment;

        /// <summary>
        /// 菜品 评论
        /// </summary>
        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        private double score;
        /// <summary>
        /// 菜品 打分
        /// </summary>
        public double Score
        {
            get { return score; }
            set { score = value; }
        }

    }
}
