using System.Collections.Generic;

namespace aspdotnetcoreMarioSamison.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName}- {LastName}";
        public virtual List<AuthorBook> Books { get; set; }
    }
}
