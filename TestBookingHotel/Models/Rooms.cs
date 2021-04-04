using System;
using System.ComponentModel.DataAnnotations;


namespace ReservasHotel.Models{

public class Rooms{
    [Key]
    public int id { get; set; }

    [Required(ErrorMessage = "Este Campo é obrigatório")]
    public string roomNumber {get;set;}
    public decimal price {get; set;}
}

}