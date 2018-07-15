namespace ApiFury.Models
{
    public class Villages
    {
         public int Id { get; set; }
         public string PlayerName {get;set;}
        //Village id for attacking
        public uint Villageid {get;set;}
        //VillagesName
        public string Name {get;set;}
        //XCordinates where our village is located
        public short ArgX {get;set;}
        //YCordinates where our village is located
        public short ArgY {get;set;}
        //Our village abandoned or not.
        public bool IsEmpty {get;set;}
        //How many pople live in this villages
        public short Population {get;set;}
    }
}