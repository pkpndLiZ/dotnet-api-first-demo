using System;
namespace demoAPI
{
	public class AutoMaperProfile : Profile
	{
		public AutoMaperProfile()
		{
			CreateMap<Character, GetCharacterDto>();
			CreateMap<AddCharacterDto, Character>();
			CreateMap<UpdateCharacterDto, Character>();
		}
	}
}

