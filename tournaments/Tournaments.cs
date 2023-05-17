Player messi = new Player("Lionel Messi", 30, "Forward");
Player nathan = new Player("Nathan Cole", 01, "Hype Man");

Team awesomeSauce = new Team("Awesome Sauce");

awesomeSauce.AddPlayer(messi);
awesomeSauce.AddPlayer(nathan);

awesomeSauce.AddWin(100);
awesomeSauce.AddLoss(0);

Console.WriteLine($"Team {awesomeSauce.ReturnName()}");
awesomeSauce.DisplayRecord();
awesomeSauce.DisplayRoster();