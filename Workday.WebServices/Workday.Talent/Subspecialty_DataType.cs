using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Subspecialty_DataType : INotifyPropertyChanged
	{
		private string subspecialty_NameField;

		private string subspecialty_DescriptionField;

		private string subspecialty_CodeField;

		private string subspecialty_IDField;

		private string uRLField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Subspecialty_Name
		{
			get
			{
				return this.subspecialty_NameField;
			}
			set
			{
				this.subspecialty_NameField = value;
				this.RaisePropertyChanged("Subspecialty_Name");
			}
		}

		[XmlElement(Order = 1)]
		public string Subspecialty_Description
		{
			get
			{
				return this.subspecialty_DescriptionField;
			}
			set
			{
				this.subspecialty_DescriptionField = value;
				this.RaisePropertyChanged("Subspecialty_Description");
			}
		}

		[XmlElement(Order = 2)]
		public string Subspecialty_Code
		{
			get
			{
				return this.subspecialty_CodeField;
			}
			set
			{
				this.subspecialty_CodeField = value;
				this.RaisePropertyChanged("Subspecialty_Code");
			}
		}

		[XmlElement(Order = 3)]
		public string Subspecialty_ID
		{
			get
			{
				return this.subspecialty_IDField;
			}
			set
			{
				this.subspecialty_IDField = value;
				this.RaisePropertyChanged("Subspecialty_ID");
			}
		}

		[XmlElement(Order = 4)]
		public string URL
		{
			get
			{
				return this.uRLField;
			}
			set
			{
				this.uRLField = value;
				this.RaisePropertyChanged("URL");
			}
		}

		[XmlElement(Order = 5)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
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
