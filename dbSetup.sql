-- Active: 1687896089164@@SG-Sandbox-7678-mysql-master.servers.mongodirector.com@3306@GregsList

CREATE TABLE
    IF NOT EXISTS accounts(
        id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255) COMMENT 'User Name',
        email varchar(255) COMMENT 'User Email',
        picture varchar(255) COMMENT 'User Picture'
    ) default charset utf8 COMMENT '';

-- starting from here create table and give them properties

CREATE TABLE
    houses(
        id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
        bedroom INT NOT NULL DEFAULT 2,
        bathroom INT NOT NULL DEFAULT 1,
        price DOUBLE NOT NULL DEFAULT 20000,
        yearmake INT NOT NULL DEFAULT 2000,
        description VARCHAR(1000)
    ) default charset utf8 COMMENT '';

INSERT INTO
    houses (
        bedroom,
        bathroom,
        price,
        yearmake,
        description
    ) VALUE (
        3,
        3,
        1234,
        2020,
        "super sick house for single guy"
    );

INSERT INTO
    houses (
        bedroom,
        bathroom,
        price,
        yearmake,
        description
    ) VALUE (
        4,
        3,
        3434,
        2022,
        "your family house with enough space and good view"
    );

INSERT INTO
    houses (
        bedroom,
        bathroom,
        price,
        yearmake,
        description
    ) VALUE (
        6,
        4,
        1244,
        2021,
        "a big family house. a good house with quite neighborhood"
    );

-- after making a table make sure you have it in the left side where all folder and files go and then insert those specifications that you made for table.

-- create some of the that thing you have the table for and then then see if you can get them

-- for connection to sserver to to the oppsettings.Development.json and then bring the value for connection-string

-- // the value for the connection string is all your data bas information that you can bring from your data base name and password.

-- After connecting your database with the project you need to make the model go to the model. and then make the class put all the properties you need to make a car

-- then go to the controller and make your controller

-- then make the servcice file

-- and then go to the repository make the file

-- after making all the files go to the startup file and add the service to the scopted with the repository

-- then go to the repository  and connect to the the DATABASE

-- to get our data from data bas in repo the methodes are different and

-- string sql="SELECT * FROM cars"selecting the table we want to work with

-- List<car> cars = _db.Query<Car>(sql).ToList() makes connection to our database <Car> infront of the (sql) mentions the type of the data we will recieve from out DATABASE
