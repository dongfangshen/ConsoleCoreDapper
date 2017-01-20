using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleCoreDapper.Model;
namespace ConsoleCoreDapper.AutoMapper
{
    public class SourceProfile:Profile
    {
        public SourceProfile()
        {
            //Source->Destination
            CreateMap<Dept, DestinDept>();

            //Source->Destination2
            //CreateMap<Source, Destination2>().ForMember(d => d.AnotherValue2, opt =>
            //{
            //    opt.MapFrom(s => s.AnotherValue);
            //});
        }
    }
}
