#region license
// <copyright company="ZAN LLC" file="Author.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion
namespace BookService.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The author.
    /// </summary>
    public class Author
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}