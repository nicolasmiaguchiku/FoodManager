using System.Text.Json.Serialization;

namespace FastMenu.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Category
    {
        None = 0,            //nenhum
        Promotion = 1,       //promoção
        BestSellers = 2,     //mais vendidos
        WellRated = 3,       //bem avaliados   
        SideDishes = 4,      //acompanhamentos
        Combos = 5,          //combos
        Classics = 6,        //clássicos
        Recommended = 7,     //recomendados
        News = 8,            //novidades
        GlutenFree = 9       //sem glúten
    }
}
