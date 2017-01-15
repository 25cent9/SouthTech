//Griffin Melson, Zachary Pearson, Daniel Collins
//1/27/2016
//Takes in data about students, interprets it, then places students in the correct classroom for both sessions
using System;
using System.Linq;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Collections.Generic;

namespace careerConnect
{
    class Program
    {
        public static int start;
        public static int page = 1;
        public static Student[] studs = readFile("C:\\Users\\278491\\Desktop\\Parkway SouthWest MiddleStudents.txt");

        static void Main(string[] args)
        {
            //Student[] studs = readFile("C:\\Users\\278491\\Desktop\\Parkway South MiddleStudents.txt");
            Course[] courses = sort(ref studs, 20);
            int firsts;
            firsts = chckFirst(studs);
            //PrintDocument();
            Console.Write(firsts);
            Console.Read();
        }
        static int chckFirst(Student[] studs)
        {
            int firsts = 0;
            foreach (Student stu in studs)
            {
                if (stu.hadFirst)
                {
                    firsts++;
                }
            }
            return firsts;
        }

        #region printpage

        static void printer_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font PrinterFont = new Font("Courier New", 20);
            var DefaultPageSettings = new PageSettings();
            //Declare local variables needed
            DefaultPageSettings.Margins.Left = 150;
            DefaultPageSettings.Margins.Right = 150;
            DefaultPageSettings.Margins.Top = 150;
            DefaultPageSettings.Margins.Bottom = 150;
            //int counter = 0;
            DateTime gDate = DateTime.Now;
            /*
            //Displays school
            string schl = studs[0].school;
            e.Graphics.DrawString(schl, PrinterFont, Brushes.Black, e.MarginBounds.Left, 20 * 0 + e.MarginBounds.Top);
            //Displays Title and Date
            e.Graphics.DrawString("South Tech Career Connect".PadRight(40) + gDate + " Page " + page, PrinterFont, Brushes.Black, e.MarginBounds.Left, 20 * 1 + e.MarginBounds.Top);
            //Displays Name, Session 1, and Session 2
            e.Graphics.DrawString("Name".PadRight(20) + "Session 1".PadRight(20) + "Session 2".PadRight(20), PrinterFont, Brushes.Black, e.MarginBounds.Left, 20 * 2 + e.MarginBounds.Top);
            //Prints out each line for each student on the studs array
            
            for (int i = start; i < studs.Length - 1; i++)
            {
                string ses1, ses2;
                ses1 = FindSession(studs[i].s1);
                ses2 = FindSession(studs[i].s2);
                string name = studs[i].fName + " " + studs[i].lName;
                string school = studs[i].school;
                //Print the page
                e.Graphics.DrawString(name.PadRight(20) + ses1.PadRight(20) + ses2.PadRight(20), PrinterFont, Brushes.Black, e.MarginBounds.Left, 20 * (counter + 3) + e.MarginBounds.Top);
                counter++;
                if (counter == 40)
                {
                    start = i + 1;
                    e.HasMorePages = true;
                    page++;
                    break;
                }
                else
                {
                    e.HasMorePages = false;
                }
            }
            */
            if (e.HasMorePages == false)
            {
                start = 0;
                page = 0;
            }
        }
        #endregion

        #region  PrintDocument
        public static void PrintDocument()
        {

            //Create an instance of our printer class
            PrintDocument printer = new PrintDocument();
            printer.PrintPage += new PrintPageEventHandler(printer_PrintPage);
            printer.Print();

        }

        #endregion

