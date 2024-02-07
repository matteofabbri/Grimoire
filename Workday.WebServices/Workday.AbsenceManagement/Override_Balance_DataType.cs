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
	public class Override_Balance_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string batch_IDField;

		private WorkerObjectType worker_ReferenceField;

		private Position_ElementObjectType position_ReferenceField;

		private Absence_Plan_ReferenceType time_Off_Plan_ReferenceField;

		private DateTime override_Balance_DateField;

		private decimal override_Balance_UnitsField;

		private bool override_Balance_UnitsFieldSpecified;

		private Carryover_Override_Balance_Units_DataType[] override_Balance_Units_DataField;

		private string commentsField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
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
		public Absence_Plan_ReferenceType Time_Off_Plan_Reference
		{
			get
			{
				return this.time_Off_Plan_ReferenceField;
			}
			set
			{
				this.time_Off_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Time_Off_Plan_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Override_Balance_Date
		{
			get
			{
				return this.override_Balance_DateField;
			}
			set
			{
				this.override_Balance_DateField = value;
				this.RaisePropertyChanged("Override_Balance_Date");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Override_Balance_Units
		{
			get
			{
				return this.override_Balance_UnitsField;
			}
			set
			{
				this.override_Balance_UnitsField = value;
				this.RaisePropertyChanged("Override_Balance_Units");
			}
		}

		[XmlIgnore]
		public bool Override_Balance_UnitsSpecified
		{
			get
			{
				return this.override_Balance_UnitsFieldSpecified;
			}
			set
			{
				this.override_Balance_UnitsFieldSpecified = value;
				this.RaisePropertyChanged("Override_Balance_UnitsSpecified");
			}
		}

		[XmlElement("Override_Balance_Units_Data", Order = 7)]
		public Carryover_Override_Balance_Units_DataType[] Override_Balance_Units_Data
		{
			get
			{
				return this.override_Balance_Units_DataField;
			}
			set
			{
				this.override_Balance_Units_DataField = value;
				this.RaisePropertyChanged("Override_Balance_Units_Data");
			}
		}

		[XmlElement(Order = 8)]
		public string Comments
		{
			get
			{
				return this.commentsField;
			}
			set
			{
				this.commentsField = value;
				this.RaisePropertyChanged("Comments");
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
