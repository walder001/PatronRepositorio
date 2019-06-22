﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Imagen
    {
        [Key]
        public int IdImagen { get; set; }
        public string RutaImagen { get; set; }
        public Imagen()
        {
            IdImagen = 0;
            RutaImagen = string.Empty;
        }
        public Imagen(int idImagen, string rutaImagen)
        {
            IdImagen = idImagen;
            RutaImagen = rutaImagen;
        }
    }
}
