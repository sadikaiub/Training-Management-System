using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TrainingManagementSystem.Models;
using TrainingManagementSystem.Repositories.Base;
using TrainingManagementSystem.Repositories.Contracts;

namespace TrainingManagementSystem.Repositories
{
    public class BatchRepository:BaseRepository<Batch>,IBatchRepository
    {
        public BatchRepository(DbContext db):base(db)
        {
            
        }
    }
}
