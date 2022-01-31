using Microsoft.AspNetCore.Authorization;

namespace BlazorTestServerAppProject.Authorization
{
    public class EmailRequirement:IAuthorizationRequirement
    {
        public string EmailSuffix { get;  }
        public EmailRequirement(string EmailSuffix)
        {
            this.EmailSuffix = EmailSuffix;
        }
    }
}
