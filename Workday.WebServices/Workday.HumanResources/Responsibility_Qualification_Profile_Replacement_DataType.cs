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
	public class Responsibility_Qualification_Profile_Replacement_DataType : INotifyPropertyChanged
	{
		private string responsibility_DescriptionField;

		private bool requiredField;

		private bool requiredFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Responsibility_Description
		{
			get
			{
				return this.responsibility_DescriptionField;
			}
			set
			{
				this.responsibility_DescriptionField = value;
				this.RaisePropertyChanged("Responsibility_Description");
			}
		}

		[XmlElement(Order = 1)]
		public bool Required
		{
			get
			{
				return this.requiredField;
			}
			set
			{
				this.requiredField = value;
				this.RaisePropertyChanged("Required");
			}
		}

		[XmlIgnore]
		public bool RequiredSpecified
		{
			get
			{
				return this.requiredFieldSpecified;
			}
			set
			{
				this.requiredFieldSpecified = value;
				this.RaisePropertyChanged("RequiredSpecified");
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
