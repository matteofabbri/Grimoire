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
	public class Basic_Customer_DataType : INotifyPropertyChanged
	{
		private string customer_IDField;

		private string customer_Reference_IDField;

		private string customer_NameField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Customer_ID
		{
			get
			{
				return this.customer_IDField;
			}
			set
			{
				this.customer_IDField = value;
				this.RaisePropertyChanged("Customer_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Customer_Reference_ID
		{
			get
			{
				return this.customer_Reference_IDField;
			}
			set
			{
				this.customer_Reference_IDField = value;
				this.RaisePropertyChanged("Customer_Reference_ID");
			}
		}

		[XmlElement(Order = 2)]
		public string Customer_Name
		{
			get
			{
				return this.customer_NameField;
			}
			set
			{
				this.customer_NameField = value;
				this.RaisePropertyChanged("Customer_Name");
			}
		}

		[XmlElement(Order = 3)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
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
