using System.Collections;
using S7Collections.Models;

namespace S7Collections.Collections;

public class HashTables
{
    public static void HashTablesMain()
    {
        Hashtable studentsTable = new Hashtable(); // Non-generic

        Student student1 = new Student(1, "Maria", 98); 
        Student student2 = new Student(2, "Jason", 76);

        studentsTable.Add(student1.Id, student1);
        studentsTable.Add(student2.Id, student2);

        Student storedStudent1 =  (Student)studentsTable[student1.Id]; // Casting required since Hashtable is non-generic

        foreach(DictionaryEntry entry in studentsTable){ //DictionaryEntry special class
            Student tmp = (Student)entry.Value; //Value special keyword
            Console.WriteLine(
                "Student Data\tID: {0}\tName: {1}\tGPA: {2}",
                tmp.Id, tmp.Name, tmp.GPA
            );
        }

        foreach(Student student in studentsTable.Values){
            // do stuff
            Console.WriteLine(
                "Student Data\tID: {0}\tName: {1}\tGPA: {2}",
                student.Id, student.Name, student.GPA
            );
        }
    }
}