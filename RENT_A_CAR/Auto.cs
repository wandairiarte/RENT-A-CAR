using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RENT_A_CAR
{
    public class Auto : Vehiculo
    {

        #region "ATRIBUTOS"

        // Tipo de anclaje para silla infantil -> Atributo de tipo string
        private string _tipoAnclaje;

        #endregion

        #region "PROPIEDADES"

        // TIPO DE ANCLAJE PARA SILLA INFANTIL -> CADENA DE TEXTO, TRES VALORES POSIBLES: "CINTURON", "ISOFIX" o "LATCH"
        public string TipoAnclaje
        {
            get { return _tipoAnclaje; }

            set
            {
                // CONTROL Y REGISTRO DEL DATO INGRESADO:
                switch (value)
                {
                    case "1":
                        {
                            _tipoAnclaje = "CINTURON";
                            break;
                        }
                    case "2":
                        {
                            _tipoAnclaje = "ISOFIX";
                            break;
                        }
                    case "3":
                        {
                            _tipoAnclaje = "LATCH";
                            break;
                        }
                    default:
                        {
                            throw new Exception("La opción seleccionada para tipo de anclaje para silla infantil no es válida, por lo tanto debe ingresarla nuevamente.");
                        }
                }
            }
        }

        #endregion

        #region "CONSTRUCTOR COMPLETO"

        public Auto(string pMatricula, string pMarca, string pModelo, int pAnio, byte pCantidadPuertas, double pCostoDiario, string pTipoAnclaje)
            : base(pMatricula, pMarca, pModelo, pAnio, pCantidadPuertas, pCostoDiario)
        {
            _tipoAnclaje = pTipoAnclaje;
        }

        #endregion

        #region "METODOS"

        public override string ToString()
        {
            return base.ToString();
        }

        #endregion

    }
}
