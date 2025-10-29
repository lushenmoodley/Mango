using Mango.Services.CouponAPI.Models.Dto;
using Mango.Web.Models.Dto;

namespace Mango.Web.Service.IService
{
    public interface ICouponService
    {
        Task<ResponseDto?> GetCouponAsync(string couponCode);
        Task<ResponseDto?> GetAllCouponsAsync();
        Task<ResponseDto?> GetCouponByIdAsync(int id);
        Task<ResponseDto?> CreateCouponsAsync(CouponDTO couponDTO);
        Task<ResponseDto?> UpdateCouponsAsync(CouponDTO couponDTO);
        Task<ResponseDto?> DeleteCouponsAsync(int Id);
    }
}
