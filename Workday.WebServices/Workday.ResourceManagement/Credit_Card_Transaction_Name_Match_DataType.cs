using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Credit_Card_Transaction_Name_Match_DataType : INotifyPropertyChanged
	{
		private decimal confidence_PercentageField;

		private bool confidence_PercentageFieldSpecified;

		private Abstract_Spend_Data_NameObjectType merchant_ReferenceField;

		private Abstract_Spend_Data_NameObjectType origination_City_ReferenceField;

		private Abstract_Spend_Data_NameObjectType destination_City_ReferenceField;

		private Abstract_Payee_Data_NameObjectType supplier_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Confidence_Percentage
		{
			get
			{
				return this.confidence_PercentageField;
			}
			set
			{
				this.confidence_PercentageField = value;
				this.RaisePropertyChanged("Confidence_Percentage");
			}
		}

		[XmlIgnore]
		public bool Confidence_PercentageSpecified
		{
			get
			{
				return this.confidence_PercentageFieldSpecified;
			}
			set
			{
				this.confidence_PercentageFieldSpecified = value;
				this.RaisePropertyChanged("Confidence_PercentageSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Abstract_Spend_Data_NameObjectType Merchant_Reference
		{
			get
			{
				return this.merchant_ReferenceField;
			}
			set
			{
				this.merchant_ReferenceField = value;
				this.RaisePropertyChanged("Merchant_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Abstract_Spend_Data_NameObjectType Origination_City_Reference
		{
			get
			{
				return this.origination_City_ReferenceField;
			}
			set
			{
				this.origination_City_ReferenceField = value;
				this.RaisePropertyChanged("Origination_City_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Abstract_Spend_Data_NameObjectType Destination_City_Reference
		{
			get
			{
				return this.destination_City_ReferenceField;
			}
			set
			{
				this.destination_City_ReferenceField = value;
				this.RaisePropertyChanged("Destination_City_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Abstract_Payee_Data_NameObjectType Supplier_Reference
		{
			get
			{
				return this.supplier_ReferenceField;
			}
			set
			{
				this.supplier_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Reference");
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
