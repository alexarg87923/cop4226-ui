-- Create the database
CREATE DATABASE BookCollectionDB;
GO

-- Select the database
USE BookCollectionDB;
GO


--Set up DB
CREATE TABLE Books (
    book_id INT IDENTITY(1,1) PRIMARY KEY,
    title VARCHAR(255) NOT NULL,
    publication_date DATE,
    sales INT,
    isbn VARCHAR(20),
    genre VARCHAR(100),
    summary VARCHAR(MAX)
);


CREATE TABLE Authors (
    author_id INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    birth_date DATE,
    biography VARCHAR(MAX)
);

CREATE TABLE BookAuthors (
    book_id INT,
    author_id INT,
    PRIMARY KEY (book_id, author_id),
    FOREIGN KEY (book_id) REFERENCES Books(book_id) ON DELETE CASCADE,
    FOREIGN KEY (author_id) REFERENCES Authors(author_id) ON DELETE CASCADE
);


CREATE TABLE Collections (
    collection_id INT IDENTITY(1,1) PRIMARY KEY,
    owner VARCHAR(255),
    name VARCHAR(255) NOT NULL,
    description VARCHAR(MAX)
);


CREATE TABLE CollectionBooks (
    collection_id INT,
    book_id INT,
    PRIMARY KEY (collection_id, book_id),
    FOREIGN KEY (collection_id) REFERENCES Collections(collection_id) ON DELETE CASCADE,
    FOREIGN KEY (book_id) REFERENCES Books(book_id) ON DELETE CASCADE
);
