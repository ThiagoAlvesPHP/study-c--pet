using Petfolio.Communication.Enums;

namespace Petfolio.Communication.Responses;

public class ResponseAllPetJson
{
    public List<ResponseShowPetJson> Pets { get; set; } = [];
}