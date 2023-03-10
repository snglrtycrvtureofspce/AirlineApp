create database airlines

use airlines

go
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

INSERT INTO Airplanes (RegistrationNumber, Type, NumberOfSeats, Payload, Speed, ManufactureDate, FlightHours, LastRepairDate, Destination, FuelConsumption)
VALUES
('ABC123', 'Boeing 747', 400, 80000, 900, '2000-01-01', 25000.5, '2022-02-28', 'Warsaw', 12.5),
('DEF456', 'Airbus A320', 150, 40000, 600, '2005-06-30', 18000.3, '2021-10-15', 'Wroclaw', 8.7),
('GHI789', 'Boeing 737', 200, 50000, 700, '2010-03-15', 12000.2, '2022-01-10', 'Poznan', 9.2);

INSERT INTO CrewMember (FullName, PassportData)
VALUES
('Elizabeth Shalkevich', '1234567890'),
('Ksenia Prikhodko', '0987654321'),
('Konstantin Korzhik', '1357908642'),
('Dana Danilovich', '2468013579');

INSERT INTO Passengers (FullName, PassportData)
VALUES
('Kim Min-ji', '0987654321'),
('Pham Ngoc Khan', '1234567890'),
('Kang Hae-rin', '2468013579');

INSERT INTO Flights (AirplaneID, DepartureDate, DepartureTime, DepartureAirport, ArrivalAirport, Distance)
VALUES
(1, '2023-03-15', '08:00:00', 'WAW', 'POZ', 3441),
(2, '2023-03-16', '12:00:00', 'WRO', 'WAW', 2475),
(3, '2023-03-18', '16:00:00', 'KRK', 'WRO', 1745);

INSERT INTO Crew (CrewCode, FlightsID, CrewMemberID)
VALUES
('Crew001', 1,1),
('Crew002', 2,2),
('Crew003', 3,3);

INSERT INTO Tickets (FlightID, PassengerID, TicketPrice, SeatNumber, SeatType)
VALUES
(1, 1, 500, 15, 'Business'),
(1, 2, 1500, 26, 'Economy'),
(2, 3, 2500, 10, 'Business'),
(3, 2, 800, 1, 'Business'),
(3, 3, 1200, 64, 'Economy');