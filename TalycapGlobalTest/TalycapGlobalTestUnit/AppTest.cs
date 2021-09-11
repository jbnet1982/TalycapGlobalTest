using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using TalycapGlobalData;
using TalycapGlobalTestUnit.TalycapGlobalWCF;
using System.Text.Json;

namespace TalycapGlobalTestUnit
{
    [TestClass]
    public class AppTest
    {
        ServiceClient ws = new ServiceClient();
        [TestMethod]
        public void Pais()
        {
            var resp = "Ok";
            var opcion = 3;
            var Id = 1;
            var Nombre = "Venezuela";
            var CodArea = "+58";
            var rs = new Pai();
            var json = "";

            try
            {
                switch (opcion)
                {
                    case 1:
                        var ls = ws.ListaPaisesAsync();
                        break;
                    case 2:
                        var res1 = ws.GetPaisAsync(Id);
                        break;
                    case 3:
                        rs.Id = 0;
                        rs.Nombre = Nombre;
                        rs.CodArea = CodArea;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        string[] charsToRemove = new string[] { "+" };
                        foreach (var c in charsToRemove)
                        {
                            json = json.Replace(c, string.Empty);
                        }
                        var res2 = ws.CreatePaisAsync(json);
                        break;
                    case 4:
                        rs.Id = Id;
                        rs.Nombre = Nombre;
                        rs.CodArea = CodArea;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res3 = ws.EditPaisAsync(json);
                        break;
                    case 5:
                        rs.Id = Id;
                        rs.Nombre = Nombre;
                        rs.CodArea = CodArea;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res4 = ws.DeletePaisAsync(json);
                        break;
                    default:
                        resp = "Error en Operación";
                        break;
                }

            }
            catch (Exception ex)
            {
                resp = ex.Message.ToString();
            }

            Assert.AreEqual("Ok", resp);

        }

        [TestMethod]
        public void Regiones()
        {

            var resp = "Ok";
            var opcion = 1;
            var Id = 1;
            var Nombre = "Bogotá D.C";
            var PaisId = 1;
            var rs = new Region();
            var json = "";

            try
            {
                switch (opcion)
                {
                    case 1:
                        var ls = ws.ListaRegionesAsync();
                        break;
                    case 2:
                        var res1 = ws.GetRegionAsync(Id);
                        break;
                    case 3:
                        rs.Id = 0;
                        rs.Nombre = Nombre;
                        rs.PaisId = PaisId;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res2 = ws.CreateRegionAsync(json);
                        break;
                    case 4:
                        rs.Id = Id;
                        rs.Nombre = Nombre;
                        rs.PaisId = PaisId;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res3 = ws.EditRegionAsync(json);
                        break;
                    case 5:
                        rs.Id = Id;
                        rs.Nombre = Nombre;
                        rs.PaisId = PaisId;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res4 = ws.DeleteRegionAsync(json);
                        break;
                    default:
                        resp = "Error en Operación";
                        break;
                }

            }
            catch (Exception ex)
            {
                resp = ex.Message.ToString();
            }

            Assert.AreEqual("Ok", resp);

        }

        [TestMethod]
        public void Ciudad()
        {
            var resp = "Ok";
            var opcion = 1;
            var Id = 1;
            var Nombre = "Bogotá";
            var RegionId = 1;
            var rs = new Ciudad();
            var json = "";

            try
            {
                switch (opcion)
                {
                    case 1:
                        var ls = ws.ListaCiudadesAsync();
                        break;
                    case 2:
                        var res1 = ws.GetCiudadAsync(Id);
                        break;
                    case 3:
                        rs.Id = 0;
                        rs.Nombre = Nombre;
                        rs.RegionId = RegionId;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res2 = ws.CreateCiudadAsync(json);
                        break;
                    case 4:
                        rs.Id = Id;
                        rs.Nombre = Nombre;
                        rs.RegionId = RegionId;
                        json = JsonConvert.SerializeObject(rs).ToString();

                        var res3 = ws.EditCiudadAsync(json);
                        break;
                    case 5:
                        rs.Id = Id;
                        rs.Nombre = Nombre;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res4 = ws.DeleteCiudadAsync(json);
                        break;
                    default:
                        resp = "Error en Operación";
                        break;
                }

            }
            catch (Exception ex)
            {
                resp = ex.Message.ToString();
            }

            Assert.AreEqual("Ok", resp);
        }

