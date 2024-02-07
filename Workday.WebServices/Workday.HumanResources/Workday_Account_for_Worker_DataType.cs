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
	public class Workday_Account_for_Worker_DataType : INotifyPropertyChanged
	{
		private string user_NameField;

		private string passwordField;

		private bool generate_Random_PasswordField;

		private bool generate_Random_PasswordFieldSpecified;

		private bool require_New_Password_at_Next_Sign_InField;

		private bool require_New_Password_at_Next_Sign_InFieldSpecified;

		private bool oneTime_Passcode_ExemptField;

		private bool oneTime_Passcode_ExemptFieldSpecified;

		private bool oneTime_Passcode_Grace_Period_EnabledField;

		private bool oneTime_Passcode_Grace_Period_EnabledFieldSpecified;

		private decimal oneTime_Passcode_Grace_Period_Login_Remaining_CountField;

		private bool oneTime_Passcode_Grace_Period_Login_Remaining_CountFieldSpecified;

		private bool account_DisabledField;

		private bool account_DisabledFieldSpecified;

		private DateTime account_Expiration_DateField;

		private bool account_Expiration_DateFieldSpecified;

		private string openID_IdentifierField;

		private string openID_Internal_IdentifierField;

		private string openID_Connect_Internal_IdentifierField;

		private Integration_System__Audited_ObjectType delegated_Authentication_Integration_System_ReferenceField;

		private decimal session_Timeout_MinutesField;

		private bool session_Timeout_MinutesFieldSpecified;

		private bool show_User_Name_in_Browser_WindowField;

		private bool show_User_Name_in_Browser_WindowFieldSpecified;

		private bool display_XML_Icon_on_ReportsField;

		private bool display_XML_Icon_on_ReportsFieldSpecified;

		private bool enable_WorkboxField;

		private bool enable_WorkboxFieldSpecified;

		private LocaleObjectType locale_ReferenceField;

		private User_LanguageObjectType user_Language_ReferenceField;

		private Unique_IdentifierObjectType preferred_Search_Scope_ReferenceField;

		private bool allow_MixedLanguage_TransactionsField;

		private bool allow_MixedLanguage_TransactionsFieldSpecified;

		private Notification_Sub_Type_ConfigurationType[] notification_Sub_Type_ConfigurationsField;

		private bool exempt_from_Delegated_AuthenticationField;

		private bool exempt_from_Delegated_AuthenticationFieldSpecified;

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
		public string Password
		{
			get
			{
				return this.passwordField;
			}
			set
			{
				this.passwordField = value;
				this.RaisePropertyChanged("Password");
			}
		}

		[XmlElement(Order = 2)]
		public bool Generate_Random_Password
		{
			get
			{
				return this.generate_Random_PasswordField;
			}
			set
			{
				this.generate_Random_PasswordField = value;
				this.RaisePropertyChanged("Generate_Random_Password");
			}
		}

		[XmlIgnore]
		public bool Generate_Random_PasswordSpecified
		{
			get
			{
				return this.generate_Random_PasswordFieldSpecified;
			}
			set
			{
				this.generate_Random_PasswordFieldSpecified = value;
				this.RaisePropertyChanged("Generate_Random_PasswordSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Require_New_Password_at_Next_Sign_In
		{
			get
			{
				return this.require_New_Password_at_Next_Sign_InField;
			}
			set
			{
				this.require_New_Password_at_Next_Sign_InField = value;
				this.RaisePropertyChanged("Require_New_Password_at_Next_Sign_In");
			}
		}

		[XmlIgnore]
		public bool Require_New_Password_at_Next_Sign_InSpecified
		{
			get
			{
				return this.require_New_Password_at_Next_Sign_InFieldSpecified;
			}
			set
			{
				this.require_New_Password_at_Next_Sign_InFieldSpecified = value;
				this.RaisePropertyChanged("Require_New_Password_at_Next_Sign_InSpecified");
			}
		}

		[XmlElement("One-Time_Passcode_Exempt", Order = 4)]
		public bool OneTime_Passcode_Exempt
		{
			get
			{
				return this.oneTime_Passcode_ExemptField;
			}
			set
			{
				this.oneTime_Passcode_ExemptField = value;
				this.RaisePropertyChanged("OneTime_Passcode_Exempt");
			}
		}

		[XmlIgnore]
		public bool OneTime_Passcode_ExemptSpecified
		{
			get
			{
				return this.oneTime_Passcode_ExemptFieldSpecified;
			}
			set
			{
				this.oneTime_Passcode_ExemptFieldSpecified = value;
				this.RaisePropertyChanged("OneTime_Passcode_ExemptSpecified");
			}
		}

		[XmlElement("One-Time_Passcode_Grace_Period_Enabled", Order = 5)]
		public bool OneTime_Passcode_Grace_Period_Enabled
		{
			get
			{
				return this.oneTime_Passcode_Grace_Period_EnabledField;
			}
			set
			{
				this.oneTime_Passcode_Grace_Period_EnabledField = value;
				this.RaisePropertyChanged("OneTime_Passcode_Grace_Period_Enabled");
			}
		}

		[XmlIgnore]
		public bool OneTime_Passcode_Grace_Period_EnabledSpecified
		{
			get
			{
				return this.oneTime_Passcode_Grace_Period_EnabledFieldSpecified;
			}
			set
			{
				this.oneTime_Passcode_Grace_Period_EnabledFieldSpecified = value;
				this.RaisePropertyChanged("OneTime_Passcode_Grace_Period_EnabledSpecified");
			}
		}

		[XmlElement("One-Time_Passcode_Grace_Period_Login_Remaining_Count", Order = 6)]
		public decimal OneTime_Passcode_Grace_Period_Login_Remaining_Count
		{
			get
			{
				return this.oneTime_Passcode_Grace_Period_Login_Remaining_CountField;
			}
			set
			{
				this.oneTime_Passcode_Grace_Period_Login_Remaining_CountField = value;
				this.RaisePropertyChanged("OneTime_Passcode_Grace_Period_Login_Remaining_Count");
			}
		}

		[XmlIgnore]
		public bool OneTime_Passcode_Grace_Period_Login_Remaining_CountSpecified
		{
			get
			{
				return this.oneTime_Passcode_Grace_Period_Login_Remaining_CountFieldSpecified;
			}
			set
			{
				this.oneTime_Passcode_Grace_Period_Login_Remaining_CountFieldSpecified = value;
				this.RaisePropertyChanged("OneTime_Passcode_Grace_Period_Login_Remaining_CountSpecified");
			}
		}

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
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

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 13)]
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

		[XmlElement(Order = 14)]
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

		[XmlElement(Order = 15)]
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

		[XmlElement(Order = 16)]
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

		[XmlElement(Order = 17)]
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

		[XmlElement(Order = 18)]
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

		[XmlElement(Order = 19)]
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

		[XmlElement("Allow_Mixed-Language_Transactions", Order = 20)]
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

		[XmlArray(Order = 21), XmlArrayItem("Notification_Sub_Type_Configuration", typeof(Notification_Sub_Type_ConfigurationType), IsNullable = false)]
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

		[XmlElement(Order = 22)]
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
