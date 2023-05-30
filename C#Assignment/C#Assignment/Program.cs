using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class MovieAssignment
    {

    }
}

class Movie
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal BoxOffice { get; set; }
    public DateTime LaunchDate { get; set; }
}
class Customer
{
    public int Id { get; set; }
    public List<Movie> Favorites { get; set; }
}
class Program
{
    static List<Movie> movies = new List<Movie>();
    static List<Customer> customers = new List<Customer>();
    static void Main(string[] args)
    {
        // Create some movies
        movies.Add(new Movie { Id = 101, Name = "Avatar", BoxOffice = 5000000, LaunchDate = new DateTime(2020, 10, 10) });
        movies.Add(new Movie { Id = 102, Name = "Avenger", BoxOffice = 2000000, LaunchDate = new DateTime(2019, 12, 11) });
        movies.Add(new Movie { Id = 103, Name = "Titanic", BoxOffice = 3000000, LaunchDate = new DateTime(2017, 7, 7) });

        // Create some customers
        customers.Add(new Customer { Id = 201, Favorites = new List<Movie>() });
        customers.Add(new Customer { Id = 202, Favorites = new List<Movie>() });
        customers.Add(new Customer { Id = 203, Favorites = new List<Movie>() });
        bool exit = false;
    Display:
        Console.WriteLine("Specify Your Role :");
        Console.WriteLine("1.Admin");
        Console.WriteLine("2.Customer");
        Console.WriteLine("Enter 1 Or 2");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        if (num == 1)
        {
            while (!exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add a movie");
                Console.WriteLine("2. Remove a movie");
                Console.WriteLine("3. Display all movies");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        AddMovie();
                        break;
                    case "2":
                        RemoveMovie();
                        break;
                    case "3":
                        DisplayMovies();
                        break;
                    case "4":
                        exit = true;
                        goto Display;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
        else if (num == 2)
        {
        Displays:
            Console.WriteLine("Enter the Operaion Performed on the Favourites");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add to the Favourites ");
            Console.WriteLine("2. Remove from the Favourites");
            Console.WriteLine("3. Display Favourites");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter choice: 1 Or 2 Or 3 Or 4");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    AddToFavorites();
                    goto Displays;
                    break;
                case "2":
                    RemoveFromFavorites();
                    goto Displays;
                    break;
                case "3":
                    DisplayCustomerFavorites();
                    goto Displays;
                    break;
                case "4":
                    exit = true;
                    goto Display;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Please Enter Correct Number");
            goto Display;
        }
    }

    static void AddMovie()
    {
        try
        {
            Movie movie = new Movie();

            Console.Write("Enter the movie ID: ");
            movie.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the name of the movie: ");
            movie.Name = Console.ReadLine();

            Console.Write("Enter the box office collection: ");
            movie.BoxOffice = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the launch date (yyyy-MM-dd): ");
            movie.LaunchDate = DateTime.Parse(Console.ReadLine());

            movies.Add(movie);
            Console.WriteLine("Movie added successfully!");
        }
        catch (Exception ex)
        {

        }

    }

    static void RemoveMovie()
    {
        try
        {
            Console.Write("Enter the movie ID to remove: ");
            int movieId = Convert.ToInt32(Console.ReadLine());

            Movie movieToRemove = movies.Find(movie => movie.Id == movieId);
            if (movieToRemove != null)
            {
                movies.Remove(movieToRemove);
                Console.WriteLine("Movie removed successfully!");
            }
            else
            {
                Console.WriteLine("Movie not found.");
            }
        }
        catch (Exception ex)
        {

        }

    }
    //static void AddCustomer()
    //{
    //    Console.Write("Enter your customer ID: ");
    //    int customerId = Convert.ToInt32(Console.ReadLine());

    //    Customer customer = new Customer();

    //}
    static void AddToFavorites()
    {
        try
        {
            Console.Write("Enter your customer ID: ");
            int customerId = Convert.ToInt32(Console.ReadLine());

            Customer customer = customers.Find(cust => cust.Id == customerId);
            //Customer customer = customers.Add(Convert.ToInt32 customerId);
            if (customer != null)
            {
                Console.Write("Enter the movie ID to add to favorites: ");
                int movieId = Convert.ToInt32(Console.ReadLine());

                Movie movieToAdd = movies.Find(movie => movie.Id == movieId);
                if (movieToAdd != null)
                {
                    customer.Favorites.Add(movieToAdd);
                    Console.WriteLine("Movie added to favorites!");
                }
                else
                {
                    Console.WriteLine("Movie not found.");
                }
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
        }
        catch (Exception ex)
        {

        }

    }

    static void RemoveFromFavorites()
    {
        try
        {
            Console.Write("Enter your customer ID: ");
            int customerId = Convert.ToInt32(Console.ReadLine());

            Customer customer = customers.Find(cust => cust.Id == customerId);
            if (customer != null)
            {
                Console.Write("Enter the movie ID to remove from favorites: ");
                int movieId = Convert.ToInt32(Console.ReadLine());

                Movie movieToRemove = customer.Favorites.Find(movie => movie.Id == movieId);
                if (movieToRemove != null)
                {
                    customer.Favorites.Remove(movieToRemove);
                    Console.WriteLine("Movie removed from favorites!");
                }
                else
                {
                    Console.WriteLine("Movie not found in favorites.");
                }
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
        }
        catch (Exception ex)
        {

        }

    }

    static void DisplayMovies()
    {
        try
        {
            if (movies.Count == 0)
            {
                Console.WriteLine("No movies to display.");
            }
            else
            {
                Console.WriteLine("List of movies:");
                Console.WriteLine("***********************************************************************************************************************");
                Console.WriteLine("||     ID       ||               Name               ||           Box Office          ||          Launch Date         ||");
                Console.WriteLine("***********************************************************************************************************************");
                foreach (Movie movie in movies)
                {
                    Console.WriteLine($"||     {movie.Id}     ||              {movie.Name}              ||                 {movie.BoxOffice}         ||              {movie.LaunchDate.ToShortDateString()}         ||");
                }
                Console.WriteLine("*************************************************************************************************************************");
            }
        }
        catch (Exception ex)
        {

        }

    }
    static void DisplayCustomerFavorites()
    {
        try
        {
            Console.Write("Enter your customer ID: ");
            int customerId = Convert.ToInt32(Console.ReadLine());

            Customer customer = customers.Find(cust => cust.Id == customerId);
            if (customer != null)
            {
                if (customer.Favorites.Count == 0)
                {
                    Console.WriteLine("No favorite movies to display.");
                }
                else
                {
                    Console.WriteLine("List of favorite movies:");
                    Console.WriteLine("***********************************************************************************************************************");
                    Console.WriteLine("||     ID       ||               Name               ||           Box Office          ||          Launch Date         ||");
                    Console.WriteLine("***********************************************************************************************************************");
                    foreach (Movie movie in customer.Favorites)
                    {
                        Console.WriteLine($"||     {movie.Id}     ||              {movie.Name}              ||                 {movie.BoxOffice}         ||              {movie.LaunchDate.ToShortDateString()}         ||");
                    }
                    Console.WriteLine("*************************************************************************************************************************");
                }
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
        }
        catch (Exception ex)
        {

        }

    }
}
