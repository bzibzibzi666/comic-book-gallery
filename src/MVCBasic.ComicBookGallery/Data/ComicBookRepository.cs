using MVCBasic.ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBasic.ComicBookGallery.Data
{
    public class ComicBookRepository
    {
        public static ComicBook GetComicBook(int id) => GetComicBooks().Where(x => x.Id == id).SingleOrDefault();

        public static List<ComicBook> GetComicBooks()
        {
            return new List<ComicBook>()
            {
                new ComicBook()
                {
                    Id = 1,
                    Title = "The Amazing Spider-Man ",
                    Issue = 700,
                    DescriptionHtml = "<p>Description</p>",
                    Artists = new List<Artist>()
                    {
                        new Artist(){Name="Name One", Role="Role One"},
                        new Artist(){Name="Name Two", Role="Role Two"},
                        new Artist(){Name="NameThree", Role="Role Three"}
                    }
                },
                new ComicBook()
                {
                    Id = 2,
                    Title = "The Amazing Spider-Man ",
                    Issue = 657,
                    DescriptionHtml = "<p><strong>FF: THREE TIE-IN.</strong> Spider-Man visits the FF for a very private wake--just for family.</p>",
                    Artists = new List<Artist>
                    {
                        new Artist() { Name = "Dan Slott", Role = "Script" },
                        new Artist() { Name = "Marcos Martin", Role = "Pencils" },
                        new Artist() { Name = "Marcos Martin", Role = "Inks" },
                        new Artist() { Name = "Muntsa Vicente", Role = "Colors" },
                        new Artist() { Name = "Joe Caramagna", Role = "Letters" }
                    },
                    Favorite = false
                },
                new ComicBook()
                {
                    Id = 3,
                    Title = "Bone ",
                    Issue= 50,
                    DescriptionHtml = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
                    Artists = new List<Artist>
                    {
                        new Artist() { Name = "Jeff Smith", Role = "Script" },
                        new Artist() { Name = "Jeff Smith", Role = "Pencils" },
                        new Artist() { Name = "Jeff Smith", Role = "Inks" },
                        new Artist() { Name = "Jeff Smith", Role = "Letters" }
                    },
                    Favorite = false
                }
            };
        }
    }
}