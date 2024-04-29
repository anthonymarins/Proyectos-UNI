﻿using System.ComponentModel.DataAnnotations;

namespace ApiBalance.Modelo.Dto
{
    public class EntradasDtoCreate
    {
        public int IdTransaccion { get; set; }
        [Required]
        public decimal entradas { get; set; }
        public int IdCuenta { get; set; }

    }
}
