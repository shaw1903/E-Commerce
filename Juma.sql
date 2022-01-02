--
-- File generated with SQLiteStudio v3.3.3 on Sun Jan 2 15:04:02 2022
--
-- Text encoding used: UTF-8
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: __EFMigrationsHistory
CREATE TABLE __EFMigrationsHistory (
    MigrationId    TEXT NOT NULL
                        CONSTRAINT PK___EFMigrationsHistory PRIMARY KEY,
    ProductVersion TEXT NOT NULL
);


-- Table: Customers
CREATE TABLE Customers (
    CustomerID   INTEGER       NOT NULL,
    CustomerName NVARCHAR (30) PRIMARY KEY,
    PostCode     STRING        NOT NULL,
    Address      STRING        NOT NULL,
    City         STRING        NOT NULL,
    PhoneNumber  INT           NOT NULL,
    EmailAddress STRING        NOT NULL
);

INSERT INTO Customers (
                          CustomerID,
                          CustomerName,
                          PostCode,
                          Address,
                          City,
                          PhoneNumber,
                          EmailAddress
                      )
                      VALUES (
                          1,
                          'Seoras',
                          'AB25 2SE',
                          'Flat D, 3 Craigie Park',
                          'Aberdeen',
                          '01224 593008',
                          'shawshawshaw@live.co.uk'
                      );

INSERT INTO Customers (
                          CustomerID,
                          CustomerName,
                          PostCode,
                          Address,
                          City,
                          PhoneNumber,
                          EmailAddress
                      )
                      VALUES (
                          2,
                          'Steph',
                          'AB22 8BE',
                          'FLAT 1 MILLBANK VIEW',
                          'Aberdeen',
                          '01224 593009',
                          'STEPH@HOTMAIL.CO.UK'
                      );


-- Table: Images
CREATE TABLE Images (
    ItemNumber INT        PRIMARY KEY
                          NOT NULL,
    ItemName   STRING     NOT NULL,
    ItemPrice  DECIMAL    NOT NULL,
    DateTaken  "DATETIME" NOT NULL,
    Event      STRING     NOT NULL,
    ImageURL   STRING     NOT NULL
);


-- Table: Orders
CREATE TABLE Orders (
    OrderNumber     INT         PRIMARY KEY
                                NOT NULL,
    OrderDate       "DATETIME"  NOT NULL,
    ItemNumber      INT         REFERENCES Images (ItemNumber) 
                                NOT NULL,
    ItemQuantity    INT         NOT NULL,
    ItemPrice       DECIMAL     NOT NULL
                                REFERENCES Images (ItemPrice),
    CustomerName    STRING (30) REFERENCES Customers (CustomerName),
    OrderTotal      DECIMAL,
    OrderSuccessful BOOLEAN
);

INSERT INTO Orders (
                       OrderNumber,
                       OrderDate,
                       ItemNumber,
                       ItemQuantity,
                       ItemPrice,
                       CustomerName,
                       OrderTotal,
                       OrderSuccessful
                   )
                   VALUES (
                       1,
                       '01/12/21',
                       1,
                       1,
                       '£14.00',
                       'Seoras',
                       '£14.00',
                       'true'
                   );


COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
