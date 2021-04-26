using System;
using System.Collections.Generic;
using System.IO;

namespace SampleBU07
{
    class Program
    {
        static void MainFirst(string[] args)
        {
            clsStudent AStudent = new clsStudent();
            clsStudent BStudent = new clsStudent("00111", "J.K.", "Rawling");
            clsStudent CStudent = new clsStudent("00222", "Yogi", "Bear", 90, 83, 97, 92, 100);

            // Create a student object container to store the student information
            AStudent.StudentID = "12310";
            AStudent.FName = "Steve";
            AStudent.LName = "Jobs";
            AStudent.Scores[0] = 96;
            AStudent.Scores[1] = 84;
            AStudent.Scores[2] = 88;
            AStudent.Scores[3] = 83;
            AStudent.Scores[4] = 91;

            BStudent.Scores[0] = 87;
            BStudent.Scores[1] = 91;
            BStudent.Scores[2] = 77;
            BStudent.Scores[3] = 100;
            BStudent.Scores[4] = 96;

            // Output the student information, including assigned scores
            Console.WriteLine("══════════════════");
            Console.WriteLine("  Student Ledger");
            Console.WriteLine("══════════════════\n");
            Console.WriteLine("Student ID       : " + AStudent.StudentID);
            Console.WriteLine("First Int or Name: " + AStudent.FName);
            Console.WriteLine("Last Name        : " + AStudent.LName);
            Console.Write("Scores           : ");
            for (int xx = 0; xx < 5; xx++)
                Console.Write(AStudent.Scores[xx].ToString("D3") + "  ");

            Console.WriteLine("\n\nStudent ID       : " + BStudent.StudentID);
            Console.WriteLine("First Int or Name: " + BStudent.FName);
            Console.WriteLine("Last Name        : " + BStudent.LName);
            Console.Write("Scores           : ");
            for (int xx = 0; xx < 5; xx++)
                Console.Write(BStudent.Scores[xx].ToString("D3") + "  ");

            Console.WriteLine("\n\nStudent ID       : " + CStudent.StudentID);
            Console.WriteLine("First Int or Name: " + CStudent.FName);
            Console.WriteLine("Last Name        : " + CStudent.LName);
            Console.Write("Scores           : ");
            for (int xx = 0; xx < 5; xx++)
                Console.Write(CStudent.Scores[xx].ToString("D3") + "  ");

            // Output the average of the scores
            Console.WriteLine("\n\nA-Student Average " + AStudent.AverageScores.ToString("0.000"));
            Console.WriteLine("B-Student Average " + BStudent.AverageScores.ToString("0.000"));
            Console.WriteLine("C-Student Average " + CStudent.AverageScores.ToString("0.000"));

            // We're done, wait for user to press key then quit
            Console.WriteLine("\n\nPress a key to exit application...");
            Console.ReadKey();
        }

        // ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
        // ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀

        static void MainAttempt2(string[] args)
        {
            // 1. Create a array or collection for student (declare)
            // 2. Read values from the file
            // 3. Process what you input
            // 4. Write info to the screen
            // All done!

            // 1 - Declare what is needed
            clsStudent[] MyStudents = new clsStudent[2];
            int Idx;
            string line;
            string[] theParts;
            StreamReader sr;

            // 2 - Open and read the data file
            sr = new StreamReader("G:\\AllMyStudents.txt");
            line = sr.ReadLine();
            Idx = 0;
            while (line != null)
            {
                theParts = line.Split(',');
                MyStudents[Idx] = new clsStudent(theParts[0],
                                                 theParts[1],
                                                 theParts[2],
                                                 int.Parse(theParts[3]),
                                                 int.Parse(theParts[4]),
                                                 int.Parse(theParts[5]),
                                                 int.Parse(theParts[6]),
                                                 int.Parse(theParts[7]));



                line = sr.ReadLine();
                Idx++;
            }
            sr.Close();

            // 3 - Process the data
            //   *** Nothing to do - just sending it to the screen ***

            // 4 - Output the results
            for (int xx = 0; xx < MyStudents.Length; xx++)
            {
                Console.WriteLine(MyStudents[xx].ToString());
            }

            Console.WriteLine("\n\nPress a key to output using a different format...");
            Console.ReadKey();

            Console.Clear();
            for (int xx = 0; xx < MyStudents.Length; xx++)
                Console.WriteLine(MyStudents[xx].ToMultiLineString());

            Console.WriteLine("\n\nPress a key to terminate...");
            Console.ReadKey();
        }

        // ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
        // ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀

        static clsStudent[] MyStudents = new clsStudent[2];
        // static List<clsStudent> MyStudents2 = new List<clsStudent>();

        /// <summary>
        /// Method to manage the application from start to finish until the user says 
        /// 'AAARRRGGGHHH I can't do this anymore!!!'   :o)
        /// </summary>
        /// <remarks>
        /// This application will read a set of student data from a file, allow the user to work
        /// with the loaded data, and then when finished, write the updated information back to the
        /// student file.
        /// </remarks>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // ────────────────────────────────────────────────────────────────────────────────────
            //    CUSTOM REMINDER OF THE MODEL:
            // ────────────────────────────────────────────────────────────────────────────────────
            //
            //                                  Memory (Variables)
            //                                           |
            //                      INPUT  »»»  PROCESSING  »»»  OUTPUT (Result)
            //
            // ────────────────────────────────────────────────────────────────────────────────────

            bool isDone = false;       // Used to manage menu loop
            ConsoleKeyInfo choice;     // Used to capture user entry

            // INPUT
            ReadStudentDataFromFile();

            // PROCESSING
            while (!isDone)
            {
                // Print a menu for the user
                Console.Clear();
                Console.WriteLine("▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
                Console.WriteLine("   Hey, welcome to my neighborhood!");
                Console.WriteLine("      (No, I'm NOT Mr. Rogers!)");
                Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄\n");
                Console.WriteLine("Hiya! Choose from the following:");
                Console.WriteLine(" 1 - Show List of Student Data (On Screen)");
                Console.WriteLine(" 2 - Edit The Student Data");
                Console.WriteLine(" 3 - Add a New Student");
                Console.WriteLine(" 4 - Remove a Student");
                Console.WriteLine(" 5 - Get Outta Here! (That means EXIT the app!)");

                choice = Console.ReadKey();
                if (choice.KeyChar == '1')
                {
                    WriteDataToScreen();

                    Console.WriteLine("\n\nPress a key to continue...");
                    Console.ReadKey();
                }
                else if (choice.KeyChar == '2')
                {
                    EditMyData();
                }
                else if (choice.KeyChar == '3')
                    isDone = true;
                else
                {
                    Console.Beep(160, 200);     // Cool way to make a deep sound for 2/10's of a second
                    Console.Beep();             // Cool way to take the default beep that .NET supplies
                }
            }

            // OUTPUT (RESULT)
            WriteStudentDataToFile();


            // Create an array to hold up to 10 components
            clsComponent[] TheComponents = new clsComponent[10];
            for (int xx = 0; xx < TheComponents.Length; xx++)
                TheComponents[xx] = new clsComponent();
        }


        #region DATA INPUT Support Methods
        // ────────────────────────────────────────────────────────────────────────────────────────
        /// <summary>
        /// Manage readinbg data from the text file.
        /// </summary>
        static void ReadStudentDataFromFile()
        {
            int Idx;
            string line;
            string[] theParts;
            StreamReader sr;

            // Initialize the first index/student to be read
            Idx = 0;

            // Open a stream reader to a specific data file and begin reading data
            sr = new StreamReader("G:\\AllMyStudents.txt");
            line = sr.ReadLine();

            // While data exists, keep on trucking!
            while (line != null)
            {
                theParts = line.Split(',');
                MyStudents[Idx] = new clsStudent(theParts[0],
                                                 theParts[1],
                                                 theParts[2],
                                                 int.Parse(theParts[3]),
                                                 int.Parse(theParts[4]),
                                                 int.Parse(theParts[5]),
                                                 int.Parse(theParts[6]),
                                                 int.Parse(theParts[7]));

                line = sr.ReadLine();
                Idx++;
            }
            sr.Close();
            sr.Dispose();

        }
        #endregion


