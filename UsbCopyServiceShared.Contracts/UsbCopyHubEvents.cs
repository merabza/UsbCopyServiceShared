namespace UsbCopyServiceShared.Contracts;

//SignalR ჰაბის მეთოდების სახელები, რომლებსაც ორივე მხარე იყენებს
public static class UsbCopyHubEvents
{
    //კლიენტი → სერვისი
    public const string StartJob = "StartJob";
    public const string ResumeJob = "ResumeJob";
    public const string AckPackage = "AckPackage";

    //სერვისი → კლიენტი
    public const string ReceiveProgress = "ReceiveProgress";
    public const string ReceivePackageReady = "ReceivePackageReady";
    public const string ReceiveJobCompleted = "ReceiveJobCompleted";
    public const string ReceiveJobFailed = "ReceiveJobFailed";
}
