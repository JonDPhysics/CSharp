// using System;
// using System.Collections.Generic;
// using System.Text;
// using System.Threading.Tasks;
// using System.ComponentModel.DataAnnotations;

// namespace PassCode.Models
// {
//     public class Generator
//     {
//         public List<char> code = new List<char>();
//         static List<char> addChar(List<char> chars)
//         {
//             for (char abc = 'A'; abc <= 'Z'; abc++)
//             {
//                 chars.Add(abc);
//             }
//             return chars;
//         }
//         static List<char> addNum(List<char> chars)
//         {
//             for (char num = '0'; num <= '9'; num++)
//             {
//                 chars.Add(num);
//             }
//             return chars;
//         }
//         public string generatePasscode(List<char> chars, int length = 14)
//         {
//             StringBuilder pass = new StringBuilder();
//             Random randChar = new Random();
//             int i = 0;
//             while (i < length)
//             {
//                 pass.Append(code[randChar.Next(0, code.Count)]);
//                 i++;
//             }
//             return pass.ToString();

//         }
//     }
// }