using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetAll;

public class GetAllPetsUseCase
{
    public ResponseAllPetJson Execute()
    {
        return new ResponseAllPetJson
        {   
            Pets = new List<ResponseShowPetJson>
            {
                new ResponseShowPetJson
                {
                    Id = 1,
                    Name = "John",
                    Type = Communication.Enums.PetType.Cat
                }
            }
        };
    }
}