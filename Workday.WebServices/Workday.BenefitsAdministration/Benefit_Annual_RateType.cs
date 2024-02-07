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
	public class Benefit_Annual_RateType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType benefit_Annual_Rate_ReferenceField;

		private Benefit_Annual_Rate_DataType benefit_Annual_Rate_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Benefit_Annual_Rate_Reference
		{
			get
			{
				return this.benefit_Annual_Rate_ReferenceField;
			}
			set
			{
				this.benefit_Annual_Rate_ReferenceField = value;
				this.RaisePropertyChanged("Benefit_Annual_Rate_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Benefit_Annual_Rate_DataType Benefit_Annual_Rate_Data
		{
			get
			{
				return this.benefit_Annual_Rate_DataField;
			}
			set
			{
				this.benefit_Annual_Rate_DataField = value;
				this.RaisePropertyChanged("Benefit_Annual_Rate_Data");
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
