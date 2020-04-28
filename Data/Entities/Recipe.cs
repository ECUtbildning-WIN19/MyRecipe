using Microsoft.AspNetCore.Identity;
using MyRecipe.Models.Domain;
using System;

namespace MyRecipe.Data.Entities
{
    public class Recipe
    {
        public Recipe(string title, string description, Uri imageUrl, string instructions, DateTime createdAt, DateTime? publishedAt)
        {
            Title = title;
            Description = description;
            ImageUrl = imageUrl;
            Instructions = instructions;
            CreatedAt = createdAt;
            PublishedAt = publishedAt;
        }

        public Recipe(string title, string description, Uri imageUrl, string instructions, DateTime createdAt, DateTime? publishedAt, ApplicationUser createdBy)
        {
            Title = title;
            Description = description;
            ImageUrl = imageUrl;
            Instructions = instructions;
            CreatedAt = createdAt;
            PublishedAt = publishedAt;
            CreatedBy = createdBy;
        }

        // TODO: Handle this properly at some point in time... = ) 
        public Recipe()
        {

        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Uri ImageUrl { get; set; }

        public string Instructions { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? PublishedAt { get; set; }

        public ApplicationUser CreatedBy { get; set; }

        public RecipeState State { get; set; } = RecipeState.Draft;
    }
}
