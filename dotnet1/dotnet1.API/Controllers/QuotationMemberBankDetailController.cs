using System.Threading.Tasks;
using dotnet1.DTO;
using dotnet1.Service;
using Microsoft.AspNetCore.Mvc;

namespace dotnet1.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuotationMemberBankDetailController : ControllerBase
    {
        private readonly DeleteQuotationMemberBankDetailService _deleteQuotationMemberBankDetailService;

        public QuotationMemberBankDetailController(DeleteQuotationMemberBankDetailService deleteQuotationMemberBankDetailService)
        {
            _deleteQuotationMemberBankDetailService = deleteQuotationMemberBankDetailService;
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteQuotationMemberBankDetailAsync(DeleteQuotationMemberBankDetailModel model)
        {
            var result = await _deleteQuotationMemberBankDetailService.DeleteQuotationMemberBankDetailAsync(model);
            return Ok(result);
        }
    }
}