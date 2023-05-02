using dotnet1.DTO;

namespace dotnet1.Service
{
    public interface IDeleteQuotationMemberBankDetailRepository
    {
        Task<bool> DeleteQuotationMemberBankDetailAsync(DeleteQuotationMemberBankDetailModel model);
    }
}