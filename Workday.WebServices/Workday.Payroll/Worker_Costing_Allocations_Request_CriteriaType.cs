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
	public class Worker_Costing_Allocations_Request_CriteriaType : INotifyPropertyChanged
	{
		private Costing_Override_CriteriaType costing_Override_CriteriaField;

		private bool include_All_Worker_Costing_AllocationsField;

		private bool include_All_Worker_Costing_AllocationsFieldSpecified;

		private bool include_All_Position_Restrictions_Costing_AllocationsField;

		private bool include_All_Position_Restrictions_Costing_AllocationsFieldSpecified;

		private bool include_Only_Current_Costing_Override_IntervalField;

		private bool include_Only_Current_Costing_Override_IntervalFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Costing_Override_CriteriaType Costing_Override_Criteria
		{
			get
			{
				return this.costing_Override_CriteriaField;
			}
			set
			{
				this.costing_Override_CriteriaField = value;
				this.RaisePropertyChanged("Costing_Override_Criteria");
			}
		}

		[XmlElement(Order = 1)]
		public bool Include_All_Worker_Costing_Allocations
		{
			get
			{
				return this.include_All_Worker_Costing_AllocationsField;
			}
			set
			{
				this.include_All_Worker_Costing_AllocationsField = value;
				this.RaisePropertyChanged("Include_All_Worker_Costing_Allocations");
			}
		}

		[XmlIgnore]
		public bool Include_All_Worker_Costing_AllocationsSpecified
		{
			get
			{
				return this.include_All_Worker_Costing_AllocationsFieldSpecified;
			}
			set
			{
				this.include_All_Worker_Costing_AllocationsFieldSpecified = value;
				this.RaisePropertyChanged("Include_All_Worker_Costing_AllocationsSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_All_Position_Restrictions_Costing_Allocations
		{
			get
			{
				return this.include_All_Position_Restrictions_Costing_AllocationsField;
			}
			set
			{
				this.include_All_Position_Restrictions_Costing_AllocationsField = value;
				this.RaisePropertyChanged("Include_All_Position_Restrictions_Costing_Allocations");
			}
		}

		[XmlIgnore]
		public bool Include_All_Position_Restrictions_Costing_AllocationsSpecified
		{
			get
			{
				return this.include_All_Position_Restrictions_Costing_AllocationsFieldSpecified;
			}
			set
			{
				this.include_All_Position_Restrictions_Costing_AllocationsFieldSpecified = value;
				this.RaisePropertyChanged("Include_All_Position_Restrictions_Costing_AllocationsSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Include_Only_Current_Costing_Override_Interval
		{
			get
			{
				return this.include_Only_Current_Costing_Override_IntervalField;
			}
			set
			{
				this.include_Only_Current_Costing_Override_IntervalField = value;
				this.RaisePropertyChanged("Include_Only_Current_Costing_Override_Interval");
			}
		}

		[XmlIgnore]
		public bool Include_Only_Current_Costing_Override_IntervalSpecified
		{
			get
			{
				return this.include_Only_Current_Costing_Override_IntervalFieldSpecified;
			}
			set
			{
				this.include_Only_Current_Costing_Override_IntervalFieldSpecified = value;
				this.RaisePropertyChanged("Include_Only_Current_Costing_Override_IntervalSpecified");
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
