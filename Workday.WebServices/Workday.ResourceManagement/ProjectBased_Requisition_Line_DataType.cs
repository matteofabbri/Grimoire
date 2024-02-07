using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Project-Based_Requisition_Line_DataType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class ProjectBased_Requisition_Line_DataType : INotifyPropertyChanged
	{
		private ProjectBased_Requisition_LineObjectType deliverables_Line_ReferenceField;

		private string deliverables_Requisition_Line_IDField;

		private ProjectObjectType project_ReferenceField;

		private Resource_ProviderObjectType supplier_ReferenceField;

		private string memoField;

		private Spend_CategoryObjectType spend_Category_ReferenceField;

		private Project_Plan_Phase_Requisition_DataType[] project_Phase_DataField;

		private decimal extended_AmountField;

		private bool extended_AmountFieldSpecified;

		private Accounting_WorktagObjectType[] worktags_ReferenceField;

		private bool source_This_LineField;

		private bool source_This_LineFieldSpecified;

		private bool mark_Purchase_Order_As_IssuedField;

		private bool mark_Purchase_Order_As_IssuedFieldSpecified;

		private Purchase_Order_LineObjectType[] purchase_Order_Line_ReferenceField;

		private Business_Document_Line_Split_DataType[] deliverables_Requisition_Line_Split_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public ProjectBased_Requisition_LineObjectType Deliverables_Line_Reference
		{
			get
			{
				return this.deliverables_Line_ReferenceField;
			}
			set
			{
				this.deliverables_Line_ReferenceField = value;
				this.RaisePropertyChanged("Deliverables_Line_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Deliverables_Requisition_Line_ID
		{
			get
			{
				return this.deliverables_Requisition_Line_IDField;
			}
			set
			{
				this.deliverables_Requisition_Line_IDField = value;
				this.RaisePropertyChanged("Deliverables_Requisition_Line_ID");
			}
		}

		[XmlElement(Order = 2)]
		public ProjectObjectType Project_Reference
		{
			get
			{
				return this.project_ReferenceField;
			}
			set
			{
				this.project_ReferenceField = value;
				this.RaisePropertyChanged("Project_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Resource_ProviderObjectType Supplier_Reference
		{
			get
			{
				return this.supplier_ReferenceField;
			}
			set
			{
				this.supplier_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public string Memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
				this.RaisePropertyChanged("Memo");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement("Project_Phase_Data", Order = 6)]
		public Project_Plan_Phase_Requisition_DataType[] Project_Phase_Data
		{
			get
			{
				return this.project_Phase_DataField;
			}
			set
			{
				this.project_Phase_DataField = value;
				this.RaisePropertyChanged("Project_Phase_Data");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Extended_Amount
		{
			get
			{
				return this.extended_AmountField;
			}
			set
			{
				this.extended_AmountField = value;
				this.RaisePropertyChanged("Extended_Amount");
			}
		}

		[XmlIgnore]
		public bool Extended_AmountSpecified
		{
			get
			{
				return this.extended_AmountFieldSpecified;
			}
			set
			{
				this.extended_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Extended_AmountSpecified");
			}
		}

		[XmlElement("Worktags_Reference", Order = 8)]
		public Accounting_WorktagObjectType[] Worktags_Reference
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

		[XmlElement(Order = 9)]
		public bool Source_This_Line
		{
			get
			{
				return this.source_This_LineField;
			}
			set
			{
				this.source_This_LineField = value;
				this.RaisePropertyChanged("Source_This_Line");
			}
		}

		[XmlIgnore]
		public bool Source_This_LineSpecified
		{
			get
			{
				return this.source_This_LineFieldSpecified;
			}
			set
			{
				this.source_This_LineFieldSpecified = value;
				this.RaisePropertyChanged("Source_This_LineSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public bool Mark_Purchase_Order_As_Issued
		{
			get
			{
				return this.mark_Purchase_Order_As_IssuedField;
			}
			set
			{
				this.mark_Purchase_Order_As_IssuedField = value;
				this.RaisePropertyChanged("Mark_Purchase_Order_As_Issued");
			}
		}

		[XmlIgnore]
		public bool Mark_Purchase_Order_As_IssuedSpecified
		{
			get
			{
				return this.mark_Purchase_Order_As_IssuedFieldSpecified;
			}
			set
			{
				this.mark_Purchase_Order_As_IssuedFieldSpecified = value;
				this.RaisePropertyChanged("Mark_Purchase_Order_As_IssuedSpecified");
			}
		}

		[XmlElement("Purchase_Order_Line_Reference", Order = 11)]
		public Purchase_Order_LineObjectType[] Purchase_Order_Line_Reference
		{
			get
			{
				return this.purchase_Order_Line_ReferenceField;
			}
			set
			{
				this.purchase_Order_Line_ReferenceField = value;
				this.RaisePropertyChanged("Purchase_Order_Line_Reference");
			}
		}

		[XmlElement("Deliverables_Requisition_Line_Split_Data", Order = 12)]
		public Business_Document_Line_Split_DataType[] Deliverables_Requisition_Line_Split_Data
		{
			get
			{
				return this.deliverables_Requisition_Line_Split_DataField;
			}
			set
			{
				this.deliverables_Requisition_Line_Split_DataField = value;
				this.RaisePropertyChanged("Deliverables_Requisition_Line_Split_Data");
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
