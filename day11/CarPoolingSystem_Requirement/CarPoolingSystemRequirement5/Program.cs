﻿
using Requirement_5;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingSystemRequirement5
{
    internal class Program

    {

        static void Main(string[] args)

        {

            List<Member> list = new List<Member>();

            for (int i = 0; i < 5; i++)

            {

                Console.WriteLine("enter details");

                string input = Console.ReadLine();

                string[] arr = input.Split(',');

                Member member = new Member(arr[0], arr[1], arr[2]);

                try

                {

                    member.checking(arr[2]);

                }

                catch (InvalidEmailException e)

                {

                    e.inform();

                }

                list.Add(member);

                foreach (Member m in list)

                {

                    Console.WriteLine(m.ToString());

                }

            }

        }

    }

}

























































































