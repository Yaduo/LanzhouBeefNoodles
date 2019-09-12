using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (context.Noodles.Any())
            {
                return;
            }

            context.AddRange
            (
                new Noodle { Name = "毛细", Price = 12, ShortDescription = "如发丝般细", LongDescription = "真的好细好细好细啊", ImageUrl = "/images/毛细.png" },
                new Noodle { Name = "细", Price = 10, ShortDescription = "普通细", LongDescription = "还是挺细的", ImageUrl = "/images/细.png" },
                new Noodle { Name = "三细", Price = 11, ShortDescription = "有点粗了", LongDescription = "比细的粗点，比二细细点", ImageUrl = "/images/三细.png" },
                new Noodle { Name = "二细", Price = 10, ShortDescription = "粗了", LongDescription = "粗的才有嚼劲", ImageUrl = "/images/二细.png" },
                new Noodle { Name = "二柱子", Price = 11, ShortDescription = "太粗了", LongDescription = "粗得快咬不动了", ImageUrl = "/images/二柱子.png" },
                new Noodle { Name = "韭叶子", Price = 12, ShortDescription = "扁的", LongDescription = "韭猜叶一样宽", ImageUrl = "/images/韭叶子.png" },
                new Noodle { Name = "薄宽", Price = 11, ShortDescription = "开始宽了", LongDescription = "比韭叶宽一点，比大宽窄一点", ImageUrl = "/images/薄宽.png" },
                new Noodle { Name = "大宽", Price = 10, ShortDescription = "裤带面", LongDescription = "比嘴还宽了", ImageUrl = "/images/大宽.png" },
                new Noodle { Name = "荞麦棱子", Price = 15, ShortDescription = "立方体的", LongDescription = "好像知道师傅怎么拉出来的", ImageUrl = "/images/荞麦棱子.png" },
                new Noodle { Name = "一窝丝", Price = 15, ShortDescription = "这是啥", LongDescription = "我也没吃过", ImageUrl = "/images/一窝丝.png" }

            );

            context.SaveChanges();
        }
    }
}
