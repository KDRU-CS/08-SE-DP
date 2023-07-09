using MediatorDesignPattern;
using static System.Console;

// Call center acts as Mediator
var callCenter = new CallCenter();

// Passengers
var passenger1 = new Passenger("Ahmad", "District #1", 5);
var passenger2 = new Passenger("Khan", "District #4", 20);

// Cabs
var cab1 = new Cab("Rozi Khan", 3, true);
var cab2 = new Cab("Shafiq Ustaaz", 4, false);
var cab3 = new Cab("Rahman Ustaaz", 10, true);
var cab4 = new Cab("Abdul Hadi", 3, true);

// Register Cabs on Mediator
callCenter.Register(cab1);
callCenter.Register(cab2);
callCenter.Register(cab3);
callCenter.Register(cab4);

// Assign passengers to call center
callCenter.BookCab(passenger1);
callCenter.BookCab(passenger2);

ReadLine(); // stay on terminal