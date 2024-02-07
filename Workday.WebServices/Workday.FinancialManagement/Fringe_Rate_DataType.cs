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
	public class Fringe_Rate_DataType : INotifyPropertyChanged
	{
		private string fringe_Rate_OrderField;

		private string fringe_Rate_DescriptionField;

		private decimal fringe_RateField;

		private bool fringe_RateFieldSpecified;

		private string fringe_Rate_IDField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Fringe_Rate_Order
		{
			get
			{
				return this.fringe_Rate_OrderField;
			}
			set
			{
				this.fringe_Rate_OrderField = value;
				this.RaisePropertyChanged("Fringe_Rate_Order");
			}
		}

		[XmlElement(Order = 1)]
		public string Fringe_Rate_Description
		{
			get
			{
				return this.fringe_Rate_DescriptionField;
			}
			set
			{
				this.fringe_Rate_DescriptionField = value;
				this.RaisePropertyChanged("Fringe_Rate_Description");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Fringe_Rate
		{
			get
			{
				return this.fringe_RateField;
			}
			set
			{
				this.fringe_RateField = value;
				this.RaisePropertyChanged("Fringe_Rate");
			}
		}

		[XmlIgnore]
		public bool Fringe_RateSpecified
		{
			get
			{
				return this.fringe_RateFieldSpecified;
			}
			set
			{
				this.fringe_RateFieldSpecified = value;
				this.RaisePropertyChanged("Fringe_RateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public string Fringe_Rate_ID
		{
			get
			{
				return this.fringe_Rate_IDField;
			}
			set
			{
				this.fringe_Rate_IDField = value;
				this.RaisePropertyChanged("Fringe_Rate_ID");
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
