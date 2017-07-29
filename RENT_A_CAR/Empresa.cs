using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RENT_A_CAR
{
    public class Empresa
    {
        
        #region "ATRIBUTOS"

        // Registro de Clientes -> Atributo de tipo List<Cliente>
        private List<Cliente> _registroClientes = new List<Cliente>();

        // Registro de Vehiculos -> Atributo de tipo List<Vehiculo>
        private List<Vehiculo> _registroVehiculos = new List<Vehiculo>();

        #endregion

        #region "PROPIEDADES"

        // REGISTRO DE CLIENTES -> LISTADO DE OBJETOS DE LA CLASE CLIENTE
        public List<Cliente> RegistroClientes
        {
            get { return _registroClientes; }
            set { _registroClientes = value; }
        }

		// REGISTRO DE VEHICULOS -> LISTADO DE OBJETOS DE LA CLASE VEHICULO 
        public List<Vehiculo> RegistroVehiculos
		{
            get { return _registroVehiculos; }
            set { _registroVehiculos = value; }
		}

        #endregion

    }
}
