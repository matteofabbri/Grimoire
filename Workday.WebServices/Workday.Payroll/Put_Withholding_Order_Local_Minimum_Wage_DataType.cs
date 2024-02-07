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
	public class Put_Withholding_Order_Local_Minimum_Wage_DataType : INotifyPropertyChanged
	{
		private object itemField;

		private DateTime effective_DateField;

		private decimal local_Minimum_WageField;

		private bool local_Minimum_WageFieldSpecified;

		private string commentField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Local_Minimum_Wage_Reference", typeof(Unique_IdentifierObjectType), Order = 0), XmlElement("Payroll_Involuntary_Withholding_Order_Reference", typeof(Withholding_OrderObjectType), Order = 0)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Local_Minimum_Wage
		{
			get
			{
				return this.local_Minimum_WageField;
			}
			set
			{
				this.local_Minimum_WageField = value;
				this.RaisePropertyChanged("Local_Minimum_Wage");
			}
		}

		[XmlIgnore]
		public bool Local_Minimum_WageSpecified
		{
			get
			{
				return this.local_Minimum_WageFieldSpecified;
			}
			set
			{
				this.local_Minimum_WageFieldSpecified = value;
				this.RaisePropertyChanged("Local_Minimum_WageSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public string Comment
		{
			get
			{
				return this.commentField;
			}
			set
			{
				this.commentField = value;
				this.RaisePropertyChanged("Comment");
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
