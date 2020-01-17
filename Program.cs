using System;
using System.Collections.Generic;
using Post.Entities;


namespace Post
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome");

            Postagem p1 = new Postagem(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12
                );

            p1.AddComment(c1);
            p1.AddComment(c2);

            Console.WriteLine(p1);
        }
    }
}
