using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2b
{
    interface IModel
    {
        long ID { get; set; }
    }

    public class Voertuig : IModel
    {
        public long ID { get; set; }
    }

    public class Auto : Voertuig
    {

    }

    class AutoRepository
    {
        private List<Auto> Autos { get; set; }

        public AutoRepository()
        {

        }

        public AutoRepository(List<Auto> autos)
        {
            Autos = autos;
        }

        public List<Auto> GetAll()
        {
            return Autos;
        }
    }

    public class Boot : Voertuig
    {

    }

    class BootRepository
    {
        private List<Boot> Boten { get; set; }

        public BootRepository()
        {

        }

        public BootRepository(List<Boot> boten)
        {
            Boten = boten;
        }

        public List<Boot> GetAll()
        {
            return Boten;
        }
    }

    class GenericRepository<T> where T : IModel
    {
        private List<T> Lijst { get; set; }

        public GenericRepository()
        {
            
        }

        public GenericRepository(List<T> lijst)
        {
            Lijst = lijst;
        }

        public List<T> GetAll()
        {
            return Lijst;
        }

        public T FindById(long id)
        {
            //Foreach door de lijst
            foreach(var item  in Lijst)
            {
                if(item.ID == id)
                {
                    return item;
                }
            }
            throw new Exception($"Element niet gevonden met id: {id}");
        }
    }

    class Controller<T> where T : IModel
    {
        public GenericRepository<T> Repo { get; set; }

        public Controller(GenericRepository<T> repo)
        {
            Repo = repo;
        }

        public List<T> GetAll()
        {
            return Repo.GetAll();
        }
    }
}
