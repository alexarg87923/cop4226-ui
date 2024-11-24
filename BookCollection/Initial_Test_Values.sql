-- Insert more authors and capture their IDs
DECLARE @AuthorID_GeorgeOrwell INT;
INSERT INTO Authors (name, birth_date, biography)
VALUES ('George Orwell', '1903-06-25', 'English novelist, essayist, journalist, and critic.');
SET @AuthorID_GeorgeOrwell = SCOPE_IDENTITY();

DECLARE @AuthorID_HarperLee INT;
INSERT INTO Authors (name, birth_date, biography)
VALUES ('Harper Lee', '1926-04-28', 'American novelist widely known for "To Kill a Mockingbird".');
SET @AuthorID_HarperLee = SCOPE_IDENTITY();

DECLARE @AuthorID_JKRowling INT;
INSERT INTO Authors (name, birth_date, biography)
VALUES ('J.K. Rowling', '1965-07-31', 'British author, best known for the Harry Potter series.');
SET @AuthorID_JKRowling = SCOPE_IDENTITY();

DECLARE @AuthorID_JRRTolkien INT;
INSERT INTO Authors (name, birth_date, biography)
VALUES ('J.R.R. Tolkien', '1892-01-03', 'English writer, poet, philologist, and academic.');
SET @AuthorID_JRRTolkien = SCOPE_IDENTITY();

DECLARE @AuthorID_JaneAusten INT;
INSERT INTO Authors (name, birth_date, biography)
VALUES ('Jane Austen', '1775-12-16', 'English novelist known primarily for her six major novels.');
SET @AuthorID_JaneAusten = SCOPE_IDENTITY();

DECLARE @AuthorID_MarkTwain INT;
INSERT INTO Authors (name, birth_date, biography)
VALUES ('Mark Twain', '1835-11-30', 'American writer, humorist, entrepreneur, publisher, and lecturer.');
SET @AuthorID_MarkTwain = SCOPE_IDENTITY();

-- Insert more books and capture their IDs
DECLARE @BookID_1984 INT;
INSERT INTO Books (title, publication_date, sales, isbn, genre, summary)
VALUES ('1984', '1949-06-08', 25, '9780451524935', 'Dystopian', 'A novel about a totalitarian regime.');
SET @BookID_1984 = SCOPE_IDENTITY();

DECLARE @BookID_Mockingbird INT;
INSERT INTO Books (title, publication_date, sales, isbn, genre, summary)
VALUES ('To Kill a Mockingbird', '1960-07-11', 40, '9780061120084', 'Classic', 'A novel about racial injustice.');
SET @BookID_Mockingbird = SCOPE_IDENTITY();

DECLARE @BookID_HarryPotter INT;
INSERT INTO Books (title, publication_date, sales, isbn, genre, summary)
VALUES ('Harry Potter and the Sorcerer''s Stone', '1997-06-26', 120, '9780439708180', 'Fantasy', 'The first book in the Harry Potter series.');
SET @BookID_HarryPotter = SCOPE_IDENTITY();

DECLARE @BookID_TheHobbit INT;
INSERT INTO Books (title, publication_date, sales, isbn, genre, summary)
VALUES ('The Hobbit', '1937-09-21', 100, '9780547928227', 'Fantasy', 'A fantasy novel and children''s book.');
SET @BookID_TheHobbit = SCOPE_IDENTITY();

DECLARE @BookID_PridePrejudice INT;
INSERT INTO Books (title, publication_date, sales, isbn, genre, summary)
VALUES ('Pride and Prejudice', '1813-01-28', 20, '9781503290563', 'Romance', 'A romantic novel of manners.');
SET @BookID_PridePrejudice = SCOPE_IDENTITY();

DECLARE @BookID_HuckleberryFinn INT;
INSERT INTO Books (title, publication_date, sales, isbn, genre, summary)
VALUES ('Adventures of Huckleberry Finn', '1884-12-10', 20, '9780486280615', 'Adventure', 'A novel about the adventures of a young boy along the Mississippi River.');
SET @BookID_HuckleberryFinn = SCOPE_IDENTITY();

