using Pet.Social.Network.Shared.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace Pet.Social.Network.Infrastructure.Auth.Permissions;

public class MustHavePermissionAttribute : AuthorizeAttribute
{
    public MustHavePermissionAttribute(string action, string resource) =>
        Policy = FSHPermission.NameFor(action, resource);
}