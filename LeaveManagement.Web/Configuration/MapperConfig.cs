using AutoMapper;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using Microsoft.Build.Framework.Profiler;

namespace LeaveManagement.Web.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
