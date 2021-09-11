using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TalycapGlobalData;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class Service : IService
{
	public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}


	//Pais
	public async Task<List<Pai>>ListaPaises()
	{
		var ls = new List<Pai>();
		var rs = new Pai();
		var Uri = "https://localhost:44386/Pais";

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<List<Pai>>(response);

			foreach (var post in posts)
			{
				rs.Id = post.Id;
				rs.Nombre = post.Nombre;
				rs.CodArea = post.CodArea;
				ls.Add(rs);
			}


		}

		return ls;

	}

	public async Task<Pai>GetPais(int Id)
    {
		var rs = new Pai();
		var Uri = "https://localhost:44386/Pais/api/Details/" + Id.ToString();

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Pai>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;
			rs.CodArea = posts.CodArea;

		}

		return rs;
	}

	public async Task<Pai> CreatePais(string json)
	{
		var rs = new Pai();
		var Uri = "https://localhost:44386/Pais/api/Post/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Pai>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;
			rs.CodArea = posts.CodArea;

		}

		return rs;
	}

	public async Task<Pai> EditPais(string json)
	{
		var rs = new Pai();
		var Uri = "https://localhost:44386/Pais/api/Put/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Pai>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;

		}

		return rs;
	}

	public async Task<Pai> DeletePais(string json)
	{
		var rs = new Pai();
		var Uri = "https://localhost:44386/Pais/api/Delete/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Pai>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;
			rs.CodArea = posts.CodArea;

		}

		return rs;
	}

	//Region

	public async Task<List<Region>> ListaRegiones()
	{
		var ls = new List<Region>();
		var rs = new Region();
		var Uri = "https://localhost:44386/Regions";

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<List<Region>>(response);

			foreach (var post in posts)
			{
				rs.Id = post.Id;
				rs.Nombre = post.Nombre;
				rs.PaisId = post.PaisId;
				ls.Add(rs);
			}


		}

		return ls;

	}

	public async Task<Region> GetRegion(int Id)
	{
		var rs = new Region();
		var Uri = "https://localhost:44386/Regions/api/Details/" + Id.ToString();

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Region>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;
			rs.PaisId = posts.PaisId;

		}

		return rs;
	}

	public async Task<Region> CreateRegion(string json)
	{
		var rs = new Region();
		var Uri = "https://localhost:44386/Regions/api/Post/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Region>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;
			rs.PaisId = posts.PaisId;
		}

		return rs;
	}

	public async Task<Region> EditRegion(string json)
	{
		var rs = new Region();
		var Uri = "https://localhost:44386/Regions/api/Put/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Region>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;
			rs.PaisId = posts.PaisId;

		}

		return rs;
	}

	public async Task<Region> DeleteRegion(string json)
	{
		var rs = new Region();
		var Uri = "https://localhost:44386/Regions/api/Delete/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Region>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;

		}

		return rs;
	}

	//Ciudades

	public async Task<List<Ciudad>> ListaCiudades()
	{
		var ls = new List<Ciudad>();
		var rs = new Ciudad();
		var Uri = "https://localhost:44386/Ciudads";

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<List<Ciudad>>(response);

			foreach (var post in posts)
			{
				rs.Id = post.Id;
				rs.Nombre = post.Nombre;
				rs.RegionId = post.RegionId;
				ls.Add(rs);
			}


		}

		return ls;

	}

	public async Task<Ciudad> GetCiudad(int Id)
	{
		var rs = new Ciudad();
		var Uri = "https://localhost:44386/Ciudads/api/Details/" + Id.ToString();

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Ciudad>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;
			rs.RegionId = posts.RegionId;


		}

		return rs;
	}

	public async Task<Ciudad> CreateCiudad(string json)
	{
		var rs = new Ciudad();
		var Uri = "https://localhost:44386/Ciudads/api/Post/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Ciudad>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;
			rs.RegionId = posts.RegionId;

		}

		return rs;
	}

	public async Task<Ciudad> EditCiudad(string json)
	{
		var rs = new Ciudad();
		var Uri = "https://localhost:44386/Ciudads/api/Put/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Ciudad>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;
			rs.RegionId = posts.RegionId;

		}

		return rs;
	}

	public async Task<Ciudad> DeleteCiudad(string json)
	{
		var rs = new Ciudad();
		var Uri = "https://localhost:44386/Ciudads/api/Delete/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Ciudad>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;
			rs.RegionId = posts.RegionId;

		}

		return rs;
	}



	//Pais
	public async Task<List<Cliente>> ListaClientes()
	{
		var ls = new List<Cliente>();
		var rs = new Cliente();
		var Uri = "https://localhost:44386/Clientes";

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<List<Cliente>>(response);

			foreach (var post in posts)
			{
				rs.Id = post.Id;
				rs.Nit = post.Nit;
				rs.Nombre = post.Nombre;
				rs.Direccion = post.Direccion;
				rs.Telefono = post.Telefono;
				rs.Indicativo = post.Indicativo;
				rs.CiudadId = post.CiudadId;
				ls.Add(rs);
			}


		}

		return ls;

	}

	public async Task<Cliente> GetCliente(int Id)
	{
		var rs = new Cliente();
		var Uri = "https://localhost:44386/Clientes/api/Details/" + Id.ToString();

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Cliente>(response);
			rs.Id = posts.Id;
			rs.Nit = posts.Nit;
			rs.Nombre = posts.Nombre;
			rs.Direccion = posts.Direccion;
			rs.Telefono = posts.Telefono;
			rs.Indicativo = posts.Indicativo;
			rs.CiudadId = posts.CiudadId;

		}

		return rs;
	}

	public async Task<Cliente> CreateCliente(string json)
	{
		var rs = new Cliente();
		var Uri = "https://localhost:44386/Clientes/api/Post/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Cliente>(response);
			rs.Id = posts.Id;
			rs.Nit = posts.Nit;
			rs.Nombre = posts.Nombre;
			rs.Direccion = posts.Direccion;
			rs.Telefono = posts.Telefono;
			rs.Indicativo = posts.Indicativo;
			rs.CiudadId = posts.CiudadId;

		}

		return rs;
	}

	public async Task<Cliente> EditCliente(string json)
	{
		var rs = new Cliente();
		var Uri = "https://localhost:44386/Clientes/api/Put/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Cliente>(response);
			rs.Id = posts.Id;
			rs.Nit = posts.Nit;
			rs.Nombre = posts.Nombre;
			rs.Direccion = posts.Direccion;
			rs.Telefono = posts.Telefono;
			rs.Indicativo = posts.Indicativo;
			rs.CiudadId = posts.CiudadId;

		}

		return rs;
	}

	public async Task<Cliente> DeleteCliente(string json)
	{
		var rs = new Cliente();
		var Uri = "https://localhost:44386/Clientes/api/Delete/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Cliente>(response);
			rs.Id = posts.Id;
			rs.Nit = posts.Nit;
			rs.Nombre = posts.Nombre;
			rs.Direccion = posts.Direccion;
			rs.Telefono = posts.Telefono;
			rs.Indicativo = posts.Indicativo;
			rs.CiudadId = posts.CiudadId;

		}
		return rs;
	}



	//Tipo Almacen

	public async Task<List<TipoAlmacen>> ListaTipoAlmacen()
	{
		var ls = new List<TipoAlmacen>();
		var rs = new TipoAlmacen();
		var Uri = "https://localhost:44386/TipoAlmacen";

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<List<TipoAlmacen>>(response);

			foreach (var post in posts)
			{
				rs.Id = post.Id;
				rs.Nombre = post.Nombre;
				ls.Add(rs);
			}


		}

		return ls;

	}

	public async Task<TipoAlmacen> GetTipoAlmacen(int Id)
	{
		var rs = new TipoAlmacen();
		var Uri = "https://localhost:44386/TipoAlmacen/api/Details/" + Id.ToString();

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<TipoAlmacen>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;

		}

		return rs;
	}

	public async Task<TipoAlmacen> CreateTipoAlmacen(string json)
	{
		var rs = new TipoAlmacen();
		var Uri = "https://localhost:44386/TipoAlmacen/api/Post/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<TipoAlmacen>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;

		}

		return rs;
	}

	public async Task<TipoAlmacen> EditTipoAlmacen(string json)
	{
		var rs = new TipoAlmacen();
		var Uri = "https://localhost:44386/TipoAlmacen/api/Put/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<TipoAlmacen>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;

		}

		return rs;
	}

	public async Task<TipoAlmacen> DeleteTipoAlmacen(string json)
	{
		var rs = new TipoAlmacen();
		var Uri = "https://localhost:44386/TipoAlmacen/api/Delete/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<TipoAlmacen>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;

		}

		return rs;
	}


	//Tipo Productos

	public async Task<List<TipoProducto>> ListaTipoProductos()
	{
		var ls = new List<TipoProducto>();
		var rs = new TipoProducto();
		var Uri = "https://localhost:44386/TipoProductos";

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<List<TipoProducto>>(response);

			foreach (var post in posts)
			{
				rs.Id = post.Id;
				rs.Nombre = post.Nombre;
				ls.Add(rs);
			}


		}

		return ls;

	}

	public async Task<TipoProducto> GetTipoProducto(int Id)
	{
		var rs = new TipoProducto();
		var Uri = "https://localhost:44386/TipoProductos/api/Details/" + Id.ToString();

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<TipoProducto>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;

		}

		return rs;
	}

	public async Task<TipoProducto> CreateTipoProducto(string json)
	{
		var rs = new TipoProducto();
		var Uri = "https://localhost:44386/TipoProductos/api/Post/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<TipoProducto>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;

		}

		return rs;
	}

	public async Task<TipoProducto> EditTipoProducto(string json)
	{
		var rs = new TipoProducto();
		var Uri = "https://localhost:44386/TipoProducto/api/Put/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<TipoProducto>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;

		}

		return rs;
	}

	public async Task<TipoProducto> DeleteTipoProducto(string json)
	{
		var rs = new TipoProducto();
		var Uri = "https://localhost:44386/TipoProductos/api/Delete/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<TipoProducto>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;

		}

		return rs;
	}


	//Tipo Envio

	public async Task<List<TipoEnvio>> ListaTipoEnvios()
	{
		var ls = new List<TipoEnvio>();
		var rs = new TipoEnvio();
		var Uri = "https://localhost:44386/TipoEnvios";

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<List<TipoEnvio>>(response);

			foreach (var post in posts)
			{
				rs.Id = post.Id;
				rs.Nombre = post.Nombre;
				ls.Add(rs);
			}


		}

		return ls;

	}

	public async Task<TipoEnvio> GetTipoEnvio(int Id)
	{
		var rs = new TipoEnvio();
		var Uri = "https://localhost:44386/TipoEnvios/api/Details/" + Id.ToString();

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<TipoEnvio>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;

		}

		return rs;
	}

	public async Task<TipoEnvio> CreateTipoEnvio(string json)
	{
		var rs = new TipoEnvio();
		var Uri = "https://localhost:44386/TipoEnvios/api/Post/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<TipoEnvio>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;

		}

		return rs;
	}

	public async Task<TipoEnvio> EditTipoEnvio(string json)
	{
		var rs = new TipoEnvio();
		var Uri = "https://localhost:44386/TipoEnvios/api/Put/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<TipoEnvio>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;

		}

		return rs;
	}

	public async Task<TipoEnvio> DeleteTipoEnvio(string json)
	{
		var rs = new TipoEnvio();
		var Uri = "https://localhost:44386/TipoEnvios/api/Delete/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<TipoEnvio>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;

		}

		return rs;
	}


	//Tipo Documentos

	public async Task<List<TipoDoc>> ListaTipoDocs()
	{
		var ls = new List<TipoDoc>();
		var rs = new TipoDoc();
		var Uri = "https://localhost:44386/TipoDocs";

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<List<TipoDoc>>(response);

			foreach (var post in posts)
			{
				rs.Id = post.Id;
				rs.Nombre = post.Nombre;
				ls.Add(rs);
			}


		}

		return ls;

	}

	public async Task<TipoDoc> GetTipoDoc(int Id)
	{
		var rs = new TipoDoc();
		var Uri = "https://localhost:44386/TipoDocs/api/Details/" + Id.ToString();

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<TipoDoc>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;

		}

		return rs;
	}

	public async Task<TipoDoc> CreateTipoDoc(string json)
	{
		var rs = new TipoDoc();
		var Uri = "https://localhost:44386/TipoDocs/api/Post/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<TipoDoc>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;

		}

		return rs;
	}

	public async Task<TipoDoc> EditTipoDoc(string json)
	{
		var rs = new TipoDoc();
		var Uri = "https://localhost:44386/TipoDocs/api/Put/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<TipoDoc>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;

		}

		return rs;
	}

	public async Task<TipoDoc> DeleteTipoDoc(string json)
	{
		var rs = new TipoDoc();
		var Uri = "https://localhost:44386/TipoDocs/api/Delete/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<TipoDoc>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;

		}

		return rs;
	}


	//Tipo Vehiculos

	public async Task<List<TipoVehiculo>> ListaTipoVehiculos()
	{
		var ls = new List<TipoVehiculo>();
		var rs = new TipoVehiculo();
		var Uri = "https://localhost:44386/TipoVehiculos";

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<List<TipoVehiculo>>(response);

			foreach (var post in posts)
			{
				rs.Id = post.Id;
				rs.Nombre = post.Nombre;
				ls.Add(rs);
			}


		}

		return ls;

	}

	public async Task<TipoVehiculo> GetTipoVehiculo(int Id)
	{
		var rs = new TipoVehiculo();
		var Uri = "https://localhost:44386/TipoVehiculos/api/Details/" + Id.ToString();

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<TipoVehiculo>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;

		}

		return rs;
	}

	public async Task<TipoVehiculo> CreateTipoVehiculo(string json)
	{
		var rs = new TipoVehiculo();
		var Uri = "https://localhost:44386/TipoVehiculos/api/Post/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<TipoVehiculo>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;

		}

		return rs;
	}

	public async Task<TipoVehiculo> EditTipoVehiculo(string json)
	{
		var rs = new TipoVehiculo();
		var Uri = "https://localhost:44386/TipoVehiculos/api/Put/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<TipoVehiculo>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;

		}

		return rs;
	}

	public async Task<TipoVehiculo> DeleteTipoVehiculo(string json)
	{
		var rs = new TipoVehiculo();
		var Uri = "https://localhost:44386/TipoVehiculos/api/Delete/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<TipoVehiculo>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;

		}

		return rs;
	}


	//Estados
	public async Task<List<Estado>> ListaEstados()
	{
		var ls = new List<Estado>();
		var rs = new Estado();
		var Uri = "https://localhost:44386/Estados";

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<List<Estado>>(response);

			foreach (var post in posts)
			{
				rs.Id = post.Id;
				rs.Nombre = post.Nombre;
				ls.Add(rs);
			}


		}

		return ls;

	}

	public async Task<Estado> GetEstado(int Id)
	{
		var rs = new Estado();
		var Uri = "https://localhost:44386/Estados/api/Details/" + Id.ToString();

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Estado>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;

		}

		return rs;
	}

	public async Task<Estado> CreateEstado(string json)
	{
		var rs = new Estado();
		var Uri = "https://localhost:44386/Estados/api/Post/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Estado>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;

		}

		return rs;
	}

	public async Task<Estado> EditEstado(string json)
	{
		var rs = new Estado();
		var Uri = "https://localhost:44386/Estados/api/Put/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Estado>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;

		}

		return rs;
	}

	public async Task<Estado> DeleteEstado(string json)
	{
		var rs = new Estado();
		var Uri = "https://localhost:44386/Estados/api/Delete/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Estado>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;

		}

		return rs;
	}


	//Consecutivo

	public async Task<ConsecutivoGuia> GetConsecutivo(int TipoEnvioId)
	{
		var rs = new ConsecutivoGuia();
		var Uri = "https://localhost:44386/ConsecutivoGuias/api/Details/" + TipoEnvioId.ToString();

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<ConsecutivoGuia>(response);
			rs.TipoEnvioId = posts.TipoEnvioId;
			rs.Consecutivo = posts.Consecutivo;

		}

		return rs;
	}

	public async Task<ConsecutivoGuia> CreateConsecutivo(string json)
	{
		var rs = new ConsecutivoGuia();
		var Uri = "https://localhost:44386/ConsecutivoGuias/api/Post/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<ConsecutivoGuia>(response);
			rs.TipoEnvioId = posts.TipoEnvioId;
			rs.Consecutivo = posts.Consecutivo;

		}

		return rs;
	}

	public async Task<ConsecutivoGuia> EditConsecutivo(string json)
	{
		var rs = new ConsecutivoGuia();
		var Uri = "https://localhost:44386/ConsecutivoGuias/api/Put/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<ConsecutivoGuia>(response);
			rs.TipoEnvioId = posts.TipoEnvioId;
			rs.Consecutivo = posts.Consecutivo;

		}

		return rs;
	}

	//Almacenes


	public async Task<List<Almacen>> ListaAlmacenes()
	{
		var ls = new List<Almacen>();
		var rs = new Almacen();
		var Uri = "https://localhost:44386/Almacens";

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<List<Almacen>>(response);

			foreach (var post in posts)
			{
				rs.Id = post.Id;
				rs.Nombre = post.Nombre;
				rs.TipoAlmacenId = post.TipoAlmacenId;
				rs.CiudadId = post.CiudadId;
				ls.Add(rs);
			}


		}

		return ls;

	}

	public async Task<Almacen> GetAlmacen(int Id)
	{
		var rs = new Almacen();
		var Uri = "https://localhost:44386/Almacens/api/Details/" + Id.ToString();

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Almacen>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;

		}

		return rs;
	}

	public async Task<Almacen> CreateAlmacen(string json)
	{
		var rs = new Almacen();
		var Uri = "https://localhost:44386/Almacens/api/Post/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Almacen>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;
			rs.TipoAlmacenId = posts.TipoAlmacenId;
			rs.CiudadId = posts.CiudadId;

		}

		return rs;
	}

	public async Task<Almacen> EditAlmacen(string json)
	{
		var rs = new Almacen();
		var Uri = "https://localhost:44386/Almacens/api/Put/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Almacen>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;
			rs.TipoAlmacenId = posts.TipoAlmacenId;
			rs.CiudadId = posts.CiudadId;

		}

		return rs;
	}

	public async Task<Almacen> DeleteAlmacen(string json)
	{
		var rs = new Almacen();
		var Uri = "https://localhost:44386/Almacens/api/Delete/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Almacen>(response);
			rs.Id = posts.Id;
			rs.Nombre = posts.Nombre;
			rs.TipoAlmacenId = posts.TipoAlmacenId;
			rs.CiudadId = posts.CiudadId;

		}

		return rs;
	}


	//Productos

	public async Task<List<Producto>> ListaProductos()
	{
		var ls = new List<Producto>();
		var rs = new Producto();
		var Uri = "https://localhost:44386/Productos";

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<List<Producto>>(response);

			foreach (var post in posts)
			{
				rs.Id = post.Id;
				rs.CodRef = post.CodRef;
				rs.Nombre = post.Nombre;
				rs.Descripcion = post.Descripcion;
				rs.TipoProductoId = post.TipoProductoId;
				rs.AlmacenId = post.AlmacenId;
				rs.Precio = post.Precio;
				ls.Add(rs);
			}


		}

		return ls;

	}

	public async Task<Producto> GetProducto(int Id)
	{
		var rs = new Producto();
		var Uri = "https://localhost:44386/Productos/api/Details/" + Id.ToString();

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Producto>(response);
			rs.Id = posts.Id;
			rs.CodRef = posts.CodRef;
			rs.Nombre = posts.Nombre;
			rs.Descripcion = posts.Descripcion;
			rs.TipoProductoId = posts.TipoProductoId;
			rs.AlmacenId = posts.AlmacenId;
			rs.Precio = posts.Precio;
		}

		return rs;
	}

	public async Task<Producto> CreateProducto(string json)
	{
		var rs = new Producto();
		var Uri = "https://localhost:44386/Productos/api/Post/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Producto>(response);
			rs.Id = posts.Id;
			rs.CodRef = posts.CodRef;
			rs.Nombre = posts.Nombre;
			rs.Descripcion = posts.Descripcion;
			rs.TipoProductoId = posts.TipoProductoId;
			rs.AlmacenId = posts.AlmacenId;
			rs.Precio = posts.Precio;
		}

		return rs;
	}

	public async Task<Producto> EditProducto(string json)
	{
		var rs = new Producto();
		var Uri = "https://localhost:44386/Productos/api/Put/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Producto>(response);
			rs.Id = posts.Id;
			rs.CodRef = posts.CodRef;
			rs.Nombre = posts.Nombre;
			rs.Descripcion = posts.Descripcion;
			rs.TipoProductoId = posts.TipoProductoId;
			rs.AlmacenId = posts.AlmacenId;
			rs.Precio = posts.Precio;
		}

		return rs;
	}

	public async Task<Producto> DeleteProducto(string json)
	{
		var rs = new Producto();
		var Uri = "https://localhost:44386/Productos/api/Delete/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Producto>(response);
			rs.Id = posts.Id;
			rs.CodRef = posts.CodRef;
			rs.Nombre = posts.Nombre;
			rs.Descripcion = posts.Descripcion;
			rs.TipoProductoId = posts.TipoProductoId;
			rs.AlmacenId = posts.AlmacenId;
			rs.Precio = posts.Precio;
		}

		return rs;
	}


	//Descuentos
	public async Task<List<Descuento>> ListaDescuentos()
	{
		var ls = new List<Descuento>();
		var rs = new Descuento();
		var Uri = "https://localhost:44386/Descuentos";

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<List<Descuento>>(response);

			foreach (var post in posts)
			{
				rs.Id = post.Id;
				rs.Descripcion = post.Descripcion;
				rs.Valor = post.Valor;
				rs.CantidadMax = post.CantidadMax;
				rs.TipoEnvioId = post.TipoEnvioId;
				ls.Add(rs);
			}


		}

		return ls;

	}

	public async Task<Descuento> GetDescuento(int Id)
	{
		var rs = new Descuento();
		var Uri = "https://localhost:44386/Descuentos/api/Details/" + Id.ToString();

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Descuento>(response);
			rs.Id = posts.Id;
			rs.Descripcion = posts.Descripcion;
			rs.Valor = posts.Valor;
			rs.CantidadMax = posts.CantidadMax;
			rs.TipoEnvioId = posts.TipoEnvioId;
		}

		return rs;
	}

	public async Task<Descuento> CreateDescuento(string json)
	{
		var rs = new Descuento();
		var Uri = "https://localhost:44386/Descuentos/api/Post/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Descuento>(response);
			rs.Id = posts.Id;
			rs.Descripcion = posts.Descripcion;
			rs.Valor = posts.Valor;
			rs.CantidadMax = posts.CantidadMax;
			rs.TipoEnvioId = posts.TipoEnvioId;
		}

		return rs;
	}

	public async Task<Descuento> EditDescuento(string json)
	{
		var rs = new Descuento();
		var Uri = "https://localhost:44386/Descuentos/api/Put/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Descuento>(response);
			rs.Id = posts.Id;
			rs.Descripcion = posts.Descripcion;
			rs.Valor = posts.Valor;
			rs.CantidadMax = posts.CantidadMax;
			rs.TipoEnvioId = posts.TipoEnvioId;
		}

		return rs;
	}

	public async Task<Descuento> DeleteDescuento(string json)
	{
		var rs = new Descuento();
		var Uri = "https://localhost:44386/Descuentos/api/Delete/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Descuento>(response);
			rs.Id = posts.Id;
			rs.Descripcion = posts.Descripcion;
			rs.Valor = posts.Valor;
			rs.CantidadMax = posts.CantidadMax;
			rs.TipoEnvioId = posts.TipoEnvioId;
		}

		return rs;
	}


	//Operadores

	public async Task<List<Operador>> ListaOperadores()
	{
		var ls = new List<Operador>();
		var rs = new Operador();
		var Uri = "https://localhost:44386/Operadores";

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<List<Operador>>(response);

			foreach (var post in posts)
			{
				rs.Id = post.Id;
				rs.Nombres = post.Nombres;
				rs.NumDoc = post.NumDoc;
				rs.TipoDocId = post.TipoDocId;
				ls.Add(rs);
			}


		}

		return ls;

	}

	public async Task<Operador> GetOperador(int Id)
	{
		var rs = new Operador();
		var Uri = "https://localhost:44386/Operadores/api/Details/" + Id.ToString();

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Operador>(response);
			rs.Id = posts.Id;
			rs.Nombres = posts.Nombres;
			rs.NumDoc = posts.NumDoc;
			rs.TipoDocId = posts.TipoDocId;

		}

		return rs;
	}

	public async Task<Operador> CreateOperador(string json)
	{
		var rs = new Operador();
		var Uri = "https://localhost:44386/Operadores/api/Post/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Operador>(response);
			rs.Id = posts.Id;
			rs.Nombres = posts.Nombres;
			rs.NumDoc = posts.NumDoc;
			rs.TipoDocId = posts.TipoDocId;

		}

		return rs;
	}

	public async Task<Operador> EditOperador(string json)
	{
		var rs = new Operador();
		var Uri = "https://localhost:44386/Operadores/api/Put/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Operador>(response);
			rs.Id = posts.Id;
			rs.Nombres = posts.Nombres;
			rs.NumDoc = posts.NumDoc;
			rs.TipoDocId = posts.TipoDocId;

		}

		return rs;
	}

	public async Task<Operador> DeleteOperador(string json)
	{
		var rs = new Operador();
		var Uri = "https://localhost:44386/Operadores/api/Delete/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Operador>(response);
			rs.Id = posts.Id;
			rs.Nombres = posts.Nombres;
			rs.NumDoc = posts.NumDoc;
			rs.TipoDocId = posts.TipoDocId;

		}

		return rs;
	}


	//Vehiculos

	public async Task<List<Vehiculo>> ListaVehiculos()
	{
		var ls = new List<Vehiculo>();
		var rs = new Vehiculo();
		var Uri = "https://localhost:44386/Vehiculos";

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<List<Vehiculo>>(response);

			foreach (var post in posts)
			{
				rs.Id = post.Id;
				rs.Descripcion = post.Descripcion;
				rs.Matricula = post.Matricula;
				rs.TipoVehiculoId = post.TipoVehiculoId;
				ls.Add(rs);
			}


		}

		return ls;

	}

	public async Task<Vehiculo> GetVehiculo(int Id)
	{
		var rs = new Vehiculo();
		var Uri = "https://localhost:44386/Vehiculos/api/Details/" + Id.ToString();

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Vehiculo>(response);
			rs.Id = posts.Id;
			rs.Descripcion = posts.Descripcion;
			rs.Matricula = posts.Matricula;
			rs.TipoVehiculoId = posts.TipoVehiculoId;

		}

		return rs;
	}

	public async Task<Vehiculo> CreateVehiculo(string json)
	{
		var rs = new Vehiculo();
		var Uri = "https://localhost:44386/Vehiculos/api/Post/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Vehiculo>(response);
			rs.Id = posts.Id;
			rs.Descripcion = posts.Descripcion;
			rs.Matricula = posts.Matricula;
			rs.TipoVehiculoId = posts.TipoVehiculoId;

		}

		return rs;
	}

	public async Task<Vehiculo> EditVehiculo(string json)
	{
		var rs = new Vehiculo();
		var Uri = "https://localhost:44386/Vehiculos/api/Put/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Vehiculo>(response);
			rs.Id = posts.Id;
			rs.Descripcion = posts.Descripcion;
			rs.Matricula = posts.Matricula;
			rs.TipoVehiculoId = posts.TipoVehiculoId;

		}

		return rs;
	}

	public async Task<Vehiculo> DeleteVehiculo(string json)
	{
		var rs = new Vehiculo();
		var Uri = "https://localhost:44386/Vehiculos/api/Delete/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Vehiculo>(response);
			rs.Id = posts.Id;
			rs.Descripcion = posts.Descripcion;
			rs.Matricula = posts.Matricula;
			rs.TipoVehiculoId = posts.TipoVehiculoId;

		}

		return rs;
	}


	//Guias

	public async Task<List<Guia>> ListaGuias()
	{
		var ls = new List<Guia>();
		var rs = new Guia();
		var Uri = "https://localhost:44386/Guias";

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<List<Guia>>(response);

			foreach (var post in posts)
			{
				rs.Id = post.Id;
				rs.NumGuia = post.NumGuia;
				rs.ClienteId = post.ClienteId;
				rs.PruductoId = post.PruductoId;
				rs.Cantidad = post.Cantidad;
				rs.PrecioUnit = post.PrecioUnit;
				rs.TotalNeto = post.TotalNeto;
				rs.PorcDesc = post.PorcDesc;
				rs.ValorDesc = post.ValorDesc;
				rs.TotalEnvio = post.TotalEnvio;
				rs.AlmacenId = post.AlmacenId;
				rs.VehiculoId = post.VehiculoId;
				rs.OperadorId = post.OperadorId;
				rs.FechaRegistro = post.FechaRegistro;
				rs.FechaEntrega = post.FechaEntrega;
				rs.EstadoId = post.EstadoId;
				rs.TipoEnvioId = post.TipoEnvioId;
				ls.Add(rs);
			}


		}

		return ls;

	}

	public async Task<Guia> GetGuia(int Id)
	{
		var rs = new Guia();
		var Uri = "https://localhost:44386/Guias/api/Details/" + Id.ToString();

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Guia>(response);
			rs.Id = posts.Id;
			rs.NumGuia = posts.NumGuia;
			rs.ClienteId = posts.ClienteId;
			rs.PruductoId = posts.PruductoId;
			rs.Cantidad = posts.Cantidad;
			rs.PrecioUnit = posts.PrecioUnit;
			rs.TotalNeto = posts.TotalNeto;
			rs.PorcDesc = posts.PorcDesc;
			rs.ValorDesc = posts.ValorDesc;
			rs.TotalEnvio = posts.TotalEnvio;
			rs.AlmacenId = posts.AlmacenId;
			rs.VehiculoId = posts.VehiculoId;
			rs.OperadorId = posts.OperadorId;
			rs.FechaRegistro = posts.FechaRegistro;
			rs.FechaEntrega = posts.FechaEntrega;
			rs.EstadoId = posts.EstadoId;
			rs.TipoEnvioId = posts.TipoEnvioId;

		}

		return rs;
	}

	public async Task<Guia> CreateGuia(string json)
	{
		var rs = new Guia();
		var Uri = "https://localhost:44386/Guias/api/Post/" + json;

		using (var http = new HttpClient())
		{
			var response = await http.GetStringAsync(Uri);
			var posts = JsonConvert.DeserializeObject<Guia>(response);
			rs.Id = posts.Id;
			rs.NumGuia = posts.NumGuia;
			rs.ClienteId = posts.ClienteId;
			rs.PruductoId = posts.PruductoId;
			rs.Cantidad = posts.Cantidad;
			rs.PrecioUnit = posts.PrecioUnit;
			rs.TotalNeto = posts.TotalNeto;
			rs.PorcDesc = posts.PorcDesc;
			rs.ValorDesc = posts.ValorDesc;
			rs.TotalEnvio = posts.TotalEnvio;
			rs.AlmacenId = posts.AlmacenId;
			rs.VehiculoId = posts.VehiculoId;
			rs.OperadorId = posts.OperadorId;
			rs.FechaRegistro = posts.FechaRegistro;
			rs.FechaEntrega = posts.FechaEntrega;
			rs.EstadoId = posts.EstadoId;
			rs.TipoEnvioId = posts.TipoEnvioId;

		}

		return rs;
	}



















}
