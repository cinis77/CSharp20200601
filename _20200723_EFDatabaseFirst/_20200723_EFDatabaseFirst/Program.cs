using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200723_EFDatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {

            BloguiEntities1 db = new BloguiEntities1();
            foreach (var item in db.Post)
            {
                Console.WriteLine(item.Tekstas);
            }
            Post post = new Post();
            post.Pavadinimas = "sfsdfsdfasdasdasb    wefsd";
            post.Tekstas = "dasdasdasdasjugejurejreure";
            post.IrasoData = DateTime.Now;
            post.Rasytojas = " ewewr ";

            db.Post.Add(post);
            db.SaveChanges();
        }
    }
}
