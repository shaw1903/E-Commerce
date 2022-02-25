--
-- File generated with SQLiteStudio v3.3.3 on Tue Feb 22 19:46:49 2022
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
    CustomerID   INTEGER       NOT NULL
                               PRIMARY KEY,
    CustomerName NVARCHAR (30),
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
    ItemID    INTEGER  PRIMARY KEY
                       NOT NULL,
    ItemName  STRING   NOT NULL,
    ItemPrice DECIMAL  NOT NULL,
    DateTaken DATETIME NOT NULL,
    Event     STRING   NOT NULL,
    ImageURL  STRING   NOT NULL
);

INSERT INTO Images (
                       ItemID,
                       ItemName,
                       ItemPrice,
                       DateTaken,
                       Event,
                       ImageURL
                   )
                   VALUES (
                       1,
                       'Picture1',
                       10,
                       '12/03/21',
                       'Show1',
                       '/Users/Seoras/Pictures/Shows/Show1/PHOTO-2021-11-03-11-15-44 6.jpg'
                   );

INSERT INTO Images (
                       ItemID,
                       ItemName,
                       ItemPrice,
                       DateTaken,
                       Event,
                       ImageURL
                   )
                   VALUES (
                       4,
                       'PHOTO-2021-11-03-11-15-44 6.jpg',
                       14.4,
                       '2022-02-17 21:41:37.146203',
                       'Testing',
                       '/Users/Seoras/Pictures/Shows/Show1/PHOTO-2021-11-03-11-15-44 6.jpg'
                   );

INSERT INTO Images (
                       ItemID,
                       ItemName,
                       ItemPrice,
                       DateTaken,
                       Event,
                       ImageURL
                   )
                   VALUES (
                       6,
                       'PHOTO-2021-11-03-11-15-44 8.jpg',
                       14.4,
                       '2022-02-17 22:00:32.26461',
                       'Testing',
                       '/Users/Seoras/Pictures/Shows/Show1/PHOTO-2021-11-03-11-15-44 8.jpg'
                   );

INSERT INTO Images (
                       ItemID,
                       ItemName,
                       ItemPrice,
                       DateTaken,
                       Event,
                       ImageURL
                   )
                   VALUES (
                       7,
                       'PHOTO-2021-11-03-11-15-44 5.jpg',
                       14.4,
                       '2022-02-17 22:00:33.738127',
                       'Testing',
                       '/Users/Seoras/Pictures/Shows/Show1/PHOTO-2021-11-03-11-15-44 5.jpg'
                   );

INSERT INTO Images (
                       ItemID,
                       ItemName,
                       ItemPrice,
                       DateTaken,
                       Event,
                       ImageURL
                   )
                   VALUES (
                       8,
                       'PHOTO-2021-11-03-11-15-44 7.jpg',
                       14.4,
                       '2022-02-17 22:00:33.765057',
                       'Testing',
                       '/Users/Seoras/Pictures/Shows/Show1/PHOTO-2021-11-03-11-15-44 7.jpg'
                   );

INSERT INTO Images (
                       ItemID,
                       ItemName,
                       ItemPrice,
                       DateTaken,
                       Event,
                       ImageURL
                   )
                   VALUES (
                       9,
                       'PHOTO-2021-11-03-11-15-44 6.jpg',
                       14.4,
                       '2022-02-17 21:59:12.807804',
                       'Testing',
                       '/Users/Seoras/Pictures/Shows/Show1/PHOTO-2021-11-03-11-15-44 6.jpg'
                   );

INSERT INTO Images (
                       ItemID,
                       ItemName,
                       ItemPrice,
                       DateTaken,
                       Event,
                       ImageURL
                   )
                   VALUES (
                       11,
                       'PHOTO-2021-11-03-11-15-44 8.jpg',
                       14.4,
                       '2022-02-17 22:02:59.9624',
                       'Testing',
                       '/Users/Seoras/Pictures/Shows/Show1/PHOTO-2021-11-03-11-15-44 8.jpg'
                   );

