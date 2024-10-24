using System;
using AutoMapper;
using Domain;

namespace Application
{
    public partial class LogsProfile
        : AutoMapper.Profile
    {
        public LogsProfile()
        {
            CreateMap<Logs, CreateLogsCommand>().ReverseMap();;

            CreateMap<Logs, CreateLogsViewModel>().ReverseMap();;

            CreateMap<Logs, UpdateLogsCommand>().ReverseMap();;

            CreateMap<Logs, UpdateLogsViewModel>().ReverseMap();;

            CreateMap<Logs, DeleteLogsCommand>().ReverseMap();;

            CreateMap<Logs, DeleteLogsViewModel>().ReverseMap();;

            CreateMap<Logs, ReadLogsQuery>().ReverseMap();;

            CreateMap<Logs, ReadLogsViewModel>().ReverseMap();;

        }

    }
}
