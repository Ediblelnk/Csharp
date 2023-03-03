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

  public static string deathMsg = 
  "\nYOU HAVE DIED. " +
  "\n\nYour corpse will be forever lost to the dungeon, held in company with the humanoids and dark magic beings " +
  "living here.";

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
    public static string initial = 
    "\nYou open the door marked \"LU57\", and you enter a near empty room. There is a torch flickering on one wall, casting shadows which dance around the room. Suddenly, a beautiful woman appears before you. Her long hair flows around her shoulders, and her eyes twinkle in the dim light. She is holding a small vial, filled with a strange pink liquid. She offers it to you, claiming it symbolizes love, through which all things are possible.";

    public static string acceptVial = 
    "\nYou reach out to grab it, but before you can, the woman transforms into a grotesque monster with razor-sharp claws and teeth. You stumble back, your heart pounding in fear, as the monster lunges at you, intent on tearing you apart. However, just as she is about to rip you to shreds, she evaporates into the air, but not before she was able to get a couple scratches in. You catch your breath, gripping your scratches.\n\nYou look around, and realize you dropped the vial when the woman had jumped at you. The pink liquid is oozing all over the floor, mixed with the broken glass from the vial.";

    public static string rejectVial =
    "\nYou firmly decline the vial, but the woman refuses to accept your answer. She keeps insisting that you take the vial, growing increasingly insistent and desperate. You continue to reject her, and her beauty slowly fades; she transforms into a hideous witch.\n\nHer hair turns brittle and gray, her skin wrinkles and sags, and her eyes grow dull and lifeless. She withers away into nothingness, leaving you alone in the dungeon, shaking with relief.";

    public static string navigation =
    "\nThere are four thick wooden doors: one is marked as \"PR1D3\" (West), another is marked as \"61U770N7\" (North), the third is marked as \"6R33D\" (South), while the fourth \"4C3D14\" (East).";

    public static string previous =
    "\nYou open the door to the \"LU57\" room. There is a torch flickering on one wall, casting shadows which dance around the room.";

    public static string acceptedVial = 
    "\nYou see the mix of broken glass and pink liquid from when you accepted the offer of the woman.";
  }

  public class room5107H {
    public static string initial =
    "\nYou open the door marked \"5107H\", and are greeted with a dimly lit room, with cold stone walls. You notice something unusual in the center of the room: a set of comfortable-looking furniture arranged neatly.\n\nWhen you inspect closer, you see the furniture is made of plush leather and soft cushions. You see something shiny wedged in the cushion of one chair, but you are not sure what it is. You are drawn to sit in it.";

    public static string sitChair =
    "\nYou approach cautiously and sit down on one of the chairs, and sink into its comforting embrace.\n\nSuddenly, you hear a loud click. The chair's arms have snapped shut, trapping you. Panic sets in as you struggle to break free. You look around and see the shiny object wedged in the cushion of the chair you are trapped in. You might be able to grab it if you try hard enough.";

    public static string reachObject =
    "\nYou angle your feet up on the chair enough to pry the shiny object out of the cushion. You are able to see it is a bronze key, and notice that there is a small keyhole on the arm of the chair, right beside your hand.\n\nYou realize that the key must be the only way out of this trap, and need to put the key into the chair. You struggle to orientate your body so that the key fits into the keyhole, but eventually you are able to get it.\n\nYou insert the key and turn it, and it gives a releasing click. The chair's grip on you loosens, and you are able to get up. You grab the bronze key.";

    public static string navigation =
    "\nThere are two thick wooden doors: one is marked as \"6R33D\" (West), while the other is marked as \"4C3D14\" (North).";

    public static string previousSat =
    "\nThis is the \"5107H\" room; it is a dimly lit room, with cold stone walls. It has a set of comfortable-looking furniture arranged neatly in the center of the room, which you had previously sat in.";

    public static string previousNoSat =
    "\nThis is the \"5107H\" room; it is a dimly lit room, with cold stone walls. It has a set of comfortable-looking furniture arranged neatly in the center of the room, which has a shiny object in the cushion of one chair. You are still drawn to it";
  }

  public class room61U770N7 {
    public static string entrance =
    "\nAs you enter the \"61U770N7\" Room, your nostrils are met with the intoxicating  aroma of food. There are tables and tables of food and drink around you. Your stomach growls with hunger and your mouth is dry with thirst.\n\nThere are three thick wooden doors: one is marked as \"3NV7\" (West), another is marked as \"LU57\" (South), and the third is marked as \"WR47H\" (East).";

    public static string ateFood =
    "\nYou decide to give in to your hunger and thirst and start to consume the food at a rapid rate. You shovel food into your mouth, barely even giving your tongue a chance to taste it, in a desperate attempt to fill your stomach.\n\nSuddenly, you feel a sharp pain in your stomach, and you collapse to the ground. You realize, too late, that the food has been poisoned. As life fades from your eyes, you ask yourself what you could have done differently.";
  }

  public class room4C3D14 {
    public static string entrance =
    "\nYou open the \"4C3D14\" door and are greeted with a pristine stone box of a room. The walls are completely smooth, and the floor is flat as can be. The only thing in the room not in pristine condition is in the very center of the room: a protrusion coming out from the center of the floor. There is a rusty hatch on the protrusion, held shut with a lock.\n\nYou approach the hatch. As you inspect it, you see that the lock has three keyholes.\n\nThere are three thick wooden doors: one is marked as \"WR47H\" (North), another is marked as \"LU57\" (West), and the third is marked as \"5107H\" (South). What would you like to do?";

    public static string threeKeys1 =
    "\nYou grab the three keys you have collected: the bronze key, the silver key, and the gold key and place them into the lock at the center of the room. You hear the lock click open, and you are able to release it from holding the hatch.\n\nYou grab the rusty hatch and use all your might to flip it open. It reveals a ladder, built into the floor, going down unto the depths below. You don't know what it might hold, but it surely must  be better than the hell that you just went through.\n\nYou mount the ladder, and start descending into the darkness. As you descend, you start to hear the sound of a search party. You hear your name being called; they are searching for you! As you continue going down, you are able to see their search lights shining up at you.";

    // "[NAME], is that you? Oh my god, it is you! We are so glad we have found you!"

    public static string threeKeys2 =
    "\nYour heart races with excitement and gratitude as you make your way towards the sound of their voices. As you emerge from the ladder and rejoin your friends, you feel overwhelmed with gratitude and a renewed sense of appreciation for your life.";
  }

  public class roomWR47H {

  }
}

