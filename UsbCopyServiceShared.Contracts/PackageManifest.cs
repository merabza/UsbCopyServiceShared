namespace UsbCopyServiceShared.Contracts;

//მანიფესტი აღწერს ერთ გადასაცემ პაკეტს და შეიცავს ინფორმაციას, თუ როგორ უნდა მიიყვანოს კლიენტმა ფაილები საწყის მდგომარეობაში
public sealed class PackageManifest
{
    //პაკეტის უნიკალური იდენტიფიკატორი
    public string PackageId { get; set; } = string.Empty;

    //სამუშაოს იდენტიფიკატორი, რომელსაც პაკეტი ეკუთვნის
    public string JobId { get; set; } = string.Empty;

    //პაკეტის რიგითი ნომერი (0-დან) და პაკეტების საერთო რაოდენობა
    public int PackageIndex { get; set; }
    public int PackagesTotal { get; set; }

    public EPackageType PackageType { get; set; }

    //გადასაცემი ბაიტების რაოდენობა და მათი SHA256 (hex)
    public long TransferSize { get; set; }
    public string Sha256 { get; set; } = string.Empty;

    //WholeFile/FilePart: ფაილის ფარდობითი გზა ('/' გამყოფით) და სრული ზომა
    public string? RelativePath { get; set; }
    public long? FileSize { get; set; }

    //FilePart: ნაწილის ინდექსი (0-დან), ნაწილების რაოდენობა და ამ ნაწილის წანაცვლება ფაილში
    public int? PartIndex { get; set; }
    public int? PartsTotal { get; set; }
    public long? PartOffset { get; set; }

    //Archive: არქივში შემავალი ფაილების რაოდენობა (საინფორმაციო)
    public int? FilesCount { get; set; }
}
