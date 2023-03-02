using System;

class Script {
  public static string decisionSeparator =
  "=============================\n";

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
  "\nyou wake up, you are in a dungeon room with a dim light. It is clear you need to get out of this place, but through what " +
  "\ndoors must you venture through in order to find an exit?" +
  "\n\nCommands: enter [room name], go [full cardinal direction], yes, no, inventory, attack, look, etc." +
  "\n\n[Generally, you will be able to type a sentence, which will be checked for keywords to determine the command input]" +
  "\n=============================\n\n";

  public static string inputError =
  "\nSorry, that choice had no relevant keywords. Please Try Again.";

  public class roomR3GR37 {
    public static string initial = 
    "\nYou find yourself in a small, dark dungeon-like chamber. The walls are made of cold, gray stone, and the only light comes " +
    "\nfrom a dim light bulb, which hangs from a thin cable. The air in the room is thick, and a sense of dread hangs in it.";

    public static string previous = 
    "\nThis is the room you started in. It is a small, dark dungeon-like chamber. The walls are made of cold, gray stone, and the " +
    "\nonly light comes from a dim light bulb, which hangs from a thin cable. The air in the room is thick, and a sense of dread " +
    "\nhangs in it.";

    public static string navigation = 
    "\nThere are two thick wooden doors: one is marked as \"PR1D3\" (North), while the other is marked as \"6R33D\" (East). ";
  }

  public class roomPR1D3 {
    public static string initial = 
    "\nYou open the door marked as \"PR1D3\". You are greeted with a room lit with glittering lights and walls adorned with rainbow " +
    "\ncolors. You feel inspired, as if everything you ever wanted to do was suddenly within your reach. You can hear the sound of " +
    "\nlaughter and music, and it fills you with joy. You can't help but smile from the feeling of accomplishment." +
    "\n\nIn the center of the room is a mirror, with a highly decorated and carved frame.";

    public static string navigation = 
    "\nThere are three thick wooden doors: one is marked as \"R3GR37\" (South), another is marked as \"LU57\" (East), and the third is marked as \"3NV7\" (North).";

    public static string lookAtMirror1 = 
    "\nYou gaze into the ornate mirror. You are greeted with prideful images of yourself, images of you accomplishing all of your goals.";

    public static string lookAtMirror2 = 
    "\nYou continue to look at the mirror. It is enchanting, and you become increasingly interested in what is shown. The mirror continues to change between different successful versions of yourself.";

    public static string lookAtMirror3 = 
    "\nYou continue to look at the mirror. You are enthralled by the pride and confidence it gives you. \n\nWithin moments, you are trapped in your own vanity and unable to look away. You are held captive by the mirror, completely oblivious to the room around you. As you are distracted by the mirror, a monster steps into the room. It stands over seven feet tall, with a muscular, humanoid body. It is covered in matted fur. Its eyes are a bright, glowing red, and its mouth is filled with razor-sharp teeth that glisten in the dim light. As it approaches you, you smell its foul breath, a mixture of decay and sulfur. It makes your stomach turn, but you simply can't look away from the mirror. \n\nThe monster's attack is swift and brutal. With lightning-fast reflexes, it lunges towards you, its razor-sharp claws extended and ready to strike. You feel its claws slice through your flesh, tearing through muscle and bone, but the mirror demands attention. It continues its assault, slashing and biting at you. You can feel your strength draining away as the monster attacks, leaving you gasping for breath. In a matter of seconds, it is over, and you are left lying on the ground, bloodied and broken. Your eyes are still glued to the mirror as you bleed out.";

    public static string previous = 
    "\nYou are in the \"PR1D3\" Room. The glittering lights and wall are still flashing with colors, although less intense than when you entered the room the first time. The laughter and music are muted, as if coming from a few rooms away.\n\nThe mirror is still in the room, complete with its carved frame.";
  }

  public class room6R33D {
    public static string initial =
    "\nYou open the door market with \"6R33D\". You enter the room, and every surface is covered in shiny gold plating. There are gold tables with gold plates and chalices sat at each place, with a plush gold chair. Every inch of the room is filled with luxurious items, each more expensive than the last. \n\nThere is a pedestal off to the side of the room. Sat on a golden pillow on this pedestal are two objects: a pair of glasses made of gold, and a necklace made of rubies. You do not see any doors in the room, not even the one you had entered through.";

