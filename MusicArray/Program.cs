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
            public void setArtist(string artist)
            {
                _Artist = artist;
            }
            public void setAlbum(string album)
            {
                _Album = album;
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
            Console.WriteLine("How many songs would you like to enter?");
            int size = int.Parse(Console.ReadLine());
            Music[] collection = new Music[size];
            try{
                for (int i=0; i < size; i++){
                    Console.WriteLine("Please enter the song title?");
                    collection[i].setTitle(Console.ReadLine());
                    Console.WriteLine("What is the artist?");
                    collection[i].setArtist(Console.ReadLine());
                    Console.WriteLine("What is the album?");
                    collection[i].setAlbum(Console.ReadLine());
                    Console.WriteLine("What is the song length?");
                    collection[i].setLength(Console.ReadLine());
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
                    collection[i].setGenre(temGenre);
                }
                catch(ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    for (int i = 0; i < size; i++)
                    {
                        Console.WriteLine($"{collection[i].Display()}");
                    }
                }

            }
        }
    }
}