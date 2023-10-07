using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;

        public InMemoryCarDal() 
        {
            _cars = new List<Car>()
            {
                new Car{Id = 1,BrandId=1,ColorId=1,DailyPrice=2000,ModelYear=2010,Description="Fluence"},
                new Car{Id = 2,BrandId=2,ColorId=2,DailyPrice=3000,ModelYear=2015,Description="Transporter"},

            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car DeleteId;
            DeleteId = _cars.SingleOrDefault(p=>p.Id== car.Id);
            _cars.Remove(DeleteId);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Carid)
        {
            return _cars.Where(p=>p.Id==Carid).ToList();
        }

        public void Update(Car car)
        {
            Car UpdateId;
            UpdateId = _cars.SingleOrDefault(p=>p.Id == car.Id);
          
            car.BrandId = UpdateId.BrandId;
            car.Description = UpdateId.Description;
        }
    }
}
