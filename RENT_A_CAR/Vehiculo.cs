using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RENT_A_CAR
{
    public abstract class Vehiculo
    {

        #region "ATRIBUTOS"

        // Matricula -> Atributo de tipo string
        private string _matricula;

        // Marca -> Atributo de tipo string
        private string _marca;

        // Modelo -> Atributo de tipo string
        private string _modelo;

        // Año -> Atributo de tipo int
        private int _anio;

        // Cantidad de puertas -> Atributo de tipo byte
        private byte _cantidadPuertas;

        // Costo diario de alquiler en dólares -> Atributo de tipo double
        private double _costoDiario;

        #endregion

        #region "PROPIEDADES"

        // MATRICULA -> CADENA DE TEXTO COMPUESTA POR 3 LETRAS MAYUSCULAS Y 4 DIGITOS
        public string Matricula
        {
            get { return _matricula; }

            set
            {
                // VERIFICACION DE INGRESO DE DATO:
                if (value == String.Empty)
                {
                    throw new Exception("El campo MATRICULA es obligatorio, por lo tanto debe ingresar un valor.");
                }

                // CONTROL DEL DATO INGRESADO:
                int serieOK = 0; // Variable de control
                int numeroOK = 0; // Variable de control

                if (value.Length == 7)
                {
                    // Serie de la matrícula: 3 letras mayúsculas
                    string serie = value.Substring(0, 3);

                    // Numeración de la matrícula: 4 dígitos
                    string numero = value.Substring(3, 4);

                    // Control de la numeración:
                    try
                    {
                        int controlNumero = Convert.ToInt32(numero);
                        numeroOK = 1;
                    }

                    catch (FormatException)
                    {
                        throw new Exception("La numeración de la matrícula contiene una letra, por lo tanto no es un valor válido.");
                    }

                    // Control de la serie:
                    if (numeroOK == 1)
                    {
                        char[] controlSerie = serie.ToCharArray();

                        for (int i = 0; i < controlSerie.Length; i++)
                        {
                            if ((Char.IsLetter(controlSerie[i]) == false) || (controlSerie[i] < 'A') || (controlSerie[i] > 'Z'))
                            {
                                serieOK = -1;
                                throw new Exception("La serie de la matrícula contiene un número, por lo tanto no es un valor válido.");
                            }
                            else
                            {
                                serieOK = 1;
                            }
                        }
                    }
                }

                else
                {
                    throw new Exception("La matrícula ingresada no contiene la cantidad de caracteres requeridos, por lo tanto no es un valor válido.");
                }

                // REGISTRO DEL DATO INGRESADO:
                if ((serieOK == 1) && (numeroOK == 1))
                {
                    _matricula = value;
                }
            }
        }

        // MARCA -> CADENA DE TEXTO DE INGRESO LIBRE
        public string Marca
        {
            get { return _marca; }

            set
            {
                // VERIFICACION DE INGRESO DE DATO:
                if (value == String.Empty)
                {
                    throw new Exception("El campo MARCA es obligatorio, por lo tanto debe ingresar un valor.");
                }

                // REGISTRO DEL DATO INGRESADO:
                _marca = value;
            }
        }

        // MODELO -> CADENA DE TEXTO DE INGRESO LIBRE
        public string Modelo
        {
            get { return _modelo; }

            set
            {
                // VERIFICACION DE INGRESO DE DATO:
                if (value == String.Empty)
                {
                    throw new Exception("El campo MODELO es obligatorio, por lo tanto debe ingresar un valor.");
                }

                // REGISTRO DEL DATO INGRESADO:
                _modelo = value;
            }
        }

        // AÑO -> NÚMERO DE TIPO INT, VALORES POSIBLES: LOS ÚLTIMOS 5 AÑOS
        public int Anio
        {
            get { return _anio; }

            set
            {
                // VERIFICACIÓN DE INGRESO DE DATO:
                if (value == 0)
                {
                    throw new Exception("El campo AÑO es obligatorio, por lo tanto debe ingresar un valor.");
                }

                // CONTROL DEL DATO INGRESADO:
                int anioFinal = DateTime.Now.Year; // Variable de control
                int anioInicial = anioFinal - 5; // Variable de control

                try
                {
                    int controlAnio = Convert.ToInt32(value); // Control de dato por tipo

                    if ((controlAnio < anioInicial) || (controlAnio > anioFinal)) // Control de dato por rango
                    {
                        throw new Exception("El año ingresado no se encuentra dentro del rango especificado, por lo tanto debe ingresar un valor válido.");
                    }

                    else
                    {
                        // REGISTRO DEL DATO INGRESADO:
                        _anio = controlAnio;
                    }
                }

                catch (FormatException)
                {
                    throw new Exception("El año ingresado no es un número entero, por lo tanto debe ingresar un valor válido.");
                }

                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        // CANTIDAD DE PUERTAS -> NUMERO DE TIPO BYTE, CUATRO VALORES POSIBLES: 2, 3, 4 o 5
        public byte CantidadPuertas
        {
            get { return _cantidadPuertas; }

            set
            {
                // CONTROL DEL DATO INGRESADO:
                try
                {
                    byte controlCantidadPuertas = Convert.ToByte(value); // Control de dato por tipo

                    if ((controlCantidadPuertas < 2) || (controlCantidadPuertas > 5)) // Control de dato por rango
                    {
                        throw new Exception("La cantidad de puertas ingresada no se encuentra dentro del rango especificado, por lo tanto debe ingresar un valor válido.");
                    }

                    else
                    {
                        // REGISTRO DEL DATO INGRESADO:
                        _cantidadPuertas = controlCantidadPuertas;
                    }
                }

                catch (FormatException)
                {
                    throw new Exception("La cantidad de puertas ingresada no es un número entero, por lo tanto debe ingresar un valor válido.");
                }

                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        // COSTO DIARIO POR ALQUILER EN DOLARES -> NUMERO DE TIPO DOUBLE MAYOR QUE CERO (PUEDE CONTENER DECIMALES)
        public double CostoDiario
        {
            get { return _costoDiario; }
            set
            {
                // CONTROL DEL DATO INGRESADO:
                try
                {
                    double controlCostoDiario = Convert.ToDouble(value); // Control de dato por tipo

                    if (controlCostoDiario <= 0) // Control de dato por rango
                    {
                        throw new Exception("El costo diario por alquiler ingresado debe ser mayor a cero, por lo tanto debe ingresar un valor válido.");
                    }

                    else
                    {
                        // REGISTRO DEL DATO INGRESADO:
                        _costoDiario = controlCostoDiario;
                    }
                }

                catch (FormatException)
                {
                    throw new Exception("El costo diario por alquiler ingresado no es un número, por lo tanto debe ingresar un valor válido.");
                }

                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        #endregion

        #region "CONSTRUCTOR COMPLETO"

        public Vehiculo(string pMatricula, string pMarca, string pModelo, int pAnio, byte pCantidadPuertas, double pCostoDiario)
        {
            Matricula = pMatricula;
            Marca = pMarca;
            Modelo = pModelo;
            Anio = pAnio;
            CantidadPuertas = pCantidadPuertas;
            CostoDiario = pCostoDiario;
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
