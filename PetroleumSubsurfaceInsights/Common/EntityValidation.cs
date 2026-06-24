namespace PetroleumSubsurfaceInsights.Common
{
    public static class EntityValidation
    {
        public static class Asset
        {
            public const int AssetNameMinLength = 2;
            public const int AssetNameMaxLength = 100;

            public const int AssetCountryMinLength = 2;
            public const int AssetCountryMaxLength = 100;

            public const int AssetOperatorMinLength = 2;
            public const int AssetOperatorMaxLength = 150;

            public const int AssetDescriptionMinLength = 20;
            public const int AssetDescriptionMaxLength = 1000;
        }

        public static class Field
        {
            public const int FieldNameMinLength = 2;
            public const int FieldNameMaxLength = 100;

            public const int FieldCountryMinLength = 2;
            public const int FieldCountryMaxLength = 100;

            public const int FieldBasinMinLength = 2;
            public const int FieldBasinMaxLength = 150;

            public const int FieldDescriptionMinLength = 20;
            public const int FieldDescriptionMaxLength = 1000;
        }
    }
}
