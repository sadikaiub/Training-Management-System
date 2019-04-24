using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagementSystem.Managers.Base;
using TrainingManagementSystem.Managers.Contracts;
using TrainingManagementSystem.Models;
using TrainingManagementSystem.Repositories.Contracts;

namespace TrainingManagementSystem.Managers
{
   public class TrainerManager:BaseManager<Trainer>,ITrainerManager
   {
       private ITrainerRepository _trainerRepository;

       public TrainerManager(ITrainerRepository trainerRepository):base(trainerRepository)
       {
           _trainerRepository = trainerRepository;
       }
   }
}
