using Microsoft.AspNetCore.Authorization;

namespace BlazorTestServerAppProject.Authorization
{
    public class EmailAuthHandler : AuthorizationHandler<EmailRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, EmailRequirement requirement)
        {
            if (context.User.Identity.Name.EndsWith(requirement.EmailSuffix))
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
}
