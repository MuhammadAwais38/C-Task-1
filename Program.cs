using System;

namespace Task1
{
    enum Religion
    {
        Islam,
        Christian,
        Hindu
    }

    enum City 
    {
        Peshawar,
        Kohat,
        Islamabad
    }

    struct Student
    {
        public string name;
        public long CNIC;
        public Religion religion;
        public City city;
    }


    class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student();
            std1.name = "Zarar";
            std1.CNIC = 1420323054787;
            std1.religion = Religion.Islam;
            std1.city = City.Peshawar;

            Student std2 = new Student();
            std2.name = "Khalid";
            std2.CNIC = 1420223054787;
            std2.religion = Religion.Islam;
            std2.city = City.Peshawar;

            Student std3 = new Student();
            std3.name = "Samuel";
            std3.CNIC = 1720323054787;
            std3.religion = Religion.Christian;
            std3.city = City.Islamabad;

            Student std4 = new Student();
            std4.name = "Virat";
            std4.CNIC = 1730123054787;
            std4.religion = Religion.Hindu;
            std4.city = City.Kohat;

            Student std5 = new Student();
            std5.name = "Zaid";
            std5.CNIC = 1620223054787;
            std5.religion = Religion.Islam;
            std5.city = City.Kohat;

            Student[] students = { std1, std2, std3, std4, std5 };

            Console.WriteLine("Name:"+students[0].name+"\n" + "CNIC:"+students[0].CNIC+ "\n" + "Religion:"
                               + students[0].religion+ "\n" + "City:" + students[0].city);
            Console.WriteLine("-----------------------");

            Console.WriteLine("Name:" + students[1].name + "\n" + "CNIC:" + students[1].CNIC + "\n" + "Religion:"
                               + students[1].religion +"\n" + "City:" + students[1].city);
            Console.WriteLine("-----------------------");

            Console.WriteLine("Name:" + students[2].name + "\n" + "CNIC:" + students[2].CNIC + "\n" + "Religion:"
                               + students[2].religion +"\n" + "City:" + students[2].city);
            Console.WriteLine("-----------------------");

            Console.WriteLine("Name:" + students[3].name + "\n" + "CNIC:" + students[3].CNIC + "\n" + "Religion:"
                               + students[3].religion +"\n" + "City:" + students[3].city);
            Console.WriteLine("-----------------------");

            Console.WriteLine("Name:" + students[4].name + "\n" + "CNIC:" + students[4].CNIC + "\n" + "Religion:"
                               + students[4].religion +"\n" + "City:" + students[4].city);
            Console.WriteLine("-----------------------");
        }
    }
}