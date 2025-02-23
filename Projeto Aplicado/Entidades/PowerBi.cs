﻿using System.ComponentModel.DataAnnotations;

namespace Projeto_Aplicado.Entidades
{
    public class PowerBi : BaseEntity
    {
        [Required]
        public int value1 { get; set; }
        [Required]
        public int value2 { get; set; }
        [Required]
        public int value3 { get; set; }
        [Required]
        public int value4 { get; set; }
        [Required]
        public int value5 { get; set; }
        public long UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
