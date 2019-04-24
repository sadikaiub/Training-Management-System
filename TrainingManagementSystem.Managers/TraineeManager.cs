using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagementSystem.Managers.Base;
using TrainingManagementSystem.Managers.Contracts;
using TrainingManagementSystem.Models;
using TrainingManagementSystem.Repositories.Contracts;

namespace TrainingManagementSystem.Managers
{
   public class TraineeManager:BaseManager<Trainee>,ITraineeManager
   {
       private ITraineeRepository _traineeRepository;

       public TraineeManager(ITraineeRepository traineeRepository):base(traineeRepository)
       {
           _traineeRepository = traineeRepository;
       }
   }
}
