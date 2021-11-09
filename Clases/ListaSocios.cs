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
            DTS.Columns.Add("Documento");
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

        public bool UpdatePersona(Persona persona)
        {
            bool resp = persona.validar();
            if (resp)
            {
                if (persona.NumSocio==0)
                {
                    UltimoSocio = UltimoSocio + 1;
                    persona.NumSocio = UltimoSocio;
                    DTS.Rows.Add();
                    int NumeroRegistroNuevo = DTS.Rows.Count - 1;
                    DTS.Rows[NumeroRegistroNuevo]["N°Socio"] = persona.NumSocio.ToString();
                    DTS.Rows[NumeroRegistroNuevo]["Nombre"] = persona.Nombre;
                    DTS.Rows[NumeroRegistroNuevo]["Apellido"] = persona.Apellido;
                    DTS.Rows[NumeroRegistroNuevo]["Nacimiento"] = persona.Nacimiento;
                    DTS.Rows[NumeroRegistroNuevo]["Edad"] = persona.Edad.ToString();
                    DTS.Rows[NumeroRegistroNuevo]["Documento"] = persona.Documento;
                    DTS.Rows[NumeroRegistroNuevo]["Domicilio"] = persona.Domicilio;
                    DTS.Rows[NumeroRegistroNuevo]["Carnet"] = persona.Carnet;
                    DTS.Rows[NumeroRegistroNuevo]["Platea"] = persona.Platea;
                    DTS.Rows[NumeroRegistroNuevo]["Estado"] = persona.Estado;

                    DTS.WriteXml("ListaSocios.xml");
                }
            }
            return resp;
        }
        
        public Persona BuscarPersona(int NumeroSocio)
        {
            Persona res = new Persona();
            for (int i = 0; i < DTS.Rows.Count; i++)
            {
                if (Convert.ToInt32(DTS.Rows[i]["N°Socio"]) == NumeroSocio)
                {
                    res.NumSocio = Convert.ToInt32(DTS.Rows[i]["N°Socio"]);
                    res.Nombre = DTS.Rows[i]["Nombre"].ToString();
                    res.Apellido= DTS.Rows[i]["Apellido"].ToString();
                    res.Nacimiento= DTS.Rows[i]["Nacimiento"].ToString();
                    res.Edad= Convert.ToInt32(DTS.Rows[i]["Edad"]);
                    res.Documento= DTS.Rows[i]["Documento"].ToString();
                    res.Domicilio=DTS.Rows[i]["Domicilio"].ToString();
                    res.Carnet= DTS.Rows[i]["Carnet"].ToString();
                    res.Platea= DTS.Rows[i]["Platea"].ToString();
                    res.Estado= DTS.Rows[i]["Estado"].ToString();

                    break;
                }
                
            }
            return res;
        }
    }
}
