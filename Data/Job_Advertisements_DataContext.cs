using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Job_Advertisements_Final_Project.Models;

namespace Job_Advertisements_Final_Project.Models
{
    //Links  the database and the model classes 
    public class Job_Advertisements_DataContext : DbContext
    {
        public Job_Advertisements_DataContext (DbContextOptions<Job_Advertisements_DataContext> options)
            : base(options)
        {
        }

        public DbSet<Job_Advertisements_Final_Project.Models.Advertisement> Advertisement { get; set; }

        public DbSet<Job_Advertisements_Final_Project.Models.Applicant> Applicant { get; set; }

        public DbSet<Job_Advertisements_Final_Project.Models.Application> Application { get; set; }
    }
}
