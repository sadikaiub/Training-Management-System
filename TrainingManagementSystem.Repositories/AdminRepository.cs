using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TrainingManagementSystem.Models;
using TrainingManagementSystem.Repositories.Base;
using TrainingManagementSystem.Repositories.Contracts;

namespace TrainingManagementSystem.Repositories
{
    public class AdminRepository:BaseRepository<Admin>,IAdminRepository
    {
        public AdminRepository(DbContext db):base(db)
        {
            
        }
    }
}
