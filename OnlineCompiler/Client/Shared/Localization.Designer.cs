﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineCompiler.Client.Shared {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Localization {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Localization() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OnlineCompiler.Client.Shared.Localization", typeof(Localization).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Compilation Error.
        /// </summary>
        public static string CompilationError {
            get {
                return ResourceManager.GetString("CompilationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Compiling.
        /// </summary>
        public static string Compiling {
            get {
                return ResourceManager.GetString("Compiling", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Напишите код на C# и нажмите &quot;Выполнить&quot;, чтобы скомпилировать и выполнить код.
        /// </summary>
        public static string Description {
            get {
                return ResourceManager.GetString("Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Выполнять.
        /// </summary>
        public static string Execute {
            get {
                return ResourceManager.GetString("Execute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Закончено.
        /// </summary>
        public static string Finished {
            get {
                return ResourceManager.GetString("Finished", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Домой.
        /// </summary>
        public static string Home {
            get {
                return ResourceManager.GetString("Home", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to C# Compiler.
        /// </summary>
        public static string OnlineCsharpCompiler {
            get {
                return ResourceManager.GetString("OnlineCsharpCompiler", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Подготовка.
        /// </summary>
        public static string Preparing {
            get {
                return ResourceManager.GetString("Preparing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Запуск.
        /// </summary>
        public static string Running {
            get {
                return ResourceManager.GetString("Running", resourceCulture);
            }
        }
    }
}
