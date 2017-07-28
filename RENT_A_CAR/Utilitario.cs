using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RENT_A_CAR
{
    public class Utilitario : Vehiculo
    {

        #region "ATRIBUTOS"

        // Capacidad de carga en kilogramos -> Atributo de tipo int
        private int _capacidadCarga;

        // Tipo de utilitario -> Atributo de tipo string
        private string _tipoUtilitario;

        #endregion

        #region "PROPIEDADES"

        // CAPACIDAD DE CARGA EN KILOGRAMOS -> NUMERO DE TIPO INT MAYOR QUE CERO
        public int CapacidadCarga
        {
            get { return _capacidadCarga; }

            set
            {
                // CONTROL DEL DATO INGRESADO:
                try
                {
                    int controlCapacidadCarga = Convert.ToInt32(value); // Control de dato por tipo

                    if (controlCapacidadCarga <= 0) // Control de dato por rango
                    {
                        throw new Exception("La capacidad de carga ingresada debe ser mayor a cero, por lo tanto debe ingresar un valor válido.");
                    }

                    else
                    {
                        // REGISTRO DEL DATO INGRESADO:
                        _capacidadCarga = controlCapacidadCarga;
                    }
                }

                catch (FormatException)
                {
                    throw new Exception("La capacidad de carga ingresada debe ser un número entero, por lo tanto debe ingresar un valor válido.");
                }

                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        // TIPO DE UTILITARIO: CADENA DE TEXTO, DOS POSIBLES VALORES: "FURGONETA" o "PICK-UP"
        public string TipoUtilitario
        {
            get { return _tipoUtilitario; }

            set
            {
                // CONTROL Y REGISTRO DEL DATO INGRESADO:
                switch (value)
                {
                    case "1":
                        {
                            _tipoUtilitario = "FURGONETA";
                            break;
                        }
                    case "2":
                        {
                            _tipoUtilitario = "PICK-UP";
                            break;
                        }
                    default:
                        {
                            throw new Exception("La opción seleccionada para tipo de utilitario no es válida, por lo tanto debe ingresarla nuevamente.");
                        }
                }
            }
        }

        #endregion

        #region "CONSTRUCTOR COMPLETO"

        public Utilitario(string pMatricula, string pMarca, string pModelo, int pAnio, byte pCantidadPuertas, double pCostoDiario, int pCapacidadCarga, string pTipoUtilitario)
            : base(pMatricula, pMarca, pModelo, pAnio, pCantidadPuertas, pCostoDiario)
        {
            CapacidadCarga = pCapacidadCarga;
            TipoUtilitario = pTipoUtilitario;
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
