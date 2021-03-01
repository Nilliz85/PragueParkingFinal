

using System;
using System.Linq;

namespace PragueParking
{
    class Program
    {
        //-------------------------------------------------------------------------
        //--------------------------- Global Variables ----------------------------
        //-------------------------------------------------------------------------

        private static string[] ParkingLot = new string[100];
        private static bool isMc = false;
        private static bool Exists = false;
        private static int delIndex, number;

        static void Main(string[] args)
        {
            //TestMethod();
            Menus();
            Console.ReadLine();
        }

        //-------------------------------------------------------------------------
        //-------------------------- Holds the Main Menu --------------------------
        //-------------------------------------------------------------------------
        private static void Menus()
        {

            bool showMenu = true;

            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        //-------------------------------------------------------------------------
        //---------------------------- The Main Menu ------------------------------
        //-------------------------------------------------------------------------
        private static bool MainMenu()
        {

            //meny alternativ
            Console.WriteLine(@"  _____                              _____           _    _              ");
            Console.WriteLine(@" |  __ \                            |  __ \         | |  (_)             ");
            Console.WriteLine(@" | |__) | __ __ _  __ _ _   _  ___  | |__) |_ _ _ __| | ___ _ __   __ _  ");
            Console.WriteLine(@" |  ___/ '__/ _` |/ _` | | | |/ _ \ |  ___/ _` | '__| |/ / | '_ \ / _` | ");
            Console.WriteLine(@" | |   | | | (_| | (_| | |_| |  __/ | |  | (_| | |  |   <| | | | | (_| | ");
            Console.WriteLine(@" |_|   |_|  \__,_|\__, |\__,_|\___| |_|   \__,_|_|  |_|\_\_|_| |_|\__, | ");
            Console.WriteLine(@"                   __/ |                                           __/ | ");
            Console.WriteLine(@"                  |___/                                           |___/  ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Park Vehicle");
            Console.WriteLine("2. Retrive Vehicle");
            Console.WriteLine("3. Find Vehicle");
            Console.WriteLine("4. Move Vehicle");
            Console.WriteLine("5. Show Parked Vehicles");

            switch (Console.ReadLine())
            {

                case "1":
                    //-------------------------------------------------------------------------
                    //-------------------------- The Park Vehicle Menu ------------------------
                    //-------------------------------------------------------------------------

                    Console.Clear();
                    Console.WriteLine(@"    _____           _      __      __  _     _      _        ");
                    Console.WriteLine(@"   |  __ \         | |     \ \    / / | |   (_)    | |       ");
                    Console.WriteLine(@"   | |__) |_ _ _ __| | __   \ \  / /__| |__  _  ___| | ___   ");
                    Console.WriteLine(@"   |  ___/ _` | '__| |/ /    \ \/ / _ \ '_ \| |/ __| |/ _ \  ");
                    Console.WriteLine(@"   | |  | (_| | |  |   <      \  /  __/ | | | | (__| |  __/  ");
                    Console.WriteLine(@"   |_|   \__,_|_|  |_|\_\      \/ \___|_| |_|_|\___|_|\___|  ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    ParkMenu();
                    return true;
                case "2":
                    //-------------------------------------------------------------------------
                    //----------------------- The Retrieve Vehicle Menu -----------------------
                    //-------------------------------------------------------------------------

                    Console.Clear();
                    Console.WriteLine(@"    _____      _        _                  __      __  _     _      _        ");
                    Console.WriteLine(@"   |  __ \    | |      (_)                 \ \    / / | |   (_)    | |       ");
                    Console.WriteLine(@"   | |__) |___| |_ _ __ _  _____   _____    \ \  / /__| |__  _  ___| | ___   ");
                    Console.WriteLine(@"   |  _  // _ \ __| '__| |/ _ \ \ / / _ \    \ \/ / _ \ '_ \| |/ __| |/ _ \  ");
                    Console.WriteLine(@"   | | \ \  __/ |_| |  | |  __/\ V /  __/     \  /  __/ | | | | (__| |  __/  ");
                    Console.WriteLine(@"   |_|  \_\___|\__|_|  |_|\___| \_/ \___|      \/ \___|_| |_|_|\___|_|\___|  ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    RetriveVehicle();
                    return true;
                case "3":
                    //-------------------------------------------------------------------------
                    //------------------------------ Find Vehicle -----------------------------
                    //-------------------------------------------------------------------------

                    Console.Clear();
                    Console.WriteLine(@"   ______ _           _   __      __  _     _      _        ");
                    Console.WriteLine(@"  |  ____(_)         | |  \ \    / / | |   (_)    | |       ");
                    Console.WriteLine(@"  | |__   _ _ __   __| |   \ \  / /__| |__  _  ___| | ___   ");
                    Console.WriteLine(@"  |  __| | | '_ \ / _` |    \ \/ / _ \ '_ \| |/ __| |/ _ \  ");
                    Console.WriteLine(@"  | |    | | | | | (_| |     \  /  __/ | | | | (__| |  __/  ");
                    Console.WriteLine(@"  |_|    |_|_| |_|\__,_|      \/ \___|_| |_|_|\___|_|\___|  ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    search();
                    return true;
                case "4":
                    //-------------------------------------------------------------------------
                    //----------------------------- Move Vehicle ------------------------------
                    //-------------------------------------------------------------------------

                    Console.Clear();
                    Console.WriteLine(@"  __  __                  __      __  _     _      _        ");
                    Console.WriteLine(@" |  \/  |                 \ \    / / | |   (_)    | |       ");
                    Console.WriteLine(@" | \  / | _____   _____    \ \  / /__| |__  _  ___| | ___   ");
                    Console.WriteLine(@" | |\/| |/ _ \ \ / / _ \    \ \/ / _ \ '_ \| |/ __| |/ _ \  ");
                    Console.WriteLine(@" | |  | | (_) \ V /  __/     \  /  __/ | | | | (__| |  __/  ");
                    Console.WriteLine(@" |_|  |_|\___/ \_/ \___|      \/ \___|_| |_|_|\___|_|\___|  ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    swap();
                    return true;
                case "5":
                    //-------------------------------------------------------------------------
                    //------------------------ Parked Vehicle Overview ------------------------
                    //-------------------------------------------------------------------------

                    Console.Clear();
                    Console.WriteLine(@"  _____           _            _  __      __  _     _      _            ");
                    Console.WriteLine(@" |  __ \         | |          | | \ \    / / | |   (_)    | |           ");
                    Console.WriteLine(@" | |__) |_ _ _ __| | _____  __| |  \ \  / /__| |__  _  ___| | ___  ___  ");
                    Console.WriteLine(@" |  ___/ _` | '__| |/ / _ \/ _` |   \ \/ / _ \ '_ \| |/ __| |/ _ \/ __| ");
                    Console.WriteLine(@" | |  | (_| | |  |   <  __/ (_| |    \  /  __/ | | | | (__| |  __/\__ \ ");
                    Console.WriteLine(@" |_|   \__,_|_|  |_|\_\___|\__,_|     \/ \___|_| |_|_|\___|_|\___||___/ ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    showParkedVehicles();
                    return true;

                default:
                    Console.Clear();
                    Console.WriteLine("Choose a option");
                    return true;
            }
        }

        // Parking Menu
        private static void ParkMenu()
        {
            //-------------------------------------------------------------------------
            //-------------------- Holds The Park Vehicle Menu ------------------------
            //-------------------------------------------------------------------------

            Console.WriteLine("1) Car");
            Console.WriteLine("2) Motorcycle");
            Console.WriteLine("0) Return to previous menu");

            switch (Console.ReadLine())
            {
                case "1":
                    //-------------------------------------------------------------------------
                    //-------------------------------- Park Car -------------------------------
                    //-------------------------------------------------------------------------

                    Console.Clear();
                    Console.WriteLine(@"    _____           _          _____             ");
                    Console.WriteLine(@"   |  __ \         | |        / ____|            ");
                    Console.WriteLine(@"   | |__) |_ _ _ __| | __    | |     __ _ _ __    ");
                    Console.WriteLine(@"   |  ___/ _` | '__| |/ /    | |    / _` | '__|  ");
                    Console.WriteLine(@"   | |  | (_| | |  |   <     | |___| (_| | |     ");
                    Console.WriteLine(@"   |_|   \__,_|_|  |_|\_\     \_____\__,_|_|    ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    ParkVehicle();
                    break;

                case "2":
                    //-------------------------------------------------------------------------
                    //-------------------------------- Park MC --------------------------------
                    //-------------------------------------------------------------------------

                    Console.Clear();
                    isMc = true;
                    Console.WriteLine(@"    _____           _         __  __  _____   ");
                    Console.WriteLine(@"   |  __ \         | |       |  \/  |/ ____|  ");
                    Console.WriteLine(@"   | |__) |_ _ _ __| | __    | \  / | |        ");
                    Console.WriteLine(@"   |  ___/ _` | '__| |/ /    | |\/| | |       ");
                    Console.WriteLine(@"   | |  | (_| | |  |   <     | |  | | |____   ");
                    Console.WriteLine(@"   |_|   \__,_|_|  |_|\_\    |_|  |_|\_____|  ");
                    Console.WriteLine();
                    Console.WriteLine();
                    ParkVehicle();
                    break;

                case "0":
            //------------------------------ Closes Menu ------------------------
                    Console.Clear();
                    break;
            }
        }


        private static void ParkVehicle()
        {
            Console.Write("Enter license plate nr: ");
            string input = UserInputCheck(Console.ReadLine().ToUpper());


            if (isMc)
            {

                isMc = false;

             //--------------- Checks the Array for "-mc" -----------------
                bool succesMc = lookForMc(input);


                if (!succesMc)
                {
                    AssigningParkingSpaceMC(input);
                }
                else if (succesMc)
                {
                    Console.Clear();
                    Console.WriteLine($"{input} is already parked here");
                }

            }
            else
            {
             //----------------- looks for given input in array ----------------
                bool succes = lookForCar(input);
                if (!succes)
                {
                    AssigningParkingSPace(input);
                }
                else if (succes)
                {
                    Console.Clear();
                    Console.WriteLine($"{input} is already parked here");
                }
            }

        }
        //-------------------------------------------------------------------------
        //------------------------------ Car Parking ------------------------------
        //-------------------------------------------------------------------------
        private static void AssigningParkingSPace(string input)
        {

            for (int i = 0; i < ParkingLot.Length; i++)
            {
                // if space is null, space becomes input
                if (ParkingLot[i] == null)
                {
                    ParkingLot[i] = input;
                    Console.WriteLine($"Please park vehicle: {input}, At space {i + 1}, ");
                    break;
                }
                else
                {
                    continue;
                }
            }

        }

        //-------------------------------------------------------------------------
        //------------------------------ MC Parking -------------------------------
        //-------------------------------------------------------------------------
        private static bool AssigningParkingSpaceMC(string input)
        {
            for (int i = 0; i < ParkingLot.Length; i++)
            {
                if (ParkingLot[i] == null)
                {

                    ParkingLot[i] = input + "-mc";
                    Console.WriteLine($"Please park vehicle: {input}, At space {i + 1}, ");
                    return true;
                }

             //---------- Checks to see how many times "-" is occuring in the array ----------
                char compare = '-';
                bool oneMc = ParkingLot[i].Count(r => r == compare) == 1; // once
                bool TwoMc = ParkingLot[i].Count(r => r == compare) >= 2; // twice

             //---------------------------- occurring once -----------------------------------
                if (oneMc)
                {

                    ParkingLot[i] += " " + input + "-mc";
                    Console.WriteLine($"Please park vehicle : {input}, At space {i + 1}, ");
                    return true;
                }
             //---------------------------- occurring twice -----------------------------------
                if (TwoMc)
                {
                    continue;

                }

            }

            return false;

        }

        //---------------------------- user input check -----------------------------------
        private static string UserInputCheck(string input)
        {

            while (true)
            {

                //---------------------------- null or empty -----------------------------------
                //---------------------------- try again -----------------------------------

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("A license plate can not be empty.");
                    input = Console.ReadLine();
                }

                //---------------------------- must be between 4-10 -----------------------------------
                if (input.Length <= 10 && input.Length >= 4)
                {
                    return input;
                }
                else
                {
                    // error msg
                    Console.WriteLine("Invalid license plate input. (4-10 characters)");
                    Console.Write("Enter license plate nr: ");
                    input = Console.ReadLine();
                }

            }
        }

        //-------------------------------------------------------------------------
        //---------------- Holds The "Retrieve Vehicle" Method --------------------
        //-------------------------------------------------------------------------
        private static void RetriveVehicle()
        {

            Console.Write("Enter vehicle license nr: ");
            string input = UserInputCheck(Console.ReadLine().ToUpper());

         //------------------------ checks for input ------------------------------
            bool succesMc = lookForMc(input);
            bool succes = lookForCar(input);

            if (succesMc)
            {
                Console.Clear();
                Console.WriteLine($"{input} is at space {delIndex + 1}");
                RemoveMc(input, delIndex);
            }
            if (succes)
            {
                Console.Clear();
                Console.WriteLine($"{input} is at space {delIndex + 1}");
                RemoveCar(input, delIndex);
            }
            else if (!succes && !succesMc)
            {
                Console.Clear();
                Console.WriteLine($"{input} is not parked here");
            }
        }


        //-------------------- searches the array for a car --------------------

        private static bool lookForCar(string input)
        {
            for (int i = 0; i < ParkingLot.Length; i++)
            {
                bool succes = ParkingLot[i] == input;
                if (succes)
                {
                    delIndex = i;
                    return true;
                }
                else
                {
                    continue;
                }
            }
            return false;

        }

        //-------------------- searches the array for a MC + "-mc" --------------------
        private static bool lookForMc(string input)
        {
            input += "-mc";

            for (int i = 0; i < ParkingLot.Length; i++)
            {
                bool succes = ParkingLot[i] == input;
                if (succes)
                {
                    delIndex = i;
                    return true;
                }
                else
                {

                    if (string.IsNullOrEmpty(ParkingLot[i]))
                    {
                        continue;
                    }
                    var search = ParkingLot[i].Split(" ");
                    for (int j = 0; j < search.Length; j++)
                    {
                        if (search[j] == input)
                        {
                            delIndex = i;
                            return true;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    continue;
                }

            }

            return false;

        }

        //-------------------------------------------------------------------------
        //--------------------- Holds The "Search" Function -----------------------
        //-------------------------------------------------------------------------
        private static void search()
        {
            Console.Write("Enter vehicle license plate nr: ");
            string input = UserInputCheck(Console.ReadLine().ToUpper());

            bool succesMc = lookForMc(input);
            bool succes = lookForCar(input);

            if (succesMc || succes)
            {

                Console.WriteLine($"{input} is parked on place: {delIndex + 1}");
            }
            else
            {

                Console.WriteLine($"Vehicle {input} is not parked here");
            }
        }


        //-------------------------------------------------------------------------
        //------------------------------ Deletes Car ------------------------------
        //-------------------------------------------------------------------------
        private static void RemoveCar(string input, int index)
        {

            if (ParkingLot[index] == input)
            {
                Console.WriteLine($"{input} is checked out, ");
                ParkingLot[index] = null;
            }

        }

        //-------------------------------------------------------------------------
        //------------------------------ Deletes MC ------------------------------
        //-------------------------------------------------------------------------
        private static bool RemoveMc(string input, int index)
        {
            for (int i = 0; i < ParkingLot.Length; i++)
            {
                if (ParkingLot[index] == input + "-mc")
                {
                    Console.WriteLine($"{input} is checked out, ");
                    ParkingLot[index] = null;
                    index = -1;
                    return true;
                }

                bool TwoMc = false;
                bool exists = false;

                //-------------------------------------------------------------------------
                //--------------------------- Catches Exeptions ---------------------------
                //-------------------------------------------------------------------------
                try
                {
                    TwoMc = ParkingLot[i].Count(r => r == '-') >= 2;
                    exists = ParkingLot[i].Contains(input + "-mc");
                }
                catch (ArgumentNullException) { }
                catch (Exception) { }

                if (TwoMc)
                {
                    if (exists)
                    {


                     //--------------------------- splits array att given index ---------------------------
                     //--------------------------- string[] search{"str1","str2"} ---------------------------
                        var search = ParkingLot[i].Split(" ");


                        input += "-mc";
                        //loop search array
                        for (int j = 0; j < search.Length; j++)
                        {

                            //--------------------------- if search[j] is same as given input ---------------------------
                            //--------------------------- remove it from parkinglot array ---------------------------

                            if (search[j] == input)
                            {
                                Console.WriteLine($"{input.Replace("-mc", "")} is checked out, ");
                                ParkingLot[i] = ParkingLot[i].Replace(search[j], "").Trim();
                                index = -1;
                                return true;

                            }
                            else
                            {
                                continue;
                            }
                        }

                    }

                }

            }

            return false;
        }

        //-------------------------------------------------------------------------
        //---------------- Shows what vehicles are park and where -----------------
        //-------------------------------------------------------------------------

        private static void showParkedVehicles()
        {
            for (int i = 0; i < ParkingLot.Length; i++)
            {

                if (ParkingLot[i] == null)
                {
                    continue;
                }

                else
                {
                    Console.WriteLine("License plate: {0}, parked on space: {1}", ParkingLot[i].ToString(), i + 1);
                }

            }


        }

        //-------------------------------------------------------------------------
        //---------------- Moves a vehicle from one place to another --------------
        //-------------------------------------------------------------------------
        private static void swap()
        {
            Console.Write("Enter license plate nr: ");
            string input = UserInputCheck(Console.ReadLine().ToUpper());

            bool succes = lookForCar(input);

            //-------------------------------------------------------------------------
            //-------------------------- Moves A Car ----------------------------------
            //-------------------------------------------------------------------------
            if (succes)
            {

                spacesLeft();

                Console.Write("Parkingspace you want to switch to:  ");
                int pSpace = ParseInput(Console.ReadLine());

                if (ParkingLot[pSpace - 1] == null)
                {
                    ParkingLot[delIndex] = null;
                    ParkingLot[pSpace - 1] = input;
                    Console.WriteLine($"Pls switch {input} from: {delIndex + 1} to: {pSpace}");
                }
                else
                {
                    Console.WriteLine("cant park here");
                }
            }

            bool succesMc = lookForMc(input);

            //-------------------------------------------------------------------------
            //--------------------------- Moves A MC ----------------------------------
            //-------------------------------------------------------------------------
            if (succesMc)
            {
                input += "-mc";


                spacesLeft();

                Console.Write("Parkingspace you want to switch to: ");
                int pSpace = ParseInput(Console.ReadLine());


                try
                {
                    Exists = ParkingLot[delIndex].Contains(input);
                }
                catch (ArgumentNullException) { }
                catch (Exception) { }

                if (Exists)
                {

                    if (ParkingLot[delIndex] == input)
                    {

                        bool count = false;

                        try
                        {
                         //----------------------------------------------------------------------------
                         //------------------------ Checks if there is 1 or 2 MC ----------------------
                         //----------------------------------------------------------------------------
                            count = ParkingLot[pSpace].Count(r => r == '-') >= 2;

                        }
                        catch (ArgumentNullException) { }
                        catch (Exception) { }


                        if (ParkingLot[pSpace - 1] == null)
                        {
                            ParkingLot[delIndex] = null;
                            ParkingLot[pSpace - 1] = input;
                            Console.Clear();
                            Console.WriteLine($"Pls switch {input.Substring(0, input.Length - 3)} from space: {delIndex + 1} to: {pSpace}");
                        }
                        else if (count)
                        {
                            ParkingLot[pSpace - 1] += input;
                            ParkingLot[delIndex] = null;
                            Console.Clear();
                            Console.WriteLine($"Pls switch {input.Substring(0, input.Length - 3)} from space: {delIndex + 1} to: {pSpace}");
                        }
                        else if (!count)
                        {
                            Console.Clear();
                            Console.WriteLine("Cant park here, space taken");
                        }
                    }
                    else
                    {
                        var search = ParkingLot[delIndex].Split(" ");
                        for (int i = 0; i < search.Length; i++)
                        {
                            if (search[i] == input)
                            {
                                if (ParkingLot[pSpace - 1] == null)
                                {
                                    ParkingLot[delIndex] = ParkingLot[delIndex].Replace(input, null).Trim();
                                    ParkingLot[pSpace - 1] = input;
                                    Console.Clear();
                                    Console.WriteLine($"Pls switch {input.Substring(0, input.Length - 3)} from space: {delIndex + 1} to: {pSpace}");
                                }
                                else
                                {
                                    //-------------------------------------------------------------------------
                                    //-------------- Changes which spot the vehicle is parked on --------------
                                    //-------------------------------------------------------------------------
                                    ParkingLot[delIndex] = ParkingLot[delIndex].Replace(input, null).Trim();


                                    //-------------------------------------------------------------------------
                                    //-------------------------- Add to new spot ------------------------------
                                    //-------------------------------------------------------------------------
                                    ParkingLot[pSpace - 1] += " " + input;
                                    Console.Clear();
                                    Console.WriteLine($"Pls switch {input.Substring(0, input.Length - 3)} from space: {delIndex + 1} to: {pSpace}");
                                }
                            }


                            else
                            {
                                continue;
                            }
                        }
                    }

                }
                else if (!Exists)
                {
                    Console.Clear();
                    Console.WriteLine("cant park here");
                }

            }
            else if (!succes && !succesMc)
            {
                Console.Clear();
                Console.WriteLine($"{input.ToUpper()} is not parked here");
            }

        }

        //-------------------------------- int parse the input -------------------------------------
        private static int ParseInput(string input)
        {
            while (true)
            {
         //--------------- boolean that holds the input and "tries" to parse to a number ------------
         //--------------------- if its "true" return the parsed number -----------------------------
         //------------------------------- "else" new input -----------------------------------------
                bool succes = Int32.TryParse(input, out number);
                
                if (succes && number <= 100 && number > 0)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Invalid input, only numbers 1-100!");
                    input = Console.ReadLine();
                }
            }
        }

        //------------------------ prints out the spaces thats left ---------------------------
        private static void spacesLeft()
        {
            for (int i = 0; i < ParkingLot.Length; i++)
            {
                if (ParkingLot[i] != null)
                {
                    continue;
                }


                Console.WriteLine($"Parking space available: {i + 1}");

            }

        }

        // data input
        //private static void TestMethod()
        //{

        //    ParkingLot[0] = "BLA123-mc MCTEST321-mc";
        //    ParkingLot[1] = null;
        //    ParkingLot[2] = "DEF456-mc";
        //    ParkingLot[3] = "GHI789";
        //    ParkingLot[5] = "TEST123-mc ENNA786-mc";
        //    ParkingLot[99] = "DERP345";
        //}
    }
}