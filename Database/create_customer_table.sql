CREATE TABLE Customer (
    mobileNo   TEXT(11)  NOT NULL,
    firstName  TEXT(50),
    lastName   TEXT(50),
    fatherName TEXT(50),
    birthdate  DATETIME,
    meliCode   TEXT(10),
    CONSTRAINT PK_Customer PRIMARY KEY (mobileNo)
);
