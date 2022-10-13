using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;

namespace TodoApp
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// переопределяем региональные настройки показа дата-времени
        /// </summary>
        /// <param name="e"></param>
        protected override void OnStartup(StartupEventArgs e)
        {
            var cultereInfo = new CultureInfo("ru-RU");
            Thread.CurrentThread.CurrentCulture = cultereInfo;
            Thread.CurrentThread.CurrentUICulture = cultereInfo;
            CultureInfo.DefaultThreadCurrentCulture= cultereInfo;
            CultureInfo.DefaultThreadCurrentUICulture= cultereInfo;
            FrameworkElement.LanguageProperty.OverrideMetadata(typeof(FrameworkElement),new FrameworkPropertyMetadata(XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.IetfLanguageTag)));
            base.OnStartup(e);  
        }
    }
}
