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
	public class Payroll_Support_Order_DataType : INotifyPropertyChanged
	{
		private bool itemField;

		private ItemChoiceType2 itemElementNameField;

		private string custodial_Party_NameField;

		private bool supports_Second_FamilyField;

		private bool supports_Second_FamilyFieldSpecified;

		private string remittance_ID_OverrideField;

		private Support_Order_Dependent_DataType[] support_Order_Dependant_ReferenceField;

		private Payroll_Support_Order_Detail_DataType[] support_Order_Details_ReferenceField;

		private string payroll_Local_County_Authority_FIPS_CodeField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Amended_Order", typeof(bool), Order = 0), XmlElement("Original_Order", typeof(bool), Order = 0), XmlElement("Termination_Order", typeof(bool), Order = 0)]
		public bool Item
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

		[XmlElement(Order = 1), XmlIgnore]
		public ItemChoiceType2 ItemElementName
		{
			get
			{
				return this.itemElementNameField;
			}
			set
			{
				this.itemElementNameField = value;
				this.RaisePropertyChanged("ItemElementName");
			}
		}

		[XmlElement(Order = 2)]
		public string Custodial_Party_Name
		{
			get
			{
				return this.custodial_Party_NameField;
			}
			set
			{
				this.custodial_Party_NameField = value;
				this.RaisePropertyChanged("Custodial_Party_Name");
			}
		}

		[XmlElement(Order = 3)]
		public bool Supports_Second_Family
		{
			get
			{
				return this.supports_Second_FamilyField;
			}
			set
			{
				this.supports_Second_FamilyField = value;
				this.RaisePropertyChanged("Supports_Second_Family");
			}
		}

		[XmlIgnore]
		public bool Supports_Second_FamilySpecified
		{
			get
			{
				return this.supports_Second_FamilyFieldSpecified;
			}
			set
			{
				this.supports_Second_FamilyFieldSpecified = value;
				this.RaisePropertyChanged("Supports_Second_FamilySpecified");
			}
		}

		[XmlElement(Order = 4)]
		public string Remittance_ID_Override
		{
			get
			{
				return this.remittance_ID_OverrideField;
			}
			set
			{
				this.remittance_ID_OverrideField = value;
				this.RaisePropertyChanged("Remittance_ID_Override");
			}
		}

		[XmlElement("Support_Order_Dependant_Reference", Order = 5)]
		public Support_Order_Dependent_DataType[] Support_Order_Dependant_Reference
		{
			get
			{
				return this.support_Order_Dependant_ReferenceField;
			}
			set
			{
				this.support_Order_Dependant_ReferenceField = value;
				this.RaisePropertyChanged("Support_Order_Dependant_Reference");
			}
		}

		[XmlElement("Support_Order_Details_Reference", Order = 6)]
		public Payroll_Support_Order_Detail_DataType[] Support_Order_Details_Reference
		{
			get
			{
				return this.support_Order_Details_ReferenceField;
			}
			set
			{
				this.support_Order_Details_ReferenceField = value;
				this.RaisePropertyChanged("Support_Order_Details_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public string Payroll_Local_County_Authority_FIPS_Code
		{
			get
			{
				return this.payroll_Local_County_Authority_FIPS_CodeField;
			}
			set
			{
				this.payroll_Local_County_Authority_FIPS_CodeField = value;
				this.RaisePropertyChanged("Payroll_Local_County_Authority_FIPS_Code");
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
