using Mango.Services.CouponAPI.Models.Dto;
using Mango.Web.Models.Dto;
using Mango.Web.Service.IService;
using Mango.Web.Utility;

namespace Mango.Web.Service
{
    public class CouponService:ICouponService
    {
        private readonly IBaseService _baseService;

        public CouponService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<ResponseDto?> GetCouponAsync(string couponCode)
        {
            return await _baseService.SendAsync(new Models.RequestDto()
            {
                ApiType = SD.APIType.GET,
                Url = SD.CouponAPIBase + "/api/coupon/GetByCode/"+couponCode
            });
        }

        public async Task<ResponseDto?> GetAllCouponsAsync()
        {
            return await _baseService.SendAsync(new Models.RequestDto()
            {
                ApiType=SD.APIType.GET,
                Url=SD.CouponAPIBase+"/api/coupon"
            });
        }

        public async Task<ResponseDto?> GetCouponByIdAsync(int id)
        {
            return await _baseService.SendAsync(new Models.RequestDto()
            {
                ApiType = SD.APIType.GET,
                Url = SD.CouponAPIBase + "/api/coupon/" + id
            });
        }

        public async Task<ResponseDto?> CreateCouponsAsync(CouponDTO? couponDTO)
        {
            return await _baseService.SendAsync(new Models.RequestDto()
            {
                ApiType = SD.APIType.POST,
                Data= couponDTO,
                Url = SD.CouponAPIBase + "/api/coupon"
            });
        }

        public async Task<ResponseDto?> UpdateCouponsAsync(CouponDTO couponDTO)
        {

            return await _baseService.SendAsync(new Models.RequestDto()
            {
                ApiType = SD.APIType.PUT,
                Data = couponDTO,
                Url = SD.CouponAPIBase + "/api/coupon"
            });
        }

        public async Task<ResponseDto?> DeleteCouponsAsync(int id)
        {
            return await _baseService.SendAsync(new Models.RequestDto()
            {
                ApiType = SD.APIType.DELETE,
                Url = SD.CouponAPIBase + "/api/coupon/" + id
            });
        }


    }
}
