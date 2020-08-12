using System.Collections.Generic;
using System.ComponentModel;

namespace Library.Models
{
  public class Book
  {
    public Book()
    {
      this.Authors = new HashSet<AuthorBook>();
      this.Patrons = new HashSet<BookPatron>(); // Patrons who have currently checked out this book, length must be less than CopyCount to checkout
    }
    public int BookId { get; set; }

    public int CopyCount { get; set; }

    [DisplayName("Book Title")]
    public string BookTitle { get; set; }

    [DisplayName("Genre")]
    public string BookGenre { get; set; }

    public int CopiesAvailable()
    {
      return this.CopyCount - this.Patrons.Count;
    }

    public virtual ICollection<AuthorBook> Authors { get; set; }

    public virtual ICollection<BookPatron> Patrons { get; set; }
  }
}