    public static string rubyNecklace =
    "\nYou take the ruby necklace and put it on. Suddenly the entire room is filled with a large metallic sound. As you look around the room, you see all the gold artifacts in the room start to shake. The shaking continues, until the entire room is rumbling. As the shaking progresses, the items start to duplicate themselves: at first slow, but at an ever increasing pace. You look around, but there is nothing that you can do to prevent the wave of golden items from crushing you.\n\nYou wonder what you could have done differently as the golden objects crush and lacerate your body, killing you.";

    public static string goldenGlasses = 
    "\nYou take the golden glasses and put them on. As your eyes adjust, you see that every object that was once golden is now made of rotting wood. There are maggots in the chalices. You are glad you didn't touch anything.\n\nAlong with everything else changing, you notice there now are three doors: one is marked as \"R3GR37\" (West), another is marked as \"LU57\" (North), and the third is marked as \"5107H\" (East).";

    public static string previous =
    "\nYou are in the \"6R33D\" Room. There are rotting wooden tables with rotting wooden bowls filled with maggots, rotting wood cups, and hard rotting chairs.\n\nThere are three thick wooden doors: one is marked as \"R3GR37\" (West), another is marked as \"LU57\" (North), and the third is marked as \"5107H\" (East).";
  }

  public class room3NV7 {
    public static string initial =
    "\nYou open the door marked as \"3NV7\". As the door opens, you see a withered hand place its fingers on the door and pull it fully open.\n\nAs you slowly step forward into the room, a withering humanoid emerges from the shadows, holding three items: a gun, a dagger, and a silver key.";

    public static string offerGun =
    "\nThe first item is a gun, which it holds out towards you with a toothy grin. It whispers, \"Take it, and gain the power to end anyone who stands in your way.\"";

    public static string acceptGun =
    "\nYou reach for the gun, but before you can grab it the humanoid snatches it away and aims it at your head. Its laughter echoes through the room as it pulls the trigger, ending your life in an instant.";

    public static string offerDagger =
    "\nYou refuse the first offer of the gun, and the humanoid sneers at you and says, \"As you wish, but you'll regret it.\" It then offers you a dagger instead, holding it out with a twisted grin. \"This blade will give you the power to cut down anyone who stands in your way,\" it says.";

    public static string acceptDagger =
    "\nYou reach for the dagger, but the humanoid quickly takes it back and plunges it into your chest. Its laughter fills the room as you collapse to the ground, lifeless.";

    public static string offerKey =
    "\nYou refuse the second offer of the dagger, the humanoid's expression turns to one of annoyance. It mutters under its breath before offering you the key. \"Take this key, and you'll unlock the power to overcome your greatest challenge,\" it says in a more subdued tone.";

    public static string rejectKey =
    "\nYou refuse the offer of the key. The humanoid's eyes narrow in anger. \"You fool!\" it hisses. \"You'll regret this decision.\" Suddenly, it lunges towards you with lightning speed, and before you can react, it sinks its razor-sharp teeth into your neck, draining your life force. As you collapse to the ground, the humanoid's laughter fills the room, satisfied that it has claimed another victim.";

    public static string acceptKey =
    "\nYou reach out for the key, and the humanoid nods in approval and hands it to you. As it does so, it whispers into your ear: \"With this key, a path will be revealed, where power and peril shall be unsealed\", before suddenly turning into dust and disappearing. You are left alone in the room, wondering what the key unlocks and just what the rest of this labyrinth holds for you.";

    public static string previous =
    "\nYou are in the \"3NV7\" room. The dust of the humanoid which offered you a gun, a dagger, and a key is still there. You wonder what would have happened if you had taken the gun and dagger.";

    public static string navigation =
    "\nThere are two thick wooden doors: one is marked as \"PR1D3\" (South), while the other is marked as \"61U770N7\" (East).";
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
  private static List<string> playerInventory = new List<string>();
  private static int playerHealth;
  private static string playerName = "";
  private static string playerChoice = "";
  // private static int trapDamage;
  // private static int trapDamageRange;



  public static void Main() {
    setGameData();
    introduction();
    roomR3GR37();
  }

  private static void setGameData() {
    roomsExplored = setRoomsExplored();
    playerInventory = new List<string>();
    playerHealth = 100;
    playerName = "";
    playerChoice = "";
    // trapDamage = 25;
    // trapDamageRange = 24;
  }

