class Book
{
    decimal isbn13;
    public Book(decimal isbn13)
    {
        this.isbn13=isbn13;
    }
}

class Ebook : Book
{
    public Ebook() : base(0)
    {
    }

    public Ebook(decimal isbn)
        :base(isbn) 
    { 
    }
}