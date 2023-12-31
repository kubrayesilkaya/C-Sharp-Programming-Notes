﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hata_Fırlatma
{
    class Program
    {
        static void parola_kontrol(string password)
        {
            if(password.Length < 6 || password.Length > 10)
            {
                throw new Exception("Parola 6-10 karakter aralığında olmalıdır.");
            }
            if(!password.Any(char.IsDigit))
            {
                throw new Exception("Parola en az bir rakam içermelidir.");
            }
            if(!password.Any(char.IsLetter))
            {
                throw new Exception("Parola en az bir harf içermelidir.");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("parola: ");
            string parola = Console.ReadLine();

            try
            {
                parola_kontrol(parola);
                Console.WriteLine("parola geçerli");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
        }
    }
}
