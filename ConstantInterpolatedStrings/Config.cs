namespace ConstantInterpolatedStrings;

public static class Config
{
    private const string CompanyName = "MyCompany";

    public static class Messages
    {
        public const string Ok = $"{CompanyName} - Ok";
        public const string Error = $"{CompanyName} - Error";
        public const string Warning = $"{CompanyName} - Warning";

        // Compile to
        // public const string Ok = "MyCompany - Ok";

        // Before
        // public const string Ok = CompanyName + " - Ok";
        // public static readonly Ok = $"{CompanyName} - Ok";
    }
}
