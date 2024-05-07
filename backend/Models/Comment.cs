using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        //It ensures that this int is nullable value and later can be stored null values inside it.
        public int? StockId { get; set; }   //This will actually form the relationship in the database.

        //Navigation property allows users to navigate to other models
        public Stock? Stock { get; set; }
    }
}