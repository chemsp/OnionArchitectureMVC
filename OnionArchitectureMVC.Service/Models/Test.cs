using OnionArchitectureMVC.Data.Data;
using OnionArchitectureMVC.Repo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureMVC.Service.Models
{
    public class Test
    {
        Truck _vehicle;
        public Test(Truck veh)
        {
            _vehicle = veh

        }

    }

    
    public class Truck : IVehicle
    {
        public void EngineStart()
        {
            Console.WriteLine("Truck start");
        }
    }


    public class Motorbike : IVehicle
    {
        public void EngineStart()
        {
            Console.WriteLine("MotorBike start");
        }
    }




    public interface IVehicle
    {
        void EngineStart();
    }

}
