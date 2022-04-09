using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace DtMoney.Infra.Models
{
    public class Transaction : Identity
    {
        [Required(ErrorMessage = "this field {0} is required")]
        [JsonProperty("title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "this field {0} is required")]
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [Required(ErrorMessage = "this field {0} is required")]
        [JsonProperty("category")]
        public string Category { get; set; }

        [Required(ErrorMessage = "this field {0} is required")]
        [JsonProperty("type")]
        public string Type { get; set; }
        
        public DateTime CreatedAt { get; set; }

        public Transaction(string title, int amount, string category, string type)
        {
            Title = title;
            Amount = amount;
            Category = category;
            Type = type;
            CreatedAt = new DateTime();
        }       

        public Transaction(){} // constructor for EF

    }
}
