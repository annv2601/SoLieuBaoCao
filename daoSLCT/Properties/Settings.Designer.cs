﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using daoSLCT.Data;
namespace daoSLCT.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.7.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=10.10.200.167;Initial Catalog=SoLieuChiTiet;Persist Security Info=Tru" +
            "e;User ID=LayDuLieu")]
        public string SoLieuChiTietConnectionString {
            get {
                //return ((string)(this["SoLieuChiTietConnectionString"]));
                string _Chuoi = System.Configuration.ConfigurationManager.ConnectionStrings["SoLieuChiTietConnectionString"].ConnectionString;
                string _KQ;
                _KQ = daMaHoa.Decrypt(_Chuoi, true, "559C3067-A6AC-4E31-B96E-F4F3AE38B630");
                return _KQ;
            }
        }
    }
}
