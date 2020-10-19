using Abp.Application.Services;
using Lxk.Ucenter.Application.Authorization.Accounts.Dto;
using System.Threading.Tasks;

namespace Lxk.Ucenter.Application.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
