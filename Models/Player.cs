﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EsportMVC
{
    public partial class Player
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public int TeamId { get; set; }
        [Required(ErrorMessage = "Поле повинно бути заповненим")]
        [Display(Name = "Ім'я гравця")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Поле повинно бути заповненим")]
        [Display(Name = "Дата народження")]
        public DateTime? Birthdate { get; set; }
        
        [Display(Name = "Країна")]

        public virtual Country Country { get; set; }
        [Display(Name = "Команда")]
        public virtual Team Team { get; set; }
    }
}