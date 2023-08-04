using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppRoti;
using AppRoti.Clases;
using Mono.Math.Prime.Generator;
using WindowsFormsApp1.Controls;

namespace AppRoti.Vistas
{
    public partial class FrmMuroPedidos : BaseForm {
        private int col;
        private int row;
        bool aux;
        private CtrPedido contSelect;
       

        static internal List<CPedido> listadoPedidos = new List<CPedido>();
        private Point offset;

        public FrmMuroPedidos(BaseForm invoker) {
            InitializeComponent();
        }

        private void ctrPedido1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            PedidoAM a = new PedidoAM();
            a.FormComplete += new FormEvent(f_FormComplete);
            a.ShowIngresoPedido(this);
        }


        private void ctrPedido1_MouseDown(object sender, MouseEventArgs e) {
            aux = true;
            CtrPedido controlAux = (sender as CtrPedido);
            contSelect = controlAux;
            offset = e.Location;
            this.SuspendLayout();
            controlAux.SuspendLayout();
            PedidosPanel.SuspendLayout();
        }

        private void ctrPedido1_MouseMove(object sender, MouseEventArgs e) {
            if (aux) {
                PedidosPanel.SendToBack();
                Point newPos = PedidosPanel.PointToClient(Cursor.Position);
                newPos.Offset(-offset.X, -offset.Y);

                // Limitar el movimiento para que no se salga del TableLayoutPanel
                int newX = Math.Max(0, Math.Min(PedidosPanel.ClientSize.Width - contSelect.Width, newPos.X));
                int newY = Math.Max(0, Math.Min(PedidosPanel.ClientSize.Height - contSelect.Height, newPos.Y));
                contSelect.Location = new Point(newX, newY);
            }
        }


        private void ctrPedido1_MouseUp(object sender, MouseEventArgs e) { 
            CtrPedido controlAux = (sender as CtrPedido);
            Point mousePos = PedidosPanel.PointToClient(Cursor.Position);
            // Obtener la columna y fila correspondiente a la posición del puntero
            int newCol = -1;
            int colLeft = 0;
            for (int col = 0; col < PedidosPanel.ColumnCount; col++) {
                colLeft += PedidosPanel.GetColumnWidths()[col];
                if (mousePos.X < colLeft) {
                    newCol = col;
                    break;
                }
            }
            int newRow = -1;
            int rowTop = 0;
            for (int row = 0; row < PedidosPanel.RowCount; row++) {
                rowTop += PedidosPanel.GetRowHeights()[row];
                if (mousePos.Y < rowTop) {
                    newRow = row;
                    break;
                }
            }
            PedidosPanel.SetRow(controlAux, newRow);
            PedidosPanel.SetColumn(controlAux, newCol);
            this.Controls.Remove(contSelect);
            PedidosPanel.ResumeLayout();
            controlAux.ResumeLayout();
            this.ResumeLayout();
            //row = PedidosPanel.GetRow(contSelect);
            //col = PedidosPanel.GetColumn(contSelect);
            //PedidosPanel.SetRow(controlAux, row);
            //PedidosPanel.SetColumn(controlAux, col);
            aux = false;
        }


        internal void f_FormComplete(object sender, EventArgDom ev) {
            if (ev.Status == CompleteStatus.completed) {
                RotiDbContext db = new RotiDbContext();
                CPedido pedido;
                pedido = ev.ObjProcess as CPedido;
                CtrPedido controlAsoc = pedido.CrearControl(pedido);
                controlAsoc = AsignarEventos(controlAsoc);
                controlAsoc.Anchor = AnchorStyles.Top;
                listadoPedidos.Add(pedido);
                db.PedidosTable.Add(pedido);
                PedidosPanel.Controls.Add(controlAsoc);
            }
            else {
                MessageBox.Show("Test");
            }
        }

        private CtrPedido AsignarEventos(CtrPedido controlAsoc) {
            controlAsoc.MouseMove += ctrPedido1_MouseMove;
            controlAsoc.MouseUp += ctrPedido1_MouseUp;
            controlAsoc.MouseDown += ctrPedido1_MouseDown;
            (controlAsoc.Controls.Find("CancelarBtn", false)[0] as Button).MouseClick += BtnCancelarPedido_MouseClick;
            (controlAsoc.Controls.Find("CompletadoBtn", false)[0] as Button).MouseClick += BtnAceptarPedido_MouseClick;
            return controlAsoc;
        }

        private void BtnAceptarPedido_MouseClick(object sender, MouseEventArgs e) {
            Program.ListadoPedidosFinal.Add((CPedido)(sender as Button).Tag);
        }

        private void BtnCancelarPedido_MouseClick(object sender, MouseEventArgs e) {
            CPedido pedAux = (CPedido)(sender as Button).Tag;
        }

        private void FrmMuroPedidos_FormClosing(object sender, FormClosingEventArgs e) {
            if (PedidosPanel.Controls.Count>0) {
                MessageBox.Show(string.Format("Imposible cerrar el muro de pedidos todavia quedan {0} pedidos activos, complete los pedidos y luego cierre",PedidosPanel.Controls.Count),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void PedidosPanel_Paint(object sender, PaintEventArgs e) {

        }

        private void FrmMuroPedidos_Load(object sender, EventArgs e) {

        }
    }
}
