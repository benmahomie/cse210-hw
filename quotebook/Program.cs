// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Board _board = new Board();

_board.AddQuote(
    new Quote(
        "Paul",
        "God hath not given...",
        new Source("2 Timothy 1:7")
    )
);

_board.AddQuote(
    new Quote(
        "Sister Elaine S. Dalton",
        "Work hard...",
        new Source(
            "How to Dare Great Things",
            "https://www.churchofjesuschrist.org"
        )
    )
);

_board.AddQuote(
    new Quote(
        "Michael Scott",
        "You miss 100% of the shots you don't take. - Wayne Gretzky",
        new Source("waynegretzkyquotes.com")
    )
);

// Source source = new Source("None Were With Him", "http://www.chruchofjesuschrist.org");

// Console.WriteLine(source.Stringify());

// Quote holland = new Quote("Elder Holland","Because Jesus walked...",source);

// // Console.WriteLine(holland.GetQuote());

// Board quoteboard = new Board();
// quoteboard.AddQuote(holland);
// quoteboard.FindQuotesByAuthor("holland");

// _board.GetRandomQuote();

Menu _menu = new Menu(_board);
_menu.Display();