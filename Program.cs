using System;

namespace Dependency_Inversion_principle
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    //public class BusinessLogiclayer
    //{
    //    private readonly DataAccessLayer DAL;  
    //    public BusinessLogiclayer()
    //    {
    //        DAL = new DataAccessLayer();  //Tighlt coupled and Dependent
    //    }
    //    public void Save (Object Details)
    //    {
    //        DAL.Save(Details);
    //    }
    //}
    //public class DataAccessLayer
    //{
    //    public void Save(Object Details)
    //    {
    //       //DB Operations 
    //    }
    //}



    public class BusinessLogiclayer
    {
        private readonly IRepositoryLayer DAL;
        public BusinessLogiclayer(IRepositoryLayer repositoryLayer) //Business layer Refers IRepositoryLayer Interface
        {
            DAL = repositoryLayer; 
        }
        public void Save(Object Details)
        {
            DAL.Save(Details);
        }
    }
    public interface IRepositoryLayer
    {
        void Save(Object Details);
    }
    public class DataAccessLayer: IRepositoryLayer //DAL Layer inherits IRepositoryLayer Interface
    {
        public void Save(Object Details)
        {
            //DB Operations 
        }
    }
}
 