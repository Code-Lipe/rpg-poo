using rpg_poo.src.Entities;

// Create three heroes
Knight thresh = new Knight("Support", 250, "Thresh");
Mage syndra = new Mage("Mage", 200, "Syndra");
Knight darius = new Knight("Fighter", 300, "Darius");

Console.WriteLine(thresh.HeroStatus());
Console.WriteLine(syndra.HeroStatus());
Console.WriteLine(darius.HeroStatus());

// Start game
Gameplay play = new Gameplay(thresh, syndra, darius);
play.StartGame();