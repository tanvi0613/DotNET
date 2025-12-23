// using System;
// namespace OopsSessions
// {
//     public class Practice
//     {
//         private int id;
//         public int Id{
//             get {return id}
//             set;}
//         private string name;
//         public string? Name{get; set;}
//         private int rank;
//         public string? Rank{get; set;}

//         public string? Errors{get; set;}

//         public Practice(int id, string name, string rank)
//         {
//             if(id > 0)
//             {
                
//                 if (id)
//                 {
//                     Errors += "Validation Error: ID should contain only numbers \n";
//                 }
//             }
//             else if (id < 0)
//             {
//                 Errors += "Validation Error: ID cannot be less than zero \n";
//             }
//             this.Id = id;

//             if(name != null)
//             {
//                 if (name.Contains("0") || name.Contains("1") || name.Contains("2") || name.Contains("3") || name.Contains("4") || name.Contains("5") || name.Contains("6") || name.Contains("7") || name.Contains("8") || name.Contains("9"))
//                 {
//                     Errors += "Validation Error: Name cannot be digits \n";
//                 }
//             }
//             else if(name == string.Empty || name == null)
//             {
//                 Errors += "Validation Error: Name cannot be null or empty \n";
//             }
//             this.Name = name;

//             if(name != null)
//             {
//                 if (name.Contains("0") || name.Contains("1") || name.Contains("2") || name.Contains("3") || name.Contains("4") || name.Contains("5") || name.Contains("6") || name.Contains("7") || name.Contains("8") || name.Contains("9"))
//                 {
//                     Errors += "Validation Error: Rank cannot be digits \n";
//                 }
//             }
//             else if(name == string.Empty || name == null)
//             {
//                 Errors += "Validation Error: Rank cannot be null or empty \n";
//             }
//             this.Name = name;
//         }

//         public string DisplayErrors()
//         {
//             return Errors;
//         }
//         #region Member function
//         // public int Num1 {set; get;}
//         // public int Num2 {set; get;}
//         // public int Result {get;}

//         // /// <summary>
//         // /// Constructor to initialize the variables
//         // /// </summary>
//         // /// <param name="num1">Input first number</param>
//         // /// <param name="num2">Input second number</param>
//         // public Practice(int num1, int num2)
//         // {
//         //     Num1 = num1;
//         //     Num2 = num2;
//         //     //Result only has get bit still can set because this is an exception that we can set value for get only in constructor
//         //     Result = num1 + num2;
//         //     //Console.WriteLine(Result);
//         // }
//         #endregion
//     }
// }