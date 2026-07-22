using System.Text.Json.Serialization;

namespace UsbCopyServiceShared.Contracts;

//პაკეტის ტიპი განსაზღვრავს, როგორ უნდა აღადგინოს კლიენტმა მიღებული ბაიტები
[JsonConverter(typeof(JsonStringEnumConverter<EPackageType>))]
public enum EPackageType
{
    //პატარა ფაილების ერთიანი zip არქივი. აღდგენა: განარქივება დანიშნულების ძირში
    Archive,

    //საშუალო ზომის ფაილი უცვლელი სახით. აღდგენა: ჩაწერა RelativePath მისამართზე
    WholeFile,

    //დიდი ფაილის ბაიტური მონაკვეთი. აღდგენა: ჩაწერა RelativePath ფაილში PartOffset პოზიციაზე
    FilePart
}
