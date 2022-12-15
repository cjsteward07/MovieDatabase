﻿using MovieDatabaseDomain;
using MovieDatabaseDTO;
using MovieDatabaseRepository;
using Microsoft.Extensions.Options;

MovieInteractor _movieInteractor = new MovieInteractor();
//DungeonCellInteractor _dungeonCellInteractor = new DungeonCellInteractor();
//DungeonCharacterInteractor _dungeonCharacterInteractor = new DungeonCharacterInteractor();
//DungeonNpcInteractor _dungeonNpcInteractor = new DungeonNpcInteractor();



//void LoadStartUpData()
//{
//    foreach (Movie item in BuildItemCollection())
//    {
//        if (_movieInteractor.AddNewItem(item) == true)
//        {
//            Console.WriteLine($"{item.Title} was added to the database.");
//        }
//        else
//        {
//            Console.WriteLine($"{item.Title} was NOT added to the database.");
//        }
//    }
//}

//List<Movie> BuildItemCollection()
//{
//    List<Movie> initialItems = new List<Movie>();
//    initialItems.Add(new Movie() { Title = "Common Arrow"});
//    //initialItems.Add(new Movie() { Name = "Dull Sword", Description = "A very old sword" });
//    //initialItems.Add(new Movie() { Name = "Ragged Tunic", Description = "It barely covers the important bits" });
//    //initialItems.Add(new Movie() { Name = "Common Arrow", Description = "A cheap wood arrow" });
//    //initialItems.Add(new Movie() { Name = "Dented Helm", Description = "What happened to the previous owner" });
//    return initialItems;
//}


Console.WriteLine("Hello");
//LoadStartUpData();

void DisplayAllItems()
{
    Console.WriteLine();
    Console.WriteLine("The following items are in the database");
    foreach (Movie item in _movieInteractor.GetAllMovies())
    {
        Console.WriteLine($" - {item.Title}");
    }

    //foreach (Character character in _dungeonCharacterInteractor.GetAllCharacters())
    //{
    //    //Ternary Statement -- single line if/then
    //    // if then statement used to set a value
    //    // variable = condition ? true value : false value
    //    string characterClass = character.CharacterClass == null ? "No Class" : character.CharacterClass.Name;
    //    string characterRace = character.CharacterRace == null ? "No Race" : character.CharacterRace.Name;

    //    Console.WriteLine($"{character.CharacterName} - {character.CharacterRace.Name} - {characterClass}");

    //    foreach (var item in _dungeonCharacterInteractor.GetCharacterItems(character.Relationships))
    //    {
    //        Console.WriteLine(item.Name);
    //    }

}
DisplayAllItems();
Console.ReadKey();
//DisplayItemInformation(1);
//DisplayItemInformation(10);

//UpdateItemModifiers(1, 0, 5);
//UpdateItemModifiers(2, 10, -1);
//UpdateItemModifiers(defenseModifier: 10, attackModifier: 10, itemId: 20);

//DeleteItem(1);
//DeleteItem(10);

//Console.WriteLine();
//Console.WriteLine("Press any key to exit");
//Console.ReadKey();

//void DisplayAllItems()
//{
//    Console.WriteLine();
//    Console.WriteLine("The following items are in the database");
//    foreach (Item item in _dungeonItemInteractor.GetAllItems())
//    {
//        Console.WriteLine($" - {item.Name}, {item.Description}");
//    }

//    foreach (Character character in _dungeonCharacterInteractor.GetAllCharacters())
//    {
//        //Ternary Statement -- single line if/then
//        // if then statement used to set a value
//        // variable = condition ? true value : false value
//        string characterClass = character.CharacterClass == null ? "No Class" : character.CharacterClass.Name;
//        string characterRace = character.CharacterRace == null ? "No Race" : character.CharacterRace.Name;

//        Console.WriteLine($"{character.CharacterName} - {character.CharacterRace.Name} - {characterClass}");

//        foreach (var item in _dungeonCharacterInteractor.GetCharacterItems(character.Relationships))
//        {
//            Console.WriteLine(item.Name);
//        }

//    }
//}

//void LoadStartUpData()
//{
//    foreach (Item item in BuildItemCollection())
//    {
//        if (_dungeonItemInteractor.AddNewItem(item) == true)
//        {
//            Console.WriteLine($"{item.Name} was added to the database.");
//        }
//        else
//        {
//            Console.WriteLine($"{item.Name} was NOT added to the database.");
//        }
//    }
//}

//List<Item> BuildItemCollection()
//{
//    List<Item> initialItems = new List<Item>();
//    initialItems.Add(new Item() { Name = "Common Arrow", Description = "A cheap wood arrow" });
//    initialItems.Add(new Item() { Name = "Dull Sword", Description = "A very old sword" });
//    initialItems.Add(new Item() { Name = "Ragged Tunic", Description = "It barely covers the important bits" });
//    initialItems.Add(new Item() { Name = "Common Arrow", Description = "A cheap wood arrow" });
//    initialItems.Add(new Item() { Name = "Dented Helm", Description = "What happened to the previous owner" });
//    return initialItems;
//}
////void DisplayAllItems()
////{
////    Console.WriteLine();
////    Console.WriteLine("The following items are in the database");
////    foreach (Item item in _dungeonItemInteractor.GetAllItems())
////    {
////        Console.WriteLine($" - {item.Name}, {item.Description}");
////    }
////}
//void DisplayItemInformation(int itemId)
//{
//    Console.WriteLine();
//    Console.WriteLine($"Searching for item ID {itemId}");
//    bool doesItemExist = _dungeonItemInteractor.GetItemIfExists(itemId, out Item returnedItem);
//    if (doesItemExist)
//    { Console.WriteLine($"Name: {returnedItem.Name}: {returnedItem.Description}"); }
//    else
//    { Console.WriteLine("That item does not exist"); }
//}

//void UpdateItemModifiers(int itemId, int attackModifier, int defenseModifier)
//{
//    // Get the item to update and check if it exists
//    if (_dungeonItemInteractor.GetItemIfExists(itemId, out Item returnedItem))
//    {
//        returnedItem.AttackModifier = attackModifier;
//        returnedItem.DefenseModifier = defenseModifier;
//        _dungeonItemInteractor.UpdateItem(returnedItem);
//        Console.WriteLine($"{returnedItem.Name} was successfully updated to the database.");
//    }
//    else
//    {
//        Console.WriteLine($"There was a problem updating the record for Id {itemId}.");
//    }
//}

//void DeleteItem(int itemId)
//{
//    // Get the item to update
//    if (_dungeonItemInteractor.DeleteItem(itemId))
//    {
//        Console.WriteLine($"Item ID {itemId} was successfully deleted from the database.");
//    }
//    else
//    {
//        Console.WriteLine($"There was a problem deleting the record for Id {itemId}.");
//    }
//}