  private static Dictionary<string, bool> setRoomsExplored() {
    Dictionary<string, bool> ret = new Dictionary<string, bool>(9);
    string[] rooms = {"R3GR37", "PR1D3", "6R33D", "3NV7", "LU57", "5107H", "61U770N7", "4C3D14", "WR47H"};
    foreach(string room in rooms) {
      ret.Add(room, false);
    }

    return ret;
  }

  private static void printInventory() {
    Console.WriteLine("\nCurrent Inventory\n=================");
    foreach(string item in playerInventory) {
      Console.WriteLine("-  " + item);
    }
    Console.WriteLine("=================");
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
    Console.Write("\n\n" + prompt + "  ");
    return (Console.ReadLine() ?? "").ToUpper();
  }

  private static void roomR3GR37() {
    Console.WriteLine(Script.decisionSeparator);
    if(roomsExplored["R3GR37"]) {
      Console.WriteLine(Script.roomR3GR37.previous);
    } else {
      Console.WriteLine(Script.roomR3GR37.initial);
      roomsExplored["R3GR37"] = true;
    }
    Console.WriteLine(Script.roomR3GR37.navigation);

    while(true) {
      playerChoice = getChoice("What would you like to do?");
      
      if(playerChoice.Contains("PR1D3") || playerChoice.Contains("NORTH")) {
        roomPR1D3();
      } else if(playerChoice.Contains("6R33D") || playerChoice.Contains("EAST")) {
        room6R33D();
      } else if(playerChoice.Contains("INVENTORY")) {
        printInventory();
      } else {
        Console.WriteLine(Script.inputError);
      }
    }
  }

  private static void roomPR1D3(bool exitMirror = false) {
    Console.WriteLine(Script.decisionSeparator);
    if(!exitMirror){
      if(roomsExplored["PR1D3"]) {
        Console.WriteLine(Script.roomPR1D3.previous);
      } else {
        Console.WriteLine(Script.roomPR1D3.initial);
        roomsExplored["PR1D3"] = true;
      }
    }
    Console.WriteLine(Script.roomPR1D3.navigation);

    while(true) {
      playerChoice = getChoice("What would you like to do?");

      if(playerChoice.Contains("LOOK") || playerChoice.Contains("GAZE") || playerChoice.Contains("MIRROR")) {
        mirrorDialogue();
      } else if(playerChoice.Contains("R3GR37") || playerChoice.Contains("SOUTH")) {
        roomR3GR37();
      } else if(playerChoice.Contains("LU57") || playerChoice.Contains("EAST")) {
        roomLU57();
      } else if(playerChoice.Contains("3NV7") || playerChoice.Contains("NORTH")) {
        room3NV7();
      } else if(playerChoice.Contains("INVENTORY")) {
        printInventory();
      } else {
        Console.WriteLine(Script.inputError);
      }
    }
  }

  private static void mirrorDialogue() {
    Console.WriteLine(Script.decisionSeparator);
    Console.WriteLine(Script.roomPR1D3.lookAtMirror1);

    while(true) {
      playerChoice = getChoice("Continue looking at the mirror?");

      if(playerChoice.Contains("NO") || playerChoice.Contains("NOT")) {
        //need to add a message for ending looking at mirror
        roomPR1D3(true);
      } else if(playerChoice.Contains("YES") || playerChoice.Contains("CONTINUE")) {
        Console.WriteLine(Script.roomPR1D3.lookAtMirror2);

        while(true) {
          playerChoice = getChoice("Continue looking at the mirror?");

          if(playerChoice.Contains("NO") || playerChoice.Contains("NOT")) {
            //need to add a message for ending looking at mirror
            roomPR1D3(true);
          } else if(playerChoice.Contains("YES") || playerChoice.Contains("CONTINUE")) {
            Console.WriteLine(Script.roomPR1D3.lookAtMirror3);
            conclusionDead();
          } else if(playerChoice.Contains("INVENTORY")) {
            printInventory();
          } else {
            Console.WriteLine(Script.inputError);
          }
        }
      } else if(playerChoice.Contains("INVENTORY")) {
        printInventory();
      } else {
        Console.WriteLine(Script.inputError);
      }
    }
  }

