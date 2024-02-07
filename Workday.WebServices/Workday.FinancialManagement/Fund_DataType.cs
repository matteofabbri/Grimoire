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
	public class Fund_DataType : INotifyPropertyChanged
	{
		private string fund_IDField;

		private string fund_NameField;

		private bool include_Fund_ID_in_NameField;

		private bool include_Fund_ID_in_NameFieldSpecified;

		private Fund_TypeObjectType fund_Type_ReferenceField;

		private bool fund_is_InactiveField;

		private bool fund_is_InactiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Fund_ID
		{
			get
			{
				return this.fund_IDField;
			}
			set
			{
				this.fund_IDField = value;
				this.RaisePropertyChanged("Fund_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Fund_Name
		{
			get
			{
				return this.fund_NameField;
			}
			set
			{
				this.fund_NameField = value;
				this.RaisePropertyChanged("Fund_Name");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Fund_ID_in_Name
		{
			get
			{
				return this.include_Fund_ID_in_NameField;
			}
			set
			{
				this.include_Fund_ID_in_NameField = value;
				this.RaisePropertyChanged("Include_Fund_ID_in_Name");
			}
		}

		[XmlIgnore]
		public bool Include_Fund_ID_in_NameSpecified
		{
			get
			{
				return this.include_Fund_ID_in_NameFieldSpecified;
			}
			set
			{
				this.include_Fund_ID_in_NameFieldSpecified = value;
				this.RaisePropertyChanged("Include_Fund_ID_in_NameSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Fund_TypeObjectType Fund_Type_Reference
		{
			get
			{
				return this.fund_Type_ReferenceField;
			}
			set
			{
				this.fund_Type_ReferenceField = value;
				this.RaisePropertyChanged("Fund_Type_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public bool Fund_is_Inactive
		{
			get
			{
				return this.fund_is_InactiveField;
			}
			set
			{
				this.fund_is_InactiveField = value;
				this.RaisePropertyChanged("Fund_is_Inactive");
			}
		}

		[XmlIgnore]
		public bool Fund_is_InactiveSpecified
		{
			get
			{
				return this.fund_is_InactiveFieldSpecified;
			}
			set
			{
				this.fund_is_InactiveFieldSpecified = value;
				this.RaisePropertyChanged("Fund_is_InactiveSpecified");
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
