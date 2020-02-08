﻿using System;
using System.Collections.Generic;
using System.Linq;
using Taller1Codigo.Cuentas;

namespace Taller1Codigo
{
    internal class Program
    {
        public static Aplicacion aplicacion = null;
        public static List<Usuario> BaseUsuarios = new List<Usuario>();

        private static void Main ( string[] args )
        {
            string[] NombreUsuarios = {"Santiago Vasquez",
                                                               "Luis Alberto Marin",
                                                                "Fabio Salazar"};

            List<INotificacion> notificacionesSantiago = new List<INotificacion>()
            {
                new NotificacionCorreo("santivasquez1@gmail.com"),
                new NotificacionFacebook("www.facebook/santiagovasquez.com"),
                new NotificacionSMS("310 4509399")
            };

            List<INotificacion> notificacionesLuis = new List<INotificacion>()
            {
                new NotificacionFacebook("betomm@gmail.com "),
                new NotificacionSMS("311 7609582")
            };

            List<INotificacion> notificacionesFabio = new List<INotificacion>(){
                new NotificacionSMS("310 3934690")
            };

            foreach ( var Nombre in NombreUsuarios )
            {
                if ( Nombre == "Santiago Vasquez" )
                {
                    CrearUsuario(Nombre , notificacionesSantiago);
                }

                if ( Nombre == "Luis Alberto Marin" )
                {
                    CrearUsuario(Nombre , notificacionesLuis);
                }

                if ( Nombre == "Fabio Salazar" )
                {
                    CrearUsuario(Nombre , notificacionesFabio);
                }
            }

            Console.ReadLine();
        }

        private static void CrearUsuario ( string Nombre , List<INotificacion> NotificacionesUsuario )
        {
            Usuario usuario = new Usuario(Nombre);
            Console.WriteLine($"Usuario {Nombre} creado");

            foreach ( var notificacion in NotificacionesUsuario )
            {
                usuario.AddNotificacion(notificacion);
                usuario.Notificaciones.Last().enviar("Alerta");
            }

            BaseUsuarios.Add(usuario);
            Console.WriteLine("------------");
        }
    }
}