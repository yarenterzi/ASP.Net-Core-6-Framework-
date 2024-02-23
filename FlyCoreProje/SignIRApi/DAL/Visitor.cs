namespace SignIRApi.DAL
{
    public enum ECity
    {
        Bursa=1,
        İstanbul=2,
        Erzurum=3,
        Kütahya=4,
        Ankara=5
    }
    public class Visitor
    {
        public int VisitorID { get; set; }
        public ECity City { get; set; }
        public int CityVisitCount { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
