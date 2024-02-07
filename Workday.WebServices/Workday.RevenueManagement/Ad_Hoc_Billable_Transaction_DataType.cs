using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Ad_Hoc_Billable_Transaction_DataType : INotifyPropertyChanged
	{
		private string ad_Hoc_Billable_Transaction_IDField;

		private Project_Transaction_SourceObjectType project_Transaction_Source_ReferenceField;

		private object[] itemsField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Ad_Hoc_Billable_Transaction_ID
		{
			get
			{
				return this.ad_Hoc_Billable_Transaction_IDField;
			}
			set
			{
				this.ad_Hoc_Billable_Transaction_IDField = value;
				this.RaisePropertyChanged("Ad_Hoc_Billable_Transaction_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Project_Transaction_SourceObjectType Project_Transaction_Source_Reference
		{
			get
			{
				return this.project_Transaction_Source_ReferenceField;
			}
			set
			{
				this.project_Transaction_Source_ReferenceField = value;
				this.RaisePropertyChanged("Project_Transaction_Source_Reference");
			}
		}

		[XmlElement("Ad_Hoc_Billable_Expense_Transaction_Data", typeof(Ad_Hoc_Billable_Expense_Transaction_DataType), Order = 2), XmlElement("Ad_Hoc_Billable_Misc_Expense_Transaction_Data", typeof(Ad_Hoc_Billable_Misc_Expense_Transaction_DataType), Order = 2), XmlElement("Ad_Hoc_Billable_Supplier_Invoice_Transaction_Data", typeof(Ad_Hoc_Billable_Supplier_Invoice_Transaction_DataType), Order = 2), XmlElement("Ad_Hoc_Billable_Time_Transaction_Data", typeof(Ad_Hoc_Billable_Time_Transaction_DataType), Order = 2)]
		public object[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
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
