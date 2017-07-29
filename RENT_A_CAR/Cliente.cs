using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RENT_A_CAR
{
    public class Cliente
    {
        #region "ATRIBUTOS"

        // Cedula -> Atributo de tipo string
        private string _cedula;

        // Tarjeta de credito -> Atributo de tipo string
        private string _tarjetaCredito;

        // Nombre completo -> Atributo de tipo string
        private string _nombreCompleto;

        // Telefono -> Atributo de tipo string
        private string _telefono;

        // Direccion -> Atributo de tipo string
        private string _direccion;

        // Fecha de Nacimiento -> Atributo de tipo DateTme
        private DateTime _fechaNacimiento;

        #endregion

        #region "PROPIEDADES"

        // CEDULA ->
        public string Cedula
        {
            get { return _cedula; }
            set { _cedula = value; }
        }

        // TARJETA DE CREDITO ->
        public string TarjetaCredito
        {
            get { return _tarjetaCredito; }
            set { _tarjetaCredito = value; }
        }

        // NOMBRE COMPLETO ->
        public string NombreCompleto
        {
            get { return _nombreCompleto; }
            set { _nombreCompleto = value; }
        }

        // TELEFONO -> 
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        // DIRECCION ->
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        // FECHA DE NACIMIENTO ->
        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        #endregion

    }
}
