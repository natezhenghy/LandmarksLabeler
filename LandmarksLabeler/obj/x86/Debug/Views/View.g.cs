﻿#pragma checksum "c:\users\natezhenghy\source\repos\LandmarksLabeler\LandmarksLabeler\Views\View.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CF34032215FCBB4996D6020AAB3B75F8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LandmarksLabeler.Views
{
    partial class View : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class View_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IView_Bindings
        {
            private global::LandmarksLabeler.Views.View dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.RelativePanel obj3;
            private global::Windows.UI.Xaml.Controls.AppBarButton obj5;
            private global::Windows.UI.Xaml.Controls.AppBarButton obj6;
            private global::Windows.UI.Xaml.Controls.AppBarButton obj7;
            private global::Windows.UI.Xaml.Controls.Image obj8;
            private global::Windows.UI.Xaml.Controls.ItemsControl obj9;
            private global::Windows.UI.Xaml.Controls.AppBarButton obj11;

            private View_obj1_BindingsTracking bindingsTracking;

            public View_obj1_Bindings()
            {
                this.bindingsTracking = new View_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3: // Views\View.xaml line 17
                        this.obj3 = (global::Windows.UI.Xaml.Controls.RelativePanel)target;
                        ((global::Windows.UI.Xaml.Controls.RelativePanel)target).SizeChanged += (global::System.Object sender, global::Windows.UI.Xaml.SizeChangedEventArgs e) =>
                        {
                            this.dataRoot._viewModel.ImagePanelSizeChanged(sender, e);
                        };
                        break;
                    case 5: // Views\View.xaml line 43
                        this.obj5 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        ((global::Windows.UI.Xaml.Controls.AppBarButton)target).Click += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                        {
                            this.dataRoot._viewModel.PreviousOrNextClick(sender, e);
                        };
                        break;
                    case 6: // Views\View.xaml line 44
                        this.obj6 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        ((global::Windows.UI.Xaml.Controls.AppBarButton)target).Click += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                        {
                            this.dataRoot._viewModel.Save_OnClick(sender, e);
                        };
                        break;
                    case 7: // Views\View.xaml line 45
                        this.obj7 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        ((global::Windows.UI.Xaml.Controls.AppBarButton)target).Click += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                        {
                            this.dataRoot._viewModel.PreviousOrNextClick(sender, e);
                        };
                        break;
                    case 8: // Views\View.xaml line 19
                        this.obj8 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 9: // Views\View.xaml line 21
                        this.obj9 = (global::Windows.UI.Xaml.Controls.ItemsControl)target;
                        break;
                    case 11: // Views\View.xaml line 13
                        this.obj11 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        ((global::Windows.UI.Xaml.Controls.AppBarButton)target).Click += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                        {
                            this.dataRoot._viewModel.OpenDataset(sender, e);
                        };
                        break;
                    default:
                        break;
                }
            }

            // IView_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::LandmarksLabeler.Views.View)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::LandmarksLabeler.Views.View obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update__viewModel(obj._viewModel, phase);
                    }
                }
            }
            private void Update__viewModel(global::LandmarksLabeler.ViewModels.ViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners__viewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update__viewModel_ImageSource(obj.ImageSource, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update__viewModel_RenderedLandmarks(obj.RenderedLandmarks, phase);
                    }
                }
            }
            private void Update__viewModel_ImageSource(global::Windows.UI.Xaml.Media.Imaging.BitmapImage obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\View.xaml line 19
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj8, obj, null);
                }
            }
            private void Update__viewModel_RenderedLandmarks(global::System.Collections.ObjectModel.ObservableCollection<global::LandmarksLabeler.ViewModels.LandmarksViewModel> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\View.xaml line 21
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj9, obj, null);
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class View_obj1_BindingsTracking
            {
                private global::System.WeakReference<View_obj1_Bindings> weakRefToBindingObj; 

                public View_obj1_BindingsTracking(View_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<View_obj1_Bindings>(obj);
                }

                public View_obj1_Bindings TryGetBindingObject()
                {
                    View_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners__viewModel(null);
                }

                public void PropertyChanged__viewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    View_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::LandmarksLabeler.ViewModels.ViewModel obj = sender as global::LandmarksLabeler.ViewModels.ViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update__viewModel_ImageSource(obj.ImageSource, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "ImageSource":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update__viewModel_ImageSource(obj.ImageSource, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::LandmarksLabeler.ViewModels.ViewModel cache__viewModel = null;
                public void UpdateChildListeners__viewModel(global::LandmarksLabeler.ViewModels.ViewModel obj)
                {
                    if (obj != cache__viewModel)
                    {
                        if (cache__viewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache__viewModel).PropertyChanged -= PropertyChanged__viewModel;
                            cache__viewModel = null;
                        }
                        if (obj != null)
                        {
                            cache__viewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged__viewModel;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\View.xaml line 12
                {
                    this.TopCommandBar = (global::Windows.UI.Xaml.Controls.CommandBar)(target);
                }
                break;
            case 4: // Views\View.xaml line 42
                {
                    this.BottomCommandBar = (global::Windows.UI.Xaml.Controls.CommandBar)(target);
                }
                break;
            case 5: // Views\View.xaml line 43
                {
                    this.Previous = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 7: // Views\View.xaml line 45
                {
                    this.Next = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 8: // Views\View.xaml line 19
                {
                    this.Image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 10: // Views\View.xaml line 29
                {
                    global::Windows.UI.Xaml.Shapes.Ellipse element10 = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                    ((global::Windows.UI.Xaml.Shapes.Ellipse)element10).ManipulationDelta += this.LM_ManipulationDelta;
                }
                break;
            case 11: // Views\View.xaml line 13
                {
                    this.OpenDataset = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\View.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    View_obj1_Bindings bindings = new View_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}
