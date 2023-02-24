using Mvc7_Razor.Models;
using Microsoft.EntityFrameworkCore;

namespace Mvc7_Razor.Data
{
    public class CardContext : DbContext
    {
        public CardContext(DbContextOptions<CardContext> options)
            : base(options)
        {
        }

        public DbSet<Card> Card { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>().HasData(
                    new Card { Id = 1, Name = "Elon Musk", Brief = "特斯拉創辦人 伊隆·馬斯克", Photo = "ElonMusk.jpg", WikiUrl = "https://goo.gl/46xeXx" },
                    new Card { Id = 2, Name = "Mark Zuckerberg", Brief = "Facebook馬克·祖伯克", Photo = "MarkZuckerberg.jpg", WikiUrl = "https://goo.gl/BktGGA" },
                    new Card { Id = 3, Name = "Steve Jobs", Brief = "蘋果創辦人 史提夫·賈伯斯", Photo = "SteveJobs.jpg", WikiUrl = "https://goo.gl/nAiX0y" },
                    new Card { Id = 4, Name = "Vader", Brief = "帝國元帥  維達", Photo = "Vader.jpg", WikiUrl = "http://bit.ly/3F5xw2w" },
                    new Card { Id = 5, Name = "Darth Mual", Brief = "星際大戰 達斯摩", Photo = "DarthMual.jpg", WikiUrl = "https://goo.gl/5obLhX" },
                    new Card { Id = 6, Name = "White Twilek", Brief = "星際大戰 女絕地武士Twilek", Photo = "WhiteTwilek.jpg", WikiUrl = "https://goo.gl/reKzAu" },
                    new Card { Id = 7, Name = "Obiwan", Brief = "星際大戰 歐比旺Obiwan", Photo = "Obiwan.jpg", WikiUrl = "http://bit.ly/33gxdgt" },
                    new Card { Id = 8, Name = "Merkel", Brief = "德國總理 梅克爾", Photo = "Merkel.jpg", WikiUrl = "http://bit.ly/33huSlv" }
                );
        }


        public DbSet<Student> Student { get; set; }
    }
}
