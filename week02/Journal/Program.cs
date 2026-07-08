using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._function = "Manager";
        job1._startDate = "January 2021";
        job1._endDate = "March 2024";
        job1._companyName = "White House";
        

        Job job2 = new Job();
        job2._function = "Senior Manager";
        job2._startDate = "April 2024";
        job2._endDate = "Current";
        job2._companyName = "United Nations";
        

        Resume myResume = new Resume();
        myResume._name = "Emaneke Favori";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.DisplayResume();
        
    }
}