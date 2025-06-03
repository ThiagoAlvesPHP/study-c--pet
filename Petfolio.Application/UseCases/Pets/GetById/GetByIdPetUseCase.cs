using Petfolio.Communication.Enums;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetAll;

public class GetByIdPetUseCase
{
    public ResponseGetByIdJson Execute(int id)
    {
        return new ResponseGetByIdJson
        {   
            Id = id,
            Name = $"Pet #{id}",
            Birthday = new DateTime(year: 2023, month: 1, day: 1),
            Type = PetType.Cat
        };
    }
}