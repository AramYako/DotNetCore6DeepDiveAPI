﻿using AutoMapper;
using CourseLibrary.API.Entities;
using CourseLibrary.API.Models;

namespace CourseLibrary.API.Profiles;
public class CoursesProfile : Profile
{
    public CoursesProfile()
    {
        CreateMap<Entities.Course, Models.CourseDto>();
        CreateMap<Models.CourseForCreationDto, Entities.Course>();
        CreateMap<CourseForUpdateDto, Course>().ReverseMap();
    }
}