INSERT INTO Flights (AirplaneID, DepartureDate, DepartureTime, DepartureAirport, ArrivalAirport, Distance)
VALUES
(1, '2023-03-20', '09:00:00', 'WAW', 'GDN', 307),
(2, '2023-03-23', '10:00:00', 'POZ', 'WRO', 247),
(3, '2023-03-25', '08:00:00', 'WAW', 'KRK', 244);

INSERT INTO Crew (CrewCode, FlightsID, CrewMemberID)
VALUES
('Crew004', 4,1),
('Crew005', 5,2),
('Crew006', 6,3),
('Crew007', 4,4),
('Crew008', 5,1),
('Crew009', 6,2);

///// ещё

INSERT INTO Airplanes (RegistrationNumber, Type, NumberOfSeats, Payload, Speed, ManufactureDate, FlightHours, LastRepairDate, Destination, FuelConsumption)
VALUES
('JKL012', 'Airbus A380', 500, 90000, 950, '2015-10-01', 8000.1, '2022-12-01', 'London', 14.2),
('MNO345', 'Boeing 787', 250, 50000, 800, '2018-07-15', 4000.2, '2023-02-15', 'Paris', 11.3),
('PQR678', 'Embraer E190', 100, 25000, 550, '2013-02-28', 6000.5, '2021-09-30', 'Rome', 7.9);

-- Пример заполнения таблицы CrewMember:
INSERT INTO CrewMember (FullName, PassportData)
VALUES
('Ivan Ivanov', '1111111111'),
('Sergey Petrov', '2222222222'),
('Olga Smirnova', '3333333333');

-- Пример заполнения таблицы Passengers:
INSERT INTO Passengers (FullName, PassportData)
VALUES
('Maria Garcia', '4444444444'),
('Nikolay Kim', '5555555555'),
('Yulia Popova', '6666666666');

-- Пример заполнения таблицы Flights:
INSERT INTO Flights (AirplaneID, DepartureDate, DepartureTime, DepartureAirport, ArrivalAirport, Distance)
VALUES
(2, '2023-03-19', '10:00:00', 'CDG', 'WAW', 1169),
(3, '2023-03-20', '14:00:00', 'FCO', 'WAW', 998),
(1, '2023-03-21', '18:00:00', 'LHR', 'WAW', 1408);

-- Пример заполнения таблицы Crew:
INSERT INTO Crew (CrewCode, FlightsID, CrewMemberID)
VALUES
('Crew004', 2,1),
('Crew005', 3,2),
('Crew006', 1,3);

-- Пример заполнения таблицы Tickets:
INSERT INTO Tickets (FlightID, PassengerID, TicketPrice, SeatNumber, SeatType)
VALUES
(2, 1, 2000, 20, 'Business'),
(2, 2, 1200, 36, 'Economy'),
(3, 3, 900, 12, 'Business'),
(1, 2, 1000, 5, 'Economy'),
(1, 3, 800, 18, 'Business');