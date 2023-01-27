using ConsoleApp11;
using ConsoleApp11.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Models
{
    public class ZalManager : ICrudService,ICrudPrint
    {
        public void Add(Entity entity)
        {
            int[,] arr = new int[10, 10];
            for (int row = 0; row < arr.Length; row++)
            {
                for (int column = 0; column < length; column++)
                {

                }
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Entity Get()
        {
            throw new NotImplementedException();
        }

        public Entity[] GetAll()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}
