using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Project-Based_Order_Line_Replacement_DataType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class ProjectBased_Order_Line_Replacement_DataType : INotifyPropertyChanged
	{
		private string deliverables_Order_Line_IDField;

		private decimal line_NumberField;

		private bool line_NumberFieldSpecified;

		private ProjectObjectType project_ReferenceField;

		private Supplier_Contract_LineObjectType supplier_Contract_Line_ReferenceField;

		private bool prepaidField;

		private bool prepaidFieldSpecified;

		private bool retentionField;

		private bool retentionFieldSpecified;

		private string memoField;

		private Requisition_LineObjectType[] requisition_Line_ReferenceField;

		private Accounting_CategoryObjectType resource_Category_ReferenceField;

		private Project_Plan_Phase_PO_DataType[] project_Phase_DataField;

		private decimal extended_AmountField;

		private bool extended_AmountFieldSpecified;

		private Accounting_WorktagObjectType[] worktags_ReferenceField;

		private Business_Document_Line_Split_DataType[] deliverables_Purchase_Order_Line_Split_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Deliverables_Order_Line_ID
		{
			get
			{
				return this.deliverables_Order_Line_IDField;
			}
			set
			{
				this.deliverables_Order_Line_IDField = value;
				this.RaisePropertyChanged("Deliverables_Order_Line_ID");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Line_Number
		{
			get
			{
				return this.line_NumberField;
			}
			set
			{
				this.line_NumberField = value;
				this.RaisePropertyChanged("Line_Number");
			}
		}

		[XmlIgnore]
		public bool Line_NumberSpecified
		{
			get
			{
				return this.line_NumberFieldSpecified;
			}
			set
			{
				this.line_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Line_NumberSpecified");
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
		public Supplier_Contract_LineObjectType Supplier_Contract_Line_Reference
		{
			get
			{
				return this.supplier_Contract_Line_ReferenceField;
			}
			set
			{
				this.supplier_Contract_Line_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Contract_Line_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public bool Prepaid
		{
			get
			{
				return this.prepaidField;
			}
			set
			{
				this.prepaidField = value;
				this.RaisePropertyChanged("Prepaid");
			}
		}

		[XmlIgnore]
		public bool PrepaidSpecified
		{
			get
			{
				return this.prepaidFieldSpecified;
			}
			set
			{
				this.prepaidFieldSpecified = value;
				this.RaisePropertyChanged("PrepaidSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Retention
		{
			get
			{
				return this.retentionField;
			}
			set
			{
				this.retentionField = value;
				this.RaisePropertyChanged("Retention");
			}
		}

		[XmlIgnore]
		public bool RetentionSpecified
		{
			get
			{
				return this.retentionFieldSpecified;
			}
			set
			{
				this.retentionFieldSpecified = value;
				this.RaisePropertyChanged("RetentionSpecified");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement("Requisition_Line_Reference", Order = 7)]
		public Requisition_LineObjectType[] Requisition_Line_Reference
		{
			get
			{
				return this.requisition_Line_ReferenceField;
			}
			set
			{
				this.requisition_Line_ReferenceField = value;
				this.RaisePropertyChanged("Requisition_Line_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public Accounting_CategoryObjectType Resource_Category_Reference
		{
			get
			{
				return this.resource_Category_ReferenceField;
			}
			set
			{
				this.resource_Category_ReferenceField = value;
				this.RaisePropertyChanged("Resource_Category_Reference");
			}
		}

		[XmlElement("Project_Phase_Data", Order = 9)]
		public Project_Plan_Phase_PO_DataType[] Project_Phase_Data
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

		[XmlElement(Order = 10)]
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

		[XmlElement("Worktags_Reference", Order = 11)]
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

		[XmlElement("Deliverables_Purchase_Order_Line_Split_Data", Order = 12)]
		public Business_Document_Line_Split_DataType[] Deliverables_Purchase_Order_Line_Split_Data
		{
			get
			{
				return this.deliverables_Purchase_Order_Line_Split_DataField;
			}
			set
			{
				this.deliverables_Purchase_Order_Line_Split_DataField = value;
				this.RaisePropertyChanged("Deliverables_Purchase_Order_Line_Split_Data");
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
