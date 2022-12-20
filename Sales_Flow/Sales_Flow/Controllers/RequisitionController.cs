using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sales_Flow.Data;
using Sales_Flow.Models;

namespace Sales_Flow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequisitionController : ControllerBase
    {
        private readonly RequisitionDbContext _requisitionDbContext;
        public RequisitionController(RequisitionDbContext requisitionDbContext)
        {
            _requisitionDbContext = requisitionDbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetRequisitions()
        {
            var requisitions = await _requisitionDbContext.Requisitions.ToListAsync();
            return Ok(requisitions);
        }
        [HttpPost]
        public async Task<IActionResult> AddRequisition([FromBody] Requisition requisitionrequest)
        {
            requisitionrequest.RequisitionID = Guid.NewGuid();
            await _requisitionDbContext.Requisitions.AddAsync(requisitionrequest);
            await _requisitionDbContext.SaveChangesAsync();

            return Ok(requisitionrequest);
        }
        [HttpGet]
        [Route("{RequisitionID:Guid}")]
        public async Task<IActionResult> GetRequisition([FromRoute] Guid Requisitionid)
        {
            var requisitions = await _requisitionDbContext.Requisitions.FirstOrDefaultAsync(x => x.RequisitionID == Requisitionid);
            if (requisitions == null)
            {
                return NotFound();
            }

            return Ok(requisitions);
        }
        [HttpPut]
        [Route("{RequisitionID:Guid}")]
        public async Task<IActionResult> UpdateRequisition([FromRoute] Guid Requisitionid, Requisition updaterequisitionRequest)
        {
            var requisitions = await _requisitionDbContext.Requisitions.FindAsync(Requisitionid);
            if (requisitions == null)
            {
                return NotFound();
            }
            requisitions.RequisitionID = updaterequisitionRequest.RequisitionID;
            requisitions.RequisitionCode = updaterequisitionRequest.RequisitionCode;
            requisitions.RequisitionDate = updaterequisitionRequest.RequisitionDate;
            requisitions.PotentialNumber = updaterequisitionRequest.PotentialNumber;
            requisitions.Complexity = updaterequisitionRequest.Complexity;
            requisitions.DeadlineDate = updaterequisitionRequest.DeadlineDate;
            requisitions.ClientName = updaterequisitionRequest.ClientName;
            requisitions.ClientCountryID = updaterequisitionRequest.ClientCountryID;
            requisitions.ProjectType = updaterequisitionRequest.ProjectType;
            requisitions.SalesPersionUserID = updaterequisitionRequest.SalesPersionUserID;
            requisitions.ProjectManagerID = updaterequisitionRequest.ProjectManagerID;
            requisitions.RequisitionStatus = updaterequisitionRequest.RequisitionStatus;
            requisitions.ExpectedStartDate = updaterequisitionRequest.ExpectedStartDate;
            requisitions.DepartmentID = updaterequisitionRequest.DepartmentID;
            requisitions.EstimatedBudget = updaterequisitionRequest.EstimatedBudget;
            requisitions.CurrencyID = updaterequisitionRequest.CurrencyID;
            requisitions.ProjectDescription = updaterequisitionRequest.ProjectDescription;
            requisitions.CreatedBy = updaterequisitionRequest.CreatedBy;
            requisitions.CreatedOn = updaterequisitionRequest.CreatedOn;
            requisitions.LastUpdatedBy = updaterequisitionRequest.LastUpdatedBy;
            requisitions.LastUpdatedOn = updaterequisitionRequest.LastUpdatedOn;
            await _requisitionDbContext.SaveChangesAsync();
            return Ok(requisitions);
        }
        [HttpDelete]
        [Route("{RequisitionID:Guid}")]
        public async Task<IActionResult> DeleteRequisition([FromRoute] Guid Requsitionid)
        {
            var requisitions = await _requisitionDbContext.Requisitions.FindAsync(Requsitionid);
            if (requisitions == null)
            {
                return NotFound();
            }

            _requisitionDbContext.Requisitions.Remove(requisitions);
            await _requisitionDbContext.SaveChangesAsync();
            return Ok(requisitions);
        }
    }
}
    