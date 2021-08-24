using Gulde.Builders;

namespace GuldePlayTests
{
    public static class A
    {
        public static CompanyBuilder Company => new CompanyBuilder();
        public static PlayerBuilder Player => new PlayerBuilder();
        public static RecipeBuilder Recipe => new RecipeBuilder();
        public static CityBuilder City => new CityBuilder();
    }

    public static class An
    {
        public static ItemBuilder Item => new ItemBuilder();
    }
}