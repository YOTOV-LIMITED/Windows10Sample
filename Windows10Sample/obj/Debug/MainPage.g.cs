﻿#pragma checksum "C:\Projects\WIN 10\Demos apps\App1\Windows10Sample\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0D425F378C7A546C7434C04D14DA992D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App1
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        private IMainPage_Bindings _bindings;

        private IMainPage_Bindings Bindings;

        internal interface IMainPage_Bindings
        {
            void Initialize();
            void UpdateAll();
            void StopChangeTracking();
        }

        /// <summary>
        /// Auto generated class for compiled bindings.
        /// </summary>
        internal class MainPage_obj1_Bindings : IMainPage_Bindings
        {
            // Pointer to the Root of the UI tree for this binding scope.
            private global::App1.MainPage dataRoot;
            private bool _initialized=false;

            // Fields for each control that has bindings.
            internal global::Windows.UI.Xaml.Controls.GridView obj6;

            public MainPage_obj1_Bindings(global::App1.MainPage dataRoot)
            {
                this.dataRoot = dataRoot;
            }

            public void Initialize()
            {
                if (!_initialized)
                {
                    _initialized=true;
                    this.InitializeCore();
                }
            }

            public void UpdateAll()
            {
                this.InitializeCore();
            }

            public void StopChangeTracking()
            {
            }

            private void InitializeCore()
            {
                this.Update_(this.dataRoot, true);
            }

            internal void Loading(Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }
            // Update method for each path node used in binding steps.
            internal void Update_(global::App1.MainPage obj, bool isInitialUpdate = false)
            {
                this.UpdatePathStep_Albums(obj, isInitialUpdate);
            }

            // Update method for each path node used in binding steps.
            internal void Update_Albums(global::App1.Model.Albums obj, bool isInitialUpdate = false)
            {
                if (isInitialUpdate)
                {
                    this.SetValue_obj6_ItemsSource(obj);
                }
            }

            private void UpdatePathStep_Albums(global::App1.MainPage obj, bool isInitialUpdate = false)
            {
                if (obj != null)
                {
                    try
                    {
                        this.Update_Albums(obj.Albums, isInitialUpdate);
                        return;
                    }
                    catch (
#pragma warning disable 0168
                    global::System.Exception ex
#pragma warning restore 0168
                    )
                    {
#if DEBUG && !DISABLE_XAML_GENERATED_BINDING_DEBUG_OUTPUT
                         global::System.Diagnostics.Debug.WriteLine("Binding update failed for 'Albums' : " + ex.Message);
#endif
                    }
                }
            }

            private void SetValue_obj6_ItemsSource(global::App1.Model.Albums obj)
            {
                try
                {
                    this.obj6.ItemsSource = obj;
                }
                catch (
#pragma warning disable 0168
                    global::System.Exception ex
#pragma warning restore 0168
                )
                {
#if DEBUG && !DISABLE_XAML_GENERATED_BINDING_DEBUG_OUTPUT
                            global::System.Diagnostics.Debug.WriteLine("Binding failure in assigning 'ItemsControl.ItemsSource' = 'Albums' at C:\\Projects\\WIN 10\\Demos apps\\App1\\Windows10Sample\\MainPage.xaml, line 112 : " + ex.Message);
#endif

                }
            }

        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                MainPage_obj1_Bindings bindings = new MainPage_obj1_Bindings(this);
                this._bindings = bindings;
                this.Bindings = bindings;
                element1.Loading += bindings.Loading;
                }
                break;
            case 2:
                this.Min = (global::Windows.UI.Xaml.VisualState)(target);
                break;
            case 3:
                this.Moy = (global::Windows.UI.Xaml.VisualState)(target);
                break;
            case 4:
                this.Max = (global::Windows.UI.Xaml.VisualState)(target);
                break;
            case 5:
                this.FlipViewImages = (global::Windows.UI.Xaml.Controls.FlipView)(target);
                break;
            case 6:
                this.GridAlbums = (global::Windows.UI.Xaml.Controls.GridView)(target);
                ((MainPage_obj1_Bindings)_bindings).obj6 = this.GridAlbums;
                break;
            case 7:
                this.UAPImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                break;
            case 8:
                this.TxtOne = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                break;
            case 9:
                this.HLinkOne = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                break;
            case 10:
                this.XboxMusicImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                break;
            }
            this._contentLoaded = true;
        }
    }
}

