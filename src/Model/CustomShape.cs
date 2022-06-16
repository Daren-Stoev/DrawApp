using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    class CustomShape : Shape
    {
        public CustomShape(RectangleF rect) : base(rect)
        {
        }

        public CustomShape(CustomShape cst) : base(cst)
        {
        }

        public override bool Contains(PointF point)
        {
           Point center = new Point
            {
                X = (int)(Rectangle.X + Rectangle.Width / 2),
                Y = (int)(Rectangle.Y + Rectangle.Height / 2)
            };
            if (base.Contains(point))
            {
                if (((Math.Pow((point.X - center.X), 2) / Math.Pow((Rectangle.Width / 2), 2))) 
                    + (Math.Pow((point.Y - center.Y), 2) / Math.Pow(Rectangle.Height / 2, 2)) <= 1)
                return true;
                else
                    return false;
            }
            else
                return false;
        }

        public override void DrawSelf(Graphics grfx)
        {
            base.RotateShape(grfx);
            base.DrawSelf(grfx);

            

            grfx.FillEllipse(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

            grfx.DrawEllipse(new Pen(BorderColor, BorderWidth), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

            grfx.DrawLine(new Pen(Color.Black, 0.5f), Rectangle.X, Rectangle.Y + Rectangle.Height / 2, Rectangle.X + Rectangle.Width, Rectangle.Y + Rectangle.Height / 2);

            grfx.DrawLine(new Pen(Color.Black, 0.5f), Rectangle.X + Rectangle.Width/2, Rectangle.Y, Rectangle.X + Rectangle.Width/2, Rectangle.Y + Rectangle.Height);

            grfx.DrawLine(new Pen(Color.Black, 0.5f), Rectangle.X - Rectangle.Width + Rectangle.Width*3.14f/3f, Rectangle.Y + Rectangle.Height / 8, Rectangle.X + Rectangle.Width - Rectangle.Width * 3.14f / 3f, Rectangle.Y + Rectangle.Height / 8);
        }
    }
}
