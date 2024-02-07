using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class System_User_DataType : INotifyPropertyChanged
	{
		private string user_NameField;

		private decimal session_Timeout_MinutesField;

		private bool session_Timeout_MinutesFieldSpecified;

		private bool account_DisabledField;

		private bool account_DisabledFieldSpecified;

		private DateTime account_Expiration_DateField;

		private bool account_Expiration_DateFieldSpecified;

		private bool account_LockedField;

		private bool account_LockedFieldSpecified;

		private bool required_New_Password_At_Next_LoginField;

		private bool required_New_Password_At_Next_LoginFieldSpecified;

		private bool show_User_Name_in_Browser_WindowField;

		private bool show_User_Name_in_Browser_WindowFieldSpecified;

		private bool display_XML_Icon_on_ReportsField;

		private bool display_XML_Icon_on_ReportsFieldSpecified;

		private bool enable_WorkboxField;

		private bool enable_WorkboxFieldSpecified;

		private LocaleObjectType locale_ReferenceField;

		private User_LanguageObjectType user_Language_ReferenceField;

		private Unique_IdentifierObjectType preferred_Search_Scope_ReferenceField;

		private Integration_System__Audited_ObjectType delegated_Authentication_Integration_System_ReferenceField;

		private bool allow_MixedLanguage_TransactionsField;

		private bool allow_MixedLanguage_TransactionsFieldSpecified;

		private Notification_Sub_Type_ConfigurationType[] notification_Sub_Type_ConfigurationsField;

		private object itemField;

		private bool exempt_from_Delegated_AuthenticationField;

		private bool exempt_from_Delegated_AuthenticationFieldSpecified;

		private bool passcode_ExemptField;

		private bool passcode_ExemptFieldSpecified;

		private bool passcode_Grace_Period_EnabledField;

		private bool passcode_Grace_Period_EnabledFieldSpecified;

		private decimal passcode_Grace_Period_Login_Remaining_CountField;

		private bool passcode_Grace_Period_Login_Remaining_CountFieldSpecified;

		private string openID_IdentifierField;

		private string openID_Internal_IdentifierField;

		private string openID_Connect_Internal_IdentifierField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string User_Name
		{
			get
			{
				return this.user_NameField;
			}
			set
			{
				this.user_NameField = value;
				this.RaisePropertyChanged("User_Name");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Session_Timeout_Minutes
		{
			get
			{
				return this.session_Timeout_MinutesField;
			}
			set
			{
				this.session_Timeout_MinutesField = value;
				this.RaisePropertyChanged("Session_Timeout_Minutes");
			}
		}

		[XmlIgnore]
		public bool Session_Timeout_MinutesSpecified
		{
			get
			{
				return this.session_Timeout_MinutesFieldSpecified;
			}
			set
			{
				this.session_Timeout_MinutesFieldSpecified = value;
				this.RaisePropertyChanged("Session_Timeout_MinutesSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Account_Disabled
		{
			get
			{
				return this.account_DisabledField;
			}
			set
			{
				this.account_DisabledField = value;
				this.RaisePropertyChanged("Account_Disabled");
			}
		}

		[XmlIgnore]
		public bool Account_DisabledSpecified
		{
			get
			{
				return this.account_DisabledFieldSpecified;
			}
			set
			{
				this.account_DisabledFieldSpecified = value;
				this.RaisePropertyChanged("Account_DisabledSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public DateTime Account_Expiration_Date
		{
			get
			{
				return this.account_Expiration_DateField;
			}
			set
			{
				this.account_Expiration_DateField = value;
				this.RaisePropertyChanged("Account_Expiration_Date");
			}
		}

		[XmlIgnore]
		public bool Account_Expiration_DateSpecified
		{
			get
			{
				return this.account_Expiration_DateFieldSpecified;
			}
			set
			{
				this.account_Expiration_DateFieldSpecified = value;
				this.RaisePropertyChanged("Account_Expiration_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Account_Locked
		{
			get
			{
				return this.account_LockedField;
			}
			set
			{
				this.account_LockedField = value;
				this.RaisePropertyChanged("Account_Locked");
			}
		}

		[XmlIgnore]
		public bool Account_LockedSpecified
		{
			get
			{
				return this.account_LockedFieldSpecified;
			}
			set
			{
				this.account_LockedFieldSpecified = value;
				this.RaisePropertyChanged("Account_LockedSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Required_New_Password_At_Next_Login
		{
			get
			{
				return this.required_New_Password_At_Next_LoginField;
			}
			set
			{
				this.required_New_Password_At_Next_LoginField = value;
				this.RaisePropertyChanged("Required_New_Password_At_Next_Login");
			}
		}

		[XmlIgnore]
		public bool Required_New_Password_At_Next_LoginSpecified
		{
			get
			{
				return this.required_New_Password_At_Next_LoginFieldSpecified;
			}
			set
			{
				this.required_New_Password_At_Next_LoginFieldSpecified = value;
				this.RaisePropertyChanged("Required_New_Password_At_Next_LoginSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Show_User_Name_in_Browser_Window
		{
			get
			{
				return this.show_User_Name_in_Browser_WindowField;
			}
			set
			{
				this.show_User_Name_in_Browser_WindowField = value;
				this.RaisePropertyChanged("Show_User_Name_in_Browser_Window");
			}
		}

		[XmlIgnore]
		public bool Show_User_Name_in_Browser_WindowSpecified
		{
			get
			{
				return this.show_User_Name_in_Browser_WindowFieldSpecified;
			}
			set
			{
				this.show_User_Name_in_Browser_WindowFieldSpecified = value;
				this.RaisePropertyChanged("Show_User_Name_in_Browser_WindowSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public bool Display_XML_Icon_on_Reports
		{
			get
			{
				return this.display_XML_Icon_on_ReportsField;
			}
			set
			{
				this.display_XML_Icon_on_ReportsField = value;
				this.RaisePropertyChanged("Display_XML_Icon_on_Reports");
			}
		}

		[XmlIgnore]
		public bool Display_XML_Icon_on_ReportsSpecified
		{
			get
			{
				return this.display_XML_Icon_on_ReportsFieldSpecified;
			}
			set
			{
				this.display_XML_Icon_on_ReportsFieldSpecified = value;
				this.RaisePropertyChanged("Display_XML_Icon_on_ReportsSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public bool Enable_Workbox
		{
			get
			{
				return this.enable_WorkboxField;
			}
			set
			{
				this.enable_WorkboxField = value;
				this.RaisePropertyChanged("Enable_Workbox");
			}
		}

		[XmlIgnore]
		public bool Enable_WorkboxSpecified
		{
			get
			{
				return this.enable_WorkboxFieldSpecified;
			}
			set
			{
				this.enable_WorkboxFieldSpecified = value;
				this.RaisePropertyChanged("Enable_WorkboxSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public LocaleObjectType Locale_Reference
		{
			get
			{
				return this.locale_ReferenceField;
			}
			set
			{
				this.locale_ReferenceField = value;
				this.RaisePropertyChanged("Locale_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public User_LanguageObjectType User_Language_Reference
		{
			get
			{
				return this.user_Language_ReferenceField;
			}
			set
			{
				this.user_Language_ReferenceField = value;
				this.RaisePropertyChanged("User_Language_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public Unique_IdentifierObjectType Preferred_Search_Scope_Reference
		{
			get
			{
				return this.preferred_Search_Scope_ReferenceField;
			}
			set
			{
				this.preferred_Search_Scope_ReferenceField = value;
				this.RaisePropertyChanged("Preferred_Search_Scope_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public Integration_System__Audited_ObjectType Delegated_Authentication_Integration_System_Reference
		{
			get
			{
				return this.delegated_Authentication_Integration_System_ReferenceField;
			}
			set
			{
				this.delegated_Authentication_Integration_System_ReferenceField = value;
				this.RaisePropertyChanged("Delegated_Authentication_Integration_System_Reference");
			}
		}

		[XmlElement("Allow_Mixed-Language_Transactions", Order = 13)]
		public bool Allow_MixedLanguage_Transactions
		{
			get
			{
				return this.allow_MixedLanguage_TransactionsField;
			}
			set
			{
				this.allow_MixedLanguage_TransactionsField = value;
				this.RaisePropertyChanged("Allow_MixedLanguage_Transactions");
			}
		}

		[XmlIgnore]
		public bool Allow_MixedLanguage_TransactionsSpecified
		{
			get
			{
				return this.allow_MixedLanguage_TransactionsFieldSpecified;
			}
			set
			{
				this.allow_MixedLanguage_TransactionsFieldSpecified = value;
				this.RaisePropertyChanged("Allow_MixedLanguage_TransactionsSpecified");
			}
		}

		[XmlArray(Order = 14), XmlArrayItem("Notification_Sub_Type_Configuration", typeof(Notification_Sub_Type_ConfigurationType), IsNullable = false)]
		public Notification_Sub_Type_ConfigurationType[] Notification_Sub_Type_Configurations
		{
			get
			{
				return this.notification_Sub_Type_ConfigurationsField;
			}
			set
			{
				this.notification_Sub_Type_ConfigurationsField = value;
				this.RaisePropertyChanged("Notification_Sub_Type_Configurations");
			}
		}

		[XmlElement("Generate_Random_Password", typeof(bool), Order = 15), XmlElement("Password", typeof(string), Order = 15)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 16)]
		public bool Exempt_from_Delegated_Authentication
		{
			get
			{
				return this.exempt_from_Delegated_AuthenticationField;
			}
			set
			{
				this.exempt_from_Delegated_AuthenticationField = value;
				this.RaisePropertyChanged("Exempt_from_Delegated_Authentication");
			}
		}

		[XmlIgnore]
		public bool Exempt_from_Delegated_AuthenticationSpecified
		{
			get
			{
				return this.exempt_from_Delegated_AuthenticationFieldSpecified;
			}
			set
			{
				this.exempt_from_Delegated_AuthenticationFieldSpecified = value;
				this.RaisePropertyChanged("Exempt_from_Delegated_AuthenticationSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public bool Passcode_Exempt
		{
			get
			{
				return this.passcode_ExemptField;
			}
			set
			{
				this.passcode_ExemptField = value;
				this.RaisePropertyChanged("Passcode_Exempt");
			}
		}

		[XmlIgnore]
		public bool Passcode_ExemptSpecified
		{
			get
			{
				return this.passcode_ExemptFieldSpecified;
			}
			set
			{
				this.passcode_ExemptFieldSpecified = value;
				this.RaisePropertyChanged("Passcode_ExemptSpecified");
			}
		}

		[XmlElement(Order = 18)]
		public bool Passcode_Grace_Period_Enabled
		{
			get
			{
				return this.passcode_Grace_Period_EnabledField;
			}
			set
			{
				this.passcode_Grace_Period_EnabledField = value;
				this.RaisePropertyChanged("Passcode_Grace_Period_Enabled");
			}
		}

		[XmlIgnore]
		public bool Passcode_Grace_Period_EnabledSpecified
		{
			get
			{
				return this.passcode_Grace_Period_EnabledFieldSpecified;
			}
			set
			{
				this.passcode_Grace_Period_EnabledFieldSpecified = value;
				this.RaisePropertyChanged("Passcode_Grace_Period_EnabledSpecified");
			}
		}

		[XmlElement(Order = 19)]
		public decimal Passcode_Grace_Period_Login_Remaining_Count
		{
			get
			{
				return this.passcode_Grace_Period_Login_Remaining_CountField;
			}
			set
			{
				this.passcode_Grace_Period_Login_Remaining_CountField = value;
				this.RaisePropertyChanged("Passcode_Grace_Period_Login_Remaining_Count");
			}
		}

		[XmlIgnore]
		public bool Passcode_Grace_Period_Login_Remaining_CountSpecified
		{
			get
			{
				return this.passcode_Grace_Period_Login_Remaining_CountFieldSpecified;
			}
			set
			{
				this.passcode_Grace_Period_Login_Remaining_CountFieldSpecified = value;
				this.RaisePropertyChanged("Passcode_Grace_Period_Login_Remaining_CountSpecified");
			}
		}

		[XmlElement(Order = 20)]
		public string OpenID_Identifier
		{
			get
			{
				return this.openID_IdentifierField;
			}
			set
			{
				this.openID_IdentifierField = value;
				this.RaisePropertyChanged("OpenID_Identifier");
			}
		}

		[XmlElement(Order = 21)]
		public string OpenID_Internal_Identifier
		{
			get
			{
				return this.openID_Internal_IdentifierField;
			}
			set
			{
				this.openID_Internal_IdentifierField = value;
				this.RaisePropertyChanged("OpenID_Internal_Identifier");
			}
		}

		[XmlElement(Order = 22)]
		public string OpenID_Connect_Internal_Identifier
		{
			get
			{
				return this.openID_Connect_Internal_IdentifierField;
			}
			set
			{
				this.openID_Connect_Internal_IdentifierField = value;
				this.RaisePropertyChanged("OpenID_Connect_Internal_Identifier");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
