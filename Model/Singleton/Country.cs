namespace DesignPatterns.Model
{
    public class Country
    {
        private Country (){}

        private Country (string Name){
            this.Name = Name;
        }

        public string? Name {get; set;}
        
        private static class CountryHolder{
            public static List<Country> INSTANCE = new List<Country>{
                new Country("Costa Rica"),
                new Country("Panama"),
                new Country("Colombia"),
                new Country("Bolibia"),
                new Country("Peru"),
                new Country("India"),
            };
        }

        public static List<Country> GetCountries(){
            return CountryHolder.INSTANCE;
        }
    }
}