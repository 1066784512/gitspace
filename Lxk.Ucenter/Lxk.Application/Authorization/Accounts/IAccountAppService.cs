using Abp.Application.Services;
using Lxk.Ucenter.Application.Authorization.Accounts.Dto;
using System.Threading.Tasks;

namespace Lxk.Ucenter.Application.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        /// <summary>
        /// 租户
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
