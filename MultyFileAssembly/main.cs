using System;
using System.Text;
using epam;

class Program
{
    static void Main()
    {
	Console.OutputEncoding = Encoding.GetEncoding(1251);
        
	Training obj = new Training();
        obj.TrainingInfo();

	Lab obj1 = new Lab();
        obj1.LabInfo();
	
	Job obj2 = new Job();
	obj2.JobInfo();
	
        Console.ReadLine();
    }
}