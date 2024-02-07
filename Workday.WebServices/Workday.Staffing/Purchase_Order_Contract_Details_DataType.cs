using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Purchase_Order_Contract_Details_DataType : INotifyPropertyChanged
	{
		private CompanyObjectType company_for_Purchase_Order_ReferenceField;

		private WorkerObjectType requester_ReferenceField;

		private Spend_CategoryObjectType spend_Category_ReferenceField;

		private decimal contract_AmountField;

		private bool contract_AmountFieldSpecified;

		private Audited_Accounting_WorktagObjectType[] worktags_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public CompanyObjectType Company_for_Purchase_Order_Reference
		{
			get
			{
				return this.company_for_Purchase_Order_ReferenceField;
			}
			set
			{
				this.company_for_Purchase_Order_ReferenceField = value;
				this.RaisePropertyChanged("Company_for_Purchase_Order_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public WorkerObjectType Requester_Reference
		{
			get
			{
				return this.requester_ReferenceField;
			}
			set
			{
				this.requester_ReferenceField = value;
				this.RaisePropertyChanged("Requester_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Spend_CategoryObjectType Spend_Category_Reference
		{
			get
			{
				return this.spend_Category_ReferenceField;
			}
			set
			{
				this.spend_Category_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Category_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Contract_Amount
		{
			get
			{
				return this.contract_AmountField;
			}
			set
			{
				this.contract_AmountField = value;
				this.RaisePropertyChanged("Contract_Amount");
			}
		}

		[XmlIgnore]
		public bool Contract_AmountSpecified
		{
			get
			{
				return this.contract_AmountFieldSpecified;
			}
			set
			{
				this.contract_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Contract_AmountSpecified");
			}
		}

		[XmlElement("Worktags_Reference", Order = 4)]
		public Audited_Accounting_WorktagObjectType[] Worktags_Reference
		{
			get
			{
				return this.worktags_ReferenceField;
			}
			set
			{
				this.worktags_ReferenceField = value;
				this.RaisePropertyChanged("Worktags_Reference");
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
