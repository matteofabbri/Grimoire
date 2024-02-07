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
	public class Gender_Identity_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string gender_Identity_NameField;

		private string gender_Identity_CodeField;

		private string gender_Identity_DescriptionField;

		private bool gender_Identity_InactiveField;

		private bool gender_Identity_InactiveFieldSpecified;

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
		public string Gender_Identity_Name
		{
			get
			{
				return this.gender_Identity_NameField;
			}
			set
			{
				this.gender_Identity_NameField = value;
				this.RaisePropertyChanged("Gender_Identity_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Gender_Identity_Code
		{
			get
			{
				return this.gender_Identity_CodeField;
			}
			set
			{
				this.gender_Identity_CodeField = value;
				this.RaisePropertyChanged("Gender_Identity_Code");
			}
		}

		[XmlElement(Order = 3)]
		public string Gender_Identity_Description
		{
			get
			{
				return this.gender_Identity_DescriptionField;
			}
			set
			{
				this.gender_Identity_DescriptionField = value;
				this.RaisePropertyChanged("Gender_Identity_Description");
			}
		}

		[XmlElement(Order = 4)]
		public bool Gender_Identity_Inactive
		{
			get
			{
				return this.gender_Identity_InactiveField;
			}
			set
			{
				this.gender_Identity_InactiveField = value;
				this.RaisePropertyChanged("Gender_Identity_Inactive");
			}
		}

		[XmlIgnore]
		public bool Gender_Identity_InactiveSpecified
		{
			get
			{
				return this.gender_Identity_InactiveFieldSpecified;
			}
			set
			{
				this.gender_Identity_InactiveFieldSpecified = value;
				this.RaisePropertyChanged("Gender_Identity_InactiveSpecified");
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