-- Link books and authors using captured IDs
INSERT INTO BookAuthors (book_id, author_id)
VALUES
    (@BookID_1984, @AuthorID_GeorgeOrwell),           -- '1984' by George Orwell
    (@BookID_Mockingbird, @AuthorID_HarperLee),       -- 'To Kill a Mockingbird' by Harper Lee
    (@BookID_HarryPotter, @AuthorID_JKRowling),       -- 'Harry Potter' by J.K. Rowling
    (@BookID_TheHobbit, @AuthorID_JRRTolkien),        -- 'The Hobbit' by J.R.R. Tolkien
    (@BookID_PridePrejudice, @AuthorID_JaneAusten),   -- 'Pride and Prejudice' by Jane Austen
    (@BookID_HuckleberryFinn, @AuthorID_MarkTwain);   -- 'Adventures of Huckleberry Finn' by Mark Twain

-- Insert more collections and capture their IDs
DECLARE @CollectionID_SciFi INT;
INSERT INTO Collections (owner, name, description)
VALUES ('John Smith', 'Sci-Fi Favorites', 'A collection of favorite science fiction books.');
SET @CollectionID_SciFi = SCOPE_IDENTITY();

DECLARE @CollectionID_Classics INT;
INSERT INTO Collections (owner, name, description)
VALUES ('Emily Johnson', 'Classic Reads', 'A collection of classic literature.');
SET @CollectionID_Classics = SCOPE_IDENTITY();

DECLARE @CollectionID_Fantasy INT;
INSERT INTO Collections (owner, name, description)
VALUES ('Michael Brown', 'Fantasy Collection', 'A collection of fantasy novels.');
SET @CollectionID_Fantasy = SCOPE_IDENTITY();

-- Add books to collections using captured IDs
INSERT INTO CollectionBooks (collection_id, book_id)
VALUES
    (@CollectionID_SciFi, @BookID_1984),                 -- '1984' in Sci-Fi Favorites
    (@CollectionID_Classics, @BookID_Mockingbird),       -- 'To Kill a Mockingbird' in Classic Reads
    (@CollectionID_Classics, @BookID_PridePrejudice),    -- 'Pride and Prejudice' in Classic Reads
    (@CollectionID_Fantasy, @BookID_HarryPotter),        -- 'Harry Potter' in Fantasy Collection
    (@CollectionID_Fantasy, @BookID_TheHobbit);          -- 'The Hobbit' in Fantasy Collection

-- Insert a new author with multiple books and capture IDs
DECLARE @AuthorID_StephenKing INT;
INSERT INTO Authors (name, birth_date, biography)
VALUES ('Stephen King', '1947-09-21', 'American author of horror, supernatural fiction, suspense, and fantasy novels.');
SET @AuthorID_StephenKing = SCOPE_IDENTITY();

DECLARE @BookID_TheShining INT;
INSERT INTO Books (title, publication_date, sales, isbn, genre, summary)
VALUES ('The Shining', '1977-01-28', 15, '9780307743657', 'Horror', 'A horror novel about a haunted hotel.');
SET @BookID_TheShining = SCOPE_IDENTITY();

DECLARE @BookID_It INT;
INSERT INTO Books (title, publication_date, sales, isbn, genre, summary)
VALUES ('It', '1986-09-15', 10, '9780450411434', 'Horror', 'A horror novel about a shapeshifting entity.');
SET @BookID_It = SCOPE_IDENTITY();

-- Link Stephen King to his books
INSERT INTO BookAuthors (book_id, author_id)
VALUES
    (@BookID_TheShining, @AuthorID_StephenKing),
    (@BookID_It, @AuthorID_StephenKing);

-- Create a new collection and capture its ID
DECLARE @CollectionID_Horror INT;
INSERT INTO Collections (owner, name, description)
VALUES ('Sarah Williams', 'Horror Books', 'A collection of horror novels.');
SET @CollectionID_Horror = SCOPE_IDENTITY();

-- Add Stephen King's books to the new collection
INSERT INTO CollectionBooks (collection_id, book_id)
VALUES
    (@CollectionID_Horror, @BookID_TheShining),
    (@CollectionID_Horror, @BookID_It);