        [TestMethod]
        public void TipoAlmacen()
        {
            var resp = "";
            var opcion = 0;
            var Id = 0;
            var Nombre = "Bodega";
            var rs = new TipoAlmacen();
            var json = "";

            try
            {
                switch (opcion)
                {
                    case 1:
                        var ls = ws.ListaTipoAlmacenAsync();
                        break;
                    case 2:
                        var res1 = ws.GetTipoAlmacenAsync(Id);
                        break;
                    case 3:
                        rs.Id = 0;
                        rs.Nombre = Nombre;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res2 = ws.CreateTipoAlmacenAsync(json);
                        break;
                    case 4:
                        rs.Id = Id;
                        rs.Nombre = Nombre;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res3 = ws.EditTipoAlmacenAsync(json);
                        break;
                    case 5:
                        rs.Id = Id;
                        rs.Nombre = Nombre;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res4 = ws.DeleteTipoAlmacenAsync(json);
                        break;
                    default:
                        resp = "Error en Operación";
                        break;
                }

            }
            catch (Exception ex)
            {
                resp = ex.Message.ToString();
            }

            Assert.AreEqual("Ok", resp);
        }

        [TestMethod]
        public void Almacen()
        {
            var resp = "";
            var opcion = 0;
            var Id = 0;
            var Nombre = "Galpón 1 Zona Franca";
            var TipoAlmacenId = 1;
            var CiudadId = 1;
            var rs = new Almacen();
            var json = "";

            try
            {
                switch (opcion)
                {
                    case 1:
                        var ls = ws.ListaAlmacenesAsync();
                        break;
                    case 2:
                        var res1 = ws.GetAlmacenAsync(Id);
                        break;
                    case 3:
                        rs.Id = 0;
                        rs.Nombre = Nombre;
                        rs.TipoAlmacenId = TipoAlmacenId;
                        rs.CiudadId = CiudadId;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res2 = ws.CreateAlmacenAsync(json);
                        break;
                    case 4:
                        rs.Id = Id;
                        rs.Nombre = Nombre;
                        rs.TipoAlmacenId = TipoAlmacenId;
                        rs.CiudadId = CiudadId;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res3 = ws.EditAlmacenAsync(json);
                        break;
                    case 5:
                        rs.Id = Id;
                        rs.Nombre = Nombre;
                        rs.TipoAlmacenId = TipoAlmacenId;
                        rs.CiudadId = CiudadId;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res4 = ws.DeleteAlmacenAsync(json);
                        break;
                    default:
                        resp = "Error en Operación";
                        break;
                }

            }
            catch (Exception ex)
            {
                resp = ex.Message.ToString();
            }

            Assert.AreEqual("Ok", resp);
        }

        [TestMethod]
        public void TipoProducto()
        {
            var resp = "";
            var opcion = 0;
            var Id = 0;
            var Nombre = "Nacional";
            var rs = new TipoProducto();
            var json = "";

            try
            {
                switch (opcion)
                {
                    case 1:
                        var ls = ws.ListaTipoProductosAsync();
                        break;
                    case 2:
                        var res1 = ws.GetTipoProductoAsync(Id);
                        break;
                    case 3:
                        rs.Id = 0;
                        rs.Nombre = Nombre;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res2 = ws.CreateTipoProductoAsync(json);
                        break;
                    case 4:
                        rs.Id = Id;
                        rs.Nombre = Nombre;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res3 = ws.EditTipoProductoAsync(json);
                        break;
                    case 5:
                        rs.Id = Id;
                        rs.Nombre = Nombre;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res4 = ws.DeleteTipoProductoAsync(json);
                        break;
                    default:
                        resp = "Error en Operación";
                        break;
                }

            }
            catch (Exception ex)
            {
                resp = ex.Message.ToString();
            }

            Assert.AreEqual("Ok", resp);
        }

