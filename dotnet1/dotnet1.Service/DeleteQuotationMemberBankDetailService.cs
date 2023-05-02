namespace dotnet1.Service
{
    using dotnet1.DataAccess;
    using dotnet1.DTO;

    public class DeleteQuotationMemberBankDetailService : IDeleteQuotationMemberBankDetailService
    {
        private readonly IDeleteQuotationMemberBankDetailRepository _deleteQuotationMemberBankDetailRepository;

        public DeleteQuotationMemberBankDetailService(IDeleteQuotationMemberBankDetailRepository deleteQuotationMemberBankDetailRepository)
        {
            _deleteQuotationMemberBankDetailRepository = deleteQuotationMemberBankDetailRepository;
        }

        public async Task<bool> DeleteQuotationMemberBankDetailAsync(DeleteQuotationMemberBankDetailModel model)
        {
            return await _deleteQuotationMemberBankDetailRepository.DeleteQuotationMemberBankDetailAsync(model);
        }
    }
}