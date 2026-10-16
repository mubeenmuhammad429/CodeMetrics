namespace CodeMetrics.API.Models;

public class Submission
{
    public int SubmissionId { get; set; }
    public int AssignmentId { get; set; }
    public int StudentId { get; set; }
    public string FilePath { get; set; } = string.Empty;
    public DateTime SubmittedAt { get; set; } = DateTime.Now;
    public decimal? PlagiarismScore { get; set; }
    public bool IsEvaluated { get; set; } = false;
}