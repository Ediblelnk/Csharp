using System;

class Script {
  public static string introduction = 
  "Grid of Sins" +
  "\nby Peter Schaefer" +
  "\nCSC 240" +
  "\nProject #2" +
  "\n=============================";
  public static string warning = 
  "CONTENT WARNING: This game is a horror game. It contains explicit descriptions and mature themes." + 
  "\nRATING: PG-13, TV-M" +
  "\n=============================";
  public static string preNamePrompt = 
  "Character name: ";
  public static string postNamePrompt = 
  "=============================";
  public static string aboutGame = 
  "GAME INFORMATION" + 
  "\nYou were exploring a cave, when all of a sudden, you get hit on the head from behind, rendering you unconscious. When you wake up, you are in a dungeon room, with a dim light. It is clear you need to get out of this place, but through what doors must you venture through in order to find an exit?" +
  "\n\nGeneral Commands: enter [room name], go [cardinal direction], yes, no, inventory, attack, look, etc." +
  "\n\n[Generally, you will be able to type a sentence, which will be checked for keywords to determine the command input]" +
  "\n=============================";
}

class GridOfSin {
  private static bool[] playerInventory = new bool[3];
  private static int playerHealth;
  private static string playerName = "";
  private static int trapDamage;
  private static int trapDamageRange;



  public static void Main() {
    introduction();
  }

  private static void setGameData() {
    playerInventory = new bool[3];
    playerHealth = 100;
    playerName = "";
    trapDamage = 25;
    trapDamageRange = 24;
  }

  private static void introduction() {
    Console.Clear();  //clear console for better immersion
    Console.WriteLine(Script.introduction);
    Console.WriteLine(Script.warning);
    
    Console.Write(Script.preNamePrompt);
    playerName = Console.ReadLine() ?? "Bob";
    Console.WriteLine(Script.postNamePrompt);

    Console.WriteLine(Script.aboutGame);
  }
}