namespace UsbCopyServiceShared.Contracts.V1.Routes;

public static class UsbCopyApiRoutes
{
    private const string Api = "api";
    private const string Version = "v1";
    public const string ApiBase = Api + "/" + Version;

    public static class UsbCopyRoute
    {
        public const string UsbCopyBase = "/usbcopy";

        //SignalR ჰაბის მისამართი: api/v1/usbcopy/hub
        public const string Hub = "/hub";

        //პაკეტის ჩამოტვირთვა: GET api/v1/usbcopy/download/{jobId}/{packageId}
        public const string Download = "/download";
    }
}
