﻿using System.Windows;
using System.Windows.Input;
using PiP_Tool.ViewModels;

namespace PiP_Tool
{
    /// <summary>
    /// Logique d'interaction pour PictureInPictureWindow.xaml
    /// </summary>
    public partial class PictureInPictureWindow
    {

        private readonly PictureInPicture _pictureInPicture;

        public PictureInPictureWindow(Point position, Size size)
        {
            _pictureInPicture = new PictureInPicture(position, size);
            DataContext = _pictureInPicture;
            InitializeComponent();
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            
            DragMove();
        }

        protected override void OnRenderSizeChanged(SizeChangedInfo sizeInfo)
        {
            if (sizeInfo.WidthChanged)
            {
                Width = sizeInfo.NewSize.Height * _pictureInPicture.Ratio;
            }
            else
            {
                Height = sizeInfo.NewSize.Width / _pictureInPicture.Ratio;
            }
        }

    }
}