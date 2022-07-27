using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace LIK.Application.Common.Mappings
{
  public  interface IMapWith<T>
    {
        // реализация по умолчанию
        // метод создает конфигурацию из исходного типа Т в тип назначения
        void Mapping(Profile profile) =>
            profile.CreateMap(typeof(T), GetType());
    }
}
