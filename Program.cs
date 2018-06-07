using SimpleMethod2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMethod2
{
    public class MovieRep
    {
        private string title;
        public string actors;
        public int people;
        public double avg_rating;

        public List<Review> Reviews { get; set; }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public double Eispraxeis(int people, double ticket)
        {
            double eispraxeis;
            eispraxeis = people * ticket;
            return eispraxeis;

        }

    }

}


public class Review
{
    private int rating;
    private string reviews;

    public int Rating
    {
        get
        {
            return rating;
        }
        set
        {
            if (value >= 1 || value <= 10)
            {
                rating = value;

            }
            rating = 1;
        }
    }
    public string Comments
    {
        get
        {
            return reviews;
        }
        set
        {
            reviews = value;
        }
    }

}

class Program
{

    static void Main(string[] args)
    {
        var list = new List<MovieRep>(12);
        var list1 = new List<Review>(3);

        Review myreview = new Review();
        MovieRep movie = new MovieRep();
        movie.Reviews = new List<Review>();

        movie = new MovieRep();
        movie.Reviews = new List<Review>();

        movie.Title = "Rocky";
        myreview.Rating = 6;
        myreview.Comments = "Good";
        movie.actors = "George";
        movie.people = 30;
        movie.Reviews.Add(myreview);

        movie.Title = "Rocky";
        myreview.Rating = 6;
        myreview.Comments = "Good";
        movie.actors = "George";
        movie.Reviews.Add(myreview);


        movie.Title = "Rocky";
        myreview.Rating = 9;
        myreview.Comments = "Excellent";
        movie.actors = "john";
        movie.Reviews.Add(myreview);
        movie.avg_rating = movie.Reviews.Average(m => m.Rating); //(9 + 6 + 6) / 3;
        movie.Reviews.Average(m => m.Rating);
        list.Add(movie);


        movie = new MovieRep();
        movie.Reviews = new List<Review>();

        movie.Title = "GOT";
        myreview.Rating = 6;
        myreview.Comments = "Good";
        movie.actors = "George";
        movie.Reviews.Add(myreview);
        movie.people = 40;

        movie.Title = "GOT";
        myreview.Rating = 4;
        myreview.Comments = "Not Good";
        movie.actors = "George";
        movie.Reviews.Add(myreview);

        movie.Title = "GOT";
        myreview.Rating = 2;
        myreview.Comments = "Terrible";
        movie.actors = "George";
        movie.Reviews.Add(myreview);
        movie.avg_rating = (9 + 4 + 2) / 3;
        list.Add(movie);

        movie = new MovieRep();
        movie.Reviews = new List<Review>();

        movie.Title = "300";
        myreview.Rating = 6;
        myreview.Comments = "Good";
        movie.actors = "George";
        movie.Reviews.Add(myreview);
        movie.people = 25;

        movie.Title = "300";
        myreview.Rating = 10;
        myreview.Comments = "Excellent";
        movie.actors = "George";
        movie.Reviews.Add(myreview);

        movie.Title = "300";
        myreview.Rating = 5;
        myreview.Comments = "Good";
        movie.actors = "George";
        movie.Reviews.Add(myreview);
        movie.avg_rating = (6 + 10 + 5) / 3;
        list.Add(movie);

        movie = new MovieRep();
        movie.Reviews = new List<Review>();

        movie.Title = "SPARTACUS";
        myreview.Rating = 6;
        myreview.Comments = "Good";
        movie.actors = "George";
        movie.Reviews.Add(myreview);
        movie.people = 28;

        movie.Title = "SPARTACUS";
        myreview.Rating = 8;
        myreview.Comments = "Good";
        movie.actors = "NIKOS";
        movie.Reviews.Add(myreview);

        movie.Title = "SPARTACUS";
        myreview.Rating = 4;
        myreview.Comments = "Not Good";
        movie.actors = "George";
        movie.Reviews.Add(myreview);
        movie.avg_rating = (6 + 8 + 4) / 3;
        list.Add(movie);

        movie = new MovieRep();
        movie.Reviews = new List<Review>();

        movie.Title = "AVENGERS";
        myreview.Rating = 7;
        myreview.Comments = "Good";
        movie.actors = "George";
        movie.Reviews.Add(myreview);
        movie.people = 32;


        movie.Title = "AVENGERS";
        myreview.Rating = 7;
        myreview.Comments = "Good";
        movie.actors = "George";
        movie.Reviews.Add(myreview);


        movie.Title = "AVENGERS";
        myreview.Rating = 7;
        myreview.Comments = "Good";
        movie.actors = "George";
        movie.Reviews.Add(myreview);
        movie.avg_rating = (7 + 7 + 7) / 3;
        list.Add(movie);

        movie = new MovieRep();
        movie.Reviews = new List<Review>();

        movie.Title = "X-MEN";
        myreview.Rating = 6;
        myreview.Comments = "Good";
        movie.actors = "George";
        movie.Reviews.Add(myreview);
        movie.people = 24;

        movie.Title = "X-MEN";
        myreview.Rating = 9;
        myreview.Comments = "EXCELLENT";
        movie.actors = "George";
        movie.Reviews.Add(myreview);

        movie.Title = "X-MEN";
        myreview.Rating = 3;
        myreview.Comments = "Not Good";
        movie.actors = "George";
        movie.Reviews.Add(myreview);
        movie.avg_rating = (6 + 9 + 3) / 3;
        list.Add(movie);

        movie = new MovieRep();
        movie.Reviews = new List<Review>();

        movie.Title = "HUNGER GAMES";
        myreview.Rating = 5;
        myreview.Comments = "Good";
        movie.actors = "ZAZA";
        movie.Reviews.Add(myreview);
        movie.people = 75;

        movie.Title = "HUNGER GAMES";
        myreview.Rating = 5;
        myreview.Comments = "Good";
        movie.actors = "ZAZA";
        movie.Reviews.Add(myreview);

        movie.Title = "HUNGER GAMES";
        myreview.Rating = 5;
        myreview.Comments = "Good";
        movie.actors = "ZAZA";
        movie.Reviews.Add(myreview);
        movie.avg_rating = (5 + 5 + 5) / 3;
        list.Add(movie);

        movie = new MovieRep();
        movie.Reviews = new List<Review>();

        movie.Title = "INTERSTELLAR";
        myreview.Rating = 9;
        myreview.Comments = "EXCELLENT";
        movie.actors = "ZAZA";
        movie.Reviews.Add(myreview);
        movie.people = 70;

        movie.Title = "INTERSTELLAR";
        myreview.Rating = 8;
        myreview.Comments = "Good";
        movie.actors = "ZAZA";
        movie.Reviews.Add(myreview);


        movie.Title = "INTERSTELLAR";
        myreview.Rating = 8;
        myreview.Comments = "Good";
        movie.actors = "ZAZA";
        movie.Reviews.Add(myreview);
        movie.avg_rating = (9 + 8 + 8) / 3;
        list.Add(movie);

        movie = new MovieRep();
        movie.Reviews = new List<Review>();

        movie.Title = "BOYKA";
        myreview.Rating = 8;
        myreview.Comments = "Good";
        movie.actors = "ZAZA";
        movie.Reviews.Add(myreview);
        movie.people = 68;

        movie.Title = "BOYKA";
        myreview.Rating = 4;
        myreview.Comments = "Not Good";
        movie.actors = "ZAZA";
        movie.Reviews.Add(myreview);

        movie.Title = "BOYKA";
        myreview.Rating = 10;
        myreview.Comments = "PERFECT";
        movie.actors = "ZAZA";
        movie.Reviews.Add(myreview);
        movie.avg_rating = (8 + 4 + 10) / 3;
        list.Add(movie);

        movie = new MovieRep();
        movie.Reviews = new List<Review>();

        movie.Title = "FAST AND FURIOUS";
        myreview.Rating = 8;
        myreview.Comments = "Good";
        movie.actors = "ZAZA";
        movie.Reviews.Add(myreview);
        movie.people = 88;

        movie.Title = "FAST AND FURIOUS";
        myreview.Rating = 9;
        myreview.Comments = "VERY Good";
        movie.actors = "ZAZA";
        movie.Reviews.Add(myreview);

        movie.Title = "FAST AND FURIOUS";
        myreview.Rating = 9;
        myreview.Comments = "VERY Good";
        movie.actors = "ZAZA";
        movie.Reviews.Add(myreview);
        movie.avg_rating = (8 + 9 + 9) / 3;
        list.Add(movie);

        movie = new MovieRep();
        movie.Reviews = new List<Review>();

        movie.Title = "JURASSIC PARK";
        myreview.Rating = 8;
        myreview.Comments = "Good";
        movie.actors = "TASOS";
        movie.Reviews.Add(myreview);
        movie.people = 88;

        movie.Title = "JURASSIC PARK";
        myreview.Rating = 8;
        myreview.Comments = "Good";
        movie.actors = "TASOS";
        movie.Reviews.Add(myreview);

        movie.Title = "JURASSIC PARK";
        myreview.Rating = 8;
        myreview.Comments = "Good";
        movie.actors = "TASOS";
        movie.Reviews.Add(myreview);
        movie.avg_rating = (8 + 8 + 8) / 3;
        list.Add(movie);

        movie = new MovieRep();
        movie.Reviews = new List<Review>();

        movie.Title = "PRISON BREAK";
        myreview.Rating = 6;
        myreview.Comments = "Good";
        movie.actors = "LOUKAS";
        movie.Reviews.Add(myreview);
        movie.people = 54;

        movie.Title = "PRISON BREAK";
        myreview.Rating = 3;
        myreview.Comments = "TERRIBLE";
        movie.actors = "LOUKAS";
        movie.Reviews.Add(myreview);

        movie.Title = "PRISON BREAK";
        myreview.Rating = 6;
        myreview.Comments = "Good";
        movie.actors = "LOUKAS";
        movie.Reviews.Add(myreview);
        movie.avg_rating = (6 + 3 + 6) / 3;
        list.Add(movie);

        var sortedList= list.OrderByDescending(x=>x.avg_rating).Take(10).ToList();

        Console.WriteLine("Oi 10 kalyteres tainies einai:");
        Print(sortedList);

        
        void Print(List<MovieRep> input)
        {
            foreach (var item in input)

            Console.WriteLine($"{item.Title} : {item.avg_rating}");

                Console.ReadKey();
        }

    }


}






