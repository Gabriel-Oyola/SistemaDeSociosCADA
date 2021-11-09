using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeSociosCADA.Clases
{
    public class ListaSocios
    {
        public Persona[] Personas { get; set; }

        public DataTable DTS { get; set; } = new DataTable();

        public ListaSocios()
        {
            DTS.TableName = "Lista de Socios";
            DTS.Columns.Add("N°Socio");
            DTS.Columns.Add("Nombre");
            DTS.Columns.Add("Apellido");
            DTS.Columns.Add("Nacimiento");
            DTS.Columns.Add("Edad");
            DTS.Columns.Add("Domicilio");
            DTS.Columns.Add("Carnet");
            DTS.Columns.Add("Platea");
            DTS.Columns.Add("Estado");

            LeerDTSArchivo();
        }

        public void LeerDTSArchivo()
        {
            if (System.IO.File.Exists("ListaSocios.xml"))
            {
                DTS.Clear();
                DTS.ReadXml("ListaSocios.xml");
                UltimoSocio = 0;
                for (int i = 0; i < DTS.Rows.Count; i++)
                {
                    if (Convert.ToInt32(DTS.Rows[i]["N°Socio"])>UltimoSocio)
                    {
                        UltimoSocio = Convert.ToInt32(DTS.Rows[i]["N°Socio"]);
                    }
                }

            }
        }

        public int UltimoSocio { get; set; } = 0;

    }
}
