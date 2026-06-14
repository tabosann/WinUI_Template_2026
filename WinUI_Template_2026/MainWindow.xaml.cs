using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.UI.Xaml;
using Microsoft.UI;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System;
using Windows.Foundation.Collections;
using Windows.Foundation;
using Windows.UI;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI_Template_2026
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        Stopwatch PerfStopwatch { get; init; } = Stopwatch.StartNew();
        Stopwatch PerfStopwatch10 { get; init; } = Stopwatch.StartNew();
        Stopwatch PerfStopwatch11 { get; init; } = Stopwatch.StartNew();
        Stopwatch PerfStopwatch20 { get; init; } = Stopwatch.StartNew();
        Stopwatch PerfStopwatch21 { get; init; } = Stopwatch.StartNew();

        public MainWindow()
        {
            InitializeComponent();

            ExtendsContentIntoTitleBar = true;
            AppWindow.TitleBar.PreferredHeightOption = TitleBarHeightOption.Tall;
        }

        private void RootGrid_Loaded(object sender, RoutedEventArgs e)
        {
            PerfStopwatch.Stop();
            m_titleBarText.Text = $"Startup (Ticks, Time) = ({PerfStopwatch.ElapsedTicks}, {PerfStopwatch.ElapsedMilliseconds} ms)";
        }

        private void RootGrid_ActualThemeChanged(FrameworkElement sender, object args)
        {
            // OSのテーマに合わせてキャプションボタンの色を変更.
            bool darkTheme = sender.ActualTheme == ElementTheme.Dark;
            if (AppWindow != null) {
                var foregroundColor = darkTheme ? Colors.White : Colors.Black;
                AppWindow.TitleBar.ButtonForegroundColor = foregroundColor;
                AppWindow.TitleBar.ButtonHoverForegroundColor = foregroundColor;

                var backgroundHoverColor = darkTheme ? Color.FromArgb(24, 255, 255, 255) : Color.FromArgb(24, 0, 0, 0);
                AppWindow.TitleBar.ButtonHoverBackgroundColor = backgroundHoverColor;
            }
        }

        private void Grid10_Loaded(object sender, RoutedEventArgs e)
        {
            PerfStopwatch10.Stop();
            m_grid10.Text = $"Loaded Ticks {PerfStopwatch10.ElapsedTicks}\n";
            m_grid10.Text += $"Loaded Time {PerfStopwatch10.ElapsedMilliseconds} ms";
        }

        private void Grid11_Loaded(object sender, RoutedEventArgs e)
        {
            PerfStopwatch11.Stop();
            m_grid11.Text = $"Loaded Ticks {PerfStopwatch11.ElapsedTicks}\n";
            m_grid11.Text += $"Loaded Time {PerfStopwatch11.ElapsedMilliseconds} ms";
        }

        private void Grid20_Loaded(object sender, RoutedEventArgs e)
        {
            PerfStopwatch20.Stop();
            m_grid20.Text = $"Loaded Ticks {PerfStopwatch20.ElapsedTicks}\n";
            m_grid20.Text += $"Loaded Time {PerfStopwatch20.ElapsedMilliseconds} ms";
        }

        private void Grid21_Loaded(object sender, RoutedEventArgs e)
        {
            PerfStopwatch21.Stop();
            m_grid21.Text = $"Loaded Ticks {PerfStopwatch21.ElapsedTicks}\n";
            m_grid21.Text += $"Loaded Time {PerfStopwatch21.ElapsedMilliseconds} ms";
        }
    }
}
