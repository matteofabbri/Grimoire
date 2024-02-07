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
	public class Compensation_Summary_DataType : INotifyPropertyChanged
	{
		private decimal total_CompensationField;

		private bool total_CompensationFieldSpecified;

		private decimal total_Base_PayField;

		private bool total_Base_PayFieldSpecified;

		private Currency_Reference_DataType currency_ReferenceField;

		private Frequency_Reference_DataType frequency_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Total_Compensation
		{
			get
			{
				return this.total_CompensationField;
			}
			set
			{
				this.total_CompensationField = value;
				this.RaisePropertyChanged("Total_Compensation");
			}
		}

		[XmlIgnore]
		public bool Total_CompensationSpecified
		{
			get
			{
				return this.total_CompensationFieldSpecified;
			}
			set
			{
				this.total_CompensationFieldSpecified = value;
				this.RaisePropertyChanged("Total_CompensationSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Total_Base_Pay
		{
			get
			{
				return this.total_Base_PayField;
			}
			set
			{
				this.total_Base_PayField = value;
				this.RaisePropertyChanged("Total_Base_Pay");
			}
		}

		[XmlIgnore]
		public bool Total_Base_PaySpecified
		{
			get
			{
				return this.total_Base_PayFieldSpecified;
			}
			set
			{
				this.total_Base_PayFieldSpecified = value;
				this.RaisePropertyChanged("Total_Base_PaySpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Currency_Reference_DataType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Frequency_Reference_DataType Frequency_Reference
		{
			get
			{
				return this.frequency_ReferenceField;
			}
			set
			{
				this.frequency_ReferenceField = value;
				this.RaisePropertyChanged("Frequency_Reference");
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
