using System.Text.Json.Serialization;

namespace UsbCopyServiceShared.Contracts;

//ResumeJob მოთხოვნის შედეგის სტატუსი
[JsonConverter(typeof(JsonStringEnumConverter<EResumeJobStatus>))]
public enum EResumeJobStatus
{
    //სამუშაო მიბმულია ამ კავშირზე და გრძელდება
    Attached,

    //სამუშაო ვერ მოიძებნა — კლიენტმა ახალი StartJob უნდა გაუშვას
    NotFound,

    //სამუშაო ჯერ კიდევ სხვა კავშირს უჭირავს — კლიენტმა მოგვიანებით უნდა სცადოს
    Busy,

    //სამუშაოს აღდგენა შეუძლებელია — კლიენტმა უნდა შეწყვიტოს და შეცდომა აჩვენოს
    Failed
}
