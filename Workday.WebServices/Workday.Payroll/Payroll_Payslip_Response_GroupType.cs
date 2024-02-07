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
	public class Payroll_Payslip_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_Originating_Contact_DataField;

		private bool include_Originating_Contact_DataFieldSpecified;

		private bool include_Originating_Bank_DataField;

		private bool include_Originating_Bank_DataFieldSpecified;

		private bool include_Receiving_Party_Contact_DataField;

		private bool include_Receiving_Party_Contact_DataFieldSpecified;

		private bool include_Receiving_Party_Bank_DataField;

		private bool include_Receiving_Party_Bank_DataFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Include_Originating_Contact_Data
		{
			get
			{
				return this.include_Originating_Contact_DataField;
			}
			set
			{
				this.include_Originating_Contact_DataField = value;
				this.RaisePropertyChanged("Include_Originating_Contact_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Originating_Contact_DataSpecified
		{
			get
			{
				return this.include_Originating_Contact_DataFieldSpecified;
			}
			set
			{
				this.include_Originating_Contact_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Originating_Contact_DataSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Include_Originating_Bank_Data
		{
			get
			{
				return this.include_Originating_Bank_DataField;
			}
			set
			{
				this.include_Originating_Bank_DataField = value;
				this.RaisePropertyChanged("Include_Originating_Bank_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Originating_Bank_DataSpecified
		{
			get
			{
				return this.include_Originating_Bank_DataFieldSpecified;
			}
			set
			{
				this.include_Originating_Bank_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Originating_Bank_DataSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Receiving_Party_Contact_Data
		{
			get
			{
				return this.include_Receiving_Party_Contact_DataField;
			}
			set
			{
				this.include_Receiving_Party_Contact_DataField = value;
				this.RaisePropertyChanged("Include_Receiving_Party_Contact_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Receiving_Party_Contact_DataSpecified
		{
			get
			{
				return this.include_Receiving_Party_Contact_DataFieldSpecified;
			}
			set
			{
				this.include_Receiving_Party_Contact_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Receiving_Party_Contact_DataSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Include_Receiving_Party_Bank_Data
		{
			get
			{
				return this.include_Receiving_Party_Bank_DataField;
			}
			set
			{
				this.include_Receiving_Party_Bank_DataField = value;
				this.RaisePropertyChanged("Include_Receiving_Party_Bank_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Receiving_Party_Bank_DataSpecified
		{
			get
			{
				return this.include_Receiving_Party_Bank_DataFieldSpecified;
			}
			set
			{
				this.include_Receiving_Party_Bank_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Receiving_Party_Bank_DataSpecified");
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