INSERT INTO Images (
                       ItemID,
                       ItemName,
                       ItemPrice,
                       DateTaken,
                       Event,
                       ImageURL
                   )
                   VALUES (
                       12,
                       'PHOTO-2021-11-03-11-15-44 5.jpg',
                       14.4,
                       '2022-02-17 22:03:01.357276',
                       'Testing',
                       '/Users/Seoras/Pictures/Shows/Show1/PHOTO-2021-11-03-11-15-44 5.jpg'
                   );

INSERT INTO Images (
                       ItemID,
                       ItemName,
                       ItemPrice,
                       DateTaken,
                       Event,
                       ImageURL
                   )
                   VALUES (
                       13,
                       'PHOTO-2021-11-03-11-15-44 7.jpg',
                       14.4,
                       '2022-02-17 22:03:01.387127',
                       'Testing',
                       '/Users/Seoras/Pictures/Shows/Show1/PHOTO-2021-11-03-11-15-44 7.jpg'
                   );

INSERT INTO Images (
                       ItemID,
                       ItemName,
                       ItemPrice,
                       DateTaken,
                       Event,
                       ImageURL
                   )
                   VALUES (
                       14,
                       'PHOTO-2021-11-03-11-15-44 6.jpg',
                       14.4,
                       '2022-02-17 22:03:01.394737',
                       'Testing',
                       '/Users/Seoras/Pictures/Shows/Show1/PHOTO-2021-11-03-11-15-44 6.jpg'
                   );

INSERT INTO Images (
                       ItemID,
                       ItemName,
                       ItemPrice,
                       DateTaken,
                       Event,
                       ImageURL
                   )
                   VALUES (
                       101,
                       'PHOTO-2021-11-03-11-15-44 8.jpg',
                       14.4,
                       '2022-02-20 15:01:38.68807',
                       'Testing',
                       '/Users/Seoras/Pictures/Shows/Show1/PHOTO-2021-11-03-11-15-44 8.jpg'
                   );

INSERT INTO Images (
                       ItemID,
                       ItemName,
                       ItemPrice,
                       DateTaken,
                       Event,
                       ImageURL
                   )
                   VALUES (
                       102,
                       'PHOTO-2021-11-03-11-15-44 8.jpg',
                       14.4,
                       '2021-11-03 12:15:45',
                       'Testing',
                       '/Users/Seoras/Pictures/Shows/Show1/PHOTO-2021-11-03-11-15-44 8.jpg'
                   );

INSERT INTO Images (
                       ItemID,
                       ItemName,
                       ItemPrice,
                       DateTaken,
                       Event,
                       ImageURL
                   )
                   VALUES (
                       103,
                       'PHOTO-2021-11-03-11-15-44 8.jpg',
                       14.4,
                       '2021-11-03 12:15:45',
                       'Testing',
                       '/Users/Seoras/Pictures/Shows/Show1/PHOTO-2021-11-03-11-15-44 8.jpg'
                   );

INSERT INTO Images (
                       ItemID,
                       ItemName,
                       ItemPrice,
                       DateTaken,
                       Event,
                       ImageURL
                   )
                   VALUES (
                       104,
                       'PHOTO-2021-11-03-11-15-44 8.jpg',
                       14.4,
                       '2021-11-03 12:15:45',
                       'Testing',
                       '/Users/Seoras/Pictures/Shows/Show1/PHOTO-2021-11-03-11-15-44 8.jpg'
                   );

INSERT INTO Images (
                       ItemID,
                       ItemName,
                       ItemPrice,
                       DateTaken,
                       Event,
                       ImageURL
                   )
                   VALUES (
                       105,
                       'PHOTO-2021-11-03-11-15-44 8.jpg',
                       14.4,
                       '2021-11-03 12:15:45',
                       'Testing',
                       '/Users/Seoras/Pictures/Shows/Show1/PHOTO-2021-11-03-11-15-44 8.jpg'
                   );

