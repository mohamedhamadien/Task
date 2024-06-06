using AutoMapper;
using Task.Models;
using Task.ViewModels;

namespace Task.Mapper
{
    public class Mapper : Profile
    {
        public Mapper() 
        {
            CreateMap<Product, ProductViewModel>().ReverseMap();
        }
    }
}
