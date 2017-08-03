﻿using AutoMapper;
using GestionTallerDeMotos.Dtos;
using GestionTallerDeMotos.Models.ModelosDeDominio;

namespace GestionTallerDeMotos.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Dominio a DTO
            Mapper.CreateMap<Cliente, Cliente>()
                .ForMember(c => c.FechaDeIngreso, opt => opt.Ignore());
            Mapper.CreateMap<Cliente, ClienteDto>();
            Mapper.CreateMap<Personeria, PersoneriaDto>();
            Mapper.CreateMap<TipoDocumento, TipoDocumentoDto>();
            Mapper.CreateMap<Marca, Marca>();
            Mapper.CreateMap<Marca, MarcaDto>();
            Mapper.CreateMap<Modelo, ModeloDto>();
            Mapper.CreateMap<Combustible, Combustible>();
            Mapper.CreateMap<Combustible, CombustibleDto>();
            Mapper.CreateMap<Aseguradora, Aseguradora>();
            Mapper.CreateMap<Aseguradora, AseguradoraDto>();
            Mapper.CreateMap<Vehiculo, Vehiculo>()
                .ForMember(v => v.FechaDeIngreso, opt => opt.Ignore());
            Mapper.CreateMap<Vehiculo, VehiculoDto>();

            //DTO a Dominio
            Mapper.CreateMap<MarcaDto, Marca>();
            Mapper.CreateMap<ModeloDto, Modelo>();
            Mapper.CreateMap<CombustibleDto, Combustible>();
            Mapper.CreateMap<AseguradoraDto, Aseguradora>();
            Mapper.CreateMap<VehiculoDto, Vehiculo>()
                .ForMember(v => v.FechaDeIngreso, opt => opt.Ignore());
        }
    }
}