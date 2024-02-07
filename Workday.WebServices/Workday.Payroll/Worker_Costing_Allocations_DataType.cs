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
	public class Worker_Costing_Allocations_DataType : INotifyPropertyChanged
	{
		private object itemField;

		private Position_ElementObjectType position_ReferenceField;

		private Earning__All_ObjectType earning_ReferenceField;

		private Worker_Costing_Allocation_Interval_DataType[] worker_Costing_Allocation_Interval_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Position_Restrictions_Reference", typeof(Position_RestrictionsObjectType), Order = 0), XmlElement("Worker_Reference", typeof(WorkerObjectType), Order = 0)]
		public object Item
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

		[XmlElement(Order = 1)]
		public Position_ElementObjectType Position_Reference
		{
			get
			{
				return this.position_ReferenceField;
			}
			set
			{
				this.position_ReferenceField = value;
				this.RaisePropertyChanged("Position_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Earning__All_ObjectType Earning_Reference
		{
			get
			{
				return this.earning_ReferenceField;
			}
			set
			{
				this.earning_ReferenceField = value;
				this.RaisePropertyChanged("Earning_Reference");
			}
		}

		[XmlElement("Worker_Costing_Allocation_Interval_Data", Order = 3)]
		public Worker_Costing_Allocation_Interval_DataType[] Worker_Costing_Allocation_Interval_Data
		{
			get
			{
				return this.worker_Costing_Allocation_Interval_DataField;
			}
			set
			{
				this.worker_Costing_Allocation_Interval_DataField = value;
				this.RaisePropertyChanged("Worker_Costing_Allocation_Interval_Data");
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
