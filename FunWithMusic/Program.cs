using System;
namespace music
{
    class Program
    {
        enum Genre
        {
            Pop,
            Rap,
            Rock,
            Indie,
            Funk
        }
        struct Music
        {
            private string _Title;
            private string _Artist;
            private string _Album;
            private double _Length;
            private Genre? _Genre;

            public Music(string title, string artist, string album, double length, Genre genre)
            {
                _Title = title;
                _Artist = artist;
                _Album = album;
                _Length = length;
                _Genre = genre;
            }
            public void setTitle(string title)
            {
                _Title = title;
            }
            public void setLength(double length)
            {
                _Length = length;
            }
            public void setGenre(Genre genre)
            {
                _Genre = genre;
            }
            public string Display()
            {
                return "Title: " + _Title + "\nAlbum: " + _Album +
                    "\nArtist: " + _Artist + "\nLength: " + _Length +
                    "\nGenre: " + _Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is the title of your favorite song?");
            string tempTitle=Console.ReadLine();
            Console.WriteLine("What is the artist?");
            string tempArtist=Console.ReadLine();
            Console.WriteLine("What is the album?");
            string tempAlbum=Console.ReadLine();
            Console.WriteLine("What is the song length?");
            double tempLength=double.Parse(Console.ReadLine());
            Console.WriteLine("What is the genre?");
            Console.WriteLine("A - Pop\nH - Rap\nS - Rock\nR - Indie\nD - Funk");
            Genre tempGenre=Genre.Pop;
            char g = char.Parse(Console.ReadLine());
            switch(g)
            {
                case 'A':
                    tempGenre = Genre.Pop; 
                    break;
                case 'H':
                    tempGenre = Genre.Rap;
                    break;
                case 'S':
                    tempGenre = Genre.Rock;
                    break;
                case 'R':
                    tempGenre = Genre.Indie;
                    break;
                case 'D':
                    tempGenre = Genre.Funk;
                    break;
            }
            Music music = new Music(tempTitle,tempArtist,tempAlbum,tempLength,tempGenre);
            Music newMusic = music;
            newMusic.setTitle("channel orange");
            newMusic.setLength(9.52);
            //Printing the new movie
            Console.WriteLine("Here's movie #2");
            Console.WriteLine($"{newMusic.Display()}");
            Console.WriteLine();
            //Printing the original
            Console.WriteLine("Here's movie #1");
            Console.WriteLine($"{music.Display()}");
        }
    }
}