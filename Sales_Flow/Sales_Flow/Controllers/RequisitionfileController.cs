using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sales_Flow.Data;
using Sales_Flow.Models;

namespace Sales_Flow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequisitionfileController : ControllerBase
    {
        private readonly RequisitionDbContext _requisitionDbContext;
        public RequisitionfileController(RequisitionDbContext requisitionDbContext)
        {
            _requisitionDbContext = requisitionDbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetRequisitionfiles()
        {
            var requisitionfile = await _requisitionDbContext.RequisitionFiles.ToListAsync();
            return Ok(requisitionfile);
        }
        [HttpPost]
        public async Task<IActionResult> AddRequisitionFile([FromBody] Requistionfile requisitionfilerequest)
        {
            requisitionfilerequest.RequsitionFileID = Guid.NewGuid();
            await _requisitionDbContext.RequisitionFiles.AddAsync(requisitionfilerequest);
            await _requisitionDbContext.SaveChangesAsync();

            return Ok(requisitionfilerequest);
        }
        [HttpGet]
        [Route("{RequsitionFileID:Guid}")]
        public async Task<IActionResult> GetRequisitionFile([FromRoute] Guid Requisitionfileid)
        {
            var requisitionfile = await _requisitionDbContext.RequisitionFiles.FirstOrDefaultAsync(x => x.RequsitionFileID == Requisitionfileid);
            if (requisitionfile == null)
            {
                return NotFound();
            }

            return Ok(requisitionfile);
        }
    }
}
