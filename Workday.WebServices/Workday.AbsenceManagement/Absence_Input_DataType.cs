using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Absence_Input_DataType : INotifyPropertyChanged
	{
		private string absence_Input_IDField;

		private string batch_IDField;

		private WorkerObjectType worker_ReferenceField;

		private Position_ElementObjectType position_ReferenceField;

		private Absence_ComponentObjectType absence_Component_ReferenceField;

		private DateTime start_DateField;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private DateTime reference_DateField;

		private decimal hoursField;

		private bool hoursFieldSpecified;

		private bool adjustmentField;

		private bool adjustmentFieldSpecified;

		private string commentField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Absence_Input_ID
		{
			get
			{
				return this.absence_Input_IDField;
			}
			set
			{
				this.absence_Input_IDField = value;
				this.RaisePropertyChanged("Absence_Input_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Batch_ID
		{
			get
			{
				return this.batch_IDField;
			}
			set
			{
				this.batch_IDField = value;
				this.RaisePropertyChanged("Batch_ID");
			}
		}

		[XmlElement(Order = 2)]
		public WorkerObjectType Worker_Reference
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

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public Absence_ComponentObjectType Absence_Component_Reference
		{
			get
			{
				return this.absence_Component_ReferenceField;
			}
			set
			{
				this.absence_Component_ReferenceField = value;
				this.RaisePropertyChanged("Absence_Component_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Start_Date
		{
			get
			{
				return this.start_DateField;
			}
			set
			{
				this.start_DateField = value;
				this.RaisePropertyChanged("Start_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime End_Date
		{
			get
			{
				return this.end_DateField;
			}
			set
			{
				this.end_DateField = value;
				this.RaisePropertyChanged("End_Date");
			}
		}

		[XmlIgnore]
		public bool End_DateSpecified
		{
			get
			{
				return this.end_DateFieldSpecified;
			}
			set
			{
				this.end_DateFieldSpecified = value;
				this.RaisePropertyChanged("End_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Reference_Date
		{
			get
			{
				return this.reference_DateField;
			}
			set
			{
				this.reference_DateField = value;
				this.RaisePropertyChanged("Reference_Date");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Hours
		{
			get
			{
				return this.hoursField;
			}
			set
			{
				this.hoursField = value;
				this.RaisePropertyChanged("Hours");
			}
		}

		[XmlIgnore]
		public bool HoursSpecified
		{
			get
			{
				return this.hoursFieldSpecified;
			}
			set
			{
				this.hoursFieldSpecified = value;
				this.RaisePropertyChanged("HoursSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public bool Adjustment
		{
			get
			{
				return this.adjustmentField;
			}
			set
			{
				this.adjustmentField = value;
				this.RaisePropertyChanged("Adjustment");
			}
		}

		[XmlIgnore]
		public bool AdjustmentSpecified
		{
			get
			{
				return this.adjustmentFieldSpecified;
			}
			set
			{
				this.adjustmentFieldSpecified = value;
				this.RaisePropertyChanged("AdjustmentSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public string Comment
		{
			get
			{
				return this.commentField;
			}
			set
			{
				this.commentField = value;
				this.RaisePropertyChanged("Comment");
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
