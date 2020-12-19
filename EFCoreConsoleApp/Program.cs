using EFCoreConsoleApp.Entities;
using LinqKit;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EFCoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {         
            var _context = new SchoolContext();

            var result = _context.Students
                   .Include(a => a.Course)
                   .AsNoTracking()
                   .AsExpandable();

            //result = result.Where(a => a.Name.Contains("Kumar"));
            //result = result.Where(a => a.Name.Contains("Shivam"));

            //Create the builder
            var predicate = PredicateBuilder.New<Student>();

            predicate = predicate.Or(p => p.Name.Contains("Kumar"));
            predicate = predicate.Or(p => p.Name.Contains("Shivam"));

            result = result.Where(predicate);

            var a = result.ToList();

            foreach (var item in result.AsEnumerable())
            {

            }
        }
    }
}
