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
	public class System_User_for_Worker_DataType : INotifyPropertyChanged
	{
		private string user_NameField;

		private User_LanguageObjectType user_Language__ReferenceField;

		private LocaleObjectType locale__ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private Time_ZoneObjectType time_Zone_ReferenceField;

		private User_LanguageObjectType default_Display_Language_ReferenceField;

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
		public User_LanguageObjectType User_Language__Reference
		{
			get
			{
				return this.user_Language__ReferenceField;
			}
			set
			{
				this.user_Language__ReferenceField = value;
				this.RaisePropertyChanged("User_Language__Reference");
			}
		}

		[XmlElement(Order = 2)]
		public LocaleObjectType Locale__Reference
		{
			get
			{
				return this.locale__ReferenceField;
			}
			set
			{
				this.locale__ReferenceField = value;
				this.RaisePropertyChanged("Locale__Reference");
			}
		}

		[XmlElement(Order = 3)]
		public CurrencyObjectType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Time_ZoneObjectType Time_Zone_Reference
		{
			get
			{
				return this.time_Zone_ReferenceField;
			}
			set
			{
				this.time_Zone_ReferenceField = value;
				this.RaisePropertyChanged("Time_Zone_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public User_LanguageObjectType Default_Display_Language_Reference
		{
			get
			{
				return this.default_Display_Language_ReferenceField;
			}
			set
			{
				this.default_Display_Language_ReferenceField = value;
				this.RaisePropertyChanged("Default_Display_Language_Reference");
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
