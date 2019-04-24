using System;
using System.Collections.Generic;
using System.Text;
using TrainingManagementSystem.Managers.Base;
using TrainingManagementSystem.Managers.Contracts;
using TrainingManagementSystem.Models;
using TrainingManagementSystem.Repositories.Contracts;

namespace TrainingManagementSystem.Managers
{
    public class AdminManager: BaseManager<Admin>,IAdminManager
    {
        private IAdminRepository _adminRepository;

        public AdminManager(IAdminRepository adminRepository):base(adminRepository)
        {
            _adminRepository = adminRepository;
        }
    }
}
