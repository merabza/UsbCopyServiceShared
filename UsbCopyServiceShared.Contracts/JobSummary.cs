namespace UsbCopyServiceShared.Contracts;

//სამუშაოს დასრულების შემაჯამებელი ინფორმაცია
public sealed class JobSummary
{
    //სულ შერჩეული ფაილების რაოდენობა (გამორიცხვების შემდეგ)
    public int FilesTotal { get; set; }

    //კლიენტთან უკვე არსებობის გამო გამოტოვებული ფაილების რაოდენობა
    public int FilesSkipped { get; set; }

    //გადაცემული ფაილების ჯამური საწყისი ზომა და რეალურად გადაცემული ბაიტები
    public long BytesOriginal { get; set; }
    public long BytesTransferred { get; set; }

    public int PackagesTotal { get; set; }

    public double ElapsedSeconds { get; set; }
}
