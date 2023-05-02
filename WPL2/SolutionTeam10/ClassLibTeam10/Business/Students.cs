﻿using ClassLibTeam10.Business.Entities;
using ClassLibTeam10.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibTeam10.Business
{
    public static class Students
    {
        public static IEnumerable<Student> List() 
        {
            return StudentRepository.StudentList; 
        }
        public static void Add(string firstName, string lastName)
        {
            StudentRepository.Add(firstName, lastName);
        }
    }
}
