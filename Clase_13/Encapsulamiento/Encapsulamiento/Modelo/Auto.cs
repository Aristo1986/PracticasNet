using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento.Modelo
{
    internal class Auto
    {
        //Campos: son variables para la clase pero que son privados
        private string _tipoDeMotor;             //Los nombres para las variables privadas empiezan con minúscula
        private string _anioDeFabricacion;
        private bool _bujiasOkey;

        public string TipoDeMotor 
        {
            get { return _tipoDeMotor;}
            set 
            {
                if (value==null || value == "")
                {
                    _tipoDeMotor = "Nafta";
                }
                else
                {
                    _tipoDeMotor = value;
                }
            }
        }
        public bool EstaEncendido { get; set; }
        public int AnioDeFabricacion { get; set; }
        public string Marca { get; set; }
    }
}

/*
 El set se usa cuando se asigna un valor a la propiedad y el get se usa cuando se lee discha propiedad

Que sucede si no defino un cuerpo para los metodos get y set para una propiedad

El compilador crea automáticamente un campo donde va a guardar ese dato

*/