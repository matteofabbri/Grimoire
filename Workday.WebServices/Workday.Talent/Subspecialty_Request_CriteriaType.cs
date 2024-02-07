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
	public class Subspecialty_Request_CriteriaType : INotifyPropertyChanged
	{
		private string subspecialty_NameField;

		private string subspecialty_CodeField;

		private bool subspecialty_ActiveField;

		private bool subspecialty_ActiveFieldSpecified;

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

		[XmlElement(Order = 2)]
		public bool Subspecialty_Active
		{
			get
			{
				return this.subspecialty_ActiveField;
			}
			set
			{
				this.subspecialty_ActiveField = value;
				this.RaisePropertyChanged("Subspecialty_Active");
			}
		}

		[XmlIgnore]
		public bool Subspecialty_ActiveSpecified
		{
			get
			{
				return this.subspecialty_ActiveFieldSpecified;
			}
			set
			{
				this.subspecialty_ActiveFieldSpecified = value;
				this.RaisePropertyChanged("Subspecialty_ActiveSpecified");
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
