using System;
using System.ComponentModel.DataAnnotations;


namespace ReservasHotel.Models{

public class Bookings{
    [Key]
    public int id { get; set; }

    [Required(ErrorMessage = "Este Campo é obrigatório")]
    public Rooms rooms {get;set;}

    [Required(ErrorMessage = "Este Campo é obrigatório")]
    public DateTime dateCheckIn {get;set;}

    [Required(ErrorMessage = "Este Campo é obrigatório")]
    public DateTime dateCheckOut {get;set;}

    [Range(1, int.MaxValue, ErrorMessage = "O preço deve ser maior que zero")]
    public decimal price {get; set;}
}

}