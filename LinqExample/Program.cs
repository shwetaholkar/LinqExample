

//// See https://aka.ms/new-console-template for more information

var States = FakeData.GetState();
var Talukas = FakeData.GetTalukas();
var districts = FakeData.GetDistricts();
var Standards = FakeData.GetStandard();
var students = FakeData.GetStudents();

//10. Display Student Information whose have the same districts and state name

//var studInfo = from s in students
//               join dist in districts
//               on s.DistrictId equals dist.DistrictId
//               join state in States
//               on s.StateId equals state.StateId
//               group s by new
//               {
//                   dist.DistrictName,
//                   state.StateName
//               };
//foreach(var item in studInfo)
//{
//    foreach(var data in item)
//    {
//        Console.WriteLine(data.StudentName + " | " + data.DistrictId + " | " + data.StateId);
//    }
//}


//This is for displaying district name and state name 


//var studData = from s in students
//               join dist in districts
//               on s.DistrictId equals dist.DistrictId
//               join state in States
//               on s.StateId equals state.StateId
//               group s by new { dist.DistrictName, state.StateName };
//foreach (var item in studData)
//{
//    var districtName = item.Key.DistrictName;
//    var stateName = item.Key.StateName;
//    foreach (var Idata in item)
//    {
//        Console.WriteLine(Idata.StudentName + "||" + districtName + " || " + stateName);
//    }
//}


//--------------------------------------------------------------------------
//9. Display unique Student Names

//var studentNames = students.Select(x => x.StudentName).Distinct();
//foreach (var student in studentNames)
//{
//    Console.WriteLine(student);
//}



//--------------------------------------------------------------------------
//8.Display Taluka Information using join


//var talukaInfo = (from student in students
//                   join taluka in Talukas
//                   on student.TalukaId equals taluka.TalukaId
//                   select new
//                   {
//                       StudentId = student.StudentID,
//                       StudentName = student.StudentName,
//                       TalukaId=taluka.TalukaId,
//                       TalukaName = taluka.TalukaName,
//                   });
//foreach (var data in talukaInfo)
//{
//    Console.WriteLine("Student Id : "+data.StudentId + "  | Student Name : " + data.StudentName +"     | Taluka Id :    " + data.TalukaId+ " | Taluka Name : " + data.TalukaName);
//}


//--------------------------------------------------------------------------
//7.Display student Information whose id between 100 and 200

//foreach (var student in students)
//{
//    if (student.StudentID >= 100 && student.StudentID <=200)
//    {
//        Console.WriteLine("Student Id : " + student.StudentID + " | Student Name : " + student.StudentName);
//    }
//}

//Using LINQ 

//var studentNames = students.Select(x => x.StudentID>=100 && x.StudentID <=200);
//foreach (var student in studentNames)
//{
//    Console.WriteLine(student);
//}



//--------------------------------------------------------------------------
//6.Display Student Information By using StudentId from user


//Console.Write("Enter student Id : ");
//var studId = int.Parse(Console.ReadLine());

//foreach (var student in students)
//{
//    if (student.StudentID == studId)
//    {
//        Console.WriteLine("Student Id : "+student.StudentID + " | Student Name : " + student.StudentName );
//    }
//}



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

//This is perfect Solution for que 3

//var data = from stud in students
//           join dist in districts
//           on stud.DistrictId equals dist.DistrictId
//           group dist by dist //here we do group by using Objects 
//            into g
//           select new
//           {
//               DistrictName = g.Key.DistrictName, //here key meance object i.e. dist
//               TotalCount = g.Count()
//           };

//var maxcount = data.Min(s => s.TotalCount);
//var data2 = data.Where(s => s.TotalCount == maxcount);
//Console.WriteLine("District Name");
//foreach (var index in data2)
//{
//    Console.WriteLine(index.DistrictName + "|" + index.TotalCount);
//}

//-----------------------
//This is my solution

//var student = (from stud in students
//               join state in States
//               on stud.StateId equals state.StateId
//               select state.StateName).Min();
//Console.WriteLine(student.Count());
//foreach (var item in student)
//{
//    Console.Write(item);
//}


//------------------------------------------------------------------
//2.Display State Name where max number of student came from

//This is perfect Solution for que 2

//var data = from stud in students
//           join state in States
//           on stud.StateId equals state.StateId
//           group state by state //here we do group by using Objects 
//            into g
//           select new
//           {
//               StateName = g.Key.StateName, //here key meance object i.e. state
//               TotalCount = g.Count()
//           };


//var maxcount = data.Max(s => s.TotalCount);
//var data2 = data.Where(s => s.TotalCount == maxcount);
//Console.WriteLine("State Name");
//foreach (var index in data2)
//{
//    Console.WriteLine(index.StateName + "|" + index.TotalCount);
//}

//-----------------------

//This is another solution for que 2 but it returns only 1 value because of FirstOrDefault() function

//var groupjoin = (from state in States
//                 join student in students
//                 on state.StateId equals student.StateId
//                 into studentGroup
//                 orderby state.StateId
//                 select new
//                 {
//                     students = studentGroup,
//                     StateName = state.StateName,
//                     Count = studentGroup.Count()
//                 }).FirstOrDefault();
//Console.WriteLine(groupjoin.Count);
//Console.WriteLine("StateName:" + groupjoin.StateName);

//-----------------------

//This is my solution 

//var student = (from stud in students
//               join state in States
//               on stud.StateId equals state.StateId
//               select state.StateName).Max();
//Console.WriteLine(student.Count());
//foreach (var item in student)
//{
//    Console.Write(item);
//}

//--------------------------------------------------------------


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









//---------------------------------------------
//Salim teaching Notes 

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



