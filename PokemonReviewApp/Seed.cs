﻿using PokemonReviewApp.Data;
using PokemonReviewApp.Models;

namespace PokemonReviewApp;

public class Seed
{
    private readonly DataContext _dataContext;

    public Seed(DataContext context)
    {
        _dataContext = context;
    }

    public void SeedDataContext()
    {
        if (_dataContext.PokemonOwners.Any())
        {
            return;
        }

        var pokemonOwner1 = new PokemonOwner
        {
            Pokemon = new Pokemon
            {
                Name = "Pikachu",
                BirthDate = new DateTime(1903, 1, 1),
                PokemonCategories = new List<PokemonCategory>()
                {
                    new() { Category = new Category { Name = "Electric"} }
                },
                Reviews = new List<Review>()
                {
                    new Review
                    {
                        Title="Pikachu", Text = "Pickahu is the best pokemon, because it is electric", Rating = 5,
                        Reviewer = new Reviewer { FirstName = "Teddy", LastName = "Smith" }
                    },
                    new Review
                    {
                        Title="Pikachu", Text = "Pickachu is the best a killing rocks", Rating = 5,
                        Reviewer = new Reviewer { FirstName = "Taylor", LastName = "Jones" }
                    },
                    new Review
                    {
                        Title="Pikachu", Text = "Pickchu, pickachu, pikachu", Rating = 1,
                        Reviewer = new Reviewer { FirstName = "Jessica", LastName = "McGregor" }
                    },
                }
            },
            Owner = new Owner
            {
                FirstName = "Jack",
                LastName = "London",
                Gym = "Brocks Gym",
                Country = new Country
                {
                    Name = "Kanto"
                }
            }
        };

        var pokemonOwner2 = new PokemonOwner
        {
            Pokemon = new Pokemon
            {
                Name = "Squirtle",
                BirthDate = new DateTime(1903, 1, 1),
                PokemonCategories = new List<PokemonCategory>()
                {
                    new PokemonCategory { Category = new Category { Name = "Water"} }
                },
                Reviews = new List<Review>()
                {
                    new Review { Title= "Squirtle", Text = "squirtle is the best pokemon, because it is electric", Rating = 5,
                    Reviewer = new Reviewer{ FirstName = "Teddy", LastName = "Smith" } },
                    new Review { Title= "Squirtle",Text = "Squirtle is the best a killing rocks", Rating = 5,
                    Reviewer = new Reviewer{ FirstName = "Taylor", LastName = "Jones" } },
                    new Review { Title= "Squirtle", Text = "squirtle, squirtle, squirtle", Rating = 1,
                    Reviewer = new Reviewer{ FirstName = "Jessica", LastName = "McGregor" } },
                }
            },
            Owner = new Owner
            {
                FirstName = "Harry",
                LastName = "Potter",
                Gym = "Mistys Gym",
                Country = new Country
                {
                    Name = "Saffron City"
                }
            }
        };

        var pokemonOwner3 = new PokemonOwner
        {
            Pokemon = new Pokemon
            {
                Name = "Venasuar",
                BirthDate = new DateTime(1903, 1, 1),
                PokemonCategories = new List<PokemonCategory>()
                {
                    new PokemonCategory { Category = new Category { Name = "Leaf"}}
                },
                Reviews = new List<Review>()
                {
                    new Review { Title="Veasaur",Text = "Venasuar is the best pokemon, because it is electric", Rating = 5,
                    Reviewer = new Reviewer{ FirstName = "Teddy", LastName = "Smith" } },
                    new Review { Title="Veasaur",Text = "Venasuar is the best a killing rocks", Rating = 5,
                    Reviewer = new Reviewer{ FirstName = "Taylor", LastName = "Jones" } },
                    new Review { Title="Veasaur",Text = "Venasuar, Venasuar, Venasuar", Rating = 1,
                    Reviewer = new Reviewer{ FirstName = "Jessica", LastName = "McGregor" } },
                }
            },
            Owner = new Owner
            {
                FirstName = "Ash",
                LastName = "Ketchum",
                Gym = "Ashs Gym",
                Country = new Country
                {
                    Name = "Millet Town"
                }
            }
        };

        _dataContext.PokemonOwners.AddRange(new[] { pokemonOwner1, pokemonOwner2, pokemonOwner3 });
        _dataContext.SaveChanges();
    }
}
