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
	public class BeneficiaryType : INotifyPropertyChanged
	{
		private BeneficiaryObjectType beneficiary_ReferenceField;

		private Beneficiary_DataType beneficiary_DataField;

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

		[XmlElement(Order = 1)]
		public Beneficiary_DataType Beneficiary_Data
		{
			get
			{
				return this.beneficiary_DataField;
			}
			set
			{
				this.beneficiary_DataField = value;
				this.RaisePropertyChanged("Beneficiary_Data");
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
