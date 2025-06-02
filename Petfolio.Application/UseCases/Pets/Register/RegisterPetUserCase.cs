using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.Register;

public class RegisterPetUserCase
{
    public ResponseRegisterPetJson Execute(RequestPetJson register)
    {
        return new ResponseRegisterPetJson
        {
            Id = 7,
            Name = register.Name
        };
    }
    
}