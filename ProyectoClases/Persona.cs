using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public enum Paises
    { España, Francia, Alemania, Andorra }

    public enum TipoGenero
    { Masculino, Femenino }

    public class Persona
    {
        #region PROPIEDADES

        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public string PropiedadImplementada { get; set; }

        // En las propiedades se utilizan campos privados para controlar los valores
        // Deben ser del mismo tipo que la propiedad. Los campos se denominan con _Propiedad
        private int _Edad;

        public int Edad
        {
            get { return this._Edad; }
            set
            {
                if (value < 0)
                {
                    // Error silencioso
                    // this._Edad = 0;
                    // Excepción
                    throw new Exception("La edad no puede ser negativa (" + value + ")");
                }
                else
                {
                    this._Edad = value;
                }
            }
        }

        public Paises Nacionalidad { get; set; }

        private TipoGenero _Genero;

        public TipoGenero Genero
        {
            get { return this._Genero; }
            set
            {
                if (value != TipoGenero.Masculino && value != TipoGenero.Femenino)
                {
                    throw new Exception("Género no válido");
                }
                else
                {
                    this._Genero = value;
                }
            }
        }

        #endregion PROPIEDADES

        #region MÉTODOS

        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }

        public string GetNombreCompleto(bool orden)
        {
            if (!orden)
            {
                return this.Apellidos + " " + this.Nombre;
            }
            else
            {
                return GetNombreCompleto();
            }
        }

        public void MetodoParametrosOpcionales(int numero1, int numero2 = 444, int numero3 = 22)
        {
        }

        #endregion MÉTODOS
    }
}