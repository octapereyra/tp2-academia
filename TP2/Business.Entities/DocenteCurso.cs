using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class DocenteCurso : BusinessEntity
    {
        private TiposCargos _Cargo;
        private int _IDCurso;
        private int _IDDocente;

        public int IDCurso { get => _IDCurso; set => _IDCurso = value; }
        public int IDDocente { get => _IDDocente; set => _IDDocente = value; }
        public TiposCargos Cargo { get => _Cargo; set => _Cargo = value; }

        public enum TiposCargos { Ayudante, JTP, Profesor_Adjunto, Profesor_Titular}

        public void SetTipoCargoById(int id)
        {
            switch (id)
            {
                case (int)TiposCargos.Ayudante:
                    this.Cargo = TiposCargos.Ayudante;
                    break;
                case (int)TiposCargos.JTP:
                    this.Cargo = TiposCargos.JTP;
                    break;
                case (int)TiposCargos.Profesor_Adjunto:
                    this.Cargo = TiposCargos.Profesor_Adjunto;
                    break;
                case (int)TiposCargos.Profesor_Titular:
                    this.Cargo = TiposCargos.Profesor_Titular;
                    break;
                default:
                    throw new Exception("No existe el tipo cargo especificado: " + id.ToString());
            }
        }

        public int GetIDTipoCargo()
        {
            switch (this.Cargo)
            {
                case TiposCargos.Ayudante:
                    return 0;
                case TiposCargos.JTP:
                    return 1;
                case TiposCargos.Profesor_Adjunto:
                    return 2;
                case TiposCargos.Profesor_Titular:
                    return 3;
                default:
                    throw new Exception("No existe el tipo cargo especificado: " + this.Cargo.ToString());
            }
        }
    }
}