        #region Students
        public static string FindSession(int session)
        {
            string classSession = "";
            switch (session)
            {
                case (0):
                    classSession = "Elec/Robot/Eng";
                    break;
                case (1):
                    classSession = "Precision Mach.";
                    break;
                case (2):
                    classSession = "Welder";
                    break;
                case (3):
                    classSession = "Inventor";
                    break;
                case (4):
                    classSession = "Carpenter";
                    break;
                case (5):
                    classSession = "Gen. Construct";
                    break;
                case (6):
                    classSession = "Elec/Concrete";
                    break;
                case (7):
                    classSession = "Cosmetologist";
                    break;
                case (8):
                    classSession = "Chef/Baker";
                    break;
                case (9):
                    classSession = "Early Childhood";
                    break;
                case (10):
                    classSession = "Vet Tech";
                    break;
                case (11):
                    classSession = "Dentist";
                    break;
                case (12):
                    classSession = "Nurse/Doctor";
                    break;
                case (13):
                    classSession = "Lab Tech/Pharm";
                    break;
                case (14):
                    classSession = "Fire/EMT";
                    break;
                case (15):
                    classSession = "Police Officer";
                    break;
                case (16):
                    classSession = "Comp Net Eng";
                    break;
                case (17):
                    classSession = "AutoBody Repair";
                    break;
                case (18):
                    classSession = "Auto Mechanic";
                    break;
                case (19):
                    classSession = "Motorcycle Mech";
                    break;
                case (20):
                    classSession = "Web/Comp Sci";
                    break;
                case (21):
                    classSession = "Graphic Design";
                    break;
            }
            return classSession;
        }
        //takes data in the form of a string, breaks it into substrings with octothorpes (#) denoting where to cut off each substring, returns an array of strings
        public static string[] parseLine(string line)
        {
            string[] parsed = new string[25];       //array to store substrings
            for (int i = 0; i < parsed.Length; i++) //makes all strings empty; i is the index of the current string
            {
                parsed[i] = "";                         //sets current string as empty
            }
            int j = 0;                              //index of substring that is currently being interpreted
            for (int i = 0; i < line.Length && j < parsed.Length; i++)   //goes character by character, places data into substring array
            {
                if (line[i] == '#')                     //if current character is an octothorpe (#)
                {
                    j++;                                    //move to next substring
                }
                else                                    //if current character is anything other than an octothorpe (#)
                {
                    parsed[j] += line[i];                   //store character in current substring
                }
            }
            return parsed;                          //returns interpreted substring array
        }
        //takes the address of file from Innocent's program, makes that data usable in the form of an array of Student objects
        public static Student[] readFile(string dest)
        {
            StreamReader file = new StreamReader(dest);                 //allows us to read file
            int lines = File.ReadLines(dest).Count();                   //number of lines/students
            Student[] studs = new Student[lines];                       //array to store student data
            string line;                                                //string that stores current line
            for (int i = 0; (line = file.ReadLine()) != null; i++)       //extracts data from from the file and puts it into the array of Student objects
            {
                string[] parsedLine = new string[25];                       //array to store the different peices of data as strings
                int[] col = new int[22];                                      //array to store data in each column
                int[] choices = new int[10];                                  //stores the student's choices in order, 0 being their first choice
                for (int j = 0; j < choices.Length; j++)                    //sets a default for the coices
                {
                    choices[j] = -1;                                            //sets current choice as -1
                }
                string fName, lName, school;                                //strings to store name and school data
                parsedLine = parseLine(line);                               //gets the substring data
                school = parsedLine[0];                                     //sets school data
                lName = parsedLine[1];                                      //sets first name data
                fName = parsedLine[2];                                      //sets last name data
                for (int j = 0; j < col.Length; j++)                        //stores column data in col
                {
                    col[j] = Convert.ToInt16(parsedLine[j + 3]);
                }
                for (int j = 0; j < col.Length; j++)                        //converts data from columns to the student's choices
                {
                    if (col[j] > 0 && col[j] < 11)
                    {
                        choices[col[j] - 1] = j;
                    }
                }
                Student temp = new Student(school, fName, lName, choices);
                studs[i] = temp;
            }
            return studs;
        }
        //this is where the magic happens, boys and girls; takes a reference of an array of Student objects and a max number of seats per, sets each Student's session 1 and session 2 based on their preferences
        public static Course[] sort(ref Student[] studs, int seats)
        {
            Random rnd = new Random();                                              //creats a Random object to shuffle the students
            for (int i = 0; i < studs.Length; i++)                                  //places a Student of a random at the index of i in the array
            {
                int j = rnd.Next(studs.Length);                                         //generates a random number between 0 and the length of the student array, stores it in j
                Student temp = new Student();                                           //temporary Student object to store data during switch
                temp = studs[j];                                                        //stores data of random Student in temp
                studs[j] = studs[i];                                                    //sets the data of Student of i in random index
                studs[i] = temp;                                                        //sets the random Student's data in the index of i
            }
            Course[] courses = new Course[22];                                              //array of ints, each refers to a course and stores how many seats are still available in each course
            for (int i = 0; i < courses.Length; i++)                                //sets each value in course array to 1 less than the max value of seats
            {
                courses[i] = new Course(seats);                                                 //sets the int at i to 1 less than the max number of seats
            }
            //session 1
            for (int i = 0; i < studs.Length; i++)                                  //looks at preferences of Student at i and places them in their highest rated course that is not full
            {
                for (int j = 0; j < studs[i].choices.Length && studs[i].s1 == -1; j++)  //checks each preferece, sets student in highest avaliable one, exits loop once student has been assigned a class
                {
                    if (studs[i].choices[j] > -1)                                           //error catching
                    {
                        if (courses[studs[i].choices[j]].seats[0] > -1)                                 //skips choice if class is full
                        {
                            studs[i].s1 = studs[i].choices[j];                                      //sets student's session 1 as class at j ranking
                            courses[studs[i].choices[j]].add(0, studs[i]);                                         //removes one seat from class at j ranking
                            studs[i].choices[j] = -1;                                               //removes class from students choices so they will not get it for session 2
                            if (j == 0)                                                             //if student had their first choice, sets a boolean to true to indicate this
                            {
                                studs[i].hadFirst = true;                                               //indicates student has had their first choice
                            }
                        }
                    }
                }
                if (studs[i].s1 == -1)
                {
                    placeLeast(ref studs[i], ref courses, 0);
                }
            }
            for (int i = 0; i < studs.Length; i++)                                  //places students that have not had their first class at the top of the array
            {
                if (studs[i].hadFirst == false)                                         //checks if student at i has not had their first choice
                {
                    Student temp = new Student();                                           //temporary Student object to store data while places are switched
                    for (int j = 0; j <= i; j++)                                            //moves student at i to 0, moves everything in between 0 and i to the next spot in the array
                    {
                        temp = studs[0];                                                        //stores data of student at 0 in temp
                        studs[0] = studs[j];                                                    //stores data of student at j in student at 0
                        studs[j] = temp;                                                        //places data of student previously at 0 in student at j
                    }
                }
            }
            //session 2
            for (int i = 0; i < studs.Length; i++)                                  //looks at preferences of Student at i and places them in their highest rated course that is not full
            {
                for (int j = 0; j < studs[i].choices.Length && studs[i].s2 == -1; j++)  //checks each preferece, sets student in highest avaliable one, exits loop once student has been assigned a class
                {
                    if (studs[i].choices[j] != -1)                                          //if the preference does not indicate a class, skip to the next one
                    {
                        if (studs[i].choices[j] > -1)                                           //error catching
                        {
                            if (courses[studs[i].choices[j]].seats[1] > -1)                                 //skips choice if class is full
                            {
                                studs[i].s2 = studs[i].choices[j];                                      //sets student's session 1 as class at j ranking
                                courses[studs[i].choices[j]].add(1, studs[i]);                                         //removes one seat from class at j ranking
                            }
                        }
                    }
                }
                if (studs[i].s2 == -1)
                {
                    placeLeast(ref studs[i], ref courses, 1);
                }
            }
            return courses;
        }
        public static void placeLeast(ref Student stud, ref Course[] courses, int s)
        {
            int clss = 0, val = courses[0].seats[s];
            for (int i = 0; i < courses.Length; i++)
            {
                if (courses[i].seats[s] > val)
                {
                    clss = i;
                }
            }
            switch (s)
            {
                case 0:
                    stud.s1 = clss;
                    courses[clss].add(0, stud);
                    break;
                case 1:
                    stud.s2 = clss;
                    courses[clss].add(1, stud);
                    break;
            }
        }
    }
    //stores all of the data for each student in a class, including identifying information, preferences, and scheduled courses
    class Student
    {
        public Student()                                                                //default constructor
        {

        }
        public Student(string nSchool, string nFName, string nLName, int[] nChoices)    //constructor
        {
            school = nSchool;
            fName = nFName;
            lName = nLName;
            choices = nChoices;
            hadFirst = false;                                                               //default
            s1 = -1;                                                                        //default
            s2 = -1;                                                                        //default
        }
        public int s1, s2;                                                              //stores what course the student has been assigned for seesion 1 and session 2, respectively
        public string fName, lName, school;                                             //stores student's first name, last name, and school, respectively
        public bool hadFirst;                                                           //indicates if student was assigned their first choice
        public int[] choices;                                                           //array that stores the student's preferences
    }
    class Course
    {
        public Course()
        {

        }
        public Course(int size)
        {
            seats = new int[2];
            for (int i = 0; i < seats.Length; i++)
            {
                seats[i] = size - 1;
            }
            sessions = new List<Student>[2];
            for (int i = 0; i < sessions.Length; i++)
            {
                sessions[i] = new List<Student>();
            }
        }
        public void add(int session, Student stud)
        {
            sessions[session].Add(stud);
            seats[session]--;
        }
        public int[] seats;
        public List<Student>[] sessions;

    }
    #endregion
}