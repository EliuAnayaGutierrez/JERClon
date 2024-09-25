using System.Drawing.Drawing2D;

namespace Vista.Controls
{
    public class MenuRendered: ToolStripProfessionalRenderer
    {
        //Fields
        private Color primaryColor;
        private Color textColor;
        private int arrowThicknees;

        //Constructor
        public MenuRendered(bool isMainMenu, Color primaryColor, Color textColor) : base(new MenuColorTable(isMainMenu, primaryColor))
        {
            this.primaryColor = primaryColor;
            this.textColor = textColor;
            if (isMainMenu) arrowThicknees = 3;
            else arrowThicknees = 2;
        }

        //overrides
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            base.OnRenderItemText(e);
            e.Item.ForeColor = e.Item.Selected ? Color.White : textColor;
        }
        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            //base.OnRenderArrow(e);

            //Fields
            var grahp = e.Graphics;
            var arrowSize = new Size(5, 12);
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
            var arrowColor = e.Item.Selected ? Color.White : primaryColor;
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
            var rect = new Rectangle(e.ArrowRectangle.Location.X, (e.ArrowRectangle.Height - arrowSize.Height) / 2,
                arrowSize.Width, arrowSize.Height);
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(arrowColor, arrowThicknees))
            {
                //Drawing
                grahp.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rect.Left, rect.Top, rect.Right, rect.Top + rect.Height / 2);
                path.AddLine(rect.Right, rect.Top + rect.Height / 2, rect.Left, rect.Top + rect.Height);
                grahp.DrawPath(pen, path);
            }
        }
    }
}
