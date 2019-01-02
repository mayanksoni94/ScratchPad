using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchTracking;
using Xamarin.Forms;

namespace ScratchPad
{
    public partial class MainPage : ContentPage
    {
        /*creating a dictionary with key and value pair as long and skpath(it is geometric path wich is taking
        coordinates at the runtime)
        inProgressPaths is for the path which is generated while dragging finger while completed paths is path which generated 
        when the drag is completed*/
        Dictionary<long, SKPath> inProgressPaths = new Dictionary<long, SKPath>();
        List<SKPath> completedPaths = new List<SKPath>();
        string height;
        string width;
        //color is used to draw rectangle
        SKPaint color = new SKPaint
        {
            Color = SKColors.CornflowerBlue
        };

        // paint is used to create skpath
        SKPaint paint = new SKPaint
        {
            Style = SKPaintStyle.Stroke,
            Color = SKColors.White,
            /*here by making the blend mode to clear we make the scratched area transparent so that in the background 
            we can show the image and text*/
            BlendMode = SKBlendMode.Clear,
            StrokeWidth = 100,
            StrokeCap = SKStrokeCap.Round,
            StrokeJoin = SKStrokeJoin.Round
        };

        public MainPage()
        {
            InitializeComponent();

        }

        //this method draws the rectangle and the paths..
        private void CanvasView_PaintSurface(object sender, SkiaSharp.Views.Forms.SKPaintSurfaceEventArgs e)
        {
            SKCanvas canvas = e.Surface.Canvas;
            canvas.Clear();
            height = canvasView.Height.ToString();
            width = canvasView.Width.ToString();
            float w = float.Parse(width);
            float h = float.Parse(height);
            //canvas.DrawRect(0, 0,w,h, color);
            canvas.DrawRect(0, 0, 2000, 2500, color);

            foreach (SKPath path in completedPaths)
            {
                canvas.DrawPath(path, paint);

            }

            foreach (SKPath path in inProgressPaths.Values)
            {
                canvas.DrawPath(path, paint);
            }


        }

        //this method when we touch or drag the finger on the screen while scratching..
        private void TouchEffect_TouchAction(object sender, TouchTracking.TouchActionEventArgs args)
        {
            switch (args.Type)
            {
                case TouchActionType.Pressed:
                    if (!inProgressPaths.ContainsKey(args.Id))
                    {
                        SKPath path = new SKPath();
                        path.MoveTo(ConvertToPixel(args.Location));
                        inProgressPaths.Add(args.Id, path);
                        canvasView.InvalidateSurface();
                    }
                    break;

                case TouchActionType.Moved:
                    if (inProgressPaths.ContainsKey(args.Id))
                    {
                        SKPath path = inProgressPaths[args.Id];
                        path.LineTo(ConvertToPixel(args.Location));
                        canvasView.InvalidateSurface();
                    }
                    break;

                case TouchActionType.Released:
                    if (inProgressPaths.ContainsKey(args.Id))
                    {
                        completedPaths.Add(inProgressPaths[args.Id]);
                        inProgressPaths.Remove(args.Id);
                        canvasView.InvalidateSurface();
                    }
                    break;

                case TouchActionType.Cancelled:
                    if (inProgressPaths.ContainsKey(args.Id))
                    {
                        inProgressPaths.Remove(args.Id);
                        canvasView.InvalidateSurface();
                    }
                    break;
            }
        }
        //this method provide the runtime coordinates of the screen while drawing the paths.
        SKPoint ConvertToPixel(TouchTrackingPoint pt)
        {
            return new SKPoint((float)(canvasView.CanvasSize.Width * pt.X / canvasView.Width),
                               (float)(canvasView.CanvasSize.Height * pt.Y / canvasView.Height));
        }
    }
}
