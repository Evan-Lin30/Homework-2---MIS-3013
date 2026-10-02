class Program
{
    static void Main()
    {
        //courses array
        string[] courses = new string[0];

        //declare an empty list, options (1 and 2)
        List<string> assignments = new List<string>(); // options based on main menu (3,4,5, 7)

        //declare an empty dictionary, options (6 and 7)
        Dictionary<string, string> assignmentDetails = new Dictionary<string, string>();

        bool running = true;
        while (running)
        {
            Console.WriteLine("Assignment Tracker \n");
            Console.WriteLine("1: Create Course");
            Console.WriteLine("2: Update Course");
            Console.WriteLine("3: Add Assignment");
            Console.WriteLine("4: Update Assignment");
            Console.WriteLine("5: Remove Assignment By Index");
            Console.WriteLine("6 Add or Update Assignment Detail");
            Console.WriteLine("7: Remove By Assignment Name for List and Dictionary");
            Console.WriteLine("8. Exit");
            Console.WriteLine("Please enter your choice:");
            int choice = Convert.ToInt16(Console.ReadLine());

            if (choice == 1)
            {
                //function 1 create course array
                //ask for the number of courses
                Console.WriteLine("\n How many courses do you have?");
                int numberOfCourses = Convert.ToInt16(Console.ReadLine());

                //create/update array
                courses = new string[numberOfCourses];

                //use a loop to capture course name
                for (int i = 0; i < courses.Length; i++)
                {
                    Console.Write($"Enter Course {i}: ");
                    courses[i] = Console.ReadLine(); // value assignment
                }
                Console.WriteLine("\nThe course array: ");
                //display index and value of the array
                for (int i = 0; i < courses.Length; i++)
                {
                    Console.WriteLine($"{i}: {courses[i]}");
                }
            }
            else if (choice == 2)
            {
                //funciton 2, ensure the array length is not 0
                if (courses.Length == 0)
                {
                    Console.WriteLine("\n The courses array has not been created yet. Please chose option 1 first");
                }
                else
                {
                    for (int i = 0; i < courses.Length; i++)
                    {
                        Console.WriteLine(i + ". " + courses[i]);
                    }
                }
                Console.WriteLine("Please enter the course index: ");
                int courseIndex = Convert.ToInt16(Console.ReadLine());

                if (courseIndex >= 0 && courseIndex < courses.Length)
                {
                    Console.WriteLine("Enter the new course");
                    courses[courseIndex] = Console.ReadLine();
                    
                    //display the updated course list
                    for (int i = 0; i < courses.Length; i++)
                    {
                        Console.WriteLine(i + ". " + courses[i]);
                    }
                }
                else
                {
                    Console.WriteLine("invalid course index");
                }
            }
            else if (choice == 3)
            {
                //function 3
                //repeatedly ask for name until user replies with y? also call Add()
                //assignment[i] = ""
                //display current assignments
                string enterMore = "y";
                while (enterMore == "y")
                {
                    Console.WriteLine("Enter assignment anme");
                    string newAssignment = Console.ReadLine();
                    assignments.Add(newAssignment);
                    
                    Console.WriteLine("Do you want to enter another assignment? (y/n):"); 
                    string entermore = Console.ReadLine();
                }
                Console.WriteLine("The Current Assignment List: ");
                if (assignments.Count == 0)
                {
                    Console.WriteLine("No assignment found");
                }
                else
                {
                    for (int i = 0; i < assignments.Count; i++)
                    {
                        Console.WriteLine($"{i}: {assignments[i]}");
                    }
                }
            }
            else if (choice == 4)
            {
                //function 4
                //display current assignments with index
                Console.WriteLine("The currents assignments are: ");
                for (int i = 0; i < assignments.Count; i++)
                {
                    Console.WriteLine($"{i}: {assignments[i]}");
                }
                // request a valid index
                Console.WriteLine("Please enter a valid assignment index");
                int assignmentIndex = Convert.ToInt16(Console.ReadLine());
                if (assignmentIndex >= 0 && assignmentIndex < assignments.Count)
                {
                    string oldAssignment = assignments[assignmentIndex];
                    
                    Console.WriteLine("Enter the new assignment: ");
                    string newAssignment = Console.ReadLine();
                    assignments[assignmentIndex] = newAssignment;

                    if (assignmentDetails.ContainsKey(oldAssignment))
                    {
                        assignmentDetails[newAssignment] = assignmentDetails[oldAssignment];
                        assignmentDetails.Remove(oldAssignment);
                    }

                    for (int i = 0; i < assignments.Count; i++)
                    {
                        Console.WriteLine($"{i}: {assignments[i]}");
                    }
                }
                else
                {
                    Console.WriteLine("invalid assignment index");
                }
            }
            else if (choice == 5)
            {
                //display current assignemnts
                Console.WriteLine("The current assignments are:");
                
                for (int i = 0; i < assignments.Count; i++)
                {
                    Console.WriteLine(i + ". " + assignments[i]);
                }
                Console.WriteLine("Please enter a valid assignment index");
                int assignmentIndex = Convert.ToInt16(Console.ReadLine());

                if (assignmentIndex >= 0 && assignmentIndex < assignments.Count)
                {
                    assignments.RemoveAt(assignmentIndex);
                    Console.WriteLine("Updated assignments:");

                    for (int i = 0; i < assignments.Count; i++)
                    {
                        Console.WriteLine(i + ". " + assignments[i]);
                    }
                }
                else
                {
                    {
                        Console.WriteLine("invalid assignment index");
                    }
                }
            }
            else if (choice == 6)
            {
                //function 6
                //Display current details;
                //request assignment name, description, and status;
                //store description + " - " + status as value and the assignment name as key;
                //display the updated assignment details.
                Console.WriteLine("The current dictionary status");
                foreach (KeyValuePair <string, string> item in assignmentDetails)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
                Console.WriteLine("Please enter the assignment name (key)");
                string name = Console.ReadLine();
                
                Console.WriteLine("Please enter the assignment description: ");
                string description = Console.ReadLine();
                
                Console.WriteLine("Please enter the assignment status: ");
                string status = Console.ReadLine();

                string assignmentValue = description + " - " + status;

                assignmentDetails[name] = assignmentValue;
                Console.WriteLine("The updated dictionary");
                foreach (KeyValuePair<string, string> item in assignmentDetails)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
            else if (choice == 7)
            {
                //function 7
                Console.WriteLine("Current assignment list: ");
                for (int i = 0; i < assignments.Count; i++)
                {
                    Console.WriteLine(i + ". " + assignments[i]);
                }
                
                Console.WriteLine("Please enter the assignment you want to remove: ");
                string remAssignment = Console.ReadLine();
                assignments.Remove(remAssignment);

                for (int i = 0; i < assignments.Count; i++)
                {
                    Console.WriteLine(i + ". " + assignments[i]);
                }
                Console.WriteLine("Do you want to remove the Dictionary Key (y/n): ");
                string removeKey = Console.ReadLine();
                if (removeKey == "y")
                {
                    assignmentDetails.Remove(removeKey);
                }
            }
            else if (choice == 8)
            {
                //funciton 8
                Console.WriteLine("Great Work!");
                running = false;
            }
            else
            {
                Console.WriteLine("please enter a valid choice.");
            }
        }
    }
}