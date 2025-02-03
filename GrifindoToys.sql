-- Create the GrifindoToys database (if not already created)
CREATE DATABASE GrifindoToys;

-- Use the GrifindoToys database
USE GrifindoToys;

-- Create the Users table
CREATE TABLE Users (
    EmployeeID INT PRIMARY KEY,  -- Unique identifier for each employee
    EmployeeName VARCHAR(100) NOT NULL,         -- Full name of the employee
    DOB DATE NOT NULL,                          -- Date of Birth
    JoinedDate DATE NOT NULL,                   -- Date when the employee joined
    UserRole VARCHAR(50) NOT NULL,              -- Role of the user (e.g., Admin, Employee)
	Password VARCHAR(255) NOT NULL
);

CREATE TABLE EmployeeLeaves (
    EmployeeID INT PRIMARY KEY,       -- Foreign key from Users table
    AnnualLeaves INT NOT NULL DEFAULT 0,  -- Annual leave count
    CasualLeaves INT NOT NULL DEFAULT 0,  -- Casual leave count
    FOREIGN KEY (EmployeeID) REFERENCES Users(EmployeeID) ON DELETE CASCADE
);

CREATE TABLE Roster (
    EmployeeID INT,                 -- Foreign Key from Users table
    DutyDate DATE NOT NULL,         -- The date of the duty
    StartingTime TIME NOT NULL,     -- Starting time for the duty
    EndingTime TIME NOT NULL,       -- Ending time for the duty
    PRIMARY KEY (EmployeeID, DutyDate), -- Composite Primary Key
    FOREIGN KEY (EmployeeID) REFERENCES Users(EmployeeID) -- Foreign Key constraint referencing EmployeeID in Users table
);

CREATE TABLE ManageEmployeeLeave (
    LeaveID INT IDENTITY(1,1) PRIMARY KEY, -- Automatically increments
    EmployeeID INT, -- Foreign key from Users table
    StartDateTime DATETIME, -- Start date and time of the leave
    EndDateTime DATETIME, -- End date and time of the leave
    NoOfLeaveDays INT, -- Total number of leave days
	Decision NVARCHAR(50) NOT NULL DEFAULT 'Pending',
    FOREIGN KEY (EmployeeID) REFERENCES Users(EmployeeID) -- Ensure the EmployeeID exists in the Users table
);


