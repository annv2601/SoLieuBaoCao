﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace daoSLPH.Properties {
    
    
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
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=10.10.200.167;Initial Catalog=SoLieuPhatHanh;User ID=sa")]
        public string SoLieuPhatHanhConnectionString {
            get {
                //return ((string)(this["SoLieuPhatHanhConnectionString"]));
                string _Chuoi= System.Configuration.ConfigurationManager.ConnectionStrings["SoLieuPhatHanhConnectionString"].ConnectionString;
                string _KQ;
                _KQ = daoSLPH.Untities.daMaHoa.Decrypt(_Chuoi, true, "B0EA8F37-F4C0-464D-BDEB-49E5F3FE421C");
                return _KQ;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=10.10.200.167;Initial Catalog=SoLieuPhatHanh;Persist Security Info=Tr" +
            "ue;User ID=sa")]
        public string SoLieuPhatHanhConnectionString1 {
            get {
                return ((string)(this["SoLieuPhatHanhConnectionString1"]));
            }
        }
    }
}