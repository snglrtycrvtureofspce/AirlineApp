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