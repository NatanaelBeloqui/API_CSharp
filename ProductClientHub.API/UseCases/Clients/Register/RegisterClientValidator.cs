using FluentValidation;
using ProductClientHub.Communication.Requests;

namespace ProductClientHub.API.UseCases.Clients.Register;

public class RegisterClientValidator : AbstractValidator <RequestClientJson>
{
    public RegisterClientValidator()
    {
        RuleFor(client => client.Name).NotEmpty();
    }
}
