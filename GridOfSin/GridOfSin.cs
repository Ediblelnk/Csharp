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
    "There are two thick wooden doors: one is marked as \"PR1D3\" (North), while the other is marked as \"6R33D\" (East). ";
  }

  public class roomPR1D3 {
    public static string initial = 
    "You open the door marked as \"PR1D3\". You are greeted with a room lit with glittering lights and walls adorned with rainbow " +
    "\ncolors. You feel inspired, as if everything you ever wanted to do was suddenly within your reach. You can hear the sound of " +
    "\nlaughter and music, and it fills you with joy. You can't help but smile from the feeling of accomplishment." +
    "\n\nIn the center of the room is a mirror, with a highly decorated and carved frame.";

    public static string navigation = 
    "There are three thick wooden doors: one is marked as \"R3GR37\" (South), another is marked as \"LU57\" (East), and the third is marked as \"3NV7\" (North).";

    public static string lookAtMirror1 = 
    "You gaze into the ornate mirror. You are greeted with prideful images of yourself, images of you accomplishing all of your goals.";

    public static string lookAtMirror2 = 
    "You continue to look at the mirror. It is enchanting, and you become increasingly interested in what is shown. The mirror continues to change between different successful versions of yourself.";

    public static string lookAtMirror3 = 
    "You continue to look at the mirror. You are enthralled by the pride and confidence it gives you. \n\nWithin moments, you are trapped in your own vanity and unable to look away. You are held captive by the mirror, completely oblivious to the room around you. As you are distracted by the mirror, a monster steps into the room. It stands over seven feet tall, with a muscular, humanoid body. It is covered in matted fur. Its eyes are a bright, glowing red, and its mouth is filled with razor-sharp teeth that glisten in the dim light. As it approaches you, you smell its foul breath, a mixture of decay and sulfur. It makes your stomach turn, but you simply can't look away from the mirror. \n\nThe monster's attack is swift and brutal. With lightning-fast reflexes, it lunges towards you, its razor-sharp claws extended and ready to strike. You feel its claws slice through your flesh, tearing through muscle and bone, but the mirror demands attention. It continues its assault, slashing and biting at you. You can feel your strength draining away as the monster attacks, leaving you gasping for breath. In a matter of seconds, it is over, and you are left lying on the ground, bloodied and broken. Your eyes are still glued to the mirror as you bleed out.";

    public static string previous = 
    "You are in the \"PR1D3\" Room. The glittering lights and wall are still flashing with colors, although less intense than when you entered the room the first time. The laughter and music are muted, as if coming from a few rooms away.\n\nThe mirror is still in the room, complete with its carved frame.";
  }

  public class room6R33D {
    public static string initial =
    "You open the door market with \"6R33D\". You enter the room, and every surface is covered in shiny gold plating. There are gold tables with gold plates and chalices sat at each place, with a plush gold chair. Every inch of the room is filled with luxurious items, each more expensive than the last. \n\nThere is a pedestal off to the side of the room. Sat on a golden pillow on this pedestal are two objects: a pair of glasses made of gold, and a necklace made of rubies. You do not see any doors in the room, not even the one you had entered through.";

    public static string rubyNecklace =
    "You take the ruby necklace and put it on. Suddenly the entire room is filled with a large metallic sound. As you look around the room, you see all the gold artifacts in the room start to shake. The shaking continues, until the entire room is rumbling. As the shaking progresses, the items start to duplicate themselves: at first slow, but at an ever increasing pace. You look around, but there is nothing that you can do to prevent the wave of golden items from crushing you.\n\nYou wonder what you could have done differently as the golden objects crush and lacerate your body, killing you.";

    public static string goldenGlasses = 
    "You take the golden glasses and put them on. As your eyes adjust, you see that every object that was once golden is now made of rotting wood. There are maggots in the chalices. You are glad you didn't touch anything.\n\nAlong with everything else changing, you notice there now are three doors: one is marked as \"R3GR37\" (West), another is marked as \"LU57\" (North), and the third is marked as \"5107H\" (East).";

    public static string previous =
    "You are in the \"6R33D\" Room. There are rotting wooden tables with rotting wooden bowls filled with maggots, rotting wood cups, and hard rotting chairs.\n\nThere are three thick wooden doors: one is marked as \"R3GR37\" (West), another is marked as \"LU57\" (North), and the third is marked as \"5107H\" (East).";
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
  private static string playerChoice = "";
  private static int trapDamage;
  private static int trapDamageRange;



  public static void Main() {
    setGameData();
    introduction();
    roomR3GR37();
  }

  private static void setGameData() {
    roomsExplored = setRoomsExplored();
    playerInventory = new bool[3];
    playerHealth = 100;
    playerName = "";
    playerChoice = "";
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

  private static string getChoice(string prompt) {
    Console.Write("\n\n" + prompt);
    return (Console.ReadLine() ?? "").ToUpper();
  }

  private static void roomR3GR37() {
    if(roomsExplored["R3GR37"]) {
      Console.WriteLine(Script.roomR3GR37.previous);
    } else {
      Console.WriteLine(Script.roomR3GR37.initial);
    }
    Console.WriteLine(Script.roomR3GR37.navigation);

    while(true) {
      playerChoice = getChoice("What would you like to do? ");
      
      if(playerChoice.Contains("PR1D3") || playerChoice.Contains("NORTH")) {
        roomPR1D3();
      } else if(playerChoice.Contains("6R33D") || playerChoice.Contains("EAST")) {
        room6R33D();
      } else {
        Console.WriteLine("Sorry, that choice had no relevant keywords. Please Try Again.");
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