INSERT INTO Images (
                       ItemID,
                       ItemName,
                       ItemPrice,
                       DateTaken,
                       Event,
                       ImageURL
                   )
                   VALUES (
                       106,
                       'PHOTO-2021-11-03-11-15-44 8.jpg',
                       14.4,
                       '2021-11-03 12:15:45',
                       'Testing',
                       '/Users/Seoras/Pictures/Shows/Show1/PHOTO-2021-11-03-11-15-44 8.jpg'
                   );

INSERT INTO Images (
                       ItemID,
                       ItemName,
                       ItemPrice,
                       DateTaken,
                       Event,
                       ImageURL
                   )
                   VALUES (
                       107,
                       'PHOTO-2021-11-03-11-15-44 8.jpg',
                       14.4,
                       '2021-11-03 12:15:45',
                       'Testing',
                       '/Users/Seoras/Pictures/Shows/Show1/PHOTO-2021-11-03-11-15-44 8.jpg'
                   );

INSERT INTO Images (
                       ItemID,
                       ItemName,
                       ItemPrice,
                       DateTaken,
                       Event,
                       ImageURL
                   )
                   VALUES (
                       108,
                       'PHOTO-2021-11-03-11-15-44 8.jpg',
                       14.4,
                       '2021-11-03 12:15:45',
                       'Testing',
                       '/Users/Seoras/Pictures/Shows/Show1/PHOTO-2021-11-03-11-15-44 8.jpg'
                   );

INSERT INTO Images (
                       ItemID,
                       ItemName,
                       ItemPrice,
                       DateTaken,
                       Event,
                       ImageURL
                   )
                   VALUES (
                       109,
                       'PHOTO-2021-11-03-11-15-44 8.jpg',
                       14.4,
                       '2021-11-03 12:15:45',
                       'Testing',
                       '/Users/Seoras/Pictures/Shows/Show1/PHOTO-2021-11-03-11-15-44 8.jpg'
                   );

INSERT INTO Images (
                       ItemID,
                       ItemName,
                       ItemPrice,
                       DateTaken,
                       Event,
                       ImageURL
                   )
                   VALUES (
                       110,
                       'PHOTO-2021-11-03-11-15-44 8.jpg',
                       14.4,
                       '2021-11-03 12:15:45',
                       'Testing',
                       '/Users/Seoras/Pictures/Shows/Show1/PHOTO-2021-11-03-11-15-44 8.jpg'
                   );

INSERT INTO Images (
                       ItemID,
                       ItemName,
                       ItemPrice,
                       DateTaken,
                       Event,
                       ImageURL
                   )
                   VALUES (
                       111,
                       'PHOTO-2021-11-03-11-15-44 8.jpg',
                       14.4,
                       '2021-11-03 12:15:45',
                       'Testing',
                       '/Users/Seoras/Pictures/Shows/Show1/PHOTO-2021-11-03-11-15-44 8.jpg'
                   );

INSERT INTO Images (
                       ItemID,
                       ItemName,
                       ItemPrice,
                       DateTaken,
                       Event,
                       ImageURL
                   )
                   VALUES (
                       112,
                       'Photo on 10-01-2021 at 11.50 #2.jpg',
                       14.4,
                       '2021-01-10 12:50:38.7638138',
                       'Testing',
                       '/Users/Seoras/Pictures/Shows/Show1/Photo on 10-01-2021 at 11.50 #2.jpg'
                   );

INSERT INTO Images (
                       ItemID,
                       ItemName,
                       ItemPrice,
                       DateTaken,
                       Event,
                       ImageURL
                   )
                   VALUES (
                       113,
                       'Photo on 10-01-2021 at 11.50 #2.jpg',
                       14.4,
                       '2021-01-10 12:50:38.7638138',
                       'Testing',
                       '/Users/Seoras/Pictures/Shows/Show1/Photo on 10-01-2021 at 11.50 #2.jpg'
                   );

