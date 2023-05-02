using dotnet1.DTO;
namespace dotnet1.Service
{
    public interface IDeleteQuotationMemberBankDetailService
    {
        Task<bool> DeleteQuotationMemberBankDetailAsync(DeleteQuotationMemberBankDetailModel model);
    }
}