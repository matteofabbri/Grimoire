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
	public class Beneficiary_DataType : INotifyPropertyChanged
	{
		private string beneficiary_IDField;

		private bool irrevocableField;

		private bool irrevocableFieldSpecified;

		private DateTime inactive_DateField;

		private bool inactive_DateFieldSpecified;

		private Qualified_Domestic_Relations_Order_Replacement_DataType[] court_OrderField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Beneficiary_ID
		{
			get
			{
				return this.beneficiary_IDField;
			}
			set
			{
				this.beneficiary_IDField = value;
				this.RaisePropertyChanged("Beneficiary_ID");
			}
		}

		[XmlElement(Order = 1)]
		public bool Irrevocable
		{
			get
			{
				return this.irrevocableField;
			}
			set
			{
				this.irrevocableField = value;
				this.RaisePropertyChanged("Irrevocable");
			}
		}

		[XmlIgnore]
		public bool IrrevocableSpecified
		{
			get
			{
				return this.irrevocableFieldSpecified;
			}
			set
			{
				this.irrevocableFieldSpecified = value;
				this.RaisePropertyChanged("IrrevocableSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Inactive_Date
		{
			get
			{
				return this.inactive_DateField;
			}
			set
			{
				this.inactive_DateField = value;
				this.RaisePropertyChanged("Inactive_Date");
			}
		}

		[XmlIgnore]
		public bool Inactive_DateSpecified
		{
			get
			{
				return this.inactive_DateFieldSpecified;
			}
			set
			{
				this.inactive_DateFieldSpecified = value;
				this.RaisePropertyChanged("Inactive_DateSpecified");
			}
		}

		[XmlElement("Court_Order", Order = 3)]
		public Qualified_Domestic_Relations_Order_Replacement_DataType[] Court_Order
		{
			get
			{
				return this.court_OrderField;
			}
			set
			{
				this.court_OrderField = value;
				this.RaisePropertyChanged("Court_Order");
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
