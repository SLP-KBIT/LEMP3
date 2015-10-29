﻿using System;
using System.Configuration;
using System.Windows;

namespace LEMP3.Model.Native
{
    public interface IWindowSettings
    {
        WINDOWPLACEMENT? Placement { get; set; }
        void Reload();
        void Save();
    }

    public class WindowSettings : ApplicationSettingsBase, IWindowSettings
    {
        public WindowSettings(Window window) : base(window.GetType().FullName) { }

        [UserScopedSetting]
        public WINDOWPLACEMENT? Placement
        {
            get { return this["Placement"] != null ? (WINDOWPLACEMENT?)(WINDOWPLACEMENT)this["Placement"] : null; }
            set { this["Placement"] = value; }
        }
    }
}
