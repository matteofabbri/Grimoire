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
	public class Costing_Allocation_DataType : INotifyPropertyChanged
	{
		private object itemField;

		private Position_ElementObjectType position_ReferenceField;

		private Earning__All_ObjectType earning_ReferenceField;

		private DateTime position_Element_Effective_Asof_DateField;

		private bool position_Element_Effective_Asof_DateFieldSpecified;

		private bool replace_Existing_Costing_Allocation_IntervalsField;

		private bool replace_Existing_Costing_Allocation_IntervalsFieldSpecified;

		private Costing_Allocation_Interval_DataType[] costing_Allocation_Interval_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Position_Restriction_Reference", typeof(Position_ElementObjectType), Order = 0), XmlElement("Worker_Reference", typeof(WorkerObjectType), Order = 0)]
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

		[XmlElement("Position_Element_Effective_As-of_Date", DataType = "date", Order = 3)]
		public DateTime Position_Element_Effective_Asof_Date
		{
			get
			{
				return this.position_Element_Effective_Asof_DateField;
			}
			set
			{
				this.position_Element_Effective_Asof_DateField = value;
				this.RaisePropertyChanged("Position_Element_Effective_Asof_Date");
			}
		}

		[XmlIgnore]
		public bool Position_Element_Effective_Asof_DateSpecified
		{
			get
			{
				return this.position_Element_Effective_Asof_DateFieldSpecified;
			}
			set
			{
				this.position_Element_Effective_Asof_DateFieldSpecified = value;
				this.RaisePropertyChanged("Position_Element_Effective_Asof_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Replace_Existing_Costing_Allocation_Intervals
		{
			get
			{
				return this.replace_Existing_Costing_Allocation_IntervalsField;
			}
			set
			{
				this.replace_Existing_Costing_Allocation_IntervalsField = value;
				this.RaisePropertyChanged("Replace_Existing_Costing_Allocation_Intervals");
			}
		}

		[XmlIgnore]
		public bool Replace_Existing_Costing_Allocation_IntervalsSpecified
		{
			get
			{
				return this.replace_Existing_Costing_Allocation_IntervalsFieldSpecified;
			}
			set
			{
				this.replace_Existing_Costing_Allocation_IntervalsFieldSpecified = value;
				this.RaisePropertyChanged("Replace_Existing_Costing_Allocation_IntervalsSpecified");
			}
		}

		[XmlElement("Costing_Allocation_Interval_Data", Order = 5)]
		public Costing_Allocation_Interval_DataType[] Costing_Allocation_Interval_Data
		{
			get
			{
				return this.costing_Allocation_Interval_DataField;
			}
			set
			{
				this.costing_Allocation_Interval_DataField = value;
				this.RaisePropertyChanged("Costing_Allocation_Interval_Data");
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
