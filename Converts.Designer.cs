﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace youtube_dl_gui {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Converts : global::System.Configuration.ApplicationSettingsBase {
        
        private static Converts defaultInstance = ((Converts)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Converts())));
        
        public static Converts Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool detectFiletype {
            get {
                return ((bool)(this["detectFiletype"]));
            }
            set {
                this["detectFiletype"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool clearOutput {
            get {
                return ((bool)(this["clearOutput"]));
            }
            set {
                this["clearOutput"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool clearInput {
            get {
                return ((bool)(this["clearInput"]));
            }
            set {
                this["clearInput"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("7500")]
        public int videoBitrate {
            get {
                return ((int)(this["videoBitrate"]));
            }
            set {
                this["videoBitrate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int videoPreset {
            get {
                return ((int)(this["videoPreset"]));
            }
            set {
                this["videoPreset"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int videoProfile {
            get {
                return ((int)(this["videoProfile"]));
            }
            set {
                this["videoProfile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8")]
        public int videoCRF {
            get {
                return ((int)(this["videoCRF"]));
            }
            set {
                this["videoCRF"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool videoFastStart {
            get {
                return ((bool)(this["videoFastStart"]));
            }
            set {
                this["videoFastStart"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool hideFFmpegCompile {
            get {
                return ((bool)(this["hideFFmpegCompile"]));
            }
            set {
                this["hideFFmpegCompile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("256")]
        public int audioBitrate {
            get {
                return ((int)(this["audioBitrate"]));
            }
            set {
                this["audioBitrate"] = value;
            }
        }
    }
}
