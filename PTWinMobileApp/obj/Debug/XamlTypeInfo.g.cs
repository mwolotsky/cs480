﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace PTWinMobileApp
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlTypeInfoProvider _provider;

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace PTWinMobileApp.PTWinMobileApp_XamlTypeInfo
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByType(type);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByName(typeName);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[25];
            _typeNameTable[0] = "PTWinMobileApp.PTForm2";
            _typeNameTable[1] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[2] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[3] = "PTWinMobileApp.MainMenu";
            _typeNameTable[4] = "PTWinMobileApp.PTForm";
            _typeNameTable[5] = "PTWinMobileApp.Login";
            _typeNameTable[6] = "PTWinMobileApp.PTForm3";
            _typeNameTable[7] = "PTWinMobileApp.PTForm4";
            _typeNameTable[8] = "PTWinMobileApp.PTForm5";
            _typeNameTable[9] = "PTWinMobileApp.PTForm6";
            _typeNameTable[10] = "PTWinMobileApp.PTForm7";
            _typeNameTable[11] = "PTWinMobileApp.PTForm8";
            _typeNameTable[12] = "PTWinMobileApp.PatientFormList";
            _typeNameTable[13] = "PTWinMobileApp.Search";
            _typeNameTable[14] = "PTWinMobileApp.SearchResult";
            _typeNameTable[15] = "PTWinMobileApp.SignUp";
            _typeNameTable[16] = "PTWinMobileApp.ViewClientList";
            _typeNameTable[17] = "PTWinMobileApp.ViewForm";
            _typeNameTable[18] = "PTWinMobileApp.ViewForm2";
            _typeNameTable[19] = "PTWinMobileApp.ViewForm3";
            _typeNameTable[20] = "PTWinMobileApp.ViewForm4";
            _typeNameTable[21] = "PTWinMobileApp.ViewForm5";
            _typeNameTable[22] = "PTWinMobileApp.ViewForm6";
            _typeNameTable[23] = "PTWinMobileApp.ViewForm7";
            _typeNameTable[24] = "PTWinMobileApp.ViewForm8";

            _typeTable = new global::System.Type[25];
            _typeTable[0] = typeof(global::PTWinMobileApp.PTForm2);
            _typeTable[1] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[2] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[3] = typeof(global::PTWinMobileApp.MainMenu);
            _typeTable[4] = typeof(global::PTWinMobileApp.PTForm);
            _typeTable[5] = typeof(global::PTWinMobileApp.Login);
            _typeTable[6] = typeof(global::PTWinMobileApp.PTForm3);
            _typeTable[7] = typeof(global::PTWinMobileApp.PTForm4);
            _typeTable[8] = typeof(global::PTWinMobileApp.PTForm5);
            _typeTable[9] = typeof(global::PTWinMobileApp.PTForm6);
            _typeTable[10] = typeof(global::PTWinMobileApp.PTForm7);
            _typeTable[11] = typeof(global::PTWinMobileApp.PTForm8);
            _typeTable[12] = typeof(global::PTWinMobileApp.PatientFormList);
            _typeTable[13] = typeof(global::PTWinMobileApp.Search);
            _typeTable[14] = typeof(global::PTWinMobileApp.SearchResult);
            _typeTable[15] = typeof(global::PTWinMobileApp.SignUp);
            _typeTable[16] = typeof(global::PTWinMobileApp.ViewClientList);
            _typeTable[17] = typeof(global::PTWinMobileApp.ViewForm);
            _typeTable[18] = typeof(global::PTWinMobileApp.ViewForm2);
            _typeTable[19] = typeof(global::PTWinMobileApp.ViewForm3);
            _typeTable[20] = typeof(global::PTWinMobileApp.ViewForm4);
            _typeTable[21] = typeof(global::PTWinMobileApp.ViewForm5);
            _typeTable[22] = typeof(global::PTWinMobileApp.ViewForm6);
            _typeTable[23] = typeof(global::PTWinMobileApp.ViewForm7);
            _typeTable[24] = typeof(global::PTWinMobileApp.ViewForm8);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_0_PTForm2() { return new global::PTWinMobileApp.PTForm2(); }
        private object Activate_3_MainMenu() { return new global::PTWinMobileApp.MainMenu(); }
        private object Activate_4_PTForm() { return new global::PTWinMobileApp.PTForm(); }
        private object Activate_5_Login() { return new global::PTWinMobileApp.Login(); }
        private object Activate_6_PTForm3() { return new global::PTWinMobileApp.PTForm3(); }
        private object Activate_7_PTForm4() { return new global::PTWinMobileApp.PTForm4(); }
        private object Activate_8_PTForm5() { return new global::PTWinMobileApp.PTForm5(); }
        private object Activate_9_PTForm6() { return new global::PTWinMobileApp.PTForm6(); }
        private object Activate_10_PTForm7() { return new global::PTWinMobileApp.PTForm7(); }
        private object Activate_11_PTForm8() { return new global::PTWinMobileApp.PTForm8(); }
        private object Activate_12_PatientFormList() { return new global::PTWinMobileApp.PatientFormList(); }
        private object Activate_13_Search() { return new global::PTWinMobileApp.Search(); }
        private object Activate_14_SearchResult() { return new global::PTWinMobileApp.SearchResult(); }
        private object Activate_15_SignUp() { return new global::PTWinMobileApp.SignUp(); }
        private object Activate_16_ViewClientList() { return new global::PTWinMobileApp.ViewClientList(); }
        private object Activate_17_ViewForm() { return new global::PTWinMobileApp.ViewForm(); }
        private object Activate_18_ViewForm2() { return new global::PTWinMobileApp.ViewForm2(); }
        private object Activate_19_ViewForm3() { return new global::PTWinMobileApp.ViewForm3(); }
        private object Activate_20_ViewForm4() { return new global::PTWinMobileApp.ViewForm4(); }
        private object Activate_21_ViewForm5() { return new global::PTWinMobileApp.ViewForm5(); }
        private object Activate_22_ViewForm6() { return new global::PTWinMobileApp.ViewForm6(); }
        private object Activate_23_ViewForm7() { return new global::PTWinMobileApp.ViewForm7(); }
        private object Activate_24_ViewForm8() { return new global::PTWinMobileApp.ViewForm8(); }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  PTWinMobileApp.PTForm2
                userType = new global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_0_PTForm2;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 1:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 3:   //  PTWinMobileApp.MainMenu
                userType = new global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_3_MainMenu;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 4:   //  PTWinMobileApp.PTForm
                userType = new global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_4_PTForm;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 5:   //  PTWinMobileApp.Login
                userType = new global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_5_Login;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 6:   //  PTWinMobileApp.PTForm3
                userType = new global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_6_PTForm3;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 7:   //  PTWinMobileApp.PTForm4
                userType = new global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_7_PTForm4;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 8:   //  PTWinMobileApp.PTForm5
                userType = new global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_8_PTForm5;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 9:   //  PTWinMobileApp.PTForm6
                userType = new global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_9_PTForm6;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 10:   //  PTWinMobileApp.PTForm7
                userType = new global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_10_PTForm7;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 11:   //  PTWinMobileApp.PTForm8
                userType = new global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_11_PTForm8;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 12:   //  PTWinMobileApp.PatientFormList
                userType = new global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_12_PatientFormList;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 13:   //  PTWinMobileApp.Search
                userType = new global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_13_Search;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 14:   //  PTWinMobileApp.SearchResult
                userType = new global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_14_SearchResult;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 15:   //  PTWinMobileApp.SignUp
                userType = new global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_15_SignUp;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 16:   //  PTWinMobileApp.ViewClientList
                userType = new global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_16_ViewClientList;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 17:   //  PTWinMobileApp.ViewForm
                userType = new global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_17_ViewForm;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 18:   //  PTWinMobileApp.ViewForm2
                userType = new global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_18_ViewForm2;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 19:   //  PTWinMobileApp.ViewForm3
                userType = new global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_19_ViewForm3;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 20:   //  PTWinMobileApp.ViewForm4
                userType = new global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_20_ViewForm4;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 21:   //  PTWinMobileApp.ViewForm5
                userType = new global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_21_ViewForm5;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 22:   //  PTWinMobileApp.ViewForm6
                userType = new global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_22_ViewForm6;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 23:   //  PTWinMobileApp.ViewForm7
                userType = new global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_23_ViewForm7;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 24:   //  PTWinMobileApp.ViewForm8
                userType = new global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_24_ViewForm8;
                userType.SetIsLocalType();
                xamlType = userType;
                break;
            }
            return xamlType;
        }



        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlMember xamlMember = null;
            // No Local Properties
            return xamlMember;
        }
    }

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlSystemBaseType
    {
        global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
        override public bool IsLocalType { get { return _isLocalType; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetIsLocalType()
        {
            _isLocalType = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::PTWinMobileApp.PTWinMobileApp_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}


