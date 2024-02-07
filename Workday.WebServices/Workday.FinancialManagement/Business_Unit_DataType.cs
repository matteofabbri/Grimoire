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
	public class Business_Unit_DataType : INotifyPropertyChanged
	{
		private string business_Unit_IDField;

		private string business_Unit_NameField;

		private bool include_Business_Unit_ID_in_NameField;

		private bool include_Business_Unit_ID_in_NameFieldSpecified;

		private bool business_Unit_is_InactiveField;

		private bool business_Unit_is_InactiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Business_Unit_ID
		{
			get
			{
				return this.business_Unit_IDField;
			}
			set
			{
				this.business_Unit_IDField = value;
				this.RaisePropertyChanged("Business_Unit_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Business_Unit_Name
		{
			get
			{
				return this.business_Unit_NameField;
			}
			set
			{
				this.business_Unit_NameField = value;
				this.RaisePropertyChanged("Business_Unit_Name");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Business_Unit_ID_in_Name
		{
			get
			{
				return this.include_Business_Unit_ID_in_NameField;
			}
			set
			{
				this.include_Business_Unit_ID_in_NameField = value;
				this.RaisePropertyChanged("Include_Business_Unit_ID_in_Name");
			}
		}

		[XmlIgnore]
		public bool Include_Business_Unit_ID_in_NameSpecified
		{
			get
			{
				return this.include_Business_Unit_ID_in_NameFieldSpecified;
			}
			set
			{
				this.include_Business_Unit_ID_in_NameFieldSpecified = value;
				this.RaisePropertyChanged("Include_Business_Unit_ID_in_NameSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Business_Unit_is_Inactive
		{
			get
			{
				return this.business_Unit_is_InactiveField;
			}
			set
			{
				this.business_Unit_is_InactiveField = value;
				this.RaisePropertyChanged("Business_Unit_is_Inactive");
			}
		}

		[XmlIgnore]
		public bool Business_Unit_is_InactiveSpecified
		{
			get
			{
				return this.business_Unit_is_InactiveFieldSpecified;
			}
			set
			{
				this.business_Unit_is_InactiveFieldSpecified = value;
				this.RaisePropertyChanged("Business_Unit_is_InactiveSpecified");
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
