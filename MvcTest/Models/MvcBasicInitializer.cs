using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcTest.Models
{
    public class MvcBasicInitializer:DropCreateDatabaseAlways<MvcBasicContext>
    {
        protected override void Seed(MvcBasicContext context)
        {
            var members = new List<Member>{
                new Member{
                    Name = "山田 リオ",
                    Email = "",
                    Birth = DateTime.Parse("1980-06-25"),
                    Married = false,
                    Memo = "ピアノが大好き"
                },
                new Member{
                    Name = "日尾直弘",
                    Email = "test@test.com",
                    Birth = DateTime.Parse("1955-8-21"),
                    Married = true,
                    Memo = "釣りが好き"
                }
            };
            members.ForEach(m => context.Members.Add(m));
            context.SaveChanges();
        }
    }
}