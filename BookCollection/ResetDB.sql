-- Switch to the master database
USE master;
GO

-- Set the database to single-user mode to terminate all connections
ALTER DATABASE BookCollectionDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
GO

-- Drop the database
DROP DATABASE BookCollectionDB;
GO
