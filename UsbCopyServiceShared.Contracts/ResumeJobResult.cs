namespace UsbCopyServiceShared.Contracts;

//ResumeJob მოთხოვნის პასუხი (JSON სტრიქონად გადაიცემა, როგორც PackageManifest/JobSummary)
public sealed class ResumeJobResult
{
    public EResumeJobStatus Status { get; set; }

    public string? ErrorMessage { get; set; }
}
