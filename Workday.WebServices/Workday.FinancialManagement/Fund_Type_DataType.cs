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
	public class Fund_Type_DataType : INotifyPropertyChanged
	{
		private string fund_Type_IDField;

		private string fund_Type_NameField;

		private bool include_Fund_Type_ID_in_NameField;

		private bool include_Fund_Type_ID_in_NameFieldSpecified;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private Fund_RestrictionObjectType fund_Restriction_ReferenceField;

		private Funded_ByObjectType funded_By_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Fund_Type_ID
		{
			get
			{
				return this.fund_Type_IDField;
			}
			set
			{
				this.fund_Type_IDField = value;
				this.RaisePropertyChanged("Fund_Type_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Fund_Type_Name
		{
			get
			{
				return this.fund_Type_NameField;
			}
			set
			{
				this.fund_Type_NameField = value;
				this.RaisePropertyChanged("Fund_Type_Name");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Fund_Type_ID_in_Name
		{
			get
			{
				return this.include_Fund_Type_ID_in_NameField;
			}
			set
			{
				this.include_Fund_Type_ID_in_NameField = value;
				this.RaisePropertyChanged("Include_Fund_Type_ID_in_Name");
			}
		}

		[XmlIgnore]
		public bool Include_Fund_Type_ID_in_NameSpecified
		{
			get
			{
				return this.include_Fund_Type_ID_in_NameFieldSpecified;
			}
			set
			{
				this.include_Fund_Type_ID_in_NameFieldSpecified = value;
				this.RaisePropertyChanged("Include_Fund_Type_ID_in_NameSpecified");
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

		[XmlElement(Order = 4)]
		public Fund_RestrictionObjectType Fund_Restriction_Reference
		{
			get
			{
				return this.fund_Restriction_ReferenceField;
			}
			set
			{
				this.fund_Restriction_ReferenceField = value;
				this.RaisePropertyChanged("Fund_Restriction_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Funded_ByObjectType Funded_By_Reference
		{
			get
			{
				return this.funded_By_ReferenceField;
			}
			set
			{
				this.funded_By_ReferenceField = value;
				this.RaisePropertyChanged("Funded_By_Reference");
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
