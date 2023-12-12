using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Text.Json.Serialization;
namespace NWC.Models
{
    [Table("BillPeriods")]
    public class BillPeriod
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string PeriodName { get; set; }
        [JsonIgnore]
        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Bill> Bills { get; set; }
    }
}
