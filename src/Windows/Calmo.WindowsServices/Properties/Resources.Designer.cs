﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Calmo.WindowsServices.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Calmo.WindowsServices.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assembly {0} : O assembly não foi encontrado..
        /// </summary>
        internal static string Assembly_AssemblyNotFoundErrorMessage {
            get {
                return ResourceManager.GetString("Assembly_AssemblyNotFoundErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assembly {0} : Assembly carregado..
        /// </summary>
        internal static string Assembly_Loaded {
            get {
                return ResourceManager.GetString("Assembly_Loaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assembly {0} : Carregando o assembly..
        /// </summary>
        internal static string Assembly_Loading {
            get {
                return ResourceManager.GetString("Assembly_Loading", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assembly {0} : Localizando o assembly..
        /// </summary>
        internal static string Assembly_Locating {
            get {
                return ResourceManager.GetString("Assembly_Locating", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assembly {0} : A classe {1} não foi encontrada no assembly..
        /// </summary>
        internal static string Assembly_TypeNotFoundErrorMessage {
            get {
                return ResourceManager.GetString("Assembly_TypeNotFoundErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assembly {0} : Verificando se a classe {1} pertence ao assembly..
        /// </summary>
        internal static string Assembly_VerifyingClassExists {
            get {
                return ResourceManager.GetString("Assembly_VerifyingClassExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Classe {0} : Iniciando varredura de processos..
        /// </summary>
        internal static string Class_EnumeratingProcesses {
            get {
                return ResourceManager.GetString("Class_EnumeratingProcesses", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Classe {0} : Execução iniciada..
        /// </summary>
        internal static string Class_Executing {
            get {
                return ResourceManager.GetString("Class_Executing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Classe {0} : Execução finalizada..
        /// </summary>
        internal static string Class_ExecutionFinalized {
            get {
                return ResourceManager.GetString("Class_ExecutionFinalized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Classe {0} : Iniciando processamento da classe..
        /// </summary>
        internal static string Class_InitializingProcessment {
            get {
                return ResourceManager.GetString("Class_InitializingProcessment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Classe {0} : Classe instanciada..
        /// </summary>
        internal static string Class_Instantiated {
            get {
                return ResourceManager.GetString("Class_Instantiated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Classe {0} : Instanciando classe..
        /// </summary>
        internal static string Class_Instantiation {
            get {
                return ResourceManager.GetString("Class_Instantiation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Classe {0} : A classe não implementa a interface {1}.\nPara uma classe ser executada pelo Resource Robot Service ela deve implementar essa interface..
        /// </summary>
        internal static string Class_NotImplementErrorMessage {
            get {
                return ResourceManager.GetString("Class_NotImplementErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Classe {0} : Solicitando processos a serem executados..
        /// </summary>
        internal static string Class_RequestingProcesses {
            get {
                return ResourceManager.GetString("Class_RequestingProcesses", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Classe {0} : Verificando se a classe implementa a interface IRobotServiceClass..
        /// </summary>
        internal static string Class_VerifyingInterfaceImplementation {
            get {
                return ResourceManager.GetString("Class_VerifyingInterfaceImplementation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Não foram informados a hora (ExecuteTime) ou o intervalo (ExecuteInterval) de execução do processo {0} e o mesmo não pode ser executado..
        /// </summary>
        internal static string ExecutionTimeNotFoundErrorMessage {
            get {
                return ResourceManager.GetString("ExecutionTimeNotFoundErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A hora informada não está no formato correto. O formato deve ser &apos;hh:MM:ss&apos;, &apos;hh:MM&apos; ou &apos;hh&apos;..
        /// </summary>
        internal static string InvalidTime {
            get {
                return ResourceManager.GetString("InvalidTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processo {0} : Executando o processo de forma assíncrona..
        /// </summary>
        internal static string Process_ExecutingAsyncProcess {
            get {
                return ResourceManager.GetString("Process_ExecutingAsyncProcess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processo {0} : Executando o processo de forma síncrona..
        /// </summary>
        internal static string Process_ExecutingSyncProcess {
            get {
                return ResourceManager.GetString("Process_ExecutingSyncProcess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processo {0} : Execução do processo finalizada..
        /// </summary>
        internal static string Process_ExecutionFinalized {
            get {
                return ResourceManager.GetString("Process_ExecutionFinalized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processo {0} : Tratando status de execução do processo..
        /// </summary>
        internal static string Process_ManagingExecutionStatus {
            get {
                return ResourceManager.GetString("Process_ManagingExecutionStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processo {0} : Tratando status de pós execução do processo..
        /// </summary>
        internal static string Process_ManagingPostExecutionStatus {
            get {
                return ResourceManager.GetString("Process_ManagingPostExecutionStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processo {0} : Iniciando processamento..
        /// </summary>
        internal static string Process_Processing {
            get {
                return ResourceManager.GetString("Process_Processing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processo {0} : Validando o processo para execução..
        /// </summary>
        internal static string Process_ValidatingExecution {
            get {
                return ResourceManager.GetString("Process_ValidatingExecution", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processo {0} : Validando hora ou intervalo de execução..
        /// </summary>
        internal static string Process_ValidatingExecutionTimeInterval {
            get {
                return ResourceManager.GetString("Process_ValidatingExecutionTimeInterval", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processo {0} : Validando status de execução..
        /// </summary>
        internal static string Process_ValidatingStatus {
            get {
                return ResourceManager.GetString("Process_ValidatingStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processo {0} : Verificando se o processo é para ser executado ou não..
        /// </summary>
        internal static string Process_VerifyingExecution {
            get {
                return ResourceManager.GetString("Process_VerifyingExecution", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A classe a ser processada não pode ser nula..
        /// </summary>
        internal static string ProcessClassNotFoundErrorMessage {
            get {
                return ResourceManager.GetString("ProcessClassNotFoundErrorMessage", resourceCulture);
            }
        }
    }
}