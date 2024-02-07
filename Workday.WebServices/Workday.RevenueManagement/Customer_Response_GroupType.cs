using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Customer_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_ReferenceField;

		private bool include_ReferenceFieldSpecified;

		private bool include_Customer_DataField;

		private bool include_Customer_DataFieldSpecified;

		private bool include_Customer_BalanceField;

		private bool include_Customer_BalanceFieldSpecified;

		private bool include_Customer_Activity_DetailField;

		private bool include_Customer_Activity_DetailFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Include_Reference
		{
			get
			{
				return this.include_ReferenceField;
			}
			set
			{
				this.include_ReferenceField = value;
				this.RaisePropertyChanged("Include_Reference");
			}
		}

		[XmlIgnore]
		public bool Include_ReferenceSpecified
		{
			get
			{
				return this.include_ReferenceFieldSpecified;
			}
			set
			{
				this.include_ReferenceFieldSpecified = value;
				this.RaisePropertyChanged("Include_ReferenceSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Include_Customer_Data
		{
			get
			{
				return this.include_Customer_DataField;
			}
			set
			{
				this.include_Customer_DataField = value;
				this.RaisePropertyChanged("Include_Customer_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Customer_DataSpecified
		{
			get
			{
				return this.include_Customer_DataFieldSpecified;
			}
			set
			{
				this.include_Customer_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Customer_DataSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Customer_Balance
		{
			get
			{
				return this.include_Customer_BalanceField;
			}
			set
			{
				this.include_Customer_BalanceField = value;
				this.RaisePropertyChanged("Include_Customer_Balance");
			}
		}

		[XmlIgnore]
		public bool Include_Customer_BalanceSpecified
		{
			get
			{
				return this.include_Customer_BalanceFieldSpecified;
			}
			set
			{
				this.include_Customer_BalanceFieldSpecified = value;
				this.RaisePropertyChanged("Include_Customer_BalanceSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Include_Customer_Activity_Detail
		{
			get
			{
				return this.include_Customer_Activity_DetailField;
			}
			set
			{
				this.include_Customer_Activity_DetailField = value;
				this.RaisePropertyChanged("Include_Customer_Activity_Detail");
			}
		}

		[XmlIgnore]
		public bool Include_Customer_Activity_DetailSpecified
		{
			get
			{
				return this.include_Customer_Activity_DetailFieldSpecified;
			}
			set
			{
				this.include_Customer_Activity_DetailFieldSpecified = value;
				this.RaisePropertyChanged("Include_Customer_Activity_DetailSpecified");
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
