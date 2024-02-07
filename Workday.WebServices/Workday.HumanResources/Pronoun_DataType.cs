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
	public class Pronoun_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string pronoun_NameField;

		private string pronoun_CodeField;

		private string pronoun_DescriptionField;

		private bool pronoun_InactiveField;

		private bool pronoun_InactiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Pronoun_Name
		{
			get
			{
				return this.pronoun_NameField;
			}
			set
			{
				this.pronoun_NameField = value;
				this.RaisePropertyChanged("Pronoun_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Pronoun_Code
		{
			get
			{
				return this.pronoun_CodeField;
			}
			set
			{
				this.pronoun_CodeField = value;
				this.RaisePropertyChanged("Pronoun_Code");
			}
		}

		[XmlElement(Order = 3)]
		public string Pronoun_Description
		{
			get
			{
				return this.pronoun_DescriptionField;
			}
			set
			{
				this.pronoun_DescriptionField = value;
				this.RaisePropertyChanged("Pronoun_Description");
			}
		}

		[XmlElement(Order = 4)]
		public bool Pronoun_Inactive
		{
			get
			{
				return this.pronoun_InactiveField;
			}
			set
			{
				this.pronoun_InactiveField = value;
				this.RaisePropertyChanged("Pronoun_Inactive");
			}
		}

		[XmlIgnore]
		public bool Pronoun_InactiveSpecified
		{
			get
			{
				return this.pronoun_InactiveFieldSpecified;
			}
			set
			{
				this.pronoun_InactiveFieldSpecified = value;
				this.RaisePropertyChanged("Pronoun_InactiveSpecified");
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
