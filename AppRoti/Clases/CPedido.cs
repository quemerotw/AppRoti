using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppRoti;
using AppRoti.Clases.Orm;


namespace AppRoti.Clases 
{


    public class CPedido : BaseClass {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        public DateTime Fecha {
            get; set;
        }


        public double Recargo {
            get; set; 
        }

        public bool Completado { get; set; }

        public double Descuento {
            get;
            set;
        }


        public double Subtotal {
            get;
            set;
        }

        public CCliente Cliente { get; set; }


        public List<CDetallePedido> DetallePedido {
            get;
            set;
        }

        public CPedido()
        {      
        }

        public CPedido(CCliente cliente) {
            DetallePedido = new List<CDetallePedido>();
            Completado = false;
            Cliente = cliente;
        }
        public double CalcularSubtotal() {
            double resultado = 0;
            foreach (CDetallePedido item in this.DetallePedido) {
                resultado += item.Producto.PrecioVenta;
            }
            return resultado;
        }

        public virtual double CalcularTotal() {
            var Total = Subtotal -= Descuento;
            Total += Recargo;
            return Total;
        }


        public WindowsFormsApp1.Controls.CtrPedido CrearControl(CPedido pedido) {
            WindowsFormsApp1.Controls.CtrPedido controlAsoc = new WindowsFormsApp1.Controls.CtrPedido();
            controlAsoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            controlAsoc.BackColor = System.Drawing.Color.LawnGreen;
            controlAsoc.Location = new System.Drawing.Point(0, 0);
            controlAsoc.Name = string.Format("ctrPedido-{0}", Id);
            controlAsoc.Size = new System.Drawing.Size(176, 190);
            (controlAsoc.Controls.Find("NroPedidoLbl", false)[0] as Label).Text += string.Format("{0} - hora {1}:{2}", Id, DateTime.Now.TimeOfDay.Hours, DateTime.Now.TimeOfDay.Minutes);
            (controlAsoc.Controls.Find("idPedidoLbl", false)[0] as Label).Text += string.Format("{0}", pedido.Cliente.ToString());
            controlAsoc.Tag = pedido;
            (controlAsoc.Controls.Find("CancelarBtn", false)[0] as Button).Tag = pedido;
            
            (controlAsoc.Controls.Find("CompletadoBtn", false)[0] as Button).Tag = pedido;
            (controlAsoc.Controls.Find("DetalleList", true)[0] as ListBox).DataSource = pedido.DetallePedido;
            (controlAsoc.Controls.Find("TotalLbl", false)[0] as Label).Text += string.Format("{0}", pedido.CalcularTotal());
            if (pedido is CPedidoDelivery) {
                controlAsoc.BackColor = Color.Gold;
                controlAsoc.Controls.Find("DireccionLbl", false)[0].Visible = true;
                (controlAsoc.Controls.Find("DireccionLbl", false)[0] as Label).Text += " " + (pedido as CPedidoDelivery).Direccion;
            }
            return controlAsoc;
        }
    }
}
