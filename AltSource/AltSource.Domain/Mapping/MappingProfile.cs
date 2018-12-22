using System;
using AutoMapper;
using AltSource.Entity;

namespace AltSource.Domain.Mapping
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Create automap mapping profiles
        /// </summary>
        public MappingProfile()
        {
            CreateMap<ClothingViewModel, Clothing>();
            CreateMap<ClothingRetailViewModel, ClothingRetail>();
            CreateMap<ClothingVendorViewModel, ClothingVendor>();
            CreateMap<VendorViewModel, Vendor>();


            //CreateMap<AnswerSetViewModel, AnswerSet>()
            //    .ForMember(dest => dest.Date, opts => opts.MapFrom(src => src.DateAnswersSubmitted))
            //    .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.AnswerSetId))
            //    .ForMember(dest => dest.Answers, opts => opts.MapFrom(src => src.AnswerSetAnswers))
            //    .ForMember(dest => dest.IsActive, opts => opts.Ignore());
            //CreateMap<AnswerSet, AnswerSetViewModel>()
            //    .ForMember(dest => dest.DateAnswersSubmitted, opts => opts.MapFrom(src => src.Date))
            //    .ForMember(dest => dest.AnswerSetId, opts => opts.MapFrom(src => src.Id))
            //    .ForMember(dest => dest.AnswerSetAnswers, opts => opts.MapFrom(src => src.Answers));

            CreateMissingTypeMaps = true;
        }

    }





}
