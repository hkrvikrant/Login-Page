using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace login_page
{
    class Program
    {
        class loginform
        {
            public void create()
            {
                Console.WriteLine("1.phone No     2.Emailid");
                Console.WriteLine("which method do you want to sigup?");
                int met = Convert.ToInt32(Console.ReadLine());
                if (met <= 1)
                {
                    phoneno();
                }
                else
                {
                    gmail();
                }
            }
            public void phoneno()
            {
                Console.WriteLine("Enter Phone NO: ");
                string phoneno = Console.ReadLine();
                Console.Write("Your generated OTP is:");
                   randid();
             //   int otpp = randid();
                Console.WriteLine();
                Console.WriteLine("Enter OTP:");
                int otp = Convert.ToInt32(Console.ReadLine());
                if (otp == 123)
                {
                    Console.WriteLine("Signup Sucessfully");
                }
                else
                {
                    Console.WriteLine("You are Enterd Wrong OTP");
                }
            }
            
            public void gmail()
            {
                Console.WriteLine("Email Id:");
                string gmaile = Console.ReadLine();
                Console.Write("Your Generated OTP is:");
                randid();
                Console.WriteLine();
                Console.Write("Enter OTP:");
                int otp = Convert.ToInt32(Console.ReadLine());
             //   int otpp = randid();
                  if (otp == 123)
                {
                    Console.WriteLine("Signup Sucessfully");
               }
                else
                {
                   Console.WriteLine("You are Enterd Wrong OTP");
              }
            }

              public int randid()
            {
                Random rnd = new Random();
                for (int i = 1; i < 5; i++)
                {
                    int value = rnd.Next(0, 9);
                    Console.Write(value);
                    return value;
                }
                }
            }

            static void Main(string[] args)
            {
                loginform log = new loginform();
                log.create();
               // log.randid();
                //log.phoneno()

                Console.ReadLine();
            }
        }
    }
