using CSVReader.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSVReader.Context
{
    public class CSVContext : DbContext
    {
        public CSVContext(DbContextOptions<CSVContext> options) : base(options)
        {

        }
        public DbSet<CSVModel> CSVs { get; set; }       
    }
}
