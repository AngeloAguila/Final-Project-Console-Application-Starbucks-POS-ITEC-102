using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var espressoPrices = new Dictionary<int, int>()
        {
            {1, 250},
            {2, 280},
            {3, 310}
        };

        var frappuccinoPrices = new Dictionary<int, int>()
        {
            {1, 225},
            {2, 250},
            {3, 285}
        };

        var pastaBreadPrices = new Dictionary<string, int>()
        {
            {"Meatball Pasta", 175},
            {"Chicken Barbeque Sandwich", 165},
            {"Spanish Chorizo, Egg and Mozzarella Cheese on Whole Wheat Pandesal", 140},
            {"Four Cheese Flatbread", 105},
            {"Double Chocolate Pecan Bar", 90},
            {"Sausage Roll", 90},
            {"Chocolate Dipped Doughnut", 90},
            {"Sticky Cinnamon Bun", 90},
            {"Cinnamon Danish", 90},
            {"Classic Starbucks Coffee Cake", 702},
            {"Chocolate Cake", 802},
            {"Classic Starbucks Muffins (dozen)", 320},
            {"Chocolate Chip Cookies (dozen)", 280}
        };

        var espressoOptions = new List<string>()
        {
            "Flat White",
            "Caramel Macchiato",
            "Caffè Latte",
            "Cappuccino",
            "Chocolate Cappuccino",
            "Americano",
            "Brewed Coffee",
            "Caffè Mocha",
            "Caffè White Mocha"
        };
        var latteFlavors = new List<string>()
        {
            "Caffè Latte - Caramel",
            "Caffè Latte - Hazelnut",
            "Caffè Latte - Vanilla"
        };
        var mochaFlavors = new List<string>()
        {
            "Caffè Mocha",
            "Caffè White Mocha"
        };
        var frappuccinoOptions = new List<string>()
        {
            "Coffee",
            "Mocha",
            "White Mocha",
            "Java Chip",
            "Caramel",
            "Espresso",
            "Caramel Java Chip",
            "Coffee-Free Vanilla Cream",
            "Strawberries & Crème",
            "Green Tea Cream",
            "Double Chocolate Chip",
            "Cold Coffee"
        };

        var pastaBreadOptions = new List<string>()
        {
            "Meatball Pasta",
            "Chicken Barbeque Sandwich",
            "Spanish Chorizo, Egg and Mozzarella Cheese on Whole Wheat Pandesal",
            "Four Cheese Flatbread",
            "Double Chocolate Pecan Bar",
            "Sausage Roll",
            "Chocolate Dipped Doughnut",
            "Sticky Cinnamon Bun",
            "Cinnamon Danish",
            "Classic Starbucks Coffee Cake",
            "Chocolate Cake",
            "Classic Starbucks Muffins (dozen)",
            "Chocolate Chip Cookies (dozen)"
        };

        var sizes = new Dictionary<int, string>()
        {
            {1, "Short"},
            {2, "Tall"},
            {3, "Grande"}
        };

        var orders = new List<string>();
        int total = 0;

        // Initialize inventory
        var inventory = new Dictionary<string, int>();
        foreach (var item in espressoOptions)
        {
            inventory[item] = 50;
        }
        foreach (var item in latteFlavors)
        {
            inventory[item] = 50;
        }
        foreach (var item in mochaFlavors)
        {
            inventory[item] = 50;
        }
        foreach (var item in frappuccinoOptions)
        {
            inventory[item] = 50;
        }
        foreach (var item in pastaBreadOptions)
        {
            if (item.Contains("Pasta"))
            {
                inventory[item] = 20;
            }
            else if (item.Contains("Sandwich"))
            {
                inventory[item] = 30;
            }
            else
            {
                inventory[item] = 50;
            }
        }

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\r\n█▀ ▀█▀ ▄▀█ █▀█ █▄▄ █░█ █▀▀ █▄▀ █▀\r\n▄█ ░█░ █▀█ █▀▄ █▄█ █▄█ █▄▄ █░█ ▄█");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nWelcome to STARBUCKS! Please choose an option:");
            Console.ResetColor();

            Console.WriteLine("[S] Start an order");
            Console.WriteLine("[I] Instructions");
            Console.WriteLine("[V] View inventory");
            Console.WriteLine("[E] Exit");

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("Press [Key] + Enter: "); string input = Console.ReadLine().ToLower();
            Console.ResetColor();
            Console.WriteLine("========================================================================================================================");


            if (input == "s")
            {
                bool finishOrder = false;
                while (!finishOrder)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\r\n█░█░█ █░█ ▄▀█ ▀█▀   █▀▄ █▀█   █▄█ █▀█ █░█   █░░ █ █▄▀ █▀▀ ▀█\r\n▀▄▀▄▀ █▀█ █▀█ ░█░   █▄▀ █▄█   ░█░ █▄█ █▄█   █▄▄ █ █░█ ██▄ ░▄");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\nWelcome to our coffee shop! Please choose an option:");
                    Console.ResetColor();
                    Console.WriteLine("\n[1] COFFEE MENU");
                    Console.WriteLine("[2] PASTA, BREAD, SANDWICHES MENU");

                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("Press [Key] + Enter: "); string orderTypeInput = Console.ReadLine().ToLower();
                    Console.ResetColor();
                    Console.WriteLine("========================================================================================================================");

                    if (orderTypeInput == "1")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\r\n          █▀▀ █▀█ █▀▀ █▀▀ █▀▀ █▀▀   █▀▄▀█ █▀▀ █▄░█ █░█\r\n          █▄▄ █▄█ █▀░ █▀░ ██▄ ██▄   █░▀░█ ██▄ █░▀█ █▄█");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\n[E] Espresso                            [F] Frappuccino");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("(1) Short - 250                         (1) Tall - 225    ");
                        Console.WriteLine("(2) Tall - 280                          (2) Grande - 250 ");
                        Console.WriteLine("(3) Grande - 310                        (3) Venti - 285 ");
                        Console.ResetColor();
                        Console.WriteLine("");

                        int maxMenuLength = Math.Max(espressoOptions.Count, frappuccinoOptions.Count);
                        for (int i = 0; i < maxMenuLength; i++)
                        {
                            string espressoOption = i < espressoOptions.Count ? $"{i + 1} - {espressoOptions[i]}" : "";
                            string frappuccinoOption = i < frappuccinoOptions.Count ? $"{i + 1} - {frappuccinoOptions[i]}" : "";
                            Console.WriteLine($"{espressoOption.PadRight(40)} {frappuccinoOption}");
                        }
                    }
                    else if (orderTypeInput == "2")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\r\n█▀█ ▄▀█ █▀ ▀█▀ ▄▀█ ░   █▄▄ █▀█ █▀▀ ▄▀█ █▀▄   █▀ ▄▀█ █▄░█ █▀▄ █░█░█ █ █▀▀ █░█ █▀▀ █▀   █▀▄▀█ █▀▀ █▄░█ █░█\r\n█▀▀ █▀█ ▄█ ░█░ █▀█ █   █▄█ █▀▄ ██▄ █▀█ █▄▀   ▄█ █▀█ █░▀█ █▄▀ ▀▄▀▄▀ █ █▄▄ █▀█ ██▄ ▄█   █░▀░█ ██▄ █░▀█ █▄█");
                        Console.ResetColor();

                        for (int i = 0; i < pastaBreadOptions.Count; i++)
                        {
                            Console.WriteLine($"{i + 1} - {pastaBreadOptions[i]} - ₱{pastaBreadPrices[pastaBreadOptions[i]]}");
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid option. Please try again.");
                        Console.ResetColor();

                        continue;
                    }

                    while (true)
                    {
                        if (orderTypeInput == "1")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("\nFormat: [Type Code Size]");
                            Console.ResetColor();
                            Console.WriteLine("[C] Cancel an order.");
                            Console.WriteLine("[O] Show orders.");
                            Console.WriteLine("[D] Finish order.");
                            Console.WriteLine("[M] Add more orders.");
                            Console.ResetColor();

                        }
                        else if (orderTypeInput == "2")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nFormat: [Type Code Size]");
                            Console.ResetColor();
                            Console.WriteLine("[C] Cancel an order.");
                            Console.WriteLine("[O] Show orders.");
                            Console.WriteLine("[D] Finish order.");
                            Console.WriteLine("[M] Add more orders.");
                            Console.ResetColor();
                        }
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("Press [Key] + Enter: "); string orderInput = Console.ReadLine().ToLower();
                        Console.ResetColor();
                        Console.WriteLine("========================================================================================================================");

                        if (string.IsNullOrWhiteSpace(orderInput))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid input. Please try again.");
                            Console.ResetColor();
                            continue;
                        }

                        if (orderInput == "m")
                        {
                            break;
                        }

                        if (orderInput == "c")
                        {
                            if (orders.Count == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You have no orders to cancel.");
                                Console.ResetColor();
                                Console.WriteLine("========================================================================================================================");
                                continue;
                            }

                            Console.WriteLine("\nYour orders:");
                            for (int i = 0; i < orders.Count; i++)
                            {
                                Console.WriteLine($"{i + 1} - {orders[i]}");
                            }
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("Enter the number of the order you want to cancel, or 'B' to go back.");
                            Console.ResetColor();

                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write("Press [Key] + Enter: "); string cancelInput = Console.ReadLine();
                            Console.ResetColor();
                            Console.WriteLine("========================================================================================================================");

                            if (cancelInput.ToLower() == "b")
                            {
                                continue;
                            }

                            int cancelIndex = int.Parse(cancelInput) - 1;
                            if (cancelIndex >= 0 && cancelIndex < orders.Count)
                            {
                                string cancelledOrder = orders[cancelIndex];
                                orders.RemoveAt(cancelIndex);
                                // Extract the price from the cancelled order and subtract it from the total
                                string[] orderParts = cancelledOrder.Split(' ');
                                int cancelledPrice = int.Parse(orderParts[orderParts.Length - 1].Replace("₱", ""));
                                total -= cancelledPrice;
                                Console.WriteLine($"Cancelled order: {cancelledOrder}");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid order number. Please try again.");
                                Console.ResetColor();
                            }
                        }
                        else if (orderInput == "o")
                        {
                            if (orders.Count == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\r\n█▀█ █▀█ █▀▄ █▀▀ █▀█   █░░ █ █▀ ▀█▀\r\n█▄█ █▀▄ █▄▀ ██▄ █▀▄   █▄▄ █ ▄█ ░█░");
                                Console.ResetColor();
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You have no orders yet. Start ordering by choosing from the menu.");
                                Console.ResetColor();
                                continue;
                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\r\n█▀█ █▀█ █▀▄ █▀▀ █▀█   █░░ █ █▀ ▀█▀\r\n█▄█ █▀▄ █▄▀ ██▄ █▀▄   █▄▄ █ ▄█ ░█░");
                            Console.ResetColor();
                            Console.WriteLine("");
                            Console.WriteLine("\a\nYour orders:");
                            for (int i = 0; i < orders.Count; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"{i + 1} - {orders[i]}");
                                Console.ResetColor();
                            }
                            Console.Write($"\nTotal: ");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"{total}");
                            Console.ResetColor();
                            Console.WriteLine("========================================================================================================================");
                            continue;
                        }
                        else if (orderInput != "d")
                        {
                            string[] order = orderInput.Split(' ');

                            if (orderTypeInput == "1" && order.Length == 3)
                            {
                                string coffeeType = order[0].Trim().ToLower();
                                int code = int.Parse(order[1].Trim());
                                int size = int.Parse(order[2].Trim());

                                if (coffeeType == "e" && code >= 1 && code <= espressoOptions.Count)  // Espresso
                                {
                                    if (!espressoPrices.ContainsKey(size))
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Invalid size. Please try again.");
                                        Console.ResetColor();
                                        continue;
                                    }
                                    int price = espressoPrices[size];
                                    string coffeeName = espressoOptions[code - 1];
                                    string sizeName = sizes[size];
                                    if (coffeeName == "Caffè Latte")
                                    {

                                        Console.WriteLine("What flavor would you like for your Caffè Latte? (C)aramel, (H)azelnut, or (V)anilla");
                                        string flavor = Console.ReadLine().Trim().ToLower();
                                        switch (flavor)
                                        {
                                            case "c":
                                                coffeeName = "Caffè Latte - Caramel";
                                                break;
                                            case "h":
                                                coffeeName = "Caffè Latte - Hazelnut";
                                                break;
                                            case "v":
                                                coffeeName = "Caffè Latte - Vanilla";
                                                break;
                                            default:
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Invalid flavor. Please try again.");
                                                Console.ResetColor();
                                                continue;
                                        }
                                    }
                                    else if (coffeeName == "Caffè Mocha" || coffeeName == "Caffè White Mocha")
                                    {
                                        Console.WriteLine("What type of mocha would you like? (M)ocha or (W)hite Mocha");
                                        string flavor = Console.ReadLine().Trim().ToLower();
                                        switch (flavor)
                                        {
                                            case "m":
                                                coffeeName = "Caffè Mocha";
                                                break;
                                            case "w":
                                                coffeeName = "Caffè White Mocha";
                                                break;
                                            default:
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Invalid flavor. Please try again.");
                                                Console.ResetColor();
                                                continue;
                                        }
                                    }

                                    // Check if the item is in stock
                                    if (inventory[coffeeName] == 0)
                                    {
                                        Console.Write($"Sorry, {coffeeName} ");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write("is out of stock. Please order another item.");
                                        Console.ResetColor();
                                        continue;
                                    }

                                    // Update inventory
                                    inventory[coffeeName]--;

                                    // Add order to list
                                    orders.Add($"{coffeeName} {sizeName} - ₱{price}");
                                    total += price;

                                    Console.WriteLine($"Added {coffeeName} {sizeName} to your order. Current total: ₱{total}");
                                }
                                else if (coffeeType == "f" && code >= 1 && code <= frappuccinoOptions.Count)  // Frappuccino
                                {
                                    if (!frappuccinoPrices.ContainsKey(size))
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Invalid size. Please try again.");
                                        Console.ResetColor();
                                        continue;
                                    }
                                    int price = frappuccinoPrices[size];
                                    string coffeeName = frappuccinoOptions[code - 1];
                                    string sizeName = sizes[size];

                                    // Check if the item is in stock
                                    if (inventory[coffeeName] == 0)
                                    {
                                        Console.Write($"Sorry, {coffeeName} ");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write("is out of stock. Please order another item.");
                                        Console.ResetColor();
                                        continue;
                                    }

                                    // Update inventory
                                    inventory[coffeeName]--;

                                    // Add order to list
                                    orders.Add($"{coffeeName} {sizeName} - ₱{price}");
                                    total += price;

                                    Console.WriteLine($"Added {coffeeName} {sizeName} to your order. Current total: ₱{total}");
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Invalid order. Please try again.");
                                    Console.ResetColor();
                                    continue;
                                }
                            }
                            else if (orderTypeInput == "2" && order.Length == 1)
                            {
                                int code = int.Parse(order[0].Trim());
                                if (code >= 1 && code <= pastaBreadOptions.Count)
                                {
                                    int price = pastaBreadPrices[pastaBreadOptions[code - 1]];
                                    string itemName = pastaBreadOptions[code - 1];

                                    // Check if the item is in stock
                                    if (inventory[itemName] == 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine($"{itemName} is out of stock. Please order another item.");
                                        Console.ResetColor();
                                        continue;
                                    }

                                    // Update inventory
                                    inventory[itemName]--;

                                    // Add order to list
                                    orders.Add($"{itemName} - ₱{price}");
                                    total += price;

                                    Console.WriteLine($"Added {itemName} to your order. Current total: ₱{total}");
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Invalid order. Please try again.");
                                    Console.ResetColor();
                                    continue;
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid order. Please try again.");
                                Console.ResetColor();
                                continue;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\r\n█▀█ ▄▀█ █▄█ █▀▄▀█ █▀▀ █▄░█ ▀█▀\r\n█▀▀ █▀█ ░█░ █░▀░█ ██▄ █░▀█ ░█░");
                            Console.ResetColor();

                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Thankyou for buying at Starbucks! Enjoy!");
                            Console.ResetColor();

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\a\nYour orders:");
                            Console.ResetColor();
                            for (int i = 0; i < orders.Count; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"{i + 1} - {orders[i]}");
                                Console.ResetColor();
                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Total: ₱{total}");
                            Console.ResetColor();

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nDo you want to confirm your orders? (Y/N)");
                            Console.ResetColor();

                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write("Press [Key] + Enter: "); string finalConfirmation = Console.ReadLine();
                            Console.ResetColor();
                            Console.WriteLine("========================================================================================================================");
                            if (finalConfirmation.ToLower() == "y")
                            {
                                finishOrder = true;  // Set the flag to true to exit the ordering loop
                                orders.Clear();  // Clear the orders list
                                total = 0;  // Reset the total
                                break;  // Add this line to break out of the inner loop
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You can continue ordering.");
                                Console.ResetColor();
                            }
                        }
                    }
                }
            }
            else if (input == "i")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\r\n█ █▄░█ █▀ ▀█▀ █▀█ █░█ █▀▀ ▀█▀ █ █▀█ █▄░█ █▀\r\n█ █░▀█ ▄█ ░█░ █▀▄ █▄█ █▄▄ ░█░ █ █▄█ █░▀█ ▄█");
                Console.ResetColor();
                Console.WriteLine("");
                Console.WriteLine("1. To start an order, type 'S' or 's'.");
                Console.WriteLine("2. Enter your order in the format: type, code, size.");
                Console.WriteLine("3. To cancel an order, type 'C' or 'c'.");
                Console.WriteLine("4. To show your orders, type 'O' or 'o'.");
                Console.WriteLine("5. To finish your order, type 'D' or 'd'.");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\nPress 'N' or 'n' to go back to the main menu.");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("Press [Key] + Enter: "); string instructionInput = Console.ReadLine().ToLower();
                Console.ResetColor();
                Console.WriteLine("========================================================================================================================");
                if (instructionInput == "n")
                {
                    continue;
                }
            }
            else if (input == "v")
            {
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\r\n█ █▄░█ █░█ █▀▀ █▄░█ ▀█▀ █▀█ █▀█ █▄█\r\n█ █░▀█ ▀▄▀ ██▄ █░▀█ ░█░ █▄█ █▀▄ ░█░");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\nCurrent inventory:");
                    Console.ResetColor();
                    int count = 1;
                    var keys = new List<string>(inventory.Keys);
                    int half = keys.Count / 2;

                    for (int i = 0; i < half; i++)
                    {
                        string item1 = $"{count} - {keys[i]}: {inventory[keys[i]]}";
                        string item2 = $"{count + half} - {keys[i + half]}: {inventory[keys[i + half]]}";
                        Console.WriteLine($"{item1.PadRight(40)} {item2}");
                        count++;
                    }

                    // If there are an odd number of items, print the last one
                    if (keys.Count % 2 != 0)
                    {
                        Console.WriteLine($"{keys.Count} - {keys[keys.Count - 1]}: {inventory[keys[keys.Count - 1]]}");
                    }

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\nEnter [R] and the code of the item to restock");
                    Console.WriteLine("Enter [U] and the code of the item to unstock, or 'B' to exit: ");
                    Console.WriteLine("Enter [B] to exit");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("Press [Key] + Enter: "); string[] stockInput = Console.ReadLine().Trim().Split(' ');
                    Console.ResetColor();
                    Console.WriteLine("========================================================================================================================");
                    string action = stockInput[0].ToLower();
                    if (action == "b")
                    {
                        break;
                    }
                    else if (action == "r" || action == "u")
                    {
                        int stockCode = int.Parse(stockInput[1]);
                        string itemName = "";
                        if (stockCode >= 1 && stockCode <= inventory.Count)
                        {
                            itemName = keys[stockCode - 1];
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid code. Please try again.");
                            Console.ResetColor();
                            continue;
                        }
                        if (action == "r")
                        {
                            inventory[itemName] += 10;  // Increase the stock by 10
                            Console.WriteLine($"Restocked {itemName}. Current stock: {inventory[itemName]}");
                        }
                        else if (action == "u")
                        {
                            if (inventory[itemName] < 10)  // Check if there are at least 10 items in stock
                            {
                                Console.WriteLine($"Cannot unstock {itemName}. Current stock: {inventory[itemName]}");
                            }
                            else
                            {
                                inventory[itemName] -= 10;  // Decrease the stock by 10
                                Console.WriteLine($"Unstocked {itemName}. Current stock: {inventory[itemName]}");
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid action. Please try again.");
                            Console.ResetColor();
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid action. Please try again.");
                        Console.ResetColor();
                    }
                }
            }
            else if (input == "e")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Exiting...");
                Console.ResetColor();
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid option. Please try again.");
                Console.ResetColor();
            }
        }
    }
}
