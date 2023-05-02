namespace dotnet1
{
    public class DeleteQuotationMemberBankDetailModel
    {
        public int Id { get; set; }
        public int QuotationId { get; set; }
        public int MemberId { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public string SwiftCode { get; set; }
    }
}