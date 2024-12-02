##**Project Contributors:**

Dominick Diaz

Alex Arguelles



# **Quick Usage Guide**

This provides a brief overview of how to use the provided C# classes to interact with your SQL Server database for managing books, authors, and collections. -Dominick

## **Prerequisites**

- **Visual Studio** or any C# IDE
- **SQL Server** (Express, LocalDB, etc.)
- **Microsoft.Data.SqlClient** NuGet package

## **Setup Instructions**

1. **Install NuGet Package**:

   - Install **Microsoft.Data.SqlClient** via NuGet Package Manager or using the CLI:

     ```bash
     dotnet add package Microsoft.Data.SqlClient
     ```

2. **Set Up the Database**:

   - Create the `BookCollectionDB` database.
   - Run the SQL scripts to create tables and stored procedures.


## **Usage Examples**

### **Working with Books**

**Add a New Book**:

```csharp
Book newBook = new Book
{
    Title = "Sample Book",
    PublicationDate = DateTime.Now,
    Sales = 100,
    ISBN = "1234567890",
    Genre = "Fiction",
    Summary = "This is a sample book."
};
newBook.Add();
Console.WriteLine($"Book added with ID: {newBook.BookId}");
```

**Update a Book**:

```csharp
newBook.Title = "Updated Sample Book";
newBook.Update();
Console.WriteLine("Book updated.");
```

**Delete a Book**:

```csharp
newBook.Delete();
Console.WriteLine("Book deleted.");
```

**Get a Book by ISBN**:

```csharp
Book fetchedBook = Book.GetByISBN("1234567890");
if (fetchedBook != null)
{
    Console.WriteLine($"Fetched Book Title: {fetchedBook.Title}");
}
```

### **Working with Authors**

**Add a New Author**:

```csharp
Author newAuthor = new Author
{
    Name = "John Doe",
    BirthDate = new DateTime(1970, 1, 1),
    Biography = "An accomplished author."
};
newAuthor.Add();
Console.WriteLine($"Author added with ID: {newAuthor.AuthorId}");
```

### **Linking Books and Authors**

**Link a Book to an Author**:

```csharp
BookAuthor bookAuthor = new BookAuthor
{
    BookId = newBook.BookId,
    AuthorId = newAuthor.AuthorId
};
bookAuthor.Link();
Console.WriteLine("Book linked to author.");
```

### **Working with Collections**

**Create a New Collection**:

```csharp
Collection newCollection = new Collection
{
    Owner = "Alice",
    Name = "Favorites",
    Description = "My favorite books."
};
newCollection.Add();
Console.WriteLine($"Collection added with ID: {newCollection.CollectionId}");
```

**Add a Book to a Collection**:

```csharp
CollectionBook collectionBook = new CollectionBook
{
    CollectionId = newCollection.CollectionId,
    BookId = newBook.BookId
};
collectionBook.Add();
Console.WriteLine("Book added to collection.");
```

- Dominick
