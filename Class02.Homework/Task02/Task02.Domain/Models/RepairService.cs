using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task02.Domain.Interfaces;

namespace Task02.Domain.Models
{
    public class RepairService : IRepairService
    {
        public void CheckVehicle()
        {
            Console.WriteLine("Checking a vehicle for issues.");
        }

        public void FixVehicle()
        {
            Console.WriteLine("Done! Your vehicle is fixed.");
        }
    }
}
