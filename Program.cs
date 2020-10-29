using System;
/**
Name: Jacob C.
Date of completion: 10/29/2020

Please be sure to comment your code - provide a comment for each structure use in 
program.
 */
namespace assignment_three
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set variables and arrays
            int sentinel = 0;
            int[] deptNum = {1, 2, 3, 4, 5, 6, 7};
            double[] deptSalary = {0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0};
            string[] deptName = {"Personnel", "Marketing", "Information Technology", "Computer Services", "Sales", "Legal", "Accounting"};
            //Program runs constantly until sentinel value is changed
            while(sentinel == 0){
                //Chooses Dept. or ends program
                Console.WriteLine("Input Dept. Number (1-7), or 0 to end program");
                int x = Convert.ToInt32(Console.ReadLine());
                if(x > 0 && x <= 7){
                    //Get Dept. 
                    int thisDept = x;
                    string thisDeptName = deptName[thisDept-1];
                    //Enter new employee data
                    Console.WriteLine("New entry for " + thisDeptName + ". Please enter employee name.");
                    string empName = Console.ReadLine();
                    Console.WriteLine("Enter " + empName + "'s Hours worked.");
                    int empHours = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter " + empName + "'s Hourly wage.");
                    double empWage = Convert.ToDouble(Console.ReadLine());
                    //Add data to existing array for relevant Dept.
                    deptSalary[thisDept-1] += empHours * empWage;
                }
                //End program, print report
                else if(x == 0){
                    //Prints Report for each dept, containing accumulated salary
                    for(int i = 0; i < 7; i++){
                        Console.WriteLine(deptName[i] + " Department's accumulated salary was $" + deptSalary[i]);
                    }
                    //Sets program to end
                    sentinel = 1;
                    Console.WriteLine("Program is done");
                }
                //If x != 0-7, asks for valid input
                else{
                    Console.WriteLine("Please enter a valid department number (1-7)");
                }
            }
        }
    }
}