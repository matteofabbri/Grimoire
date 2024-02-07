using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Evidence_of_Insurability_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType[] worker_ReferenceField;

		private Benefit_PlanObjectType[] benefit_Plan_ReferenceField;

		private bool itemField;

		private ItemChoiceType7 itemElementNameField;

		private DateTime eOI_Approve_Or_Deny_DateField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Worker_Reference", Order = 0)]
		public WorkerObjectType[] Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
			}
		}

		[XmlElement("Benefit_Plan_Reference", Order = 1)]
		public Benefit_PlanObjectType[] Benefit_Plan_Reference
		{
			get
			{
				return this.benefit_Plan_ReferenceField;
			}
			set
			{
				this.benefit_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Benefit_Plan_Reference");
			}
		}

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Approve_for_selected", typeof(bool), Order = 2), XmlElement("Deny_for_selected", typeof(bool), Order = 2)]
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

		[XmlElement(Order = 3), XmlIgnore]
		public ItemChoiceType7 ItemElementName
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

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime EOI_Approve_Or_Deny_Date
		{
			get
			{
				return this.eOI_Approve_Or_Deny_DateField;
			}
			set
			{
				this.eOI_Approve_Or_Deny_DateField = value;
				this.RaisePropertyChanged("EOI_Approve_Or_Deny_Date");
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
