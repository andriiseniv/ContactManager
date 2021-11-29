using CsvHelper;
using CSVReader.Context;
using CSVReader.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CSVReader.Controllers
{
    public class CSVController : Controller
    {
        private readonly CSVContext _context;

        public CSVController(CSVContext context)
        {
            _context = context;
        }

        public IActionResult Index(string type, int[]contacts)
        {
            if (type == "AName")
            {
                return View(_context.CSVs.AsEnumerable().OrderBy(x => x.CSVID).Where(j => contacts.Contains(j.CSVID)).ToList());
            }
            else if (type == "DName")
            {
                return View(_context.CSVs.AsEnumerable().OrderByDescending(x => x.CSVID).Where(j => contacts.Contains(j.CSVID)).ToList());
            }

            if (type == "ABirth")
            {
                return View(_context.CSVs.AsEnumerable().OrderBy(x => x.DateOfBirth).Where(j => contacts.Contains(j.CSVID)).ToList());
            }
            else if (type == "DBirth")
            {
                return View(_context.CSVs.AsEnumerable().OrderByDescending(x => x.DateOfBirth).Where(j => contacts.Contains(j.CSVID)).ToList());
            }

            if (type == "ASalary")
            {
                return View(_context.CSVs.AsEnumerable().OrderBy(x => x.Salary).Where(j => contacts.Contains(j.CSVID)).ToList());
            }
            else if (type == "DSalary")
            {
                return View(_context.CSVs.AsEnumerable().OrderByDescending(x => x.Salary).Where(j => contacts.Contains(j.CSVID)).ToList());
            }

            return View("Index", _context.CSVs.OrderByDescending(x => x.CSVID).ToList());
        }

        public IActionResult Import(IFormFile file)
        {

            if (file != null)
            {
                List<CSVModel> csvModel = new List<CSVModel>();
                using (var reader = new StreamReader(file.OpenReadStream()))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Read();
                    csv.ReadHeader();
                    while (csv.Read())
                    {
                        var record = new CSVModel
                        {
                            Name = csv.GetField<string>("Name"),
                            DateOfBirth = csv.GetField<DateTime>("DateOfBirth"),
                            Married = csv.GetField<bool>("Married"),
                            Phone = csv.GetField<string>("Phone"),
                            Salary = csv.GetField<int>("Salary")
                        };
                        csvModel.Add(record);
                    }
                }
                return View(csvModel);
            }
            else return RedirectToAction(nameof(Index));
        }

        public IActionResult Write(string[] name, DateTime[] dateOfBirth, bool[] married, string[] phone, double[] salary)
        {
            for (int i = 0; i < name.Length; i++)
            {
                var record = new CSVModel
                {
                    Name = name[i].ToString(),
                    DateOfBirth = dateOfBirth[i],
                    Married = (bool)married[i],
                    Phone = phone[i],
                    Salary = salary[i]
                };
                _context.CSVs.Add(record);
            }
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = _context.CSVs.Find(id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }
        [HttpPost]
        public IActionResult Edit(int id, [Bind("CSVID,Name,DateOfBirth,Married,Phone,Salary")] CSVModel item)
        {
           
            if (id != item.CSVID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(item);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(item);
            }
        }

        public IActionResult ShowFindResults(String FindName,
                                             int FindBirthFrom,
                                             int FindMarried,
                                             String FindPhone,
                                             Int32 FindSalaryFrom, Int32 FindSalaryTo)
        {
            var criteria = _context.CSVs.OrderByDescending(x => x.CSVID).ToList();

            if (FindName != null)
            {
                criteria = _context.CSVs.Where(j => j.Name.Contains(FindName)).ToList();
            }

            if (FindBirthFrom != 0)
            {
                criteria = criteria.Where(j => j.DateOfBirth.Year >= FindBirthFrom).ToList();
            }

            if (FindMarried > 0)
            {
                criteria = criteria.Where(j => j.Married == true).ToList();
            }
            else if (FindMarried < 0)
            {
                criteria = criteria.Where(j => j.Married == false).ToList();
            }

            if (FindPhone != null)
            {
                criteria = criteria.Where(j => j.Phone.Contains(FindPhone)).ToList();
            }

            if (FindSalaryFrom != 0)
            {
                criteria = criteria.Where(j => j.Salary >= FindSalaryFrom).ToList();
            }
            if (FindSalaryTo != 0)
            {
                criteria = criteria.Where(j => j.Salary <= FindSalaryTo).ToList();
            }

            return View("Index", criteria.OrderByDescending(x => x.CSVID).ToList());
        }


        [HttpPost, ActionName("Delete")]    
        public IActionResult Delete(int id)
        {
            var car = _context.CSVs.Find(id);
            _context.CSVs.Remove(car);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

    }
}

