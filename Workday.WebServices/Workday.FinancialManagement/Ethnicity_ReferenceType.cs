using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Ethnicity_ReferenceType : INotifyPropertyChanged
	{
		private string ethnicity_NameField;

		private Organization_ReferenceType regulatory_Region_Organization_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Ethnicity_Name
		{
			get
			{
				return this.ethnicity_NameField;
			}
			set
			{
				this.ethnicity_NameField = value;
				this.RaisePropertyChanged("Ethnicity_Name");
			}
		}

		[XmlElement(Order = 1)]
		public Organization_ReferenceType Regulatory_Region_Organization_Reference
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
