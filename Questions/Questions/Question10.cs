using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class AuditEvent
    {
        public string Data = "AuditEventData";

        public override string ToString()
        {
            return $"ToString is overriden to share data {Data}";
        }
    }
    public class Question10
    {
        public static void Runner()
        {
            object[] arr = { 10, 11.4m, "string data", new DateOnly(), new AuditEvent()};

            foreach(object obj in arr)
            {
                if(obj is int)
                {
                    int data = (int)obj;
                    Type type = obj.GetType();
                    Console.WriteLine($"Data is {data} and type is {type.Name}");
                }else if(obj is decimal)
                {
                    decimal data = (decimal)obj;
                    Type type = obj.GetType();
                    Console.WriteLine($"Data is {data} and type is {type.Name}");
                }else if(obj is string)
                {
                    string data = (string)obj;
                    Type type = obj.GetType();
                    Console.WriteLine($"Data is {data} and type is {type.Name}");
                }else if(obj is DateOnly)
                {
                    DateOnly data = (DateOnly)obj;
                    Type type = obj.GetType();
                    Console.WriteLine($"Data is {data} and type is {type.Name}");
                }else if(obj is AuditEvent)
                {
                    AuditEvent data = obj as AuditEvent;
                    Type type = obj.GetType();
                    Console.WriteLine($"Data is {data} and type is {type.Name}");
                    Console.WriteLine(data.ToString());
                }
            }
        }
    }
}

//Output
/*
 Data is 10 and type is Int32
Data is 11.4 and type is Decimal 
Data is string data and type is String
Data is 01-01-0001 and type is DateOnly 
Data is ToString is overriden to share data AuditEventData and type is AuditEvent
ToString is overriden to share data AuditEventData  
*/