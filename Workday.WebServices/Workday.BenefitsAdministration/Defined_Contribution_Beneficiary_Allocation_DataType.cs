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
	public class Defined_Contribution_Beneficiary_Allocation_DataType : INotifyPropertyChanged
	{
		private BeneficiaryObjectType beneficiary_ReferenceField;

		private Beneficary_Allocation_Percentage_DataType[] beneficiary_Allocation_Percentage_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public BeneficiaryObjectType Beneficiary_Reference
		{
			get
			{
				return this.beneficiary_ReferenceField;
			}
			set
			{
				this.beneficiary_ReferenceField = value;
				this.RaisePropertyChanged("Beneficiary_Reference");
			}
		}

		[XmlElement("Beneficiary_Allocation_Percentage_Data", Order = 1)]
		public Beneficary_Allocation_Percentage_DataType[] Beneficiary_Allocation_Percentage_Data
		{
			get
			{
				return this.beneficiary_Allocation_Percentage_DataField;
			}
			set
			{
				this.beneficiary_Allocation_Percentage_DataField = value;
				this.RaisePropertyChanged("Beneficiary_Allocation_Percentage_Data");
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
