using dotnet1.DTO;

namespace dotnet1
{
    public class DeleteQuotationMemberBankDetailRepository : IDeleteQuotationMemberBankDetailRepository
    {
        public async Task<bool> DeleteQuotationMemberBankDetailAsync(DeleteQuotationMemberBankDetailModel model)
        {
            using (var conn = new SqlConnection())
            {
                await conn.OpenAsync();

                var command = new SqlCommand("DeleteQuotationMemberBankDetail", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Id", model.Id);
                command.Parameters.AddWithValue("@QuotationId", model.QuotationId);
                command.Parameters.AddWithValue("@MemberId", model.MemberId);
                command.Parameters.AddWithValue("@BankName", model.BankName);
                command.Parameters.AddWithValue("@AccountNumber", model.AccountNumber);
                command.Parameters.AddWithValue("@AccountType", model.AccountType);
                command.Parameters.AddWithValue("@SwiftCode", model.SwiftCode);

                await command.ExecuteNonQueryAsync();

                return true;
            }
        }
    }
}