  private static void room6R33D() {
    Console.WriteLine(Script.decisionSeparator);
    if(roomsExplored["6R33D"]) {
      Console.WriteLine(Script.room6R33D.previous);
    } else {
      Console.WriteLine(Script.room6R33D.initial);
      roomsExplored["6R33D"] = true;

      while(true) {
        playerChoice = getChoice("Will you take the Ruby Necklace or Golden Glasses?");

        if(playerChoice.Contains("GOLD")) {
          Console.WriteLine(Script.decisionSeparator);
          Console.WriteLine(Script.room6R33D.goldenGlasses);
          playerInventory.Add("Golden Glasses");
          break;
        } else if(playerChoice.Contains("RUBY")) {
          Console.WriteLine(Script.decisionSeparator);
          Console.WriteLine(Script.room6R33D.rubyNecklace);
          conclusionDead();
        } else if(playerChoice.Contains("INVENTORY")) {
          printInventory();
        } else {
          Console.WriteLine(Script.inputError);
        }
      }
    }

    while(true) {
      playerChoice = getChoice("What would you like to do?");

      if(playerChoice.Contains("R3GR37") || playerChoice.Contains("WEST")) {
        roomR3GR37();
      } else if(playerChoice.Contains("LU57") || playerChoice.Contains("NORTH")) {
        roomLU57();
      } else if(playerChoice.Contains("5107H") || playerChoice.Contains("EAST")) {
        room5107H();
      } else if(playerChoice.Contains("INVENTORY")) {
        printInventory();
      } else {
        Console.WriteLine(Script.inputError);
      }
    }
  }

  private static void room3NV7() {
    Console.WriteLine(Script.decisionSeparator);
    if(roomsExplored["3NV7"]) {
      Console.WriteLine(Script.room3NV7.previous);
    } else {
      Console.WriteLine(Script.room3NV7.initial);
      roomsExplored["3NV7"] = true;
      Console.WriteLine(Script.room3NV7.offerGun);

      while(true) {
        if(playerChoice.Contains("YES")) break;
        playerChoice = getChoice("Do you take the gun?");

        if(playerChoice.Contains("YES")) {
          Console.WriteLine(Script.room3NV7.acceptGun);
          conclusionDead();
        } else if(playerChoice.Contains("INVENTORY")) {
          printInventory();
        } else if(playerChoice.Contains("NO")) {
          Console.WriteLine(Script.room3NV7.offerDagger);

          while(true) {
            if(playerChoice.Contains("YES")) break;
            playerChoice = getChoice("Do you take the dagger?");

            if(playerChoice.Contains("YES")) {
              Console.WriteLine(Script.room3NV7.acceptDagger);
              conclusionDead();
            } else if(playerChoice.Contains("INVENTORY")) {
              printInventory();
            } else if(playerChoice.Contains("NO")) {
              Console.WriteLine(Script.room3NV7.offerKey);

              while(true) {
                if(playerChoice.Contains("YES")) break;
                playerChoice = getChoice("Do you take the silver key?");

                if(playerChoice.Contains("NO")) {
                  Console.WriteLine(Script.room3NV7.rejectKey);
                  conclusionDead();
                } else if(playerChoice.Contains("INVENTORY")) {
                  printInventory();
                } else if(playerChoice.Contains("YES")) {
                  Console.WriteLine(Script.room3NV7.acceptKey);
                  playerInventory.Add("Silver Key");
                } else {
                  Console.WriteLine(Script.inputError);
                }
              }
            } else {
              Console.WriteLine(Script.inputError);
            }
          }
        } else {
          Console.WriteLine(Script.inputError);
        }
      }
    }
    Console.WriteLine(Script.room3NV7.navigation);

    while(true) {
      playerChoice = getChoice("What would you like to do?");

      if(playerChoice.Contains("PR1D3") || playerChoice.Contains("SOUTH")) {
        roomPR1D3();
      } else if(playerChoice.Contains("61U770N7") || playerChoice.Contains("EAST")) {
        room61U770N7();
      } else if(playerChoice.Contains("INVENTORY")) {
        printInventory();
      } else {
        Console.WriteLine(Script.inputError);
      }
    }


  }

  private static void roomLU57() {
    Console.WriteLine(Script.decisionSeparator);

  }

  private static void room5107H() {
    Console.WriteLine(Script.decisionSeparator);

  }

  private static void room61U770N7() {
    Console.WriteLine(Script.decisionSeparator);

  }

  private static void room4C3D14() {
    Console.WriteLine(Script.decisionSeparator);

  }

  private static void roomWR47H() {
    Console.WriteLine(Script.decisionSeparator);

  }

  private static void conclusionDead() {
    Console.WriteLine("YOU ARE DEAD.");
  }
}