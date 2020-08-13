using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Library.Models
{
  public class Patron : IdentityUser
  {
    public Patron() : base()
    {
      this.Books = new HashSet<BookPatron>();
    }
    // public int PatronId { get; set; }
    public string PatronName { get; set; }
    public ApplicationUser User { get; set; }
    public ICollection<BookPatron> Books { get; set; }
  }
}