        [TestMethod]
        public void Producto()
        {
            var resp = "";
            var opcion = 0;
            var Id = 0;
            var CodRef = "";
            var Nombre = "";
            var Descripcion = "";
            var AlmacenId = 1;
            var TipoProductoId = 1;
            var rs = new Producto();
            var json = "";

            try
            {
                switch (opcion)
                {
                    case 1:
                        var ls = ws.ListaProductosAsync();
                        break;
                    case 2:
                        var res1 = ws.GetProductoAsync(Id);
                        break;
                    case 3:
                        rs.Id = 0;
                        rs.CodRef = CodRef;
                        rs.Nombre = Nombre;
                        rs.Descripcion = Descripcion;
                        rs.AlmacenId = AlmacenId;
                        rs.TipoProductoId = TipoProductoId;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res2 = ws.CreateProductoAsync(json);
                        break;
                    case 4:
                        rs.Id = Id;
                        rs.CodRef = CodRef;
                        rs.Nombre = Nombre;
                        rs.Descripcion = Descripcion;
                        rs.AlmacenId = AlmacenId;
                        rs.TipoProductoId = TipoProductoId;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res3 = ws.EditProductoAsync(json);
                        break;
                    case 5:
                        rs.Id = Id;
                        rs.CodRef = CodRef;
                        rs.Nombre = Nombre;
                        rs.Descripcion = Descripcion;
                        rs.AlmacenId = AlmacenId;
                        rs.TipoProductoId = TipoProductoId;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res4 = ws.DeleteProductoAsync(json);
                        break;
                    default:
                        resp = "Error en Operación";
                        break;
                }

            }
            catch (Exception ex)
            {
                resp = ex.Message.ToString();
            }

            Assert.AreEqual("Ok", resp);
        }

        [TestMethod]
        public void Cliente()
        {
            var resp = "";
            var opcion = 0;
            var Id = 0;
            var Nit = "";
            var Nombre = "";
            var Direccion = "";
            var Telefono = "";
            var Indicativo = "";
            var CiudadId = 1;
            var rs = new Cliente();
            var json = "";

            try
            {
                switch (opcion)
                {
                    case 1:
                        var ls = ws.ListaClientesAsync();
                        break;
                    case 2:
                        var res1 = ws.GetClienteAsync(Id);
                        break;
                    case 3:
                        rs.Id = 0;
                        rs.Nit = Nit;
                        rs.Nombre = Nombre;
                        rs.Direccion = Direccion;
                        rs.Telefono = Telefono;
                        rs.Indicativo = Indicativo;
                        rs.CiudadId = CiudadId;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res2 = ws.CreateClienteAsync(json);
                        break;
                    case 4:
                        rs.Id = Id;
                        rs.Nit = Nit;
                        rs.Nombre = Nombre;
                        rs.Direccion = Direccion;
                        rs.Telefono = Telefono;
                        rs.Indicativo = Indicativo;
                        rs.CiudadId = CiudadId;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res3 = ws.EditClienteAsync(json);
                        break;
                    case 5:
                        rs.Id = Id;
                        rs.Nit = Nit;
                        rs.Nombre = Nombre;
                        rs.Direccion = Direccion;
                        rs.Telefono = Telefono;
                        rs.Indicativo = Indicativo;
                        rs.CiudadId = CiudadId;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res4 = ws.DeleteClienteAsync(json);
                        break;
                    default:
                        resp = "Error en Operación";
                        break;
                }

            }
            catch (Exception ex)
            {
                resp = ex.Message.ToString();
            }

            Assert.AreEqual("Ok", resp);
        }


        [TestMethod] 
        public void TipoDoc()
        {
            var resp = "";
            var opcion = 0;
            var Id = 0;
            var Nombre = "Cédula de Ciudadanía";
            var rs = new TipoDoc();
            var json = "";

            try
            {
                switch (opcion)
                {
                    case 1:
                        var ls = ws.ListaTipoDocsAsync();
                        break;
                    case 2:
                        var res1 = ws.GetTipoDocAsync(Id);
                        break;
                    case 3:
                        rs.Id = 0;
                        rs.Nombre = Nombre;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res2 = ws.CreateTipoDocAsync(json);
                        break;
                    case 4:
                        rs.Id = Id;
                        rs.Nombre = Nombre;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res3 = ws.EditTipoDocAsync(json);
                        break;
                    case 5:
                        rs.Id = Id;
                        rs.Nombre = Nombre;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res4 = ws.DeleteTipoDocAsync(json);
                        break;
                    default:
                        resp = "Error en Operación";
                        break;
                }

            }
            catch (Exception ex)
            {
                resp = ex.Message.ToString();
            }

            Assert.AreEqual("Ok", resp);
        }


