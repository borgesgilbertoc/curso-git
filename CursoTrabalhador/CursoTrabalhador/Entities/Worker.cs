using System.Collections.Generic;
using CursoTrabalhador.Entities.Enums;

namespace CursoTrabalhador.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker ()
        {
        }

        public Worker(string name, WorkerLevel level, double basesalary, Department department )
        {
            Name = name;
            Level = level;
            BaseSalary = basesalary;
            Department = department;
        }


    }
}
