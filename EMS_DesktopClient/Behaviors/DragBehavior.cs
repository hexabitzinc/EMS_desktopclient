using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interactivity;
using System.Windows.Media;

namespace EMS_DesktopClient.Behaviors
{
    public class DragBehavior : Behavior<UIElement>
    {
        private TranslateTransform transform = new TranslateTransform();
        private Point mouseStartPoint;
        private Point elementStartPosition;
        protected override void OnAttached()
        {
            Window parent = Application.Current.MainWindow;
            AssociatedObject.RenderTransform = transform;

            AssociatedObject.MouseLeftButtonDown += (sender, e) =>
            {
                elementStartPosition = AssociatedObject.TranslatePoint(new Point(), parent);
                mouseStartPoint = e.GetPosition(parent);
                AssociatedObject.CaptureMouse();
            };
            AssociatedObject.MouseLeftButtonUp += (sender, e) =>
            {
                AssociatedObject.ReleaseMouseCapture();
            };
            AssociatedObject.MouseMove += (sender, e) =>
            {
                Vector diff = e.GetPosition(parent) - mouseStartPoint;
                if (AssociatedObject.IsMouseCaptured)
                {
                    transform.X = diff.X;
                    transform.Y = diff.Y;
                }
            };
        }
    }
}
