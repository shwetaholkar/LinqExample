

//// See https://aka.ms/new-console-template for more information

class FakeData
{

    public static List<State> GetState()
    {
        List<State> states = new List<State>();


        for (int i = 1; i <= 5; i++)
        {
            State state = new State();
            state.StateId = i;
            state.StateName = Faker.Address.City();
            states.Add(state);
        }
        return states;
    }

    public static List<District> GetDistricts()
    {
        List<District> districts = new List<District>();
        Random rand = new Random();

        for (int i = 1; i <= 10; i++)
        {
            District district = new District();
            district.DistrictId = i;
            district.DistrictName = Faker.Address.City();
            district.StateId = rand.Next(1, 5);
            districts.Add(district);
        }
        return districts;
    }

    public static List<Taluka> GetTalukas()
    {
        List<Taluka> talukas = new List<Taluka>();
        Random rand = new Random();

        for (int i = 1; i <= 40; i++)
        {
            Taluka taluka = new Taluka();
            taluka.TalukaId = i;
            taluka.TalukaName = Faker.Address.City();
            taluka.DistrictId = rand.Next(1, 10);
            talukas.Add(taluka);
        }
        return talukas;
    }


    public static List<Standard> GetStandard()
    {
        List<Standard> standards = new List<Standard>();


        for (int i = 1; i <= 5; i++)
        {
            Standard standard = new Standard();
            standard.StandardID = i;
            standard.StandardName = "Standard " + (char)(66 + i);
            standards.Add(standard);
        }
        return standards;
    }



    public static List<Student> GetStudents()
    {
        List<Student> students = new List<Student>();
        Random rand = new Random();

        for (int i = 1; i <= 300; i++)
        {
            Student student = new Student();
            student.StudentID = i;
            student.StudentName = Faker.Name.First();
            student.StandardID = rand.Next(1, 5);
            student.StateId = rand.Next(1, 5);
            student.DistrictId = rand.Next(1, 5);
            student.TalukaId = rand.Next(1, 20);


            students.Add(student);
        }
        return students;
    }
}







//Console.WriteLine("Hello, World!");
//string[] names = { "Bill", "StAve", "James", "Mohan" };

//// LINQ Query 

////foreach(string name in names)
////{
////    if(name.StartsWith("moh"))
////            Console.WriteLine(name); //James,Mohan
////}

////var myLinqQuery = names.Where(n => n.StartsWith("Moh"));

////var myLinqQuery2 = from name in names
////                   where name.Contains('a')
////                   select name;
///*
// * 
// * 
// * 
// * 
// * 
// * 
// */ 




////var myLinqQuery3 = names.GroupBy(x => x.Contains('a'));

////foreach(var index in myLinqQuery3)
////{

////   foreach(var Data in index)
////    {
////        Console.WriteLine(Data);
////    }
////   Console.WriteLine();
////}


////// Query execution
////foreach (var name in myLinqQuery3)
////    Console.Write(name + " ");




//////Joins


//IList<string> strList1 = new List<string>() {
//    "One",
//    "Two",
//    "Three",
//    "Four"
//};

//IList<string> strList2 = new List<string>() {
//    "One",
//    "Two",
//    "Five",
//    "Six"
//};

//var innerJoin = strList1.Join(strList2,
//                      str1 => str1,
//                      str2 => str2,
//                      (str1, str2) => str1);



//IList<Student> studentList = new List<Student>() {
//    new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
//    new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
//    new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
//    new Student() { StudentID = 4, StudentName = "Ram" , StandardID =2 },
//    new Student() { StudentID = 5, StudentName = "Ron"  }
//};

//IList<Standard> standardList = new List<Standard>() {
//    new Standard(){ StandardID = 1, StandardName="Standard A"},
//    new Standard(){ StandardID = 2, StandardName="Standard B"},
//    new Standard(){ StandardID = 3, StandardName="Standard C"}
//};

////var innerJoin2 = studentList.Join(// outer sequence 
////                      standardList,  // inner sequence 
////                      student => student.StandardID,    // outerKeySelector
////                      standard => standard.StandardID,  // innerKeySelector
////                      (student, standard) => new  // result selector
////                      {
////                          StudentName = student.StudentName,
////                          StandardName = standard.StandardName
////                      });

////foreach (var standard in innerJoin2)
////{
////    Console.WriteLine(standard.StudentName + "  " + standard.StandardName);
////}




//var innerJoin3 = from student in studentList
//                 join stand in standardList
//                 on student.StandardID equals stand.StandardID
//                 select new
//                 {
//                     StudentName = student.StudentName,
//                     StandardName= stand.StandardName,
//                 };

//foreach(var student in innerJoin3)
//{
//    Console.WriteLine(student.StudentName +","+student.StandardName);
//}



