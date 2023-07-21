using Microsoft.AspNetCore.Mvc;
using Sipay_Api_Second_Week_Assignment.Models.Query;

namespace Sipay_Api_Second_Week_Assignment;

[ApiController]
[Route("sipy/api/[controller]")]
public class TransactionController : ControllerBase
{
    private readonly ITransactionRepository repository;
    public TransactionController(ITransactionRepository repository)
    {
        this.repository = repository;
    }

    [HttpGet("GetByParameter")]
    public IActionResult GetByParameter([FromQuery] TransactionQueryParameters parameters)
    {
        //var entityList = repository.GetByParameter(x => (x.AccountNumber == parameters.AccountNumber) && (x.ReferenceNumber == parameters.ReferenceNumber) && ((x.CreditAmount > parameters.MinAmountCredit) && (x.CreditAmount < parameters.MaxAmountCredit)) && ((x.DebitAmount > parameters.MaxAmountDebit) && (x.DebitAmount < parameters.MaxAmountDebit)));
        var entityList = repository.GetByParameter(x => (x.AccountNumber == parameters.AccountNumber));

        return Ok(entityList.ToList());
    }
}
