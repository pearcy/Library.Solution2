using System.Collections.Generic;
using System.ComponentModel;

namespace Library.Models
{
  public class Author
  {
    public Author()
    {
      this.Books = new HashSet<AuthorBook>();
    }

    public int AuthorId { get; set; }

    [DisplayName("Name")]
    public string AuthorName { get; set; }

    public virtual ICollection<AuthorBook> Books { get; set; }
  }
}