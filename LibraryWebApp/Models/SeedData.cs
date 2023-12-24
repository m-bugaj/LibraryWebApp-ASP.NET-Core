using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LibraryWebApp.Data;
using System;
using System.Linq;

namespace LibraryWebApp.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new LibraryWebAppContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<LibraryWebAppContext>>()))
        {
            // Look for any movies.
            if (context.Book.Any())
            {
                return;   // DB has been seeded
            }
            context.Book.AddRange(
                new Book
                {
                    Title = "W pustyni i w puszczy",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Adventure",
                    Price = 7.99M
                },
                new Book
                {
                    Title = "Krzyżacy",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Historical",
                    Price = 8.99M
                },
                new Book
                {
                    Title = "Harry Potter i więzień Azkabanu",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Fantasy",
                    Price = 9.99M
                },
                new Book
                {
                    Title = "Hobbit",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Fantasy",
                    Price = 9.99M
                }
            );
            context.SaveChanges();
        }
    }
}