        [TestMethod]
        public void Operador()
        {
            var resp = "";
            var opcion = 0;
            var Id = 0;
            var Nombres = "";
            var NumDoc = "";
            var TipoDocId = 1;
            var rs = new Operador();
            var json = "";

            try
            {
                switch (opcion)
                {
                    case 1:
                        var ls = ws.ListaCiudadesAsync();
                        break;
                    case 2:
                        var res1 = ws.GetCiudadAsync(Id);
                        break;
                    case 3:
                        rs.Id = 0;
                        rs.Nombres = Nombres;
                        rs.NumDoc = NumDoc;
                        rs.TipoDocId = TipoDocId;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res2 = ws.CreateCiudadAsync(json);
                        break;
                    case 4:
                        rs.Id = Id;
                        rs.Nombres = Nombres;
                        rs.NumDoc = NumDoc;
                        rs.TipoDocId = TipoDocId;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res3 = ws.EditCiudadAsync(json);
                        break;
                    case 5:
                        rs.Id = Id;
                        rs.Nombres = Nombres;
                        rs.NumDoc = NumDoc;
                        rs.TipoDocId = TipoDocId;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res4 = ws.DeleteCiudadAsync(json);
                        break;
                    default:
                        resp = "Error en Operación";
                        break;
                }

            }
            catch (Exception ex)
            {
                resp = ex.Message.ToString();
            }

            Assert.AreEqual("Ok", resp);
        }


        [TestMethod]
        public void TipoVehiculo()
        {
            var resp = "";
            var opcion = 0;
            var Id = 0;
            var Nombre = "";
            var rs = new TipoVehiculo();
            var json = "";

            try
            {
                switch (opcion)
                {
                    case 1:
                        var ls = ws.ListaTipoVehiculosAsync();
                        break;
                    case 2:
                        var res1 = ws.GetTipoVehiculoAsync(Id);
                        break;
                    case 3:
                        rs.Id = 0;
                        rs.Nombre = Nombre;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res2 = ws.CreateTipoVehiculoAsync(json);
                        break;
                    case 4:
                        rs.Id = Id;
                        rs.Nombre = Nombre;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res3 = ws.EditTipoVehiculoAsync(json);
                        break;
                    case 5:
                        rs.Id = Id;
                        rs.Nombre = Nombre;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res4 = ws.DeleteTipoVehiculoAsync(json);
                        break;
                    default:
                        resp = "Error en Operación";
                        break;
                }

            }
            catch (Exception ex)
            {
                resp = ex.Message.ToString();
            }

            Assert.AreEqual("Ok", resp);
        }

        [TestMethod]

        public void Vehiculo()
        {
            var resp = "";
            var opcion = 0;
            var Id = 0;
            var Descripcion = "";
            var Matricula = "";
            var TipoVehiculoId = 1;
            var rs = new Vehiculo();
            var json = "";

            try
            {
                switch (opcion)
                {
                    case 1:
                        var ls = ws.ListaVehiculosAsync();
                        break;
                    case 2:
                        var res1 = ws.GetVehiculoAsync(Id);
                        break;
                    case 3:
                        rs.Id = 0;
                        rs.Descripcion = Descripcion;
                        rs.Matricula = Matricula;
                        rs.TipoVehiculoId = TipoVehiculoId;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res2 = ws.CreateVehiculoAsync(json);
                        break;
                    case 4:
                        rs.Id = Id;
                        rs.Descripcion = Descripcion;
                        rs.Matricula = Matricula;
                        rs.TipoVehiculoId = TipoVehiculoId;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res3 = ws.EditVehiculoAsync(json);
                        break;
                    case 5:
                        rs.Id = Id;
                        rs.Descripcion = Descripcion;
                        rs.Matricula = Matricula;
                        rs.TipoVehiculoId = TipoVehiculoId;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res4 = ws.DeleteVehiculoAsync(json);
                        break;
                    default:
                        resp = "Error en Operación";
                        break;
                }

            }
            catch (Exception ex)
            {
                resp = ex.Message.ToString();
            }

            Assert.AreEqual("Ok", resp);
        }


        [TestMethod]

