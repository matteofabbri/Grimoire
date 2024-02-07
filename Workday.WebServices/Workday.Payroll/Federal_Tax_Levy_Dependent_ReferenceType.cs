using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Federal_Tax_Levy_Dependent_ReferenceType : INotifyPropertyChanged
	{
		private string dependent_NameField;

		private string dependent_Identification_NumberField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Dependent_Name
		{
			get
			{
				return this.dependent_NameField;
			}
			set
			{
				this.dependent_NameField = value;
				this.RaisePropertyChanged("Dependent_Name");
			}
		}

		[XmlElement(Order = 1)]
		public string Dependent_Identification_Number
		{
			get
			{
				return this.dependent_Identification_NumberField;
			}
			set
			{
				this.dependent_Identification_NumberField = value;
				this.RaisePropertyChanged("Dependent_Identification_Number");
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
