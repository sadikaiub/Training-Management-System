using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace TrainingManagementSystem.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public string  Outline { get; set; }
        public int  NumberOfClass { get; set; }
        public List<Trainee> Trainees { get; set; }
        public  List<Trainer> Trainers { get; set; }
        public List<Batch> Batches { get; set; }
        
    }

  
}