        public void TipoEnvio()
        {
            var resp = "";
            var opcion = 0;
            var Id = 0;
            var Nombre = "";
            var rs = new TipoEnvio();
            var json = "";

            try
            {
                switch (opcion)
                {
                    case 1:
                        var ls = ws.ListaTipoEnviosAsync();
                        break;
                    case 2:
                        var res1 = ws.GetTipoEnvioAsync(Id);
                        break;
                    case 3:
                        rs.Id = 0;
                        rs.Nombre = Nombre;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res2 = ws.CreateTipoEnvioAsync(json);
                        break;
                    case 4:
                        rs.Id = Id;
                        rs.Nombre = Nombre;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res3 = ws.EditTipoEnvioAsync(json);
                        break;
                    case 5:
                        rs.Id = Id;
                        rs.Nombre = Nombre;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res4 = ws.DeleteTipoEnvioAsync(json);
                        break;
                    default:
                        resp = "Error en Operación";
                        break;
                }

            }
            catch (Exception ex)
            {
                resp = ex.Message.ToString();
            }

            Assert.AreEqual("Ok", resp);
        }


        [TestMethod]

        public void Descuentos()
        {
            var resp = "";
            var opcion = 0;
            var Id = 0;
            var Descripcion = "";
            var Valor = 0;
            var CantidadMax = 0;
            var TipoEnvioId = 1;
            var rs = new Descuento();
            var json = "";

            try
            {
                switch (opcion)
                {
                    case 1:
                        var ls = ws.ListaDescuentosAsync();
                        break;
                    case 2:
                        var res1 = ws.GetDescuentoAsync(Id);
                        break;
                    case 3:
                        rs.Id = 0;
                        rs.Descripcion = Descripcion;
                        rs.Valor = Valor;
                        rs.CantidadMax = CantidadMax;
                        rs.TipoEnvioId = TipoEnvioId;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res2 = ws.CreateDescuentoAsync(json);
                        break;
                    case 4:
                        rs.Id = Id;
                        rs.Descripcion = Descripcion;
                        rs.Valor = Valor;
                        rs.CantidadMax = CantidadMax;
                        rs.TipoEnvioId = TipoEnvioId;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res3 = ws.EditDescuentoAsync(json);
                        break;
                    case 5:
                        rs.Id = Id;
                        rs.Descripcion = Descripcion;
                        rs.Valor = Valor;
                        rs.CantidadMax = CantidadMax;
                        rs.TipoEnvioId = TipoEnvioId;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res4 = ws.DeleteDescuentoAsync(json);
                        break;
                    default:
                        resp = "Error en Operación";
                        break;
                }

            }
            catch (Exception ex)
            {
                resp = ex.Message.ToString();
            }

            Assert.AreEqual("Ok", resp);
        }

        [TestMethod]
        public void ConsecutivoGuia()
        {
            var resp = "";
            var opcion = 0;
            var TipoEnvioId = 1;
            var Consecutivo = "1000000001";
            var rs = new ConsecutivoGuia();
            var json = "";

            try
            {
                switch (opcion)
                {
                  
                    case 1:
                        var res1 = ws.GetConsecutivoAsync(TipoEnvioId);
                        break;
                    case 2:
                        rs.TipoEnvioId = TipoEnvioId;
                        rs.Consecutivo = Consecutivo;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res2 = ws.CreateConsecutivoAsync(json);
                        break;
                    case 3:
                        rs.TipoEnvioId = TipoEnvioId;
                        rs.Consecutivo = Consecutivo;
                        json = JsonConvert.SerializeObject(rs).ToString();

                        var res3 = ws.EditConsecutivoAsync(json);
                        break;
                    default:
                        resp = "Error en Operación";
                        break;
                }

            }
            catch (Exception ex)
            {
                resp = ex.Message.ToString();
            }

            Assert.AreEqual("Ok", resp);
        }

        [TestMethod]

        public void Estado()
        {
            var resp = "";
            var opcion = 0;
            var Id = 0;
            var Nombre = "";
            var rs = new Estado();
            var json = "";

            try
            {
                switch (opcion)
                {
                    case 1:
                        var ls = ws.ListaEstadosAsync();
                        break;
                    case 2:
                        var res1 = ws.GetEstadoAsync(Id);
                        break;
                    case 3:
                        rs.Id = 0;
                        rs.Nombre = Nombre;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res2 = ws.CreateEstadoAsync(json);
                        break;
                    case 4:
                        rs.Id = Id;
                        rs.Nombre = Nombre;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res3 = ws.EditEstadoAsync(json);
                        break;
                    case 5:
                        rs.Id = Id;
                        rs.Nombre = Nombre;
                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res4 = ws.DeleteEstadoAsync(json);
                        break;
                    default:
                        resp = "Error en Operación";
                        break;
                }

            }
            catch (Exception ex)
            {
                resp = ex.Message.ToString();
            }

            Assert.AreEqual("Ok", resp);
        }


