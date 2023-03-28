create database airlines

use airlines

go
CREATE TABLE People
(
id INT IDENTITY(1,1) PRIMARY KEY,
username VARCHAR(50) NOT NULL,
password VARCHAR(50) NOT NULL,
name VARCHAR(50) NOT NULL,
surname  VARCHAR(50) NOT NULL
)
CREATE TABLE Airplanes
(
AirplaneID INT IDENTITY(1,1) PRIMARY KEY,
RegistrationNumber VARCHAR(10) NOT NULL,
Type VARCHAR(50) NOT NULL,
NumberOfSeats INT NOT NULL,
Payload INT NOT NULL,
Speed INT NOT NULL,
ManufactureDate DATE NOT NULL,
FlightHours FLOAT NOT NULL,
LastRepairDate DATE NOT NULL,
Destination VARCHAR(50) NOT NULL,
FuelConsumption FLOAT NOT NULL
)

CREATE TABLE CrewMember
(
CrewMemberID INT IDENTITY(1,1) PRIMARY KEY,
FullName VARCHAR(50) NOT NULL,
PassportData VARCHAR(50) NOT NULL,
)

CREATE TABLE Passengers
(
PassengerID INT IDENTITY(1,1) PRIMARY KEY,
FullName VARCHAR(50) NOT NULL,
PassportData VARCHAR(50) NOT NULL,
)

CREATE TABLE Flights
(
FlightID INT IDENTITY(1,1) PRIMARY KEY,
AirplaneID INT NOT NULL,
DepartureDate DATE NOT NULL,
DepartureTime TIME NOT NULL,
DepartureAirport VARCHAR(50) NOT NULL,
ArrivalAirport VARCHAR(50) NOT NULL,
Distance INT NOT NULL,
FOREIGN KEY (AirplaneID) REFERENCES Airplanes (AirplaneID)
)

CREATE TABLE Crew
(
CrewID INT IDENTITY(1,1) PRIMARY KEY,
CrewCode VARCHAR(10) NOT NULL,
FlightsID INT NOT NULL,
CrewMemberID INT NOT NULL,
FOREIGN KEY (FlightsID) REFERENCES Flights (FlightID),
FOREIGN KEY (CrewMemberID) REFERENCES CrewMember (CrewMemberID)
)

CREATE TABLE Tickets
(
TicketID INT IDENTITY(1,1) PRIMARY KEY,
FlightID INT NOT NULL,
PassengerID INT NOT NULL,
TicketPrice MONEY NOT NULL,
SeatNumber INT NOT NULL,
SeatType VARCHAR(10) NOT NULL,
FOREIGN KEY (FlightID) REFERENCES Flights (FlightID),
FOREIGN KEY (PassengerID) REFERENCES Passengers (PassengerID)
)

CREATE TABLE basket
(
name VARCHAR(50) NOT NULL,
price VARCHAR(50) NOT NULL;
)

INSERT INTO People (username, password, name, surname)
VALUES
('admin', 'admin', 'admin', 'admin');

INSERT INTO Airplanes (RegistrationNumber, Type, NumberOfSeats, Payload, Speed, ManufactureDate, FlightHours, LastRepairDate, Destination, FuelConsumption)
VALUES
('ABC123', 'Boeing 747', 400, 80000, 900, '2000-01-01', 25000.5, '2022-02-28', 'Warsaw', 12.5),
('DEF456', 'Airbus A320', 150, 40000, 600, '2005-06-30', 18000.3, '2021-10-15', 'Wroclaw', 8.7),
('JKL012', 'Airbus A380', 500, 90000, 950, '2015-10-01', 8000.1, '2022-12-01', 'London', 14.2),
('MNO345', 'Boeing 787', 250, 50000, 800, '2018-07-15', 4000.2, '2023-02-15', 'Paris', 11.3),
('PQR678', 'Embraer E190', 100, 25000, 550, '2013-02-28', 6000.5, '2021-09-30', 'Rome', 7.9),
('GHI789', 'Boeing 737', 200, 50000, 700, '2010-03-15', 12000.2, '2022-01-10', 'Poznan', 9.2);

INSERT INTO CrewMember (FullName, PassportData)
VALUES
('Elizabeth Shalkevich', '1234567890'),
('Ksenia Prikhodko', '0987654321'),
('Konstantin Korzhik', '1357908642'),
('Ivan Ivanov', '1111111111'),
('Sergey Petrov', '2222222222'),
('Olga Smirnova', '3333333333'),
('Dana Danilovich', '2468013579');

INSERT INTO Passengers (FullName, PassportData)
VALUES
('Kim Min-ji', '0987654321'),
('Pham Ngoc Khan', '1234567890'),
('Maria Garcia', '4444444444'),
('Nikolay Kim', '5555555555'),
('Yulia Popova', '6666666666'),
('Kang Hae-rin', '2468013579');

INSERT INTO Flights (AirplaneID, DepartureDate, DepartureTime, DepartureAirport, ArrivalAirport, Distance)
VALUES
(1, '2023-03-15', '08:00:00', 'WAW', 'POZ', 3441),
(2, '2023-03-16', '12:00:00', 'WRO', 'WAW', 2475),
(2, '2023-03-19', '10:00:00', 'CDG', 'WAW', 1169),
(3, '2023-03-20', '14:00:00', 'FCO', 'WAW', 998),
(1, '2023-03-21', '18:00:00', 'LHR', 'WAW', 1408),
(3, '2023-03-18', '16:00:00', 'KRK', 'WRO', 1745);

INSERT INTO Crew (CrewCode, FlightsID, CrewMemberID)
VALUES
('Crew001', 1,1),
('Crew002', 2,2),
('Crew004', 4,1),
('Crew005', 5,2),
('Crew006', 6,3),
('Crew007', 4,4),
('Crew008', 5,1),
('Crew009', 6,2),
('Crew010', 2,1),
('Crew011', 3,2),
('Crew012', 1,3),
('Crew013', 3,3);

INSERT INTO Tickets (FlightID, PassengerID, TicketPrice, SeatNumber, SeatType)
VALUES
(1, 1, 500, 15, 'Business'),
(1, 2, 1500, 26, 'Economy'),
(2, 3, 2500, 10, 'Business'),
(3, 2, 800, 1, 'Business'),
(2, 1, 2000, 20, 'Business'),
(2, 2, 1200, 36, 'Economy'),
(3, 3, 900, 12, 'Business'),
(1, 2, 1000, 5, 'Economy'),
(1, 3, 800, 18, 'Business'),
(3, 3, 1200, 64, 'Economy');

Create view V1
As select DepartureDate, DepartureTime, DepartureAirport, ArrivalAirport, Distance from Flights

Create view V2
As select CrewCode,  Flights.FlightID, CrewMember.CrewMemberID from Crew 
Join Flights on Crew.FlightsID = Flights.FlightID
Join CrewMember on Crew.CrewMemberID = CrewMember.CrewMemberID

Create view V3
As select SeatType, Flights.FlightID, Passengers.PassengerID from Tickets 
Join Flights on Tickets.FlightID = Flights.FlightID
Join Passengers on Tickets.PassengerID = Passengers.PassengerID