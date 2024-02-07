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
	public class Intercompany_Profile_DataType : INotifyPropertyChanged
	{
		private string intercompany_Profile_MemoField;

		private bool intercompany_Transactions_AllowedField;

		private bool intercompany_Transactions_AllowedFieldSpecified;

		private bool intercompany_Settle_OnlyField;

		private bool intercompany_Settle_OnlyFieldSpecified;

		private CompanyObjectType from_Company_ReferenceField;

		private CompanyObjectType to_Company_ReferenceField;

		private Settlement_InstructionObjectType[] settlement_Instruction_ReferenceField;

		private Payment_TypeObjectType[] allowed_Payment_Type_ReferenceField;

		private Payment_TypeObjectType default_Payment_Type_ReferenceField;

		private bool transfer_Asset_as_OriginalField;

		private bool transfer_Asset_as_OriginalFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Intercompany_Profile_Memo
		{
			get
			{
				return this.intercompany_Profile_MemoField;
			}
			set
			{
				this.intercompany_Profile_MemoField = value;
				this.RaisePropertyChanged("Intercompany_Profile_Memo");
			}
		}

		[XmlElement(Order = 1)]
		public bool Intercompany_Transactions_Allowed
		{
			get
			{
				return this.intercompany_Transactions_AllowedField;
			}
			set
			{
				this.intercompany_Transactions_AllowedField = value;
				this.RaisePropertyChanged("Intercompany_Transactions_Allowed");
			}
		}

		[XmlIgnore]
		public bool Intercompany_Transactions_AllowedSpecified
		{
			get
			{
				return this.intercompany_Transactions_AllowedFieldSpecified;
			}
			set
			{
				this.intercompany_Transactions_AllowedFieldSpecified = value;
				this.RaisePropertyChanged("Intercompany_Transactions_AllowedSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Intercompany_Settle_Only
		{
			get
			{
				return this.intercompany_Settle_OnlyField;
			}
			set
			{
				this.intercompany_Settle_OnlyField = value;
				this.RaisePropertyChanged("Intercompany_Settle_Only");
			}
		}

		[XmlIgnore]
		public bool Intercompany_Settle_OnlySpecified
		{
			get
			{
				return this.intercompany_Settle_OnlyFieldSpecified;
			}
			set
			{
				this.intercompany_Settle_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Intercompany_Settle_OnlySpecified");
			}
		}

		[XmlElement(Order = 3)]
		public CompanyObjectType From_Company_Reference
		{
			get
			{
				return this.from_Company_ReferenceField;
			}
			set
			{
				this.from_Company_ReferenceField = value;
				this.RaisePropertyChanged("From_Company_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public CompanyObjectType To_Company_Reference
		{
			get
			{
				return this.to_Company_ReferenceField;
			}
			set
			{
				this.to_Company_ReferenceField = value;
				this.RaisePropertyChanged("To_Company_Reference");
			}
		}

		[XmlElement("Settlement_Instruction_Reference", Order = 5)]
		public Settlement_InstructionObjectType[] Settlement_Instruction_Reference
		{
			get
			{
				return this.settlement_Instruction_ReferenceField;
			}
			set
			{
				this.settlement_Instruction_ReferenceField = value;
				this.RaisePropertyChanged("Settlement_Instruction_Reference");
			}
		}

		[XmlElement("Allowed_Payment_Type_Reference", Order = 6)]
		public Payment_TypeObjectType[] Allowed_Payment_Type_Reference
		{
			get
			{
				return this.allowed_Payment_Type_ReferenceField;
			}
			set
			{
				this.allowed_Payment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Allowed_Payment_Type_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public Payment_TypeObjectType Default_Payment_Type_Reference
		{
			get
			{
				return this.default_Payment_Type_ReferenceField;
			}
			set
			{
				this.default_Payment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Default_Payment_Type_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public bool Transfer_Asset_as_Original
		{
			get
			{
				return this.transfer_Asset_as_OriginalField;
			}
			set
			{
				this.transfer_Asset_as_OriginalField = value;
				this.RaisePropertyChanged("Transfer_Asset_as_Original");
			}
		}

		[XmlIgnore]
		public bool Transfer_Asset_as_OriginalSpecified
		{
			get
			{
				return this.transfer_Asset_as_OriginalFieldSpecified;
			}
			set
			{
				this.transfer_Asset_as_OriginalFieldSpecified = value;
				this.RaisePropertyChanged("Transfer_Asset_as_OriginalSpecified");
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
