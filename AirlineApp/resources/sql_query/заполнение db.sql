-- Заполнение таблицы "Airplanes"
INSERT INTO Airplanes (AirplaneID, RegistrationNumber, Type, NumberOfSeats, Payload, Speed, ManufactureDate, FlightHours, LastRepairDate, Destination, FuelConsumption)
VALUES
(1, 'ABC123', 'Boeing 747', 400, 80000, 900, '2000-01-01', 25000.5, '2022-02-28', 'Warsaw', 12.5),
(2, 'DEF456', 'Airbus A320', 150, 40000, 600, '2005-06-30', 18000.3, '2021-10-15', 'Wroclaw', 8.7),
(3, 'GHI789', 'Boeing 737', 200, 50000, 700, '2010-03-15', 12000.2, '2022-01-10', 'Poznan', 9.2);

-- Заполнение таблицы "Crew"
INSERT INTO Crew (CrewID, CrewCode, AirplaneID)
VALUES
(1, 'Crew001', 1),
(2, 'Crew002', 2),
(3, 'Crew003', 3);

-- Заполнение таблицы "CrewMember"
INSERT INTO CrewMember (CrewMemberID, CrewID, FullName, PassportData)
VALUES
(1, 1, 'Elizabeth Shalkevich', '1234567890'),
(2, 1, 'Ksenia Prikhodko', '0987654321'),
(3, 2, 'Konstantin Korzhik', '1357908642'),
(4, 3, 'Dana Danilovich', '2468013579');

-- Заполнение таблицы "Flights"
INSERT INTO Flights (FlightID, AirplaneID, DepartureDate, DepartureTime, DepartureAirport, ArrivalAirport, Distance)
VALUES
(1, 1, '2023-03-15', '08:00:00', 'WAW', 'POZ', 3441),
(2, 2, '2023-03-16', '12:00:00', 'WRO', 'WAW', 2475),
(3, 3, '2023-03-18', '16:00:00', 'KRK', 'WRO', 1745);

-- Заполнение таблицы "Passengers"
INSERT INTO Passengers (PassengerID, FullName, PassportData, SeatNumber, SeatType)
VALUES
(1, 'Kim Min-ji', '0987654321', 10, 'Economy'),
(2, 'Pham Ngoc Khan', '1234567890', 15, 'Business'),
(3, 'Kang Hae-rin', '2468013579', 7, 'Business');

-- Заполнение таблицы "Tickets"
INSERT INTO Tickets (TicketID, FlightID, PassengerID, TicketPrice)
VALUES
(1, 1, 1, 500),
(2, 1, 2, 1500),
(3, 2, 3, 2500),
(4, 3, 2, 800),
(5, 3, 3, 1200);