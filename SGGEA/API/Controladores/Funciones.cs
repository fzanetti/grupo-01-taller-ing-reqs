using API.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Controladores
{
    public class Funciones
    {
        public static readonly Funcion Monitoreo_de_red_de_energia = new Funcion(1, "Monitoreo de red de energía");
        public static readonly Funcion Alerta_de_fallas_del_sistema = new Funcion(2, "Alerta de fallas del sistema");
        public static readonly Funcion Admin_de_parametros_del_sistema = new Funcion(3, "Admin. de parámetros del sistema");
        public static readonly Funcion Visualizacion_de_la_bitacora_de_fallas_del_sistema = new Funcion(4, "Visualización de la bitácora de fallas del sistema");
        public static readonly Funcion Visualizacion_de_metricas_historicas_de_energia = new Funcion(5, "Visualización de métricas históricas de energía");
        public static readonly Funcion Visualizacion_de_registro_de_actividad_de_usuario = new Funcion(6, "Visualización de registro de actividad de usuario");
        public static readonly Funcion Admin_de_usuarios = new Funcion(7, "Admin. de usuarios");
        public static readonly Funcion Configuracion_de_orden_de_alimentacion_de_energia = new Funcion(8, "Configuración de orden de alimentación de energía");
        public static readonly Funcion Admin_de_Perfiles_de_usuario = new Funcion(9, "Admin. de Perfiles de usuario");
        public static readonly Funcion Admin_de_Funciones = new Funcion(10, "Admin. de Funciones");
        public static readonly Funcion Admin_de_sistema_de_componentes_generadores = new Funcion(11, "Admin. de sistema de componentes generadores");
        public static readonly Funcion Admin_de_bancos_de_almacenamiento = new Funcion(12, "Admin. de bancos de almacenamiento");
        public static readonly Funcion Admin_de_sistema_de_control_de_energia = new Funcion(13, "Admin. de sistema de control de energía");
        public static readonly Funcion Admin_de_sistema_de_provision_de_energia = new Funcion(14, "Admin. de sistema de provisión de energía");
        public static readonly Funcion Admin_de_sistema_de_conversion_de_energia = new Funcion(15, "Admin. de sistema de conversión de energía");
        public static readonly Funcion Admin_de_bancos_de_baterias = new Funcion(16, "Admin. de bancos de baterías");

        public static Funcion ObtenerFuncionPorId(int id)
        {
            List<Funcion> funciones=new List<Funcion>();
            funciones.Add(Funciones.Monitoreo_de_red_de_energia);
            funciones.Add(Funciones.Alerta_de_fallas_del_sistema);
            funciones.Add(Funciones.Admin_de_parametros_del_sistema);
            funciones.Add(Funciones.Visualizacion_de_la_bitacora_de_fallas_del_sistema);
            funciones.Add(Funciones.Visualizacion_de_metricas_historicas_de_energia);
            funciones.Add(Funciones.Visualizacion_de_registro_de_actividad_de_usuario);
            funciones.Add(Funciones.Admin_de_usuarios);
            funciones.Add(Funciones.Configuracion_de_orden_de_alimentacion_de_energia);
            funciones.Add(Funciones.Admin_de_Perfiles_de_usuario);
            funciones.Add(Funciones.Admin_de_Funciones);
            funciones.Add(Funciones.Admin_de_sistema_de_componentes_generadores);
            funciones.Add(Funciones.Admin_de_bancos_de_almacenamiento);
            funciones.Add(Funciones.Admin_de_sistema_de_control_de_energia);
            funciones.Add(Funciones.Admin_de_sistema_de_provision_de_energia);
            funciones.Add(Funciones.Admin_de_sistema_de_conversion_de_energia);
            funciones.Add(Funciones.Admin_de_bancos_de_baterias);

            return funciones.Find(f => f.Valor == id);
        }

        public static List<Funcion> ObtenerFunciones()
        {
            List<Funcion> funciones = new List<Funcion>();
            funciones.Add(Funciones.Monitoreo_de_red_de_energia);
            funciones.Add(Funciones.Alerta_de_fallas_del_sistema);
            funciones.Add(Funciones.Admin_de_parametros_del_sistema);
            funciones.Add(Funciones.Visualizacion_de_la_bitacora_de_fallas_del_sistema);
            funciones.Add(Funciones.Visualizacion_de_metricas_historicas_de_energia);
            funciones.Add(Funciones.Visualizacion_de_registro_de_actividad_de_usuario);
            funciones.Add(Funciones.Admin_de_usuarios);
            funciones.Add(Funciones.Configuracion_de_orden_de_alimentacion_de_energia);
            funciones.Add(Funciones.Admin_de_Perfiles_de_usuario);
            funciones.Add(Funciones.Admin_de_Funciones);
            funciones.Add(Funciones.Admin_de_sistema_de_componentes_generadores);
            funciones.Add(Funciones.Admin_de_bancos_de_almacenamiento);
            funciones.Add(Funciones.Admin_de_sistema_de_control_de_energia);
            funciones.Add(Funciones.Admin_de_sistema_de_provision_de_energia);
            funciones.Add(Funciones.Admin_de_sistema_de_conversion_de_energia);
            funciones.Add(Funciones.Admin_de_bancos_de_baterias);
            return funciones;
        }

    }
}
