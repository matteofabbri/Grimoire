using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Language_Achievement_DataType : INotifyPropertyChanged
	{
		private LanguageObjectType language_ReferenceField;

		private bool remove_LanguageField;

		private bool remove_LanguageFieldSpecified;

		private bool native_LanguageField;

		private bool native_LanguageFieldSpecified;

		private Language_AbilityType[] language_AbilityField;

		private DateTime assessed_OnField;

		private bool assessed_OnFieldSpecified;

		private string noteField;

		private RoleObjectType assessed_by_Worker_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public LanguageObjectType Language_Reference
		{
			get
			{
				return this.language_ReferenceField;
			}
			set
			{
				this.language_ReferenceField = value;
				this.RaisePropertyChanged("Language_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public bool Remove_Language
		{
			get
			{
				return this.remove_LanguageField;
			}
			set
			{
				this.remove_LanguageField = value;
				this.RaisePropertyChanged("Remove_Language");
			}
		}

		[XmlIgnore]
		public bool Remove_LanguageSpecified
		{
			get
			{
				return this.remove_LanguageFieldSpecified;
			}
			set
			{
				this.remove_LanguageFieldSpecified = value;
				this.RaisePropertyChanged("Remove_LanguageSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Native_Language
		{
			get
			{
				return this.native_LanguageField;
			}
			set
			{
				this.native_LanguageField = value;
				this.RaisePropertyChanged("Native_Language");
			}
		}

		[XmlIgnore]
		public bool Native_LanguageSpecified
		{
			get
			{
				return this.native_LanguageFieldSpecified;
			}
			set
			{
				this.native_LanguageFieldSpecified = value;
				this.RaisePropertyChanged("Native_LanguageSpecified");
			}
		}

		[XmlElement("Language_Ability", Order = 3)]
		public Language_AbilityType[] Language_Ability
		{
			get
			{
				return this.language_AbilityField;
			}
			set
			{
				this.language_AbilityField = value;
				this.RaisePropertyChanged("Language_Ability");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Assessed_On
		{
			get
			{
				return this.assessed_OnField;
			}
			set
			{
				this.assessed_OnField = value;
				this.RaisePropertyChanged("Assessed_On");
			}
		}

		[XmlIgnore]
		public bool Assessed_OnSpecified
		{
			get
			{
				return this.assessed_OnFieldSpecified;
			}
			set
			{
				this.assessed_OnFieldSpecified = value;
				this.RaisePropertyChanged("Assessed_OnSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public string Note
		{
			get
			{
				return this.noteField;
			}
			set
			{
				this.noteField = value;
				this.RaisePropertyChanged("Note");
			}
		}

		[XmlElement(Order = 6)]
		public RoleObjectType Assessed_by_Worker_Reference
		{
			get
			{
				return this.assessed_by_Worker_ReferenceField;
			}
			set
			{
				this.assessed_by_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Assessed_by_Worker_Reference");
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
