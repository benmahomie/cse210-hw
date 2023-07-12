Address _mandalayBay = new Address("3087 Mandalay Bay Rd", "Las Vegas", "NV");
Address _iCenter = new Address("Center 50, W Viking St", "Rexburg", "ID");
Address _golden1Center = new Address("500 David J Stern Walk", "Sacramento", "CA");

Lecture _fundamentalsOfIOT = new Lecture("Fundamentals of IOT", "Gary Covey will cover the fundamentals of IOT devices used in the industry.", "July 21, 2023", "10:00am", _mandalayBay, "Gary Covey", 145);
Reception _sparklingStarsGala = new Reception("Sparkling Stars Gala", "Join us for an enchanting evening of elegance, glamour, and celebration.", "July 28, 2023", "9:00pm", _golden1Center, "rsvp@starsofsac.com");
OutdoorGathering _summerBreezePicnic = new OutdoorGathering("Summer Breeze Picnic", "Join us for a delightful afternoon of fun, food, and relaxation.", "July 27, 2023", "11:00am", _iCenter, "Overcast");

Console.WriteLine("FUNDAMENTALS OF IOT\n");
_fundamentalsOfIOT.PrintStandardDetails();
_fundamentalsOfIOT.PrintFullDetails();
_fundamentalsOfIOT.PrintShortDescription();
Console.WriteLine("SPRKLING STARS GALA\n");
_sparklingStarsGala.PrintStandardDetails();
_sparklingStarsGala.PrintFullDetails();
_sparklingStarsGala.PrintShortDescription();
Console.WriteLine("SUMMER BREEZE PICNIC");
_summerBreezePicnic.PrintStandardDetails();
_summerBreezePicnic.PrintFullDetails();
_summerBreezePicnic.PrintShortDescription();