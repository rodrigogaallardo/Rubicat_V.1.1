﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos.Admin;

namespace Logica
{
    public class Transporte
    {
        public void AgregarTransporte(Entidades.Transporte transporte)
        {
            AdmTransporte.InsertTransporte(transporte);
        }
        public void ModificarTransporte(Entidades.Transporte transporte)
        {
            AdmTransporte.UpdateTransporte(transporte);
        }
        public void BorrarTransporte(int id)
        {
            AdmTransporte.DeleteTransporte(id);
        }
        public List<Entidades.Transporte> TraerTransporte()
        {
            return AdmTransporte.SelectTransporte();
        }
        public Entidades.Transporte TraerPorId(int id)
        {
            return AdmTransporte.SelectId(id);
        }
        public List<Entidades.Transporte> SelectTransporte(string letra)
        {
            return AdmTransporte.SelectTransporte(letra);
        }
    }
}
