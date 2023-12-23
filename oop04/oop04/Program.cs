class Book
{
    decimal isdbn13;
    string title;
    string contents;

    public Book(decimal isbn13, string title, string contents)
    {
        this.isdbn13 = isbn13;
        this.title = title;
        this.contents = contents;
    }

    public override bool Equals(object? obj)
    {
        if(obj == null)
        {
            return false;
        }

        Book book = obj as Book;
        if(book == null)
        {
            return false;
        }
        return this.isdbn13 == book.isdbn13;
    }
}