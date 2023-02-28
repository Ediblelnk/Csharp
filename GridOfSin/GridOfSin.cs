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
  "\nYou were exploring a cave, when all of a sudden, you get hit on the head from behind, rendering you unconscious. When " +
  "you wake up, you are in a dungeon room with a dim light. It is clear you need to get out of this place, but through what " +
  "doors must you venture through in order to find an exit?" +
  "\n\nGeneral Commands: enter [room name], go [cardinal direction], yes, no, inventory, attack, look, etc." +
  "\n\n[Generally, you will be able to type a sentence, which will be checked for keywords to determine the command input]" +
  "\n=============================";

  public class roomR3GR37 {
    public static string initial = 
    "You find yourself in a small, dark dungeon-like chamber. The walls are made of cold, gray stone, and the only light comes " +
    "\nfrom a dim light bulb, which hangs from a thin cable. The air in the room is thick, and a sense of dread hangs in it.";
    public static string previous = 
    "This is the room you started in. It is a small, dark dungeon-like chamber. The walls are made of cold, gray stone, and the " +
    "\nonly light comes from a dim light bulb, which hangs from a thin cable. The air in the room is thick, and a sense of dread " +
    "\nhangs in it.";
    public static string navigation = 
    "There are two thick wooden doors: one is marked as \"PR1D3\" (North), while the other is marked as \"6R33D\" (East). " +
    "\nWhat would you like to do?";
  }

  public class roomPR1D3 {

  }

  public class room6R33D {

  }

  public class room3NV7 {

  }

  public class roomLU57 {

  }

  public class room5107H {

  }

  public class room61U770N7 {

  }

  public class room4C3D14 {

  }

  public class roomWR47H {

  }
}

class GridOfSin {
  private static Dictionary<string, bool> roomsExplored = new Dictionary<string, bool>(9);
  private static bool[] playerInventory = new bool[3];
  private static int playerHealth;
  private static string playerName = "";
  private static string playerNavigation = "";
  private static int trapDamage;
  private static int trapDamageRange;



  public static void Main() {
    setGameData();
    introduction();

  }

  private static void setGameData() {
    roomsExplored = setRoomsExplored();
    playerInventory = new bool[3];
    playerHealth = 100;
    playerName = "";
    playerNavigation = "";
    trapDamage = 25;
    trapDamageRange = 24;
  }

  private static Dictionary<string, bool> setRoomsExplored() {
    Dictionary<string, bool> ret = new Dictionary<string, bool>(9);
    string[] rooms = {"R3GR37", "PR1D3", "6R33D", "3NV7", "LU57", "5107H", "61U770N7", "4C3D14", "WR47H"};
    foreach(string room in rooms) {
      ret.Add(room, false);
    }

    return ret;
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

  private static string getChoice() {
    return "";
  }

  private static void roomR3GR37() {
    if(roomsExplored["R3GR37"]) {
      Console.WriteLine(Script.roomR3GR37.previous);
    } else {
      Console.WriteLine(Script.roomR3GR37.initial);
    }
    Console.WriteLine(Script.roomR3GR37.navigation);

    while(true) {
      playerNavigation = (Console.ReadLine() ?? "").ToUpper();
      
      if(playerNavigation.Contains("PR1D3") || playerNavigation.Contains("NORTH")) {
        roomPR1D3();
      } else if(playerNavigation.Contains("6R33D") || playerNavigation.Contains("EAST")) {
        room6R33D();
      }
    }
  }

  private static void roomPR1D3() {

  }

  private static void room6R33D() {

  }

  private static void room3NV7() {

  }

  private static void roomLU57() {

  }

  private static void room5107H() {

  }

  private static void room61U770N7() {

  }

  private static void room4C3D14() {

  }

  private static void roomWR47H() {

  }
}