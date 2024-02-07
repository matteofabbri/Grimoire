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
	public class Payment_Message_Request_CriteriaType : INotifyPropertyChanged
	{
		private OrganizationObjectType[] organization_ReferenceField;

		private Bank_AccountObjectType bank_Account_ReferenceField;

		private Outsourced_Payment_GroupObjectType outsourced_Payment_Group_ReferenceField;

		private DateTime created_AfterField;

		private bool created_AfterFieldSpecified;

		private DateTime created_BeforeField;

		private bool created_BeforeFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Organization_Reference", Order = 0)]
		public OrganizationObjectType[] Organization_Reference
		{
			get
			{
				return this.organization_ReferenceField;
			}
			set
			{
				this.organization_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Bank_AccountObjectType Bank_Account_Reference
		{
			get
			{
				return this.bank_Account_ReferenceField;
			}
			set
			{
				this.bank_Account_ReferenceField = value;
				this.RaisePropertyChanged("Bank_Account_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Outsourced_Payment_GroupObjectType Outsourced_Payment_Group_Reference
		{
			get
			{
				return this.outsourced_Payment_Group_ReferenceField;
			}
			set
			{
				this.outsourced_Payment_Group_ReferenceField = value;
				this.RaisePropertyChanged("Outsourced_Payment_Group_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Created_After
		{
			get
			{
				return this.created_AfterField;
			}
			set
			{
				this.created_AfterField = value;
				this.RaisePropertyChanged("Created_After");
			}
		}

		[XmlIgnore]
		public bool Created_AfterSpecified
		{
			get
			{
				return this.created_AfterFieldSpecified;
			}
			set
			{
				this.created_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Created_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Created_Before
		{
			get
			{
				return this.created_BeforeField;
			}
			set
			{
				this.created_BeforeField = value;
				this.RaisePropertyChanged("Created_Before");
			}
		}

		[XmlIgnore]
		public bool Created_BeforeSpecified
		{
			get
			{
				return this.created_BeforeFieldSpecified;
			}
			set
			{
				this.created_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Created_BeforeSpecified");
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
