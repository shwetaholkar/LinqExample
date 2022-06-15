

//// See https://aka.ms/new-console-template for more information

var States = FakeData.GetState();
var Talukas = FakeData.GetTalukas();
var districts = FakeData.GetDistricts();
var Standards = FakeData.GetStandard();
var students = FakeData.GetStudents();

//6.Display Student Information By using StudentId from user


//--------------------------------------------------------------------------
//5. Display Last 10 students Information using First Assignment

//var studentInfo = (from student in students
//                   join state in States
//                   on student.StateId equals state.StateId
//                   join standard in Standards
//                   on student.StandardID equals standard.StandardID
//                   join district in districts
//                   on student.DistrictId equals district.DistrictId
//                   join taluka in Talukas
//                   on student.TalukaId equals taluka.TalukaId
//                   select new
//                   {
//                       StudentId = student.StudentID,
//                       StudentName = student.StudentName,
//                       StandardName = standard.StandardName,
//                       StateName = state.StateName,
//                       DistrictName = district.DistrictName,
//                       TalukaName = taluka.TalukaName,
//                   }).TakeLast(10);
//foreach (var student in studentInfo)
//{
//    Console.WriteLine(student.StudentId + " , " + student.StudentName +
//        " , " + student.StandardName + " , " + student.StateName + " , " + student.DistrictName
//        + " , " + student.TalukaName);
//}


//--------------------------------------------------------------------------
//4. Display First 10 students Information using First Assignment

//var studentInfo = (from student in students
//                   join state in States
//                   on student.StateId equals state.StateId
//                   join standard in Standards
//                   on student.StandardID equals standard.StandardID
//                   join district in districts
//                   on student.DistrictId equals district.DistrictId
//                   join taluka in Talukas
//                   on student.TalukaId equals taluka.TalukaId
//                   select new
//                   {
//                       StudentId = student.StudentID,
//                       StudentName = student.StudentName,
//                       StandardName = standard.StandardName,
//                       StateName = state.StateName,
//                       DistrictName = district.DistrictName,
//                       TalukaName = taluka.TalukaName,
//                   }).Take(10);
//foreach (var student in studentInfo)
//{
//    Console.WriteLine(student.StudentId + " , " + student.StudentName +
//        " , " + student.StandardName + " , " + student.StateName + " , " + student.DistrictName
//        + " , " + student.TalukaName);
//}


//-------------------------------------------------------
//3.Display district Name where min number of students came from

//var student = (from stud in students
//               join state in States
//               on stud.StateId equals state.StateId
//               select state.StateName).Min();
//foreach (var item in student)
//{
//    Console.Write(item);
//}


//------------------------------------------------------------------
//2.Display State Name where max number of student came from

//var student = (from stud in students
//               join state in States
//               on stud.StateId equals state.StateId
//               select state.StateName).Max();
//foreach (var item in student)
//{
//    Console.Write(item);
//}

//--------------------------------------------------------------
//var state = students.GroupBy(x => x.StateId);

//foreach (var student in state)
//{

//    Console.WriteLine(student.Key);
//    Console.WriteLine("-----------------------------------------------");
//    var count = student.Count();


//    Console.WriteLine("Count of Student " + count);
//}


//foreach (var s in student)
//{
//    var count = student.Max(x => x.StudentID);
//    Console.WriteLine("Maximun count : " + count);
//}


//---------------------------------------------------------------

//1.Display the Count of students TalukaWise

//var taluka = students.GroupBy(x => x.TalukaId);

//foreach (var student in taluka)
//{
//    //int count = 0;
//    Console.WriteLine(student.Key);
//    Console.WriteLine("-----------------------------------------------");
//    var count = student.Count();
//    //foreach (var data in student)
//    //{
//    //    count++;
//    //}
//    Console.WriteLine("Count of Student " + count);
//}

//------------------------------------------------------------------
//Show student info where standard is d

//var student = from stud in students
//              join standard in Standards
//              on stud.StandardID equals standard.StandardID
//              where standard.StandardName.Contains("D")
//              select new
//              {
//                  stud.StudentName
//              };
//foreach (var s in student)
//{
//    Console.WriteLine(s.StudentName);
//}

//-------------------------------------------------------
//Show Student Info where student name ends with 'z'

//var student = from s in students
//              where s.StudentName.EndsWith("z")
//              select s;

//foreach (var s in student)
//{
//    Console.WriteLine(s.StudentName);
//}


//------------------------------------------------------------------

//Using groupjoin
//var groupJoin = from taluka in Talukas
//                join student in students
//                on taluka.TalukaId equals student.TalukaId
//                into studentGroup
//                select new
//                {
//                    Student = studentGroup,
//                    TalukaName = taluka.TalukaName
//                };
//foreach (var group in groupJoin)
//{
//    Console.WriteLine("Taluka Name :" + group.TalukaName);

//}

//------------------------------------------------------------------

//Using group by
//var taluka = students.GroupBy(x => x.TalukaId);

//foreach (var student in taluka)
//{
//    Console.WriteLine(student.Key);
//    Console.WriteLine("-----------------------------------------------");
//    foreach (var data in student)
//    {
//        Console.WriteLine(data.StudentID + " , " +data.StudentName );
//    }
//    Console.WriteLine();
//}

//--------------------------------------------------------------------------------

//IEnumerable<Student> DisplayStudent()
void DisplayStudent()
{

    List<Student> students = new List<Student>();
    List<State> states = new List<State>();
    List<Standard> standards = new List<Standard>();
    List<District> districts = new List<District>();
    List<Taluka> talukas = new List<Taluka>();

    Random rand = new Random();

    var studentInfo = from student in students
                      join state in States
                      on student.StateId equals state.StateId
                      join standard in Standards
                      on student.StandardID equals standard.StandardID
                      join district in districts
                      on student.DistrictId equals district.DistrictId
                      join taluka in talukas
                      on student.TalukaId equals taluka.TalukaId
                      select new
                      {
                          StudentId = student.StudentID,
                          StudentName = student.StudentName,
                          StandardName = standard.StandardName,
                          StateName = state.StateName,
                          DistrictName = district.DistrictName,
                          TalukaName = taluka.TalukaName,
                      };

    //return studentInfo;
    //foreach(var student in innerJoin3)
    //{
    //    Console.WriteLine(student.StudentName +","+student.StandardName);
    //}
}

void TalukaWiseDisplay()
{
    List<Taluka> talukas = new List<Taluka>();
    List<Student> students = new List<Student>();
    var taluka = talukas.GroupBy(x => x.TalukaId);
    foreach (var student in taluka)
    {
        foreach (var data in student)
        {
            Console.WriteLine(data);
        }
        Console.WriteLine();
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