        #region OUTPUT/RESULTS Support Methods
        // ────────────────────────────────────────────────────────────────────────────────────────
        /// <summary>
        /// Manage writing the data back out to the text file.
        /// </summary>
        static void WriteStudentDataToFile()
        {
            StreamWriter sw;

            sw = new StreamWriter("G:\\AllMyStudents.txt", false);
            for (int xx = 0; xx < MyStudents.Length; xx++)
            {
                sw.WriteLine(MyStudents[xx].StudentID + ", " +
                    MyStudents[xx].FName + ", " +
                    MyStudents[xx].LName + ", " +
                    MyStudents[xx].Scores[0].ToString() + ", " +
                    MyStudents[xx].Scores[1].ToString() + ", " +
                    MyStudents[xx].Scores[2].ToString() + ", " +
                    MyStudents[xx].Scores[3].ToString() + ", " +
                    MyStudents[xx].Scores[4].ToString());
            }
            sw.Close();
            sw.Dispose();
        }
        #endregion


        #region Menu Item Support Methods
        // ────────────────────────────────────────────────────────────────────────────────────────
        /// <summary>
        /// A method to send the data to the console screen.
        /// </summary>
        static void WriteDataToScreen()
        {
            Console.WriteLine();
            for (int xx = 0; xx < MyStudents.Length; xx++)
                Console.WriteLine("Index " + xx.ToString("D2") + ": " + MyStudents[xx].ToString());
        }
        // ────────────────────────────────────────────────────────────────────────────────────────
        static void EditMyData()
        {
            int tmpID = -1;
            string tmpStr = string.Empty;

            Console.WriteLine("\n\nAha! You want to EDIT the data, do you???!!! MMMUUWWAAAHHHHHH!AAA!\n\n");
            while (tmpStr.Trim() != "A")
            {
                Console.WriteLine("Which Entry Index do you want to modify? ('A' to Abort)");
                tmpStr = Console.ReadLine();

                if (tmpStr.ToUpper().Trim() != "A")
                {
                    if (int.TryParse(tmpStr, out tmpID))
                    {
                        EditStudentID(tmpID);
                        tmpStr = "A";
                    }
                    else
                        Console.WriteLine("\nNot a legal ID; try again!");
                }
            }
        }
        #endregion
        // ────────────────────────────────────────────────────────────────────────────────────────
        static void EditStudentID(int pID)
        {
            string tmpStr;
            ConsoleKeyInfo choice;

            Console.Clear();
            Console.WriteLine("Edit Student Data...");

            Console.WriteLine("(A) Student ID: " + MyStudents[pID].StudentID);
            Console.WriteLine("(B) Last Name:" + MyStudents[pID].LName);
            Console.WriteLine("(C) First Name:" + MyStudents[pID].FName);
            Console.WriteLine("(D) Score 1:" + MyStudents[pID].Scores[0].ToString());
            Console.WriteLine("(E) Score 2:" + MyStudents[pID].Scores[1].ToString());
            Console.WriteLine("(F) Score 3:" + MyStudents[pID].Scores[2].ToString());
            Console.WriteLine("(G) Score 4:" + MyStudents[pID].Scores[3].ToString());
            Console.WriteLine("(H) Score 5:" + MyStudents[pID].Scores[4].ToString());

            Console.WriteLine("Which Field do you want to edit?  ((X) - Abort)");
            choice = Console.ReadKey();
            if (choice.KeyChar == 'A')
            {
                // Do something
            }
            else if (choice.KeyChar == 'B')
            {
                Console.WriteLine("\n\nEnter new last name for this student:");
                tmpStr = Console.ReadLine();
                MyStudents[pID].LName = tmpStr;
            }
            else if (choice.KeyChar == 'C')
            {
                // Do something
            }
            else if (choice.KeyChar == 'D')
            {
                // Do something
            }
            else if (choice.KeyChar == 'E')
            {
                // Do something
            }
            else if (choice.KeyChar == 'F')
            {

            }
            else if (choice.KeyChar == 'G')
            {

            }
            else if (choice.KeyChar == 'H')
            {

            }
            else if (choice.KeyChar == 'X')
            {

            }
        }
    }
}
