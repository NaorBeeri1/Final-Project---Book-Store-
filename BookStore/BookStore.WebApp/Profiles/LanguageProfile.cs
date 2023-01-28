using System;
using AutoMapper;
using BookStore.WebApp.Models;
using BookStore.WebApp.ViewModels;

namespace BookStore.WebApp.Profiles
{
    public class LanguageProfile : Profile
    {
        public LanguageProfile()
        {
            CreateMap<Language, LanguageViewModel>();
        }
    }
}