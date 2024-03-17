using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.EMS.Models.Entities;

public class SalesManagerReport
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }
    public int SalesManagerId { get; set; } 
    public int AccountId { get; set; } 
    public DateOnly Date { get; set; } 
    public int EngagementTotal { get; set; } 
    public string Comments { get; set; } 
    public int ReportStatusId { get; set; } 
   
    public SalesManagerReport(int salesManagerId, int accountId, DateOnly date, int engagementTotal, string comments, int reportStatusId)
    {
        SalesManagerId = salesManagerId;
        AccountId = accountId;
        Date = date;
        EngagementTotal = engagementTotal;
        Comments = comments;
        ReportStatusId = reportStatusId;
    }
}