        [TestMethod]
        public void Guia()
        {
            var resp = "";
            var opcion = 0;
            
            var rs = new Guia();
            var json = "";

            try
            {
                switch (opcion)
                {
                    case 1:
                        var ls = ws.ListaGuiasAsync();
                        break;
                    case 2:
                        var Id = 1;
                        var res1 = ws.GetGuiaAsync(Id);
                        break;
                    case 3:


                        var tipoenv = 1;
                        var Cantidad = 1;
                        decimal ValDesc = 0;
                        decimal PorcDesc = 0;
                        decimal TotalEnvio = 0;
                        
                        var num = 1;
                        var cons = "";

                        decimal Precio = 0;
                        var ProductoId = 1;

                        var sqlp = ws.GetProductoAsync(ProductoId);
                        Precio = sqlp.Result.Precio;
                  
                        decimal TotalNeto = Cantidad * Precio;
                        TotalEnvio = Cantidad * Precio;

                        var sql = ws.ListaGuiasAsync();

                        foreach (var rg in sql.Result)
                        {
                            num += 1;
                        }
                    

                        switch (num.ToString().Length)
                        {
                            case 1:
                                cons = tipoenv.ToString() + "00000000" + num.ToString();
                                break;
                            case 2:
                                cons = tipoenv.ToString() + "0000000" + num.ToString();
                                break;
                            case 3:
                                cons = tipoenv.ToString() + "000000" + num.ToString();
                                break;
                            case 4:
                                cons = tipoenv.ToString() + "00000" + num.ToString();
                                break;
                            case 5:
                                cons = tipoenv.ToString() + "0000" + num.ToString();
                                break;
                            case 6:
                                cons = tipoenv.ToString() + "000" + num.ToString();
                                break;
                            case 7:
                                cons = tipoenv.ToString() + "00" + num.ToString();
                                break;
                            case 8:
                                cons = tipoenv.ToString() + "0" + num.ToString();
                                break;
                            case 9:
                                cons = tipoenv.ToString() + num.ToString();
                                break;


                        }

                        if (Cantidad >= 10)
                        {
                            var sql2 = ws.GetDescuentoAsync(tipoenv);

                            PorcDesc = sql2.Result.Valor / 100;
                            ValDesc = TotalEnvio * PorcDesc;
                            TotalEnvio = TotalEnvio - ValDesc;

                        }
                        rs.Id = 0;
                        rs.NumGuia = cons;
                        rs.ClienteId = 1;
                        rs.PruductoId = 1;
                        rs.Cantidad = Cantidad;
                        rs.PrecioUnit =Precio;
                        rs.TotalNeto = TotalNeto;
                        rs.PorcDesc = PorcDesc;
                        rs.ValorDesc = ValDesc;
                        rs.TotalEnvio = TotalEnvio;
                        rs.AlmacenId = 1;
                        rs.VehiculoId = 1;
                        rs.OperadorId = 1;
                        rs.FechaRegistro = System.DateTime.Now;
                        rs.EstadoId = 1;
                        rs.TipoEnvioId = tipoenv;

                        json = JsonConvert.SerializeObject(rs).ToString();
                        var res2 = ws.CreateCiudadAsync(json);

                        var ConsG = new ConsecutivoGuia();
                        ConsG.TipoEnvioId = tipoenv;
                        ConsG.Consecutivo = cons;
                        int gui = 0;
                        var sqlcon = ws.GetConsecutivoAsync(tipoenv);

                        if (cons == sqlcon.Result.Consecutivo.ToString())
                        {
                            json = JsonConvert.SerializeObject(ConsG).ToString();
                            var res3 = ws.CreateConsecutivoAsync(json);

                        }
                        else
                        {
                            json = JsonConvert.SerializeObject(ConsG).ToString();
                            var res3 = ws.EditConsecutivoAsync(json);

                        }
                        break;
                  
                }

            }
            catch (Exception ex)
            {
                resp = ex.Message.ToString();
            }

            Assert.AreEqual("Ok", resp);
        }




    }
}
