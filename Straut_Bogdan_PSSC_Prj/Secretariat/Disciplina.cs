using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secretariat
{
    class Disciplina
    {
        public string nume { get; internal set; }
        public int ID_materie { get; internal set; }
        public float nota_activitate { get; internal set; }
        public float nota_examen { get; internal set; }

        public Disciplina(string nume, int ID_materie)
        {
            this.nume = nume;
            this.ID_materie = ID_materie;
        }

        public Disciplina(string nume, int ID_materie, float nota_activitate, float nota_examen)
        {
            this.nume = nume;
            this.ID_materie = ID_materie;
            this.nota_activitate = nota_activitate;
            this.nota_examen = nota_examen;
        }

        public float GetNota_activitate()
        {
            return this.nota_activitate;
        }

        public float GetNota_examen()
        {
            return this.nota_examen;
        }

        public void UpdateNotaActivitate(float nota)
        {
            this.nota_activitate = nota;
        }

        public void UpdateNotaExamen(float nota)
        {
            if (this.nota_examen != null)
            {
                if (this.nota_examen < nota)
                {
                    this.nota_examen = nota;
                }
            }
            else
            {
                this.nota_examen = nota;
            }
        }

        public void UpdateNumeDisciplina(string nume)
        {
            this.nume = nume;
        }

        public int GetID_materie()
        {
            return this.ID_materie;
        }

        public override bool Equals(object obj)
        {
            var disciplina = (Disciplina)obj;
            if (disciplina != null)
            {
                if (disciplina.GetID_materie() == this.GetID_materie())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
