using DtMoney.Infra.Models;
using DtMoney.Services.Trasactions;
using Microsoft.AspNetCore.Mvc;

namespace DtMoney.Api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionService _transactionService;

        public TransactionsController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet("list")]
        public async Task<IActionResult> ListTransactions()
        {
            return Ok(await _transactionService.GetTransactions());
        }
        
        [HttpPost("insert")]
        public async Task<IActionResult> InsertTransactions(Transaction transaction)
        {
            await _transactionService.AddTransactions(transaction);
            return Ok(transaction);
        }

        [HttpDelete("delete/{id:guid}")]        
        public async Task<IActionResult> deleteTransactions(Guid id)
        {
            await _transactionService.RemoveTransactions(id);
            return Ok();
        }
    }
}
