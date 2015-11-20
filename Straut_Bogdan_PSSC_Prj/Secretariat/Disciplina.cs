﻿using System;
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
    }
}
