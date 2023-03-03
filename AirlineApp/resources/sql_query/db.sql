-- Создание таблицы "Airplanes"
CREATE TABLE Airplanes (
AirplaneID INT PRIMARY KEY,
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
);
GO

-- Создание таблицы "Crew"
CREATE TABLE Crew (
CrewID INT PRIMARY KEY,
CrewCode VARCHAR(10) NOT NULL,
AirplaneID INT NOT NULL,
FOREIGN KEY (AirplaneID) REFERENCES Airplanes (AirplaneID)
);
GO

-- Создание таблицы "CrewMember"
CREATE TABLE CrewMember (
CrewMemberID INT PRIMARY KEY,
CrewID INT NOT NULL,
FullName VARCHAR(50) NOT NULL,
PassportData VARCHAR(50) NOT NULL,
FOREIGN KEY (CrewID) REFERENCES Crew (CrewID)
);
GO

-- Создание таблицы "Flights"
CREATE TABLE Flights (
FlightID INT PRIMARY KEY,
AirplaneID INT NOT NULL,
DepartureDate DATE NOT NULL,
DepartureTime TIME NOT NULL,
DepartureAirport VARCHAR(50) NOT NULL,
ArrivalAirport VARCHAR(50) NOT NULL,
Distance INT NOT NULL,
FOREIGN KEY (AirplaneID) REFERENCES Airplanes (AirplaneID)
);
GO

-- Создание таблицы "Passengers"
CREATE TABLE Passengers (
PassengerID INT PRIMARY KEY,
FullName VARCHAR(50) NOT NULL,
PassportData VARCHAR(50) NOT NULL,
SeatNumber INT NOT NULL,
SeatType VARCHAR(10) NOT NULL
);
GO

-- Создание таблицы "Tickets"
CREATE TABLE Tickets (
TicketID INT PRIMARY KEY,
FlightID INT NOT NULL,
PassengerID INT NOT NULL,
TicketPrice MONEY NOT NULL,
FOREIGN KEY (FlightID) REFERENCES Flights (FlightID),
FOREIGN KEY (PassengerID) REFERENCES Passengers (PassengerID)
);
GO