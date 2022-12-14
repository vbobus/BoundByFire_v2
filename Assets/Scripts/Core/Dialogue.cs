using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*This script stores every dialogue conversation in a public Dictionary.*/

public class Dialogue : MonoBehaviour
{

    public Dictionary<string, string[]> dialogue = new Dictionary<string, string[]>();

    void Start()
    {
        //Door
        dialogue.Add("LockedDoorA", new string[] {
            "A large door...",
            "Looks like it has a key hole!"
        });


        dialogue.Add("LockedDoorB", new string[] {
            "Key used!"
        });

        //NPC
        dialogue.Add("CharacterA", new string[] {
            "Hi there!",
            "I'm an NPC! This conversation is called 'npcA'...",
            "If you go and find me 80 coins, my dialogue will move on to 'npcB'!",
            "Feel free to edit my dialogue in the 'Dialogue.cs' file!",
            "To keep it simple, you can also ask me one, and only one, question...",
            "...Like you just did! And I'll just move on to the next sentence.",
            "I'll answer that question, but it won't change much about the game!",
            "You can always tweak the 'DialogueBox.cs' script to add more functionality!"
        });

        dialogue.Add("CharacterAChoice1", new string[] {
            "",
            "",
            "Let me go find some coins!",
        });

        dialogue.Add("CharacterAChoice2", new string[] {
            "",
            "",
            "What else can you do?"
        });

        dialogue.Add("CharacterB", new string[] {
            "Hey! You found 80 coins! That means 'npcB' is now being used inside 'Dialogue.cs'!",
            "After my dialogue completes, I'll take 80 coins, or however many you specify in the inspector...",
            "And I'll also give you a new ability!",
            "In this case, how about a generic DOWNWARD SMASH? Simply attack while pressing down in mid-air!"
        });

        dialogue.Add("CharacterC", new string[] {
            "I am a test dialogue",
            "That's all I have to say"
        });

        //TOWN DIALOGUE---------------------------------------------------------------------------------
        //TavernNPC1 Dialogue
        dialogue.Add("TownNPC1", new string[] {
            "A half-beast in Slatia? I haven't seen your kind in a while now. Say.....",
            "Can you do the fire thing?",
            "No? Well that's a bummer."
        });

        dialogue.Add("TownNPC2", new string[] {
            "You know there's a lot outside Slatia right?",
            "Evenborough Woods, the Stlagmites Shrine, and the Peaksie Canyon are some of my favourite places to visit.",
            "Maybe you can find more of your kind there right? Ha, ha, ha..."
        });

        dialogue.Add("TownNPC3", new string[] {
            "I'm telling you, I saw some crazy swamp things just outside the town!",
            "Ahh you never believe me do you? They were big, they were scary, and they were.....",
            "Uh, sorry buddy. Don't wanna be that guy, but we're kind of in the middle of a conversation here."
        });


        dialogue.Add("Mayor", new string[] {
            "Hey you, half-beast! There's something going on in the outskirts to the right, you gotta help out!",
            "Now's not the time to give me faces! Now is the time to MOVE!"
        });

        //INSIDE HOUSE DIALOGUE---------------------------------------------------------------------------------
        dialogue.Add("HouseNPC1", new string[] {
            "You know some people in Evenborough Woods lives in trees right? Crazy. I could never do that.",
            "If you ask me, it's a lot cozier to be in a nice warm house. Do you know what's that like?"
        });

        dialogue.Add("HouseNPC2", new string[] {
            "Humans, half-beasts, witches, ya da, ya da, ya da.",
            "Hear things for too long and they start to lose their meaning. It's like a broken.....",
            "Ah, I'll think of a name when I meet up with my buddies to play our music at the tavern"
        });

        dialogue.Add("HouseShelf1", new string[] {
            "It's a shelf filled with a neat collection of books all about cooking.",
            "Would you like to read one of them?",
            "TITLE: SLATIA'S FINEST DISHES",
            "'One of the most renown delicacies in all of Slatia is the Minced Meat Sherbert Pie.",
            "'Layered only with the finest taters from the village of Octone, they're mixed well with delightful lamb and split peas'",
            "'Paired with a hot scotch, this is one meal you'll never forget.",
            "It's the end of the excerpt."
        });

        dialogue.Add("HouseShelf1Choice1", new string[] {
            "",
            "Not now",
        });

        dialogue.Add("HouseShelf1Choice2", new string[] {
            "",
            "Fine, I'll read it"
        });

        dialogue.Add("HouseBoxes1", new string[] {
            "A tidy collection of boxes are stacked on top of each other. One of them reads 'Octone Potatoes'."
        });

        dialogue.Add("HouseBoxes2", new string[] {
            "Empty boxes are stacked up on top of each other. One of them has writing that reads 'Peaksie....'.",
            "The rest of the text is too faded to make out."
        });


        //TAVERN DIALOGUE ---------------------------------------------------------------------------------
        //TavernNPC1 Dialogue
        dialogue.Add("TavernNPC1", new string[] {
            "Oy, what are ya looking for here half-beast? I ain't got nothing for ya.",
            "Oh, you're just passing by?",
            "Then buzz of will ya? You're ruinin' my vibe."
        });

        //TavernNPC2 Dialogue
        dialogue.Add("TavernNPC2", new string[] {
            "You ever tried the tavern's hot scotch?",
            "It's the best drink you can get in Slatia. You should try it out sometimes."
        });
        

        //TavernNPC3 Dialogue
        dialogue.Add("TavernNPC3", new string[] {
            "I'm starving..... haven't had anything since leaving Evenborough.",
            "..... oh, you were listening? Well.... this is awkward.",
            "Um.... don't mind me. Seriously, look away"
        });

        //TheBoss Dialogue
        dialogue.Add("TheBoss", new string[] {
            "Back again so soon? I don't got any quests for you right now I'm afraid.",
            "What else can I do for you?",
            "Quests? Ha, ha, you trying to cut me out kid?", 
            "Well you can find more people SIMILAR to me throughout the lands here and there looking for help.",
            "They'll usually be willing to pay a pretty penny for a good merc like yourself.",
            "Can't find many in Slatia, but there's some good half-beast vendors you'll be able to purchase items from with your earned gold."
        });

        dialogue.Add("TheBossChoice1", new string[] {
            "",
            "Nothing for now",
        });

        dialogue.Add("TheBossChoice2", new string[] {
            "",
            "Where can I find Quests?"
        });

        //Tavern Book Shelf Dialogue
        dialogue.Add("TavernShelf", new string[] {
            "It's a musty old bookshelf with a few grimy books.",
            "Would you like to read one of them?",
            "TITLE: THE GREAT FIRE OF SLATIA",
            "'Not much is know about where the fires that lit up the town square of Slatia came from.'",
            "'Although not many were injured in the incident, this proved the dangers of magic that could come from half-beasts.'",
            "'The towns royal guard went on record to say the following after the arrest of the suspected half-beast perpertrators:'",
            "'Fear not citizens of the Slatia, the hidden evil of the half-beasts shall not go unpunished. We shall make it an effort to ensure such an event never occurs again.'",
            "'Restrictions shall be placed on any of those who choose to align and help those that practice such witchcraft in the future. This is a warning to everyone.'",
            "The rest of the document is torn off and is illegible...."
        });

        dialogue.Add("TavernShelfChoice1", new string[] {
            "",
            "Not now",
        });

        dialogue.Add("TavernShelfChoice2", new string[] {
            "",
            "Fine, I'll read it"
        });
        
    }
}

