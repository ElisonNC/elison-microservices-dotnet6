using GeekShopping.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeekShopping.Web.Services.IServices
{
    public interface ICouponService
    {
        Task<CouponViewModel> GetCoupon(string code, string token);
    }
}
