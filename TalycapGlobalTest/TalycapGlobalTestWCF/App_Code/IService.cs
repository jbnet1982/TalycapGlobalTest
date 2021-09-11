using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using TalycapGlobalData;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IService
{

	[OperationContract]
	string GetData(int value);

	[OperationContract]
	CompositeType GetDataUsingDataContract(CompositeType composite);

	//Paises

	[OperationContract]
	Task<List<Pai>> ListaPaises();

	[OperationContract]
	Task<Pai> GetPais(int Id);

	[OperationContract]
	Task<Pai> CreatePais(string json);

	[OperationContract]
	Task<Pai> EditPais(string json);

	[OperationContract]
	Task<Pai> DeletePais(string json);

	//Regiones

	[OperationContract]
	Task<List<Region>> ListaRegiones();

	[OperationContract]
	Task<Region> GetRegion(int Id);

	[OperationContract]
	Task<Region> CreateRegion(string json);

	[OperationContract]
	Task<Region> EditRegion(string json);

	[OperationContract]
	Task<Region> DeleteRegion(string json);

	//Ciudades
	[OperationContract]
	Task<List<Ciudad>> ListaCiudades();
	[OperationContract]
	Task<Ciudad> GetCiudad(int Id);
	[OperationContract]
	Task<Ciudad> CreateCiudad(string json);
	[OperationContract]
	Task<Ciudad> EditCiudad(string json);
	[OperationContract]
	Task<Ciudad> DeleteCiudad(string json);

	//Tipo Almacen
	[OperationContract]
	Task<List<TipoAlmacen>> ListaTipoAlmacen();
	[OperationContract]
	Task<TipoAlmacen> GetTipoAlmacen(int Id);
	[OperationContract]
	Task<TipoAlmacen> CreateTipoAlmacen(string json);
	[OperationContract]
	Task<TipoAlmacen> EditTipoAlmacen(string json);
	[OperationContract]
	Task<TipoAlmacen> DeleteTipoAlmacen(string json);

	//Tipo Productos
	[OperationContract]
	Task<List<TipoProducto>> ListaTipoProductos();
	[OperationContract]
	Task<TipoProducto> GetTipoProducto(int Id);
	[OperationContract]
	Task<TipoProducto> CreateTipoProducto(string json);
	[OperationContract]
	Task<TipoProducto> EditTipoProducto(string json);
	[OperationContract]
	Task<TipoProducto> DeleteTipoProducto(string json);

	//Tipo Envio
	[OperationContract]
	Task<List<TipoEnvio>> ListaTipoEnvios();
	[OperationContract]
	Task<TipoEnvio> GetTipoEnvio(int Id);
	[OperationContract]
	Task<TipoEnvio> CreateTipoEnvio(string json);
	[OperationContract]
	Task<TipoEnvio> EditTipoEnvio(string json);
	[OperationContract]
	Task<TipoEnvio> DeleteTipoEnvio(string json);

	//Tipo Documentos
	[OperationContract]
	Task<List<TipoDoc>> ListaTipoDocs();
	[OperationContract]
	Task<TipoDoc> GetTipoDoc(int Id);
	[OperationContract]
	Task<TipoDoc> CreateTipoDoc(string json);
	[OperationContract]
	Task<TipoDoc> EditTipoDoc(string json);
	[OperationContract]
	Task<TipoDoc> DeleteTipoDoc(string json);


	//Tipo Vehiculos
	[OperationContract]
	Task<List<TipoVehiculo>> ListaTipoVehiculos();
	[OperationContract]
	Task<TipoVehiculo> GetTipoVehiculo(int Id);
	[OperationContract]
	Task<TipoVehiculo> CreateTipoVehiculo(string json);
	[OperationContract]
	Task<TipoVehiculo> EditTipoVehiculo(string json);
	[OperationContract]
	Task<TipoVehiculo> DeleteTipoVehiculo(string json);

	//Estados
	[OperationContract]
	Task<List<Estado>> ListaEstados();
	[OperationContract]
	Task<Estado> GetEstado(int Id);
	[OperationContract]
	Task<Estado> CreateEstado(string json);
	[OperationContract]
	Task<Estado> EditEstado(string json);
	[OperationContract]
	Task<Estado> DeleteEstado(string json);

	//Consecutivo
	[OperationContract]
	Task<ConsecutivoGuia> GetConsecutivo(int TipoEnvioId);
	[OperationContract]
	Task<ConsecutivoGuia> CreateConsecutivo(string json);
	[OperationContract]
	Task<ConsecutivoGuia> EditConsecutivo(string json);

	//Almacenes
	[OperationContract]
	Task<List<Almacen>> ListaAlmacenes();
	[OperationContract]
	Task<Almacen> GetAlmacen(int Id);
	[OperationContract]
	Task<Almacen> CreateAlmacen(string json);
	[OperationContract]
	Task<Almacen> EditAlmacen(string json);
	[OperationContract]
	Task<Almacen> DeleteAlmacen(string json);

	//Productos
	[OperationContract]
	Task<List<Producto>> ListaProductos();
	[OperationContract]
	Task<Producto> GetProducto(int Id);
	[OperationContract]
	Task<Producto> CreateProducto(string json);
	[OperationContract]
	Task<Producto> EditProducto(string json);
	[OperationContract]
	Task<Producto> DeleteProducto(string json);

	//Descuentos
	[OperationContract]
	Task<List<Descuento>> ListaDescuentos();
	[OperationContract]
	Task<Descuento> GetDescuento(int Id);
	[OperationContract]
	Task<Descuento> CreateDescuento(string json);
	[OperationContract]
	Task<Descuento> EditDescuento(string json);
	[OperationContract]
	Task<Descuento> DeleteDescuento(string json);

	//Operadores
	[OperationContract]
	Task<List<Operador>> ListaOperadores();
	[OperationContract]
	Task<Operador> GetOperador(int Id);
	[OperationContract]
	Task<Operador> CreateOperador(string json);
	[OperationContract]
	Task<Operador> EditOperador(string json);
	[OperationContract]
	Task<Operador> DeleteOperador(string json);


	//Vehiculos
	[OperationContract]
	Task<List<Vehiculo>> ListaVehiculos();
	[OperationContract]
	Task<Vehiculo> GetVehiculo(int Id);
	[OperationContract]
	Task<Vehiculo> CreateVehiculo(string json);
	[OperationContract]
	Task<Vehiculo> EditVehiculo(string json);
	[OperationContract]
	Task<Vehiculo> DeleteVehiculo(string json);

	//Guias
	[OperationContract]
	Task<List<Guia>> ListaGuias();
	[OperationContract]
	Task<Guia> GetGuia(int Id);
	[OperationContract]
	Task<Guia> CreateGuia(string json);

	//Cliente

	[OperationContract]
	Task<List<Cliente>> ListaClientes();
	[OperationContract]
	Task<Cliente> GetCliente(int Id);
	[OperationContract]
	Task<Cliente> CreateCliente(string json);
	[OperationContract]
	Task<Cliente> EditCliente(string json);
	[OperationContract]
	Task<Cliente> DeleteCliente(string json);




	// TODO: agregue aquí sus operaciones de servicio
}

// Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
[DataContract]
public class CompositeType
{
	bool boolValue = true;
	string stringValue = "Hello ";

	[DataMember]
	public bool BoolValue
	{
		get { return boolValue; }
		set { boolValue = value; }
	}

	[DataMember]
	public string StringValue
	{
		get { return stringValue; }
		set { stringValue = value; }
	}
}
