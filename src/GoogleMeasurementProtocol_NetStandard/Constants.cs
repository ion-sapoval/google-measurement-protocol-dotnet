namespace GoogleMeasurementProtocol
{
    public static class HitTypes
    {
        public const string PageView = "pageview";

        public const string ScreenView = "screenview";

        public const string Event = "event";

        public const string Transaction = "transaction";

        public const string Item = "item";

        public const string Social = "social";

        public const string Exception = "exception";

        public const string Timing = "timing";
    }

    public static class HttpMethod
    {
        public const string POST = "POST";
        public const string GET = "GET";
    }

    public static class GoogleEndpointAddresses
    {
        public const string DebugCollect = "https://www.google-analytics.com/debug/collect";
        public const string Collect = "https://www.google-analytics.com/collect";
        public const string BatchCollect = "https://www.google-analytics.com/batch";
    }
}