class GridOfSin {
  private static Dictionary<string, bool> roomsExplored = new Dictionary<string, bool>(9);
  private static bool acceptedVial = false;
  private static bool satInChair = false;
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
    acceptedVial = false;
    satInChair = false;
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
          Console.WriteLine(Script.room6R33D.goldenGlasses);
          playerInventory.Add("Golden Glasses");
          break;
        } else if(playerChoice.Contains("RUBY")) {
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
    if(roomsExplored["LU57"]) {
      Console.WriteLine(Script.roomLU57.previous);
      if(acceptedVial) {Console.WriteLine(Script.roomLU57.acceptedVial);}
    } else {
      Console.WriteLine(Script.roomLU57.initial);
      roomsExplored["LU57"] = true;

      while(true) {
        playerChoice = getChoice("Do you accept the vial?");

        if(playerChoice.Contains("YES")) {
          Console.WriteLine(Script.roomLU57.acceptVial);
          acceptedVial = true;
          break;
        } else if(playerChoice.Contains("NO")) {
          Console.WriteLine(Script.roomLU57.rejectVial);
          break;
        } else if(playerChoice.Contains("INVENTORY")) {
          printInventory();
        } else {
          Console.WriteLine(Script.inputError);
        }
      }
    }
    Console.WriteLine(Script.roomLU57.navigation);

    while(true) {
      playerChoice = getChoice("What would you like to do?");

      if(playerChoice.Contains("PR1D3") || playerChoice.Contains("WEST")) {
        roomPR1D3();
      } else if(playerChoice.Contains("61U770N7") || playerChoice.Contains("NORTH")) {
        room61U770N7();
      } else if(playerChoice.Contains("6R33D") || playerChoice.Contains("SOUTH")) {
        room6R33D();
      } else if(playerChoice.Contains("4C3D14") || playerChoice.Contains("EAST")) {
        room4C3D14();
      } else if(playerChoice.Contains("INVENTORY")) {
        printInventory();
      } else {
        Console.WriteLine(Script.inputError);
      }
    }
  }

  private static void room5107H(bool exitChair = false) {
    Console.WriteLine(Script.decisionSeparator);
    if(roomsExplored["5107H"] && satInChair) {
      Console.WriteLine(Script.room5107H.previousSat);
    } else if(roomsExplored["5107H"] && !satInChair) {
      Console.WriteLine(Script.room5107H.previousSat);
    } else {
      Console.WriteLine(Script.room5107H.initial);
      roomsExplored["5107H"] = true;
      Console.WriteLine(Script.room5107H.navigation);

      while(true) {
        playerChoice = getChoice("What would you like to do?");

        if(playerChoice.Contains("SIT") || playerChoice.Contains("CHAIR")) {
          chairDialogue();
        } else if(playerChoice.Contains("6R33D") || playerChoice.Contains("WEST")) {
          room6R33D();
        } else if(playerChoice.Contains("4C3D14") || playerChoice.Contains("NORTH")) {
          
        }
      }
    }
  }

  private static void chairDialogue() {

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
    Console.WriteLine(Script.deathMsg);

    while(true) {
      playerChoice = getChoice("Would you like to play again?");

      if(playerChoice.Contains("YES")) {
        setGameData();
        roomR3GR37();
      } else if(playerChoice.Contains("NO")) {
        credits();
      }
    }
  }

  public static void credits() {
    Console.WriteLine("THIS IS THE CREDITS");
  }
}