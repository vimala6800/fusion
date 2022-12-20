using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using sales.Data;
using sales.Models;

namespace sales.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequistionController : ControllerBase
    {
        private readonly RequisitioDbContext RequisitioDbContext;
        public RequistionController(RequisitioDbContext RequisitioDbContext)
        {
            RequistionDbContext = RequistionDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRequisitions()
        {
            var requisition = await RequistionDbContext.Requisitions.ToListAsync();

            return Ok(requisition);
        }

        [HttpPost]
        public async Task<IActionResult> AddRequisition([FromBody] Requisition requisitionRequest)
        {
            requisitionRequest.Id = Guid.NewGuid();
            await _RequistionDbContext.Requisitions.AddAsync(requisitionRequest);
            await _RequistionDbContext.SaveChangesAsync();

            return Ok(requisitionRequest);
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetRequisition([FromRoute] Guid id)
        {
            var requisition = await _RequistionDbContext.Requisitions.FirstOrDefaultAsync(x => x.Id == id);
            if (requisition == null)
            {
                return NotFound();
            }

            return Ok(requisition);
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> UpdateRequisition([FromRoute] Guid id, Requisition updaterequisitionRequest)
        {
            var requisition = await _RequistionDbContext.Requisitions.FindAsync(id);
            if (requisition == null)
            {
                return NotFound();
            }
            requisition.RequisitionID = updaterequisitionRequest.RequisitionID;
            requisition.RequisitionCode = updaterequisitionRequest.RequisitionCode;
            requisition.RequisitionDate = updaterequisitionRequest.RequisitionDate;
            requisition.PotentialNumber = updaterequisitionRequest.PotentialNumber;
            requisition.Complexity = updaterequisitionRequest.Complexity;
            requisition.DeadlineDate = updaterequisitionRequest.DeadlineDate;
            requisition.ClientName = updaterequisitionRequest.ClientName;
            requisition.ClientCountryID = updaterequisitionRequest.ClientCountryID;
            requisition.ProjectType = updaterequisitionRequest.ProjectType;
            requisition.SalesPersionUserID = updaterequisitionRequest.SalesPersionUserID;
            requisition.ProjectManagerID = updaterequisitionRequest.ProjectManagerID;
            requisition.RequisitionStatus = updaterequisitionRequest.RequisitionStatus;
            requisition.ExpectedStartDate = updaterequisitionRequest.ExpectedStartDate;
            requisition.DepartmentID = updaterequisitionRequest.DepartmentID;
            requisition.EstimatedBudget = updaterequisitionRequest.EstimatedBudget;
            requisition.CurrencyID = updaterequisitionRequest.CurrencyID;
            requisition.ProjectDescription = updaterequisitionRequest.ProjectDescription;
            requisition.CreatedBy = updaterequisitionRequest.CreatedBy;
            requisition.CreatedOn = updaterequisitionRequest.CreatedOn;
            requisition.LastUpdatedBy = updaterequisitionRequest.LastUpdatedBy;
            requisition.LastUpdatedOn = updaterequisitionRequest.LastUpdatedOn;
            await _RequistionDbContext.SaveChangesAsync();
            return Ok(requisition);
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> DeleteRequisition([FromRoute] Guid id)
        {
            var requisition = await _RequistionDbContext.Requisition.FindAsync(id);
            if (requisition == null)
            {
                return NotFound();
            }

            _RequistionDbContext.Requisitions.Remove(requisition);
            await _RequistionDbContext.SaveChangesAsync();
            return Ok(requisition);
        }
    }
}


