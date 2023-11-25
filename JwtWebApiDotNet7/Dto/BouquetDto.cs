using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JwtWebApiDotNet7.Models
{
    public class BouquetDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";

        public string Photo { get; set; } = "";
        public int Price { get; set; }



    }
}
