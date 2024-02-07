using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Disability_ReferenceType : INotifyPropertyChanged
	{
		private string disability_NameField;

		private Organization_ReferenceType[] regulatory_Region_Organization_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Disability_Name
		{
			get
			{
				return this.disability_NameField;
			}
			set
			{
				this.disability_NameField = value;
				this.RaisePropertyChanged("Disability_Name");
			}
		}

		[XmlElement("Regulatory_Region_Organization_Reference", Order = 1)]
		public Organization_ReferenceType[] Regulatory_Region_Organization_Reference
		{
			get
			{
				return this.regulatory_Region_Organization_ReferenceField;
			}
			set
			{
				this.regulatory_Region_Organization_ReferenceField = value;
				this.RaisePropertyChanged("Regulatory_Region_Organization_Reference");
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
