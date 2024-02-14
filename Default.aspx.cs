using Negocio;
using Dominio;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace RestoApp
{
    public partial class _Default : Page
    {
        public List<Mesas> ListMesas { get; set; }
        public List<Empleados> ListEmpleados {  get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                MesasNegocio mesas = new MesasNegocio();
                ListMesas = mesas.Listar();
                
                ddlMesero.DataSource = ListEmpleados;
                ddlMesero.DataBind();

                RptMesas.DataSource = ListMesas;
                RptMesas.DataBind();
            }
        }
        protected void RptMesas_ItemCommand (object source, RepeaterCommandEventArgs e)
        {

        }
    }
}