INSERT INTO Images (
                       ItemID,
                       ItemName,
                       ItemPrice,
                       DateTaken,
                       Event,
                       ImageURL
                   )
                   VALUES (
                       114,
                       'Photo on 10-01-2021 at 11.50 #2.jpg',
                       14.4,
                       '2021-01-10 12:50:38.7638138',
                       'Testing',
                       '/Users/Seoras/Pictures/Shows/Show1/Photo on 10-01-2021 at 11.50 #2.jpg'
                   );

INSERT INTO Images (
                       ItemID,
                       ItemName,
                       ItemPrice,
                       DateTaken,
                       Event,
                       ImageURL
                   )
                   VALUES (
                       115,
                       'Photo on 10-01-2021 at 11.50 #2.jpg',
                       14.4,
                       '2021-01-10 12:50:38.7638138',
                       'Testing',
                       '/Users/Seoras/Pictures/Shows/Show1/Photo on 10-01-2021 at 11.50 #2.jpg'
                   );

INSERT INTO Images (
                       ItemID,
                       ItemName,
                       ItemPrice,
                       DateTaken,
                       Event,
                       ImageURL
                   )
                   VALUES (
                       116,
                       'Photo on 10-01-2021 at 11.50 #2.jpg',
                       14.4,
                       '2021-01-10 12:50:38.7638138',
                       'Testing',
                       '/Users/Seoras/Pictures/Shows/Show1/Photo on 10-01-2021 at 11.50 #2.jpg'
                   );

INSERT INTO Images (
                       ItemID,
                       ItemName,
                       ItemPrice,
                       DateTaken,
                       Event,
                       ImageURL
                   )
                   VALUES (
                       117,
                       'PHOTO-2021-11-03-11-15-44 8.jpg',
                       14.4,
                       '2021-11-03 12:15:45',
                       'Testing',
                       '/Users/Seoras/Pictures/Shows/Show1/PHOTO-2021-11-03-11-15-44 8.jpg'
                   );

INSERT INTO Images (
                       ItemID,
                       ItemName,
                       ItemPrice,
                       DateTaken,
                       Event,
                       ImageURL
                   )
                   VALUES (
                       118,
                       'PHOTO-2021-11-03-11-15-44 8.jpg',
                       14.4,
                       '2021-11-03 12:15:45',
                       'Testing',
                       '/Users/Seoras/Pictures/Shows/Show1/PHOTO-2021-11-03-11-15-44 8.jpg'
                   );

INSERT INTO Images (
                       ItemID,
                       ItemName,
                       ItemPrice,
                       DateTaken,
                       Event,
                       ImageURL
                   )
                   VALUES (
                       119,
                       'PHOTO-2021-11-03-11-15-44 8.jpg',
                       14.4,
                       '2021-11-03 12:15:45',
                       'Testing',
                       '/Users/Seoras/Pictures/Shows/Show1/PHOTO-2021-11-03-11-15-44 8.jpg'
                   );


-- Table: Orders
CREATE TABLE Orders (
    OrderID         INTEGER     PRIMARY KEY
                                NOT NULL,
    OrderDate       "DATETIME"  NOT NULL,
    ItemID          INTEGER     REFERENCES Images (ItemID) 
                                NOT NULL,
    ItemQuantity    INT         NOT NULL,
    ItemPrice       DECIMAL     NOT NULL,
    CustomerName    STRING (30),
    OrderTotal      DECIMAL,
    OrderSuccessful BOOLEAN,
    CustomerID      INTEGER     REFERENCES Customers (CustomerID),
    FOREIGN KEY (
        ItemID
    )
    REFERENCES Images (ItemID),
    FOREIGN KEY (
        CustomerID
    )
    REFERENCES Orders (CustomerID) 
);

INSERT INTO Orders (
                       OrderID,
                       OrderDate,
                       ItemID,
                       ItemQuantity,
                       ItemPrice,
                       CustomerName,
                       OrderTotal,
                       OrderSuccessful,
                       CustomerID
                   )
                   VALUES (
                       1,
                       '01/12/21',
                       1,
                       1,
                       '£14.00',
                       'Seoras',
                       '£14.00',
                       'true',
                       NULL
                   );


COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
