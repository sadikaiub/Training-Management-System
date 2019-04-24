using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagementSystem.Managers.Base;
using TrainingManagementSystem.Managers.Contracts;
using TrainingManagementSystem.Models;
using TrainingManagementSystem.Repositories.Contracts;

namespace TrainingManagementSystem.Managers
{
    public class BatchManager : BaseManager<Batch>, IBatchManager
    {
        private IBatchRepository _batchRepository;

        public BatchManager(IBatchRepository batchRepository) : base(batchRepository)
        {
            _batchRepository = batchRepository;
        }
    }
}
