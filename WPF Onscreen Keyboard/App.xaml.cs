using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.Collections.ObjectModel;

namespace BensOSK
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Apply a skin dictionary to the UI
        /// </summary>
        /// <param name="skinDictionaryUri"></param>
        public void ApplySkin(Uri skinDictionary)
        {
            // load dictionary inot memory
            ResourceDictionary skinDict = Application.LoadComponent(skinDictionary) as ResourceDictionary;

            // merge dictionaries
            Collection<ResourceDictionary> mergedDicts = base.Resources.MergedDictionaries;

            // Remove the existing skin dictiony
            if (mergedDicts.Count > 0)
            {
                // clear
                mergedDicts.Clear();
            }

            // Apply skin from uri
            mergedDicts.Add(skinDict);
        }
    }
}
