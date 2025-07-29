namespace Klevify_Domain.Domain.Common
{
    public static class ValidationConstants
    {
        // User
        public const int UserNameMaxLength = 50;
        public const int PasswordMinLength = 6;
        public const int PasswordMaxLength = 100;
        public const int FirstNameMaxLength = 50;
        public const int LastNameMaxLength = 50;

        // Role
        public const int RoleNameMaxLength = 50;

        // Genre
        public const int GenreNameMaxLength = 50;

        // BookLanguage
        public const int BookNameMaxLength = 100;
        public const int BookDescriptionMaxLength = 1000;

        // Language
        public const int LanguageNameMaxLength = 50;

        // MembershipType
        public const int MembershipTypeNameMaxLength = 100;
    }
}