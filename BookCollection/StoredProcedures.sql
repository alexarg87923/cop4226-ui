

CREATE PROCEDURE AddBook
    @Title VARCHAR(255),
    @PublicationDate DATE = NULL,
    @Sales INT = 0,
    @ISBN VARCHAR(20) = NULL,
    @Genre VARCHAR(100) = NULL,
    @Summary VARCHAR(MAX) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Books (title, publication_date, sales, isbn, genre, summary)
    VALUES (@Title, @PublicationDate, @Sales, @ISBN, @Genre, @Summary);

    SELECT SCOPE_IDENTITY() AS NewBookID;
END
GO



CREATE PROCEDURE UpdateBook
    @BookID INT,
    @Title VARCHAR(255),
    @PublicationDate DATE = NULL,
    @Sales INT = 0,
    @ISBN VARCHAR(20) = NULL,
    @Genre VARCHAR(100) = NULL,
    @Summary VARCHAR(MAX) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Books
    SET
        title = @Title,
        publication_date = @PublicationDate,
        sales = @Sales,
        isbn = @ISBN,
        genre = @Genre,
        summary = @Summary
    WHERE book_id = @BookID;
END
GO


CREATE PROCEDURE DeleteBook
    @BookID INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM Books WHERE book_id = @BookID;
END
GO


CREATE PROCEDURE GetBookByISBN
    @ISBN VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT * FROM Books WHERE isbn = @ISBN;
END
GO


CREATE PROCEDURE SearchBooks
    @Title VARCHAR(255) = NULL,
    @Genre VARCHAR(100) = NULL,
    @AuthorName VARCHAR(255) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT DISTINCT B.*
    FROM Books B
    LEFT JOIN BookAuthors BA ON B.book_id = BA.book_id
    LEFT JOIN Authors A ON BA.author_id = A.author_id
    WHERE
        (@Title IS NULL OR B.title LIKE '%' + @Title + '%') AND
        (@Genre IS NULL OR B.genre = @Genre) AND
        (@AuthorName IS NULL OR A.name LIKE '%' + @AuthorName + '%');
END
GO



CREATE PROCEDURE AddAuthor
    @Name VARCHAR(255),
    @BirthDate DATE = NULL,
    @Biography VARCHAR(MAX) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Authors (name, birth_date, biography)
    VALUES (@Name, @BirthDate, @Biography);

    SELECT SCOPE_IDENTITY() AS NewAuthorID;
END
GO


CREATE PROCEDURE UpdateAuthor
    @AuthorID INT,
    @Name VARCHAR(255),
    @BirthDate DATE = NULL,
    @Biography VARCHAR(MAX) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Authors
    SET
        name = @Name,
        birth_date = @BirthDate,
        biography = @Biography
    WHERE author_id = @AuthorID;
END
GO


CREATE PROCEDURE DeleteAuthor
    @AuthorID INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM Authors WHERE author_id = @AuthorID;
END
GO


CREATE PROCEDURE LinkBookAuthor
    @BookID INT,
    @AuthorID INT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO BookAuthors (book_id, author_id)
    VALUES (@BookID, @AuthorID);
END
GO


CREATE PROCEDURE UnlinkBookAuthor
    @BookID INT,
    @AuthorID INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM BookAuthors
    WHERE book_id = @BookID AND author_id = @AuthorID;
END
GO

CREATE PROCEDURE AddBookToCollection
    @CollectionID INT,
    @BookID INT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO CollectionBooks (collection_id, book_id)
    VALUES (@CollectionID, @BookID);
END
GO

CREATE PROCEDURE RemoveBookFromCollection
    @CollectionID INT,
    @BookID INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM CollectionBooks
    WHERE collection_id = @CollectionID AND book_id = @BookID;
END
GO

CREATE PROCEDURE AddCollection
    @Owner VARCHAR(255),
    @Name VARCHAR(255),
    @Description VARCHAR(MAX) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Collections (owner, name, description)
    VALUES (@Owner, @Name, @Description);

    SELECT SCOPE_IDENTITY() AS NewCollectionID;
END
GO


CREATE PROCEDURE UpdateCollection
    @CollectionID INT,
    @Owner VARCHAR(255),
    @Name VARCHAR(255),
    @Description VARCHAR(MAX) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Collections
    SET
        owner = @Owner,
        name = @Name,
        description = @Description
    WHERE collection_id = @CollectionID;
END
GO


CREATE PROCEDURE DeleteCollection
    @CollectionID INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM Collections WHERE collection_id = @CollectionID;
END
GO


CREATE PROCEDURE ListBooksInCollection
    @CollectionID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT B.*
    FROM Books B
    INNER JOIN CollectionBooks CB ON B.book_id = CB.book_id
    WHERE CB.collection_id = @CollectionID;
END
GO



CREATE PROCEDURE ChangeCollectionOwnerName
    @OldOwnerName VARCHAR(255),
    @NewOwnerName VARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Collections
    SET owner = @NewOwnerName
    WHERE owner = @OldOwnerName